using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestMDC.Domain.Entities;
using TestMDC.Domain.Returns;
using TestMDC.Endpoints.Exercise1;
using TestMDC.Endpoints.Exercise2;
using TestMDC.Endpoints.Exercise3;
using TestMDC.Endpoints.Exercise4;
using TestMDC.Endpoints.Exercise5;
using TestMDC.Endpoints.Exercise6;
using TestMDC.Endpoints.Exercise7;
using TestMDC.Endpoints.Exercise8;

namespace TestMDC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {

        [HttpPost("1")]
        public ActionResult<Exercise1Return> Exercise1([FromServices] ISimpleCalculatorEndpoints simpleCalculator , [FromBody] SimpleCalculator request)
        {
            var result = simpleCalculator.CalculatorSimple(request);

            return Ok(result);
        }

        [HttpPost("2")]
        public ActionResult<Exercise2Return> Exercise2([FromServices] IPrimeNumbersEndpoint primeNumbers, [FromBody] PrimeNumbers request)
        {
            List<int> nuns = new List<int>();
            nuns.Add(12);

            Exercise2Return result = new Exercise2Return(request.Number, primeNumbers.NumbersPrime(), primeNumbers.VerifyNumberPrime(request.Number));

            return Ok(result);
            
        }

        [HttpPost("3")]
        public ActionResult<Exercise3Return> Exercise3([FromServices] IFactorialEndpoint factorialEndpoint ,[FromBody] Factorial request)
        {
            Exercise3Return result = new Exercise3Return(request.Number, factorialEndpoint.CalculateFactorial(request.Number));

            return Ok(result);
        }

        [HttpPost("4")]
        public ActionResult<Exercise4Return> Exercise4([FromServices] IPalindromeEndpoint palindromeEndpoint, [FromBody] Palindrome request)
        {
            Exercise4Return result = new Exercise4Return(request.Word, palindromeEndpoint.WordPalindrome(request.Word));

            return Ok(result);
        }

        [HttpPost("5")]
        public ActionResult<Exercise5Return> Exercise5([FromServices] ITableEndpoint tableEndpoint, [FromBody] Table request)
        {
            Exercise5Return result = new Exercise5Return(request.Number, tableEndpoint.GerateTable(request.Number));

            return Ok(result);
        }

        [HttpPost("6")]
        public ActionResult<Exercise6Return> Exercise6([FromServices] IVowelCounter vowelCounter, [FromBody] Vowel request)
        {
            Exercise6Return result = new Exercise6Return(request.Sentence, vowelCounter.SetenceVowelCounter(request.Sentence));

            return Ok(result);
        }

        [HttpPost("7")]
        public ActionResult<Exercise7Return> Exercise7([FromServices] IGradeAverage gradeAverage, [FromBody] Average request)
        {
            Exercise7Return result = new Exercise7Return(request.Grades1, request.Grades2, request.Grades3, gradeAverage.CalculateAverage(request));

            return Ok(result);
        }

        [HttpPost("8")]
        public ActionResult<Exercise8Return> Exercise8([FromServices] IInterestCalculation interestCalculation, [FromBody] Interest request)
        {
            Exercise8Return result = new Exercise8Return(request.InitialCapital, request.InterestRate, request.MonthsInvestment, interestCalculation.CaculateInvestment(request));

            return Ok(result);
        }
       
    }
}
