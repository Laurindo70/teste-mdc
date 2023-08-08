namespace TestMDC.Domain.Returns
{
    public class Exercise4Return
    {
        public Exercise4Return(string word, Boolean wordIsPalindrome)
        {
            Word = word;
            WordIsPalindrome = wordIsPalindrome;
        }

        public string Word { get; set; }
        public Boolean WordIsPalindrome { get; set; }
    }
}
