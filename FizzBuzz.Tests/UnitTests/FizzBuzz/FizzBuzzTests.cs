using System;
using FizzBuzz.Core.FizzBuzz;
using NUnit.Framework;
namespace FizzBuzz.Tests.UnitTests.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private readonly IFizzBuzzHandler _handler;
        public FizzBuzzTests() 
        {
            _handler = new FizzBuzzOutput();
        }

        [Test]
        public void FizzBuzzShouldHandleNumberDivisableByThreeAndFive()
        {
            var number = new[] { 15, 30, 45, 60, 75, 90 };
            var rand = (int)new Random().NextDouble() * (6 - 1) + 1; 

            var shouldReturnBuzz = _handler.CanHandle(number[rand]);

            Assert.AreEqual(true, shouldReturnBuzz);
        }

        [Test]
        public void OutputWillMatchFizzBuzz()
        {
            var number = new[] { 15, 30, 45, 60, 75, 90 };
            var rand = (int)new Random().NextDouble() * (6 - 1) + 1; 

            var result = _handler.Handle(number[rand]);

            Assert.AreEqual("FizzBuzz",result);
        }
    }
}
