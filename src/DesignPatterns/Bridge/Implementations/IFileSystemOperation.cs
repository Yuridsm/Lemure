namespace Lemure.DesignPatterns.Bridge.Implementations;

public interface IFileSystemOperation
{
	void CreateFile(string name);
	void DeleteFile(string name);
	byte[] ReadFile(string name);
}