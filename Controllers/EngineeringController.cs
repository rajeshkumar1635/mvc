using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class EngineeringController : Controller
    {
        // GET: EngineeringController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CurrentProjects()
        {
            var EngDept = new EngineeringDepartment();
            return View(EngDept);
        }

    }
}
