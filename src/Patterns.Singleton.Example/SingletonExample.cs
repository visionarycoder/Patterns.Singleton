// ReSharper disable InconsistentNaming
namespace Patterns.Singleton.Example;

public class SingletonExample
{

    private static readonly object padlock = default!;
    private static SingletonExample? instance;

    private SingletonExample()
    {

    }

    public static SingletonExample Instance
    {

        get
        {
            lock (padlock)
            {
                instance ??= new SingletonExample();
            }
            return instance;
        }

    }

}