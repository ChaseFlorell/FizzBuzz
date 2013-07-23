
namespace FizzBuzz.Core.FizzBuzz
{
    public class NumberOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return numberToHandle.ToString();
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle%3 != 0 && numberToHandle%5!=0;
        }
    }
}
