using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class AppController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("App is running");
    }
}
