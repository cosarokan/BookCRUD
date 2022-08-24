using BusinessLayer;
using DataAccessLayer;
using EntityLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IBookTypeService _bookTypeService;
        private readonly IAuthorService _authorService;
        

        public BookController(IBookService bookService, IBookTypeService bookTypeService, IAuthorService authorService)
        {
            _bookService = bookService;
            _bookTypeService = bookTypeService;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            ViewBag.BookTypes = _bookTypeService.GetAll();
            ViewBag.Authors = _authorService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Index(BookViewModel bookViewModel)
        {
            try
            {
                ViewBag.BookTypes = _bookTypeService.GetAll();
                ViewBag.Authors = _authorService.GetAll();

                bookViewModel.CreatedDate = DateTime.Now;
                bookViewModel.IsDeleted = false;
                var result = _bookService.Add(bookViewModel);

                ViewBag.AddBookSuccessMessage = "Book added!";
                return View();
            }
            catch (Exception)
            {
                ViewBag.AddBookFailed = "Couldn't add book!";
                return View();
            }
        }

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    return View();
        //}

    }
}
