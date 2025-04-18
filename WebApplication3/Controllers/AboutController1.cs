using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var aboutModel = new About
            {
              
                    Name = "Mohammed Ali",
                    Description = "Experienced developer with a passion for building clean, scalable solutions.",
                    ImageUrl = "/images/profile.jpg",
                    LinkedInUrl = "https://linkedin.com/in/mohammedali",
                    GitHubUrl = "https://github.com/mohammedaliomara",
                    ResumeUrl = "/files/Resume.pdf"
            };

            return View(aboutModel);
        }
    }
}
