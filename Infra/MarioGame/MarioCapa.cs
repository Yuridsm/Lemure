using System;
using System.Collections.Generic;
using System.Text;

namespace lemure.Infra.MarioGame
{
    public class MarioCapa : IMario
    {
        public IMario LevarDano()
        {
            Console.WriteLine("Ganhou Grande");
            return new MarioGrande();
        }

        public void PegarCogumelo()
        {
            Console.WriteLine("Ganhou 1000 pontos");
            //return this;
        }

        public IMario PegarFlor()
        {
            Console.WriteLine("Ganhou Grande com fogo");
            return new MarioFogo();
        }

        public IMario PegarPena()
        {
            Console.WriteLine("Ganhou 1000 pontos");
            return this;
        }

        public void SetContext(IMario context)
        {

        }
    }
}
