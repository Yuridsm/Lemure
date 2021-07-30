using System;
using System.Collections.Generic;
using System.Text;

namespace lemure.Infra.MarioGame
{
    public class MarioPequeno : IMario
    {
        private Mario marioContext;
        public IMario LevarDano()
        {
            Console.WriteLine("Mário Morto");
            return new MarioMorto();
        }

        public void PegarCogumelo()
        {
            Console.WriteLine("Passa para Mário grande");
            //return new MarioGrande();
            this.marioContext.ChangeState(new MarioGrande());
        }

        public IMario PegarFlor()
        {
            Console.WriteLine("Mário grande com fogo");
            return new MarioFogo();
        }

        public IMario PegarPena()
        {
            Console.WriteLine("Mário grande com capa");
            return new MarioCapa();
        }

        public void SetContext(IMario context)
        {

        }
    }
}
