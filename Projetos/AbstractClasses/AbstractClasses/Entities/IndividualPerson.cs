

namespace AbstractClasses.Entities
{
    internal class IndividualPerson : Person
    {
        public double HealthExpeditures { get; set; }

        public IndividualPerson() { }

        public IndividualPerson(string name, double anualIncome, double healthExpeditures) : base(name,anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double TaxCalculation()
        {
            if(AnualIncome >= 20000.00)
            {
                if(HealthExpeditures > 0)
                {
                    return (AnualIncome * 0.25) - (HealthExpeditures * 0.5);
                }
                return AnualIncome * 0.25;
            }
            else
            {
                if(HealthExpeditures > 0)
                {
                    return (AnualIncome * 0.15) - (HealthExpeditures * 0.5);
                }
                return AnualIncome * 0.15;
            }
            
        }

    }
}
