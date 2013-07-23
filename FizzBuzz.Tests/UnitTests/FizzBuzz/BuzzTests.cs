using System;
using FizzBuzz.Core.FizzBuzz;
using NUnit.Framework;
namespace FizzBuzz.Tests.UnitTests.FizzBuzz
{
    [TestFixture]
    public class BuzzTests
    {
        private readonly IFizzBuzzHandler _handler;
        public BuzzTests() 
        {
            _handler = new BuzzOutput();
        }

        [Test]
        public void BuzzShouldHandleNumberDivisableByFive()
        {
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            var shouldReturnBuzz = _handler.CanHandle(number[rand]);

            Assert.AreEqual(true, shouldReturnBuzz);
        }

        [Test]
        public void OutputWillMatchBuzz()
        {
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            var result = _handler.Handle(number[rand]);

            Assert.AreEqual("Buzz",result);
        }
    }
}
