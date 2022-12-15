using System;

namespace Lemure
{
    public interface IAnimal
    {
        void Andar();
        void Comer();
    }

    public class Cachorro : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("Cachorro andando...");
        }

        public void Comer()
        {
            Console.WriteLine("Cachorro comendo...");
        }
    }

    public class Pinguim : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("Pinguim andando...");
        }

        public void Comer()
        {
            Console.WriteLine("Pinguim comendo...");
        }
    }

    public class Gato : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("Gato comendo...");
        }

        public void Comer()
        {
            Console.WriteLine("Comer comendo...");
        }
    }

}
