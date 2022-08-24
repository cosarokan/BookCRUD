using BusinessLayer;
using EntityLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AuthorViewModel authorViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.CreatedFailedMessage = "Enter the author name!";
                    return View();
                }
                authorViewModel.CreatedDate = DateTime.Now;
                authorViewModel.IsDeleted = false;
                var result = _authorService.Add(authorViewModel);

                ViewBag.AddAuthorSuccessMessage = "Author added!";
                return View();
            }
            catch (Exception)
            {
                ViewBag.AddAuthorFailMessage = "Couldn't add author!";
                return View();
                throw;
            }
        }
    }
}
