using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ContactController : Controller
{
    [HttpPost]
    public async Task<IActionResult> SendEmail([FromForm] ContactFormModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid input");

        var toEmail = "contact@example.com"; // Replace with your actual email

        var mail = new MailMessage
        {
            From = new MailAddress(model.Email, model.Name),
            Subject = model.Subject,
            Body = $"From: {model.Name}\nEmail: {model.Email}\n\nMessage:\n{model.Message}",
            IsBodyHtml = false
        };
        mail.To.Add(toEmail);

        using (var smtp = new SmtpClient("smtp.example.com", 587)) // Replace with your SMTP settings
        {
            smtp.Credentials = new NetworkCredential("your-smtp-username", "your-smtp-password");
            smtp.EnableSsl = true;

            try
            {
                await smtp.SendMailAsync(mail);
                return Ok("Email sent successfully!");
            }
            catch (SmtpException ex)
            {
                return StatusCode(500, $"Failed to send email: {ex.Message}");
            }
        }
    }
}
