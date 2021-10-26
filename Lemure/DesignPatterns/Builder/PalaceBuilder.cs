using System;

namespace lemure.DesignPatterns.Builder
{
    public class PalaceBuilder : IBuilder
    {
        private PalaceBuilder _result;
        private int walls;
        private int doors;
        private int windows;
        private int roof;
        private int garage;

        public IBuilder BuildWalls(){
            walls = 10;
            Console.WriteLine("Construindo paredes do Palácio");
            return _result;
        }

        public IBuilder BuildDoors(){
            doors = 10;
            Console.WriteLine("Construindo portas do Palácio");
            return _result;
        }

        public IBuilder BuildWindows(){
            windows = 10;
            Console.WriteLine("Construindo janelas do Palácio");
            return _result;
        }

        public IBuilder BuildRoof(){
            roof = 10;
            Console.WriteLine("Construindo cobertura do Palácio");
            return _result;
        }

        public IBuilder BuildGarage(){
            garage = 10;
            Console.WriteLine("Construindo garagem do Palácio");
            return _result;
        }

        public void Reset() {
            Console.WriteLine("Resetando ...");
            _result = new PalaceBuilder();
        }

        public PalaceBuilder GetResults(){
            Console.WriteLine("Resultado da cosntrução do Palácio");
            return _result;
        }
    }
}