using lemure.DesignPatterns.Builder;

namespace Lemure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var house = new HouseBuilder();
            var director = new Director(house);
            director.Make("house");
            var p = house.GetResults();
        }
    }
}
