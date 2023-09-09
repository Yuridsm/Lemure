using System;
using System.Text;
using Lemure.DesignPatterns.Bridge.Config;

namespace Lemure.DesignPatterns.Bridge.Implementations;

public class PrivateNetworkFileSystem : IFileSystemOperation
{
    private readonly NetworkFileSystemConfig _networkFileSystemConfig;

    public PrivateNetworkFileSystem(NetworkFileSystemConfig networkFileSystemConfig)
    {
        _networkFileSystemConfig = networkFileSystemConfig;
    }

    public void CreateFile(string name)
    {
        Console.WriteLine($"Creating file with name: {name} on Private Network [at {_networkFileSystemConfig.ServerAddress}]");
    }

    public void DeleteFile(string name)
    {
        Console.WriteLine($"Deleting file with name {name} on Private Network [at {_networkFileSystemConfig.ServerAddress}]");
    }

    public byte[] ReadFile(string name)
    {
        return Encoding.UTF8.GetBytes($"Some text here from Private Network [at {_networkFileSystemConfig.ServerAddress}]");
    }
}