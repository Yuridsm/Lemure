using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Infra.StatePatternJulio
{
    public class ProductState : IChatState
    {
        private Chat chat;

        public ProductState(Chat chat)
        {
            this.chat = chat;
        }
        public void ChangeState(IChatState State)
        {
            this.chat.SetState(State);
        }

        public void HandleOptions(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    //this.chat.SetState(new )
                    Console.WriteLine("Opção escolhida: 1");
                    break;
                case "2":
                    Console.WriteLine("Estado atual: produtos");
                    break;
                case "3":
                    Console.WriteLine("Opção escolhida: 3");
                    break;
            }
        }
    }
}
