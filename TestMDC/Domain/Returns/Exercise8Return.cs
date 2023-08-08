namespace TestMDC.Domain.Returns
{
    public class Exercise8Return
    {
        public Exercise8Return(double initialCapital, double interestRate, int monthsInvestment, double valueFinalInvestment)
        {
            InitialCapital = initialCapital;
            InterestRate = interestRate;
            MonthsInvestment = monthsInvestment;
            ValueFinalInvestment = valueFinalInvestment;
        }
        public Double InitialCapital { get; set; }
        public Double InterestRate { get; set; }
        public int MonthsInvestment { get; set; }
        public Double ValueFinalInvestment { get; set; }

    }
}
