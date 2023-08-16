using Microsoft.AspNetCore.Mvc;

namespace dotnetwebapi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorld : ControllerBase
{
    [HttpGet("{id}", Name = "GetWorld")]
    public String Get([FromRoute] int id)
    {
        return $"ID is {id}";
    }
}
