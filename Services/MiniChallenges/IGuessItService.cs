namespace miniChallenge8_10.Services.MiniChallenges;

public interface IGuessItService
{
    string EasyMode(string input);
    string NormalMode(string input);
    string HardMode(string input);
}