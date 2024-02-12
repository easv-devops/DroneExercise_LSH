using Microsoft.AspNetCore.Mvc;

namespace FirstDrone;

[ApiController]
public class Controller : ControllerBase
{
    [HttpGet]
    [Route("/Hello")]
    public IActionResult getHello()
    {
        return Ok("Hello World");
    }
    
    [HttpGet]
    [Route("/Goodbye")]
    public IActionResult getGoodbye()
    {
        return Ok("Goodbye World");
    }
}