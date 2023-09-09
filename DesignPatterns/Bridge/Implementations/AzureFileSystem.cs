using System;
using System.Text;

namespace Lemure.DesignPatterns.Bridge.Implementations;

public class AzureFileSystem : IFileSystemOperation
{
    public void CreateFile(string name)
    {
        Console.WriteLine($"Creating file with name {name} on Azure Cloud");
    }

    public void DeleteFile(string name)
    {
        Console.WriteLine($"Deleting file with name {name} on Azure Cloud");
    }

    public byte[] ReadFile(string name)
    {
        return Encoding.UTF8.GetBytes("Some text here from Azure Cloud");
    }
}