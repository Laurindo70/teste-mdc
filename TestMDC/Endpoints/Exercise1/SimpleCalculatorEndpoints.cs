using TestMDC.Domain.Entities;
using TestMDC.Domain.Returns;

namespace TestMDC.Endpoints.Exercise1
{
    public class SimpleCalculatorEndpoints : ISimpleCalculatorEndpoints
    {
        public Exercise1Return CalculatorSimple(SimpleCalculator request)
        {
            var result = new Exercise1Return(request.Number1, request.Number2, request.Operation);

            switch (request.Operation)
            {
                case "+":
                    result.Result = request.Number1 + request.Number2; break;
                case "-":
                    result.Result = request.Number1 - request.Number2; break;
                case "*":
                    result.Result = request.Number1 * request.Number2; break;
                case "/":
                    result.Result = request.Number1 / request.Number2; break;
                default:
                    throw new Exception();
            }

            return result;
        }
    }
}
