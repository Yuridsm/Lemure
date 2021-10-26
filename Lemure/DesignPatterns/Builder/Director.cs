using System;

namespace lemure.DesignPatterns.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Make(string type)
        {
            //_builder.Reset();

            Console.WriteLine($"Construindo {type}");

            if(type == "house")
            {
                _builder.BuildWalls().BuildWindows().BuildDoors();//.BuildRoof();
            }

            if(type == "palace")
            {
                _builder
                .BuildWalls()
                .BuildWindows()
                .BuildDoors()
                .BuildGarage();
            }
        }
    }
}