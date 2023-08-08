using TestMDC.Domain.Entities;

namespace TestMDC.Endpoints.Exercise8
{
    public interface IInterestCalculation
    {
        Double CaculateInvestment(Interest request);
    }
}
