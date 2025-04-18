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
                Name = "John Doe",
                Description = "I'm a passionate developer focused on building clean and user-friendly applications.",
                ImageUrl = "/images/profile.jpg", // Make sure this image exists
                LinkedInUrl = "https://www.linkedin.com/in/johndoe",
                GitHubUrl = "https://github.com/johndoe",
                ResumeUrl = "/files/JohnDoeResume.pdf"
            };

            return View(aboutModel);
        }
    }
}
