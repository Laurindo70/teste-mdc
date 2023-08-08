namespace TestMDC.Endpoints.Exercise2
{
    public interface IPrimeNumbersEndpoint
    {
        Boolean VerifyNumberPrime(int Number);
        List<int> NumbersPrime();
    }
}
