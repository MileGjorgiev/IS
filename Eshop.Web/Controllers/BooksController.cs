using EShop.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetPartnerBooks(); 
            return View(books);
        }
    }
}
