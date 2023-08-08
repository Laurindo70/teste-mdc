using TestMDC.Domain.Entities;

namespace TestMDC.Endpoints.Exercise7
{
    public class GradeAverage : IGradeAverage
    {
        public double CalculateAverage(Average request)
        {
            Double grade = (request.Grades1 + request.Grades2 + request.Grades3) /3;

            return grade;
        }
    }
}
