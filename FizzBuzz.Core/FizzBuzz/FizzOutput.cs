
namespace FizzBuzz.Core.FizzBuzz
{
    public class FizzOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "fizz";
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle%3 == 0;
        }
    }
}
