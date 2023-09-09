using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Lemure.DesignPatterns.Bridge.Config;

public class LocalFileSystemConfig
{
    public string RootDirectory { get; internal set; }
}

public class LocalFileSystemConfigBuilder
{
    private LocalFileSystemConfig config = new();

    public LocalFileSystemConfigBuilder SetRootDirectory(string rootDirectory)
    {
        config.RootDirectory = rootDirectory;
        return this;
    }

    public LocalFileSystemConfig Build() => config;
}