using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterManager userManager = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(userManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p)
        {
            userManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

    }
}
