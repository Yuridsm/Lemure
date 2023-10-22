using Lemure.DesignPatterns.Bridge.Implementations;

namespace Lemure.DesignPatterns.Bridge.Abstraction;

public abstract class FileSystem
{
	protected IFileSystemOperation _fileSystem;

	public abstract void CreateFile(string name);
	public abstract void DeleteFile(string name);
	public abstract byte[] ReadFile(string name);
}