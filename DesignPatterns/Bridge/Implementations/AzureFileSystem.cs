using System;
using System.Text;
using Lemure.DesignPatterns.Bridge.Config;

namespace Lemure.DesignPatterns.Bridge.Implementations;

public class AzureFileSystem : IFileSystemOperation
{
    private readonly CloudFileSystemConfig _cloudFileSystemConfig;

    public AzureFileSystem(CloudFileSystemConfig cloudFileSystemConfig)
    {
        _cloudFileSystemConfig = cloudFileSystemConfig;
    }
    
    public void CreateFile(string name)
    {
        Console.WriteLine($"Creating file with name {name} on Azure Cloud's {_cloudFileSystemConfig.BucketName} bucket");
    }

    public void DeleteFile(string name)
    {
        Console.WriteLine($"Deleting file with name {name} on Azure Cloud's {_cloudFileSystemConfig.BucketName} bucket");
    }

    public byte[] ReadFile(string name)
    {
        return Encoding.UTF8.GetBytes($"Some text here from Azure Cloud's {_cloudFileSystemConfig.BucketName} bucket");
    }
}