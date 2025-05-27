using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace books_mvc.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Collection()
        {
            var book = new Books();
            return View(book);

        }
        public ActionResult FavoriteBook()
        {
            var book = new Books();
            return View(book);
        }
    }
}
