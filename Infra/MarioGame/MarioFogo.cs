using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Infra.MarioGame
{
    public class MarioFogo : IMario
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
            Console.WriteLine("Ganhou 1000 pontos");
            return this;
        }

        public IMario PegarPena()
        {
            Console.WriteLine("Ganhou grande com capa");
            return new MarioCapa();
        }

        public void SetContext(IMario context)
        {

        }
    }
}
