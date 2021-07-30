using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Infra.StatePatternJulio
{
    public class MenuState : IChatState
    {
        private Chat chat;

        public MenuState(Chat chat)
        {
            this.chat = chat;
        }
        public void ChangeState(IChatState State)
        {
            this.chat.SetState(State);
        }

        public void HandleOptions(string userInput)
        {
            switch(userInput)
            {
                case "1": 
                    
                    Console.WriteLine("Produto 1 \n Produto 2 ");
                    this.chat.SetState(new ProductState(this.chat));
                    break;
                case "2":
                    Console.WriteLine("Opção escolhida: 2");
                    break;
                case "3":
                    Console.WriteLine("Opção escolhida: 3");
                    break;
            }
        }
    }
}
