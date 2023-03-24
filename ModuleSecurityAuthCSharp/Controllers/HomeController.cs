using Microsoft.AspNetCore.Mvc;

namespace ModuleSecurityAuthCSharp.Controllers;

[Route("")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("submit")]
    public IActionResult SubmitPhoneNumber([FromForm] string phoneNumber)
    {
        Console.WriteLine($"User submitted phone number: {phoneNumber}");

        return View("PhoneNumberResult");
    }
}
