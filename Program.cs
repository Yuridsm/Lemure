using LeanringWithMosh.interfaces.Comparable;
using LeanringWithMosh.interfaces.Disposable;
using System.Collections.Generic;
using System;
using System.Text;

namespace LeanringWithMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { name = "Macoratti", salary = 80000, cpf = new CPF() { cpf = 11905365446 } });
            list.Add(new Employee() { name = "Janice", salary = 10000, cpf = new CPF() { cpf = 20005365446 } });
            list.Add(new Employee() { name = "Yuri", salary = 40000, cpf = new CPF() { cpf = 13005365446 } });
            list.Add(new Employee() { name = "Bianca", salary = 50000, cpf = new CPF() { cpf = 80005365446 } });
            list.Add(new Employee() { name = "Amanda", salary = 17000, cpf = new CPF() { cpf = 97805365446 } });
            list.Add(new Employee() { name = "Jefferson", salary = 8000, cpf = new CPF() { cpf = 70205365446 } });
            list.Add(new Employee() { name = "Raiela", salary = 90000, cpf = new CPF() { cpf = 70105365446 } });
            list.Sort();

            foreach(var employee in list)
            {
                Console.WriteLine(employee);
            }

            // Training IDisposable using FilesManager class
            using (FilesManager manager = new FilesManager("C:\\Users\\yurii\\Documents\\yuriCSharp.data"))
            {
                byte[] data = Encoding.ASCII.GetBytes("C:\\Users\\yurii\\Documents\\Macoratti.net");
                manager.Write(data);
            }

            // Training IDisposable using MyDatabase class
            using (MyDatabase db = new MyDatabase("Oracle:localhost:4444, ..."))
            {
                Console.WriteLine("Connecting to the Oracle");
                db.GetOnDatabase();
            }
        }
    }
}
