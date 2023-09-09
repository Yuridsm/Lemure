using System.Threading.Tasks;
using Lemure.CNAB;

namespace Lemure;

public static class Program
{
    public static async Task Main()
    {
		await SantanderCNAB.ExecuteUseCase();
	}
}
