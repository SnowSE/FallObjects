namespace Game.Logic;

public enum GuessResult
{
    Unknown,
    Indeterminate = 13,
    TooLow,
    TooHigh,
    Correct,
    TooManyGuess = 57,
}