

namespace Programa
{
     class Funcionario
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; private set; }  

        public Funcionario() { }
        public Funcionario(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
            
        }


        public void RiseSalary(double quantity)
        {
            double result = (Salary * quantity) / 100;
            Salary += result;
        }
        public override string ToString()
        {
            return Id + ", " + Name + ", $" + Salary.ToString("F2");
        }
    }
}
