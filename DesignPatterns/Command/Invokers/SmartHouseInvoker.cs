using Lemure.DesignPatterns.Command.Contracts;
using System.Collections.Generic;

namespace Lemure.DesignPatterns.Command.Invokers
{
    public class SmartHouseInvoker
    {
        private Dictionary<string, ISmartHouse> _commands = new Dictionary<string, ISmartHouse>();

        public void AddCommand(string key, ISmartHouse command)
        {
            _commands[key] = command;
        }

        public void ExecuteCommand(string key)
        {
            // Adicione algum tipo de checagem aqui
            _commands[key].Execute();
        }

        public void UndoCommand(string key)
        {
            // Adicione algum tipo de checagem aqui
            _commands[key].Undo();
        }
    }
}
