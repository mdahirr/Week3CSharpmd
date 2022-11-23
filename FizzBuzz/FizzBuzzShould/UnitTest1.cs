using FizzBuzzApp;

namespace FizzBuzzTests
{
    public class FizzBuzzShould
    {
        [Test]
        public void GivenOne_FizzBuzzReturns_StringOfOne()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void GivenANumber_Return_ItsString(int input, string expectedOutput)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        public void GivenANumber_Return_Fizz(int input, string expectedOutput)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        public void GivenANumber_Return_Buzz(int input, string expectedOutput)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expectedOutput));
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void GivenANumber_Return_FizzBuzz(int input, string expectedOutput)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expectedOutput));
        }
    }
}