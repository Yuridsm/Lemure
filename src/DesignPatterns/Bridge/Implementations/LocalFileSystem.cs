using System;
using System.Text;
using Lemure.DesignPatterns.Bridge.Config;

namespace Lemure.DesignPatterns.Bridge.Implementations;

public class LocalFileSystem : IFileSystemOperation
{
	private LocalFileSystemConfig _localFileSystemConfig;

	public LocalFileSystem(LocalFileSystemConfig localFileSystemConfig)
	{
		_localFileSystemConfig = localFileSystemConfig;
	}

	public void CreateFile(string name)
	{
		Console.WriteLine($"Creating file with name {name}, in Local System, at {_localFileSystemConfig.RootDirectory}");
	}

	public void DeleteFile(string name)
	{
		Console.WriteLine($"Deleting file with name {name}, in Local System, at {_localFileSystemConfig.RootDirectory}");
	}

	public byte[] ReadFile(string name)
	{
		return Encoding.UTF8.GetBytes($"Some text here from Local System, at {_localFileSystemConfig.RootDirectory}");
	}
}