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
