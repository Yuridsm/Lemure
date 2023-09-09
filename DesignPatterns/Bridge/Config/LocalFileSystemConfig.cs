namespace Lemure.DesignPatterns.Bridge.Config;

public class LocalFileSystemConfig
{
    public string RootDirectory { get; set; }
}

public class LocalFileSystemConfigBuilder
{
    private readonly LocalFileSystemConfig config = new();

    public LocalFileSystemConfigBuilder SetRootDirectory(string rootDirectory)
    {
        config.RootDirectory = rootDirectory;
        return this;
    }

    public LocalFileSystemConfig Build() => config;
}