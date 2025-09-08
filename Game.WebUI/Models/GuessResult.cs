namespace Game.Models;

public enum GuessResult
{
    Indeterminate = 13,
    TooLow,
    TooHigh,
    Correct,
    TooManyGuess = 57,
}