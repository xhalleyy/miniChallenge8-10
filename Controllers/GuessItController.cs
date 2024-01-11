
using Microsoft.AspNetCore.Mvc;
using miniChallenge8_10.Services.MiniChallenges;

namespace miniChallenge8_10.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("EasyMode/{input}")]
    public string EasyMode(string input)
    {
        return _guessItService.EasyMode(input);
    }

    [HttpGet]
    [Route("NormalMode/{input}")]
    public string NormalMode(string input)
    {
        return _guessItService.NormalMode(input);
    }

    [HttpGet]
    [Route("HardMode/{input}")]
    public string HardMode(string input)
    {
        return _guessItService.HardMode(input);
    }
}
