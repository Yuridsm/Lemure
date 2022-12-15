using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemure.DesignPatterns.Memento.Contracts
{
    public interface IMemento
    {
        string GetName();
        DateTime GetDate();
    }
}
