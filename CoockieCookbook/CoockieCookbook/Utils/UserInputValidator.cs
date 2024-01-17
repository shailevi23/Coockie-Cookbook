namespace CoockieCookbook.Utils
{
    class UserInputValidator : IUserInputValidator
    {
        public bool IsDigit(string input)
        {
            return int.TryParse(input, out int res);
        }

        public bool IsInRange(string input, int minVal, int maxVal)
        {
            int idInput = int.Parse(input);
            if (idInput >= minVal && idInput <= maxVal)
            {
                return true;
            }

            return false;
        }
    }
}
