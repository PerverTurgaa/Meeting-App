using MeetingUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingUygulaması.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();


            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul , ABC Kongre Merkezi",
                Date = new DateTime(2024, 1, 20,20,0,0),
                NumberOfPeople = UserCount

            };

            return View(meetingInfo);
        }

      
    }
}
