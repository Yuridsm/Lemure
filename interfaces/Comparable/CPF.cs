using System;

namespace lemure.interfaces.Comparable
{
    public class CPF : IComparable<CPF> 
    {
        private readonly Int64 _cpf;
        public CPF(Int64 cpf)
        {
            _cpf = cpf;
        }

        public int CompareTo(CPF cpf)
        {
            if(_cpf == cpf._cpf)
            {
                return 0;
            } 
            if (_cpf > cpf._cpf)
            {
                return 1;
            }
            return -1;
        }

        public override string ToString()
        {
            return $"This is your CPF -> {_cpf}";
        }
    }
}
