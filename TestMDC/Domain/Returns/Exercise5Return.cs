namespace TestMDC.Domain.Returns
{
    public class Exercise5Return
    {
        public Exercise5Return(int number, List<int> numbersResult)
        {
            Number = number;
            NumbersResult = numbersResult;
        }
        public int Number { get; set; }
        public List<int> NumbersResult { get; set; }
    }
}
