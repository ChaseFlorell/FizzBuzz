using FizzBuzz.Core.FizzBuzz;
using NUnit.Framework;
using System;

namespace FizzBuzz.Tests.UnitTests.FizzBuzz
{
    [TestFixture]
    public class FizzTests
    {
        private readonly IFizzBuzzHandler _handler;
        public FizzTests() 
        {
            _handler = new FizzOutput();
        }

        [Test]
        public void FizzShouldHandleNumberDivisableByThree()
        {
            var number = new[] {3,6,9,12,15,18,21,24,27,30};
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            var shouldReturnFizz = _handler.CanHandle(number[rand]);

            Assert.AreEqual(shouldReturnFizz,true);
        }

        [Test]
        public void OutputWillMatchFizz()
        {
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            var result = _handler.Handle(number[rand]);

            Assert.AreEqual(result,"Fizz");
        }
    }
}
