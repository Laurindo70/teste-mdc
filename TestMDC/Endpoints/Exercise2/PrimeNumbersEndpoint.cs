using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestMDC.Endpoints.Exercise2
{
    public class PrimeNumbersEndpoint : IPrimeNumbersEndpoint
    {
        public List<int> NumbersPrime()
        {
            List<int> numbersPrime = new List<int>();
            int numbers = 2;
            int counter = 2;
            var verify = true;

            while (numbersPrime.Count < 10)
            {
                while (counter != numbers)
                {
                    if (numbers % counter == 0)
                    {
                        verify = false;
                    }

                    counter++;
                }
                if(verify) numbersPrime.Add(numbers);
                counter = 2;
                verify= true;
                numbers++;
            }

            return numbersPrime;
        }

        public bool VerifyNumberPrime(int Number)
        {
            var NumberPrime = true;
            int counter = 2;

            if (Number == 1) return false;
            if (Number == 2) return true;

            while (counter != Number)
            {
                Console.WriteLine(Number%counter);
                if (Number % counter == 0)
                {
                    NumberPrime = false;
                }

                counter++;
            }

            return NumberPrime;
        }
    }
}
