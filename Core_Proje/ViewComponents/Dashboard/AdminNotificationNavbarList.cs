using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNotificationNavbarList :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
