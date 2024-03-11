using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
         WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = messageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = messageManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult DeleteMessageReceiver(int id)
        {
            var values = messageManager.TGetById(id);
            messageManager.TDelete(values);
            return RedirectToAction("ReceiverMessageList");
        }
        public IActionResult DeleteMessageSender(int id)
        {
            var values = messageManager.TGetById(id);
            messageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");
        }

        public IActionResult DetailsMessage(int id)
        {
            var values = messageManager.TGetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            messageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
