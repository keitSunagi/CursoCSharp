
namespace AbstractClasses.Entities
{
     class CompanyPerson : Person
    {
        public int EmployeeNumber { get; set; }

        public CompanyPerson() { }

        public CompanyPerson(string name, double anualIncome, int employeeNumber) : base(name,anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }
        public override double TaxCalculation()
        {
            if(EmployeeNumber > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
