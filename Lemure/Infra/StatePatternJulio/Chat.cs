using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Infra.StatePatternJulio
{
    public class Chat
    {
        private IChatState currenteState;
        public Chat()
        {   
            Console.WriteLine("Opção 1 \n Opção 2 \n Opção 3");
            this.SetState(new MenuState(this));
        }

        public void SetState(IChatState chatState)
        {
            this.currenteState = chatState;
        }

        public IChatState GetCurrentState()
        {
            return this.currenteState;
        }
    }
}
