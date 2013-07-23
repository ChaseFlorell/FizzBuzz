
namespace FizzBuzz.Core.FizzBuzz
{
    public class BuzzOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "Buzz";
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle%5 == 0;
        }
    }
}
