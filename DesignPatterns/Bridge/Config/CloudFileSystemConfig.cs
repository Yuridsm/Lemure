namespace Lemure.DesignPatterns.Bridge.Config;

public class CloudFileSystemConfig
{
    public CloudProviderEnum CloudProvider { get; set; }
    public string ConnectionString { get ; set; }
    public string BucketName { get; set; }
}

public class CloudFileSystemConfigBuilder
{
    private readonly CloudFileSystemConfig _cloudFileSystemConfig = new();

    public CloudFileSystemConfigBuilder SetCloudProvider(CloudProviderEnum cloudProviderEnum)
    {
        _cloudFileSystemConfig.CloudProvider = cloudProviderEnum;
        return this;
    }

    public CloudFileSystemConfigBuilder SetConnectionString(string connectionString)
    {
        _cloudFileSystemConfig.ConnectionString = connectionString;
        return this;
    }

    public CloudFileSystemConfigBuilder SetBucketName(string bucketName)
    {
        _cloudFileSystemConfig.BucketName = bucketName;
        return this;
    }

    public CloudFileSystemConfig Build() => _cloudFileSystemConfig;
}