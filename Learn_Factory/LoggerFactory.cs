using System;

// Product Interface
public interface ILogger
{
    void Log(string message);
}
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Console: {message}");
    }
}
public class FileLogger : ILogger
{
    private readonly string _path;
    public FileLogger(string path)
    {
        _path = path;
    }
    public void Log(string message)
    {
        Console.WriteLine($"File Logging: {_path} :  {message}");
    }
}
public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Database: {message}");
    }
}

public class CloudLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Cloud: {message}");
    }
}

public static class LoggerFactory
{
    public static ILogger CreateLogger(string type, string additionaData = "")
    {
        switch (type)
        {
            case "Console":
                return new ConsoleLogger();
            case "File":
                return new FileLogger(additionaData);
            case "Database":
                return new DatabaseLogger();
            case "Cloud":
                return new CloudLogger();
            default:
                throw new ArgumentException("Invalid Logger");
        }
    }
}
