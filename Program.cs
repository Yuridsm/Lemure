using System;
using lemure.interfaces.Comparable;
using lemure.DesignPatterns.Adapter.Business;
using lemure.DesignPatterns.Adapter.Contracts;

namespace lemure
{
    public interface ICar<TEntity> where TEntity : class
    {
        int Serial { get; set; }
        string Name { get; set; }
    }

    class Camaro<TEntity> : ICar<TEntity> where TEntity : class
    {
        public int Serial { get; set; }
        public string Name { get; set; }

        public Camaro(int serial, string name)
        {
            this.Serial = serial;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Serial : {Serial}\nName : {Name}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var validator = new Email("yurifullstack@gmail.com");
            validator.Validate();
        }
    }
}
