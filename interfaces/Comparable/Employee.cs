using System;

namespace lemure.interfaces.Comparable
{
    public class Employee : IComparable<Employee>
    {
        public string name { get; set; }
        public int salary { get; set; }
        public CPF cpf { get; set; }
        // Estou ordenando apenas por CPF
        public int CompareTo(Employee epl)
        {
            return this.cpf.CompareTo(epl.cpf);   
        }
        public override string ToString()
        {
            return this.salary.ToString() + ", " + this.name + " : [" + this.cpf.ToString() + "]";
        }
    }
}
