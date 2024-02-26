using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.VıewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
          
            return View();
        }

        //[HttpPost]

        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = DateTime.Now;
        //    p.Status = true;
        //    messageManager.TAdd(p);
        //    return View();
        //}
    }
}
