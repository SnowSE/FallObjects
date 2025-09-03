

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

    public string Guess(int value)
    {
        string retval = "correct";
        if (value > CorrectNumber)
        {
            retval = "higher";
        }
        if (value < CorrectNumber)
        {
            retval = "lower";
        }
        return retval;
    }
}