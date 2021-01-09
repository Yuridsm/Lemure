using LeanringWithMosh.Reflection.NoReflection;
using LeanringWithMosh.Reflection.WithReflection;
using LeanringWithMosh.LazyInitialization;
using Order = LeanringWithMosh.Reflection.NoReflection.Order;
using System.Runtime.InteropServices;

namespace LeanringWithMosh
{
    public class Program
    {
        public static void LoggerNoReflection(Customer customer, Product product, Order order)
        {
            LogNoReflection.CustomerLog(customer);
            LogNoReflection.ProductLog(product);
            LogNoReflection.OrdersLog(order);
        }

        public static void LoggerWithReflection(Customer customer, Product product, Order order)
        {
            LogWithReflection.Log(customer);
            LogWithReflection.Log(product);
            LogWithReflection.Log(order);
        }

        static void Main(string[] args)
        {
            /*List<Employee> list = new List<Employee>();
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

            // Testing Attributes
            UsingAttributes.TestingAttribute();

            // Testing Reflection
            var customer = new Customer()
            {
                Id = 10,
                Name = "Macoratti",
                Address = "Rua Projetada, 100"
            };
            var product = new Product()
            {
                Id = 1,
                Name = "Caderno",
                Description = "Caderno Espiral 100 folhas",
                Stock = 100,
                Price = 3.99M
            };
            var order = new Order()
            {
                Id = 1,
                CustumerId = 1,
                OrderDate = DateTime.Now
            };
            Console.WriteLine("***** Logando sem usar Reflection ****");
            LoggerNoReflection(customer, product, order);
            Console.WriteLine(" ---------- Logando usando Reflection ----------");
            //LogarUsandoReflection(cliente, produto, pedido);
            LoggerWithReflection(customer, product, order);*/

            // Serializing and Desserializing
            /*var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            WeatherForecast weatherForecast = new WeatherForecast();
            weatherForecast.Date = DateTime.Now;
            weatherForecast.Summary = "Hey there";
            weatherForecast.TemperatureCelsius = 123;
            weatherForecast.Anyone = new ComplexWrap();
            weatherForecast.Anyone.firstName = "Yuri";
            weatherForecast.Anyone.lastName = "Melo";
            weatherForecast.Anyone.age = 23;
            string jsonString = JsonSerializer.Serialize(weatherForecast, options);
            Console.WriteLine(jsonString);

            var forecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString, options);
            Console.WriteLine(forecast.Anyone.firstName);*/

            // Lazy Initializatin
            LazyInit lazy = new LazyInit();
            lazy.Load();

            // Interop Services

        }
    }
}
