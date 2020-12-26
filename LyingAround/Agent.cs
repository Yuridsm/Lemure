using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.LyingAround
{
    public static class Agent
    {
        public static string Info(this KGB kgbAgent)
        {
            return kgbAgent.KGBAgentCode();
        }
    }
}
