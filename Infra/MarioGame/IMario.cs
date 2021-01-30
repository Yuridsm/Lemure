using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Infra.MarioGame
{
    public interface IMario
    {
        void PegarCogumelo();
        IMario PegarFlor();
        IMario PegarPena();
        IMario LevarDano();
        public void SetContext(IMario context);
    }
}
