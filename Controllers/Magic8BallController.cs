using Microsoft.AspNetCore.Mvc;
using miniChallenge8_10.Services.MiniChallenges;

namespace miniChallenge8_10.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }

    [HttpGet]
    [Route("YourAnswer")]
    public string YourAnswer()
    {
        return _magic8BallService.YourAnswer();
    }

}