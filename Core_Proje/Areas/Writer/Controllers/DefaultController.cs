﻿
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {

        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
           Announcement values=announcementManager.TGetById(id);
            return View(values);
        }
    }
}
