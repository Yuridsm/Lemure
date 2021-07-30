using System;
using System.Collections.Generic;
using System.Text;

namespace lemure.Infra.MarioGame
{
    public class Mario
    {
        private IMario estado;
        public Mario(IMario _initialState)
        {
            estado = _initialState;
        }

        public void ChangeState(IMario state)
        {
            this.estado = state;
        }
        /*public void PegarCogumelo()
        {
            estado = estado.PegarCogumelo();
        }*/

        public void PegarFlor()
        {
            estado = estado.PegarFlor();
        }

        public void PegarPena()
        {
            estado = estado.PegarPena();
        }

        public void LevarDano()
        {
            estado = estado.LevarDano();
        }
    }
}
