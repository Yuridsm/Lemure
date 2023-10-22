using System;

namespace lemure.interfaces.Comparable;

public class CPF : IComparable<CPF>
{
	public Int64 cpf;
	public int CompareTo(CPF cpf)
	{
		if (this.cpf == cpf.cpf)
		{
			return 0;
		}
		if (this.cpf > cpf.cpf)
		{
			return 1;
		}
		return -1;
	}

	public override string ToString()
	{
		return this.cpf.ToString();
	}
}
