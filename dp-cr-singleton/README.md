# Creational Design Patterns
## Singleton
### Intent
Ensure a class has only one instance, and provide a global point of access to it.
### Motivation
It's important for some classes to have exactly one instance. For example, it can be desirable to have only a single instance of a class that controls access to a shared resource. It's also important that this instance is easily accessible. The Singleton pattern addresses both of these concerns.
### Applicability
Use the Singleton pattern when:
* there must be exactly one instance of a class, and it must be accessible to clients from a well-known access point
* when the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code
* when the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code
* when it's important that the sole instance is lazy initialized, and you don't want to use lazy initialization
* when it's important that the sole instance is lazy initialized, and you don't want to use lazy initialization
* when the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code
  
### Code 1:
```cs
namespace CreationalDesignPatterns
{
    public sealed class Logger
    {
        private static Logger? _logger;

        public string? LogMessage { get; set; }

        private Logger() { }

        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }
            return _logger;
        }

        public void OtherMethod()
        {
            // Do something
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetLogger();
            Logger logger2 = Logger.GetLogger();
            //Logger logger3 = new Logger(); // Won't allow to create instance

            logger1.LogMessage = "Register successfully";

            Console.WriteLine(logger1 == logger2);
            Console.WriteLine($"logger1 Message: {logger1.LogMessage}");
            Console.WriteLine($"logger2 Message: {logger2.LogMessage}");
        }
    }
}
```
### Code 2:
```cs
```

### Tutorials
### Consequences
### Real-world examples
### Credits
### Related patterns
### References



### TODO
- [ ] Diagram
- [ ] Description
- [ ] Code
- [ ] Example
