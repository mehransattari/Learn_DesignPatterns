
namespace Learn_Singleton;

    public sealed class Singleton
{
    private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>( () => new Singleton() );
    public static Singleton Instance => lazyInstance.Value;

    private Singleton()
    {
            
    }

    public void LogMessage(string message)
    {
        Console.WriteLine( $"log message : {message}" );
    }

}

