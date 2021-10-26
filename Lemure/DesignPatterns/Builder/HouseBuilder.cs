using Lemure.DesignPatterns.Builder;
using System;

namespace lemure.DesignPatterns.Builder
{
    public class HouseBuilder : IBuilder
    {
        private House _result;

        public HouseBuilder()
        {
            this.Reset();
        }

        public IBuilder BuildWalls(){
            Console.WriteLine("Construindo paredes da Casa");
            _result.walls = 2;
            return this;
        }

        public IBuilder BuildDoors(){
            _result.doors = 2;
            Console.WriteLine("Construindo portas da Casa");
            return this;
        }

        public IBuilder BuildWindows(){
            _result.windows = 2;
            Console.WriteLine("Construindo janelas da Casa");
            return this;
        }

        public IBuilder BuildRoof(){
            _result.roof = 2;
            Console.WriteLine("Construindo cobertura da Casa");
            return this;
        }

        public IBuilder BuildGarage(){
            _result.garage = 2;
            Console.WriteLine("Construindo garagem da Casa");
            return this;
        }
        
        public void Reset() {
            Console.WriteLine("Resetando ...");
            _result = new House();
        }

        public HouseBuilder GetResults(){
            Console.WriteLine("Resultado da cosntrução da Casa");
            return this;
        }
    }
}