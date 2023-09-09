using Lemure.DesignPatterns.Bridge.Implementations;

namespace Lemure.DesignPatterns.Bridge.Abstractions;

public class CustomFileSystem : FileSystem
{
    public CustomFileSystem(IFileSystemOperation fileSystem)
    {
        _fileSystem = fileSystem;
    }

    public override void CreateFile(string name)
    {
        _fileSystem.CreateFile(name);
    }

    public override void DeleteFile(string name)
    {
        _fileSystem.DeleteFile(name);
    }

    public override byte[] ReadFile(string name)
    {
        return _fileSystem.ReadFile(name);
    }
}