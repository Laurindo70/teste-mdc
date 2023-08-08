namespace TestMDC.Domain.Returns
{
    public class Exercise1Return
    {
        public Exercise1Return(float n1, float n2, string operation)
        {
            Number1 = n1;
            Number2 = n2;
            Operation = operation;
        }

        public double Result { get; set; }
        public float Number1 { get; set; }
        public float Number2 { get; set; }
        public string Operation { get; set; }
    }
}
