using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using EntityLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Diagnostics;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;
        private readonly IBookRepository _bookRepository;

        public HomeController(ILogger<HomeController> logger, IBookService bookService, IBookRepository bookRepository)
        {
            _logger = logger;
            _bookService = bookService;
            _bookRepository = bookRepository;
        }

        public IActionResult Index(BookViewModel bookViewModel)
        {
            try
            {
                List<Book> list = _bookRepository.GetAllBooks();
                return View(list);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(new BookViewModel { Id = id });
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}