using Lemure.DesignPatterns.Bridge.Abstractions;
using Lemure.DesignPatterns.Bridge.Config;
using Lemure.DesignPatterns.Bridge.Implementations;

namespace Lemure.Delegates.Bridge;

public class BridgeClient
{
    public static void Execute()
    {
        IFileSystemOperation fileSystemOperation;
        FileSystem fileSystem;

        // Local File
        LocalFileSystemConfig config = new LocalFileSystemConfigBuilder()
            .SetRootDirectory("C:\\Files")
            .Build();

        fileSystemOperation = new LocalFileSystem(config);

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");

        // Private Network
        fileSystemOperation = new PrivateNetworkFileSystem();

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");

        // AWS File System
        fileSystemOperation = new AWSFileSystem();

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");

        // Azure File System
        fileSystemOperation = new AzureFileSystem();

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");

        // GCP File System
        fileSystemOperation = new GCPFileSystem();

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");
    }
}