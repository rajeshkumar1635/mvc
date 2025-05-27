using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace books_mvc.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Index()
        {
            var book = new Books();
            return View("allbooks",book);

        }
        public ActionResult FavoriteBook()
        {
            var book = new Books();
            return View(book);
        }
    }
}
