using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConjuntos.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            //Critério de comparação do GetHashCode de igualdade será o ID do estudante
            return Id.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Student)) return false;
                                                //Downcasting, transformando objeto recebido em uma classe do tipo estudante.
            Student other = obj as Student;
                                                //Testa a igualdade positiva 100% do ID dos dois objetos
            return Id.Equals(other.Id);
        }
    }
}
