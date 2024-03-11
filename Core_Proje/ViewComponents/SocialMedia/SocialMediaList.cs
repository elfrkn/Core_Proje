using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        SocialMediaManager socilaMedia = new SocialMediaManager(new EfSocialMediaDal());

        public IViewComponentResult Invoke()
        {
            var values = socilaMedia.TGetList();
            return View(values);
        }
    }
}
