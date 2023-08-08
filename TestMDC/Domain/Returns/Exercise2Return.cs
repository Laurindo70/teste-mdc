namespace TestMDC.Domain.Returns
{
    public class Exercise2Return
    {

        public Exercise2Return(int number, List<int> numbers, Boolean isPrime)
        {
            Number = number;
            NumbersPrime = numbers;
            IsPrime = isPrime;
        }

        public int Number { get; set; }
        public List<int> NumbersPrime { get; set; }
        public Boolean IsPrime { get; set; }
    }
}
