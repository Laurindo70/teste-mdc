using TestMDC.Domain.Entities;

namespace TestMDC.Endpoints.Exercise7
{
    public interface IGradeAverage
    {
        Double CalculateAverage(Average request);
    }
}
