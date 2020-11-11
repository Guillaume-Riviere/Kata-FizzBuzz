
namespace FizzBuzzKata
{

    public class FizzBuzz
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public string FizzBuzzShow(int input)
        {
            if (Is_Divisible_By(input, 15))
                return Fizz+Buzz;

            if (Is_Divisible_By(input, 3))
                return Fizz;

            if (Is_Divisible_By(input, 5))
                return Buzz;

            return input.ToString();
        }

        #region Utils

        public bool Is_Divisible_By(int input, int divisor)
        {
            if (input % divisor == 0)
                return true;
            return false;
        }

        #endregion
    }
}
