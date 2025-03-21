﻿using Microsoft.AspNetCore.Mvc;
using NotificationService.Models.Entity;
using NotificationService.Models.Service;

namespace NotificationService.Controllers
{
    [Route("api/v1/notificationMail")]
    [ApiController]
    public class MailController : Controller
    {
        private readonly IMailService _mail;

        public MailController(IMailService mail)
        {
            _mail = mail;
        }

        [HttpPost("sendmail")]
        public async Task<IActionResult> SendMailAsync(MailData mailData)
        {
            bool result = await _mail.SendAsync(mailData);

            if (result)
            {
                return StatusCode(StatusCodes.Status200OK, "Mail has successfully been sent.");
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    "An error occured. The Mail could not be sent.");
            }
        }
    }
}
