namespace CoockieCookbook.Utils
{
    interface IUserInputValidator
    {
        bool IsDigit(string input);
        bool IsInRange(string input, int minVal, int maxVal);
    }
}
