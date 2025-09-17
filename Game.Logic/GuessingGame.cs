namespace Game.Models;

public class GuessingGame
{
    public int CorrectNumber;

    public GuessingGame()
    {
        Random rnd = new Random();
        CorrectNumber = rnd.Next(1, 100);
    }


    public GuessingGame(int initial)
    {
        CorrectNumber = initial;
    }

    public GuessResult Guess(int value)
    {
        GuessResult retval = GuessResult.Correct; 
        
        if (value > CorrectNumber)
        {
            retval = GuessResult.TooHigh;
        }
        if (value < CorrectNumber)
        {
            retval = GuessResult.TooLow;
        }
        return retval;
    }
}