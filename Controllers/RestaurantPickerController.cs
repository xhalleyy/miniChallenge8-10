using Microsoft.AspNetCore.Mvc;
using miniChallenge8_10.Services.MiniChallenges;

namespace miniChallenge8_10.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }

    [HttpGet]
    [Route("FoodCategory/{input}")]
    public string FoodCategory(string input)
    {
        return _restaurantPickerService.FoodCategory(input);     
    }
}
