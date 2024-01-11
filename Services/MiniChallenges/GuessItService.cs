namespace miniChallenge8_10.Services.MiniChallenges;

public class GuessItService : IGuessItService
{
    public string EasyMode(string input)
    {
        int randomIndex = new Random().Next(1, 11);
        bool isNum = int.TryParse(input, out int num);
        if (isNum && num > 0 && num < 11)
        {
            if (num == randomIndex)
            {
                return $" Your guess, {num}, was correct!";
            }
            else if (num > randomIndex)
            {
                return $"Your guess, {num}, is higher than the number.";
            }
            else
            {
                return $"Your guess, {num}, is lower than the number.";
            }
        }
        else
        {
            return $"Your input, {input}, was not a valid number AND/OR isn't between the numbers 1-10.";
        }
    }

    public string NormalMode(string input)
    {
        int randomIndex = new Random().Next(1, 51);
        bool isNum = int.TryParse(input, out int num);
        if (isNum && num > 0 && num < 51)
        {
            if (num == randomIndex)
            {
                return $" Your guess, {num}, was correct!";
            }
            else if (num > randomIndex)
            {
                return $"Your guess, {num}, is higher than the number.";
            }
            else
            {
                return $"Your guess, {num}, is lower than the number.";
            }
        }
        else
        {
            return $"Your input, {input}, was not a valid number AND/OR isn't between the numbers 1-50.";
        }
    }

    public string HardMode(string input)
    {
        int randomIndex = new Random().Next(1, 101);
        bool isNum = int.TryParse(input, out int num);
        if (isNum && num > 0 && num < 101)
        {
            if (num == randomIndex)
            {
                return $" Your guess, {num}, was correct!";
            }
            else if (num > randomIndex)
            {
                return $"Your guess, {num}, is higher than the number.";
            }
            else
            {
                return $"Your guess, {num}, is lower than the number.";
            }
        }
        else
        {
            return $"Your input, {input}, was not a valid number AND/OR isn't between the numbers 1-100.";
        }
    }
}
