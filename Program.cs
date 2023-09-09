using Lemure.Delegates.Bridge;
using Lemure.DesignPatterns.Bridge;

namespace Lemure;

public static class Program
{
  public static void Main()
  {
		// await SantanderCNAB.ExecuteUseCase();
    BridgeClient.Execute();
	}
}
