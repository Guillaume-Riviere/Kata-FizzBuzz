using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzKataTest
{
    [TestFixture]
    public class FizzBuzzKataTest
    {
        [Test]
        public void Should_Return_String1_Having_Integer1()
        {
            int input = 1;
            string expected = "1";
            FizzBuzz fizzBuzz = new FizzBuzz();
            string output = fizzBuzz.FizzBuzzShow(input);
            Assert.AreEqual(expected, output);
        }

        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        public void Should_Return_Corresponding_String_Having_Integer(int _input, string _expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string output = fizzBuzz.FizzBuzzShow(_input);
            Assert.AreEqual(_expected, output);
        }

        [TestCase(3, "Fizz")]
        public void Should_Return_Fizz_Having_Integer3(int _input, string _expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string output = fizzBuzz.FizzBuzzShow(_input);
            Assert.AreEqual(_expected, output);
        }

        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        public void Should_Return_Fizz_Having_Integer_divisible_by_three(int _input, string _expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string output = fizzBuzz.FizzBuzzShow(_input);
            Assert.AreEqual(_expected, output);
        }

        [TestCase(5, "Buzz")]
        public void Should_Return_Buzz_Having_Integer5(int _input, string _expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string output = fizzBuzz.FizzBuzzShow(_input);
            Assert.AreEqual(_expected, output);
        }

        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        public void Should_Return_Buzz_Having_Integer_divisible_by_five(int _input, string _expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string output = fizzBuzz.FizzBuzzShow(_input);
            Assert.AreEqual(_expected, output);
        }

        [TestCase(15, "FizzBuzz")]
        public void Should_Return_FizzBuzz_Having_Integer_divisible_by_three_and_five(int _input, string _expected)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string output = fizzBuzz.FizzBuzzShow(_input);
            Assert.AreEqual(_expected, output);
        }
    }
}