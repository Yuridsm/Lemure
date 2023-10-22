using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lemure.DesignPatterns.TemplateMethod;

public abstract class CustomerDataParse
{
	public IEnumerable<CustomerData> _customerData;
	protected readonly string _filePath;

	public CustomerDataParse(string filePath)
	{
		_filePath = filePath;
	}

	public async Task FixCustomerData()
	{
		await ParseData();
	}

	protected abstract Task ParseData();
}
