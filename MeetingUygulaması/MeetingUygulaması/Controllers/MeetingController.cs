using MeetingUygulaması.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingUygulaması.Controllers
{
    public class MeetingController : Controller
    {


        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
            // MODEL BINDING form benden hangi değerleri bekliyor name olarak bunları yazdım
            // örnek input ta yer alan name="Phone" bilgisi için Phone 
        {  
            if(ModelState.IsValid)
            {

                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();
                return View("Thanks", model);
                // return view le tekrar forma gönderiyorum ama redirect to action da diyebilirim far klı bir yere göndermek için
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }


        // meeting/details/2
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}
