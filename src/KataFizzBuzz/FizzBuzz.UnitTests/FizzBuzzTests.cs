using FluentAssertions;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1)]
        public void ReturnString(int integer) =>
            new FizzBuzz().GetStringForNumber(integer).Should().BeOfType<string>();

        [Theory]
        [InlineData(1)]
        public void ReturnIntAsString(int integer) =>
            new FizzBuzz().GetStringForNumber(integer).Should().Be(integer.ToString());

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        [InlineData(24)]
        [InlineData(27)]
        [InlineData(33)]
        [InlineData(36)]
        [InlineData(39)]
        [InlineData(48)]
        [InlineData(51)]
        [InlineData(54)]
        [InlineData(57)]
        [InlineData(66)]
        [InlineData(69)]
        public void ReturnFizzIfDivisableByThree(int integer) => new FizzBuzz().GetStringForNumber(integer).Should().Be("Fizz");

        [Theory]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(55)]
        [InlineData(65)]
        [InlineData(85)]
        [InlineData(95)]
        public void ReturnBuzzIfDivisableByFiveButNoByThreeOrSevenOrTen(int integer) => new FizzBuzz().GetStringForNumber(integer).Should().Be("Buzz");

        [Theory]
        [InlineData(15)]
        [InlineData(45)]
        [InlineData(75)]
        public void ReturnBuzzFizzIfDivisableByThreeAndFiveButNotBySevenOrTen(int integer) => new FizzBuzz().GetStringForNumber(integer).Should().Be("BuzzFizz");

        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        [InlineData(28)]
        [InlineData(49)]
        [InlineData(56)]
        [InlineData(63)]
        [InlineData(70)]
        [InlineData(77)]
        [InlineData(84)]
        [InlineData(91)]
        [InlineData(98)]
        public void ReturnFizzBuzzBangIfDivisableBySeven(int integer) => new FizzBuzz().GetStringForNumber(integer).Should().Be("FizzBuzzBang");

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        [InlineData(40)]
        [InlineData(50)]
        [InlineData(60)]
        [InlineData(80)]
        [InlineData(90)]
        [InlineData(100)]
        public void ReturnBroIfDivisableByTenButNotBySeven(int integer) => new FizzBuzz().GetStringForNumber(integer).Should().Be("Bro");
    }
}
