using Microsoft.AspNetCore.Mvc;

namespace books_mvc.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Index()
        {
            return View();
        }

    }
}
