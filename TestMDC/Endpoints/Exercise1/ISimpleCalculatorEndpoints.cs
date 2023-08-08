using TestMDC.Domain.Entities;
using TestMDC.Domain.Returns;

namespace TestMDC.Endpoints.Exercise1
{
    public interface ISimpleCalculatorEndpoints
    {
        Exercise1Return CalculatorSimple(SimpleCalculator request);
    }
}
