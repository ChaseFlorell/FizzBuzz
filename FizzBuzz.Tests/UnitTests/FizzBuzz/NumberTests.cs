using System;
using FizzBuzz.Core.FizzBuzz;
using NUnit.Framework;

namespace FizzBuzz.Tests.UnitTests.FizzBuzz
{
    [TestFixture]
    public class NumberTests
    {

         private readonly IFizzBuzzHandler _handler;
        public NumberTests() 
        {
            _handler = new NumberOutput();
        }

        [Test]
        public void ShouldHandleNumberNotDivisableByThreeOrFive()
        {
            var number = new[] { 1, 2, 4, 7, 8, 10, 11, 13, 14, 16 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var shouldReturnNumber = _handler.CanHandle(number[rand]);

            Assert.AreEqual(true, shouldReturnNumber);
        }

        [Test]
        public void OutputWillMatchNumber()
        {
            var number = new[] { 1, 2, 4, 7, 8, 10, 11, 13, 14, 16 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;
            var expectedResult = number[rand].ToString();

            var result = _handler.Handle(number[rand]);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
