using BusinessLayer;
using EntityLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class BookTypeController : Controller
    {
        private readonly IBookTypeService _bookTypeService;

        public BookTypeController(IBookTypeService bookTypeService)
        {
            _bookTypeService = bookTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BookTypeViewModel bookTypeViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.CreateFailedMessage = "Enter the book type!";
                    return View(bookTypeViewModel);
                }
                foreach (char item in bookTypeViewModel.Name)
                {
                    if (char.IsDigit(item))
                    {
                        ViewBag.DigitFailedMessage = "Only should be letter";
                        return View(bookTypeViewModel);
                    }
                }
                bookTypeViewModel.CreatedDate = DateTime.Now;
                bookTypeViewModel.IsDeleted = false;
                var result = _bookTypeService.Add(bookTypeViewModel);

                ViewBag.CreateBookTypeSuccessMessage = "Book type added!";
                return View();
                
            }
            catch (Exception)
            {
                ViewBag.CreateBookTypeFailedMessage = "Couldn't add book type!";
                return View();

            }
        }

    }
}
