public class Account
{
    private int _number;

    public void TheAccount(int number)
    {
        SetNumber(number);
    }
    public int GetNumber()
    //These are called getter methods, to access private variables
    {
        return _number;
    }

    public void SetNumber(int number)
    {
        if (_number < 0)
        {
            throw new ArgumentException("Acconunt number must be positiive.");
        }
        _number = number;
    }

}