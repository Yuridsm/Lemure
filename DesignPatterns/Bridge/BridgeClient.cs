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

        #region LocalFileSystem
        LocalFileSystemConfig config = new LocalFileSystemConfigBuilder()
            .SetRootDirectory("C:\\Files")
            .Build();

        fileSystemOperation = new LocalFileSystem(config);

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");
        #endregion

        #region PrivateNetwork
        NetworkFileSystemConfig networkConfig = new NetworkFileSystemConfigBuilder()
            .SetServerAddress("http://localhost:4000")
            .SetUsername("Yuri")
            .SetPassword("teste123")
            .Build();

        fileSystemOperation = new PrivateNetworkFileSystem(networkConfig);

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");
        #endregion

        #region AWSFileSystem
        CloudFileSystemConfig awsFileSystemConfig = new CloudFileSystemConfigBuilder()
            .SetCloudProvider(CloudProviderEnum.AWS)
            .SetBucketName("aws-bucket-docs")
            .SetConnectionString("my AWS connection string here")
            .Build();

        fileSystemOperation = new AWSFileSystem(awsFileSystemConfig);

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");
        #endregion

        #region AzureFileSystem
        CloudFileSystemConfig azureFileSystemConfig = new CloudFileSystemConfigBuilder()
            .SetCloudProvider(CloudProviderEnum.AWS)
            .SetBucketName("azure-bucket-docs")
            .SetConnectionString("my azure connection string here")
            .Build();

        fileSystemOperation = new AzureFileSystem(azureFileSystemConfig);

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");
        #endregion

        #region GCPFileSystem
        CloudFileSystemConfig gcpFileSystemConfig = new CloudFileSystemConfigBuilder()
            .SetCloudProvider(CloudProviderEnum.AWS)
            .SetBucketName("gcp-bucket-docs")
            .SetConnectionString("my GCP connection string here")
            .Build();

        fileSystemOperation = new GCPFileSystem(gcpFileSystemConfig);

        fileSystem = new CustomFileSystem(fileSystemOperation);
        fileSystem.CreateFile("test.txt");
        fileSystem.DeleteFile("test.txt");
        #endregion
    }
}