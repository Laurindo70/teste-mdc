namespace TestMDC.Domain.Returns
{
    public class Exercise3Return
    {
        public Exercise3Return(int numberFactorial, int factorialResult)
        {
            NumberFactorial = numberFactorial;
            FactorialResult = factorialResult;
        }
        public int NumberFactorial { get; set; }
        public int FactorialResult { get; set; }
    }
}
