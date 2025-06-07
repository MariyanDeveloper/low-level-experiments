namespace OperatingSystem.Tests;

public record Assembly(byte[] Data)
{
    public int Size => Data.Length;

    public static Assembly FromFile(string file)
    {
        var bytes = File.ReadAllBytes(file);

        return new Assembly(bytes);
    }
};

public class MemoryManager
{
    private int _offset;
    private readonly byte[] _memory;

    public MemoryManager(byte[] memory)
    {
        _memory = memory ?? throw new ArgumentNullException(nameof(memory));
    }

    public int Malloc(int amountOfBytes)
    {
        var result = _offset;
        _offset += amountOfBytes;
        return result;
    }

    public void Free(int address)
    {
        _offset = address;
    }
}

public class OperatingSystem
{
    public Process CreateProcess(Assembly assembly)
    {
        throw new NotImplementedException();
    }
}

public class Process
{
    private readonly MemoryManager _memoryManager;
    public Thread MainThread { get; }

    public Process(MemoryManager memoryManager)
    {
        _memoryManager = memoryManager ?? throw new ArgumentNullException(nameof(memoryManager));
    }

    public int Malloc(int amountOfBytes) => _memoryManager.Malloc(amountOfBytes);

    public void Start()
    {
        throw new NotImplementedException();
    }
}

public class Thread
{
    private readonly Process _parent;

    public Thread(Process parent)
    {
        _parent = parent ?? throw new ArgumentNullException(nameof(parent));
    }

    public void Execute(int[] someCommands) { }
}

public class UnitTest1
{
    [Fact]
    public void TestBasicOSOperations()
    {
        var operatingSystem = new OperatingSystem();
        var assembly = Assembly.FromFile("somePath");
        var process = operatingSystem.CreateProcess(assembly);
        process.Start();
    }
}
