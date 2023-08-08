namespace TestMDC.Domain.Returns
{
    public class Exercise6Return
    {
        public Exercise6Return(string setence, int counterVowel)
        {
            Setence = setence;
            CounterVowelSetence = counterVowel;
        }
        public string Setence { get; set; }
        public int CounterVowelSetence { get; set; }
    }
}
