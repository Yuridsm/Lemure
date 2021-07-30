using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Infra.StatePatternJulio
{
    public interface IChatState
    {
        public void HandleOptions(string userInput);
        public void ChangeState(IChatState State);
    }
}
