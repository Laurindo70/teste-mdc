namespace TestMDC.Endpoints.Exercise6
{
    public class VowelCounter : IVowelCounter
    {
        public int SetenceVowelCounter(string setence)
        {
            int counter = 0;
            string setenceUper = setence.ToUpper();

            for (int i = 0; i < setenceUper.Length; i++)
            {
                switch (setenceUper[i])
                {
                    case 'A':
                        counter++;
                        break;
                    case 'E':
                        counter++;
                        break;
                    case 'I':
                        counter++;
                        break;
                    case 'O':
                        counter++;
                        break;
                    case 'U':
                        counter++;
                        break;
                    default:
                        continue;
                }
            }

            return counter;
        }
    }
}
