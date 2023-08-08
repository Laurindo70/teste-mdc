namespace TestMDC.Endpoints.Exercise3
{
    public class FactorialEndpoint : IFactorialEndpoint
    {
        public int CalculateFactorial(int Number)
        {
            int result = Number;
            int aux = Number - 1;
            if (Number == 1) return 1;

            while (aux >= 2)
            {
                result *= aux;

                aux--;
            }

            return result;

        }
    }
}
