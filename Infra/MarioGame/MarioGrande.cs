using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Infra.MarioGame
{
    public class MarioGrande : IMario
    {
        public IMario LevarDano()
        {
            Console.WriteLine("Mário Pequeno");
            return new MarioPequeno();
        }

        public void PegarCogumelo()
        {
            Console.WriteLine("Mais 1000 pontos");
            //return this; // Retorna a si próprio
        }

        public IMario PegarFlor()
        {
            Console.WriteLine("Mário com Fogo");
            return new MarioFogo();
        }

        public IMario PegarPena()
        {
            Console.WriteLine("Mário com Capa");
            return new MarioCapa();
        }

        public void SetContext(IMario context)
        {

        }
    }
}
