using System.Text;

namespace TestMDC.Endpoints.Exercise4
{
    public class PalindromeEndpoint : IPalindromeEndpoint
    {
        public bool WordPalindrome(string word)
        {
            StringBuilder WordAux = new StringBuilder();

            for (int i = word.Length - 1; i >=0; i--)
            {
                WordAux.Append(word[i]);
            }

            return (bool)(word.Equals(WordAux.ToString()));
        }
    }
}
