namespace TestMDC.Domain.Returns
{
    public class Exercise7Return
    {
        public Exercise7Return(Double grades1, Double grades2, Double grades3, Double average)
        {
            Grades1 = grades1;
            Grades2 = grades2;
            Grades3 = grades3;
            Average = average;
        }
        public Double Grades1 { get; set; }
        public Double Grades2 { get; set; }
        public Double Grades3 { get; set; }
        public Double Average { get; set; }
    }
}
