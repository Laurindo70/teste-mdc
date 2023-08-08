using TestMDC.Domain.Entities;

namespace TestMDC.Endpoints.Exercise8
{
    public class InterestCalculation : IInterestCalculation
    {
        public double CaculateInvestment(Interest request)
        {
            double valueFinal = request.InitialCapital;

            for(int i = 0; i < request.MonthsInvestment; i++)
            {
                valueFinal += valueFinal * (request.InterestRate / 100);
            }

            return valueFinal;
        }
    }
}
