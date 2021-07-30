using System;
using System.Collections.Generic;

namespace Lemure.Collections.Comparable
{
    public class CarTest
    {
        public static void Test()
        {
            //cria uma lista de funcionários
            List<Car> lista = new List<Car>();
            lista.Add(new Car() { Name = "Macoratti", MaxSpeed = 10000 });
            lista.Add(new Car() { Name = "Janice", MaxSpeed = 10000 });
            lista.Add(new Car() { Name = "Yuri", MaxSpeed = 40000 });
            lista.Add(new Car() { Name = "Bianca", MaxSpeed = 10000 });
            lista.Add(new Car() { Name = "Amanda", MaxSpeed = 500000 });
            lista.Add(new Car() { Name = "Jefferson", MaxSpeed = 17000 });
            lista.Add(new Car() { Name = "Dinora", MaxSpeed = 8000 });

            // Como IComparable é para ordenação, logo precisamos mandar ordenar
            lista.Sort();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
