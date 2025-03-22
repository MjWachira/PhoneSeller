using Microsoft.AspNetCore.Mvc;
using PhoneSeller.Services;

namespace PhoneSeller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhoneController : ControllerBase
    {
        private readonly PhoneService _phoneService;

        public PhoneController(PhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [HttpGet]
        public IActionResult GetPhones()
        {
            var phones = _phoneService.GetPhones();
            return Ok(phones);
        }
    }
}