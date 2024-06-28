
namespace StrategyPattern;

// Strategy
public interface ICompression
{
    public void Compress(string file);
}

public class ZIPCompression : ICompression
{
    public void Compress(string file)
    {
        Console.WriteLine("file.ZIP");
    }
}

public class RARCompression : ICompression
{
    public void Compress(string file)
    {
        Console.WriteLine("file.RAR");
    }
}

// Context
public class Compressor
{
    ICompression compression;

    public Compressor(ICompression compression)
    {
        this.compression = compression;
    }

    public void Compress(string file)
    {
        compression.Compress(file);
    }
}
