//using System;

//Create a C# program that demonstrates Constructor Injection, Setter Injection, and Interface Injection. Implement a simple service ILoggingService and a class MyClass that depends on this service. Demonstrate each type of dependency injection method.

//Alert!

//The result of execution should be:

//Constructor Injection: Logging message.
//Setter Injection: Logging message.
//Interface Injection: Logging message.


//It is a fairly simple exercise ment for you to mainly see and interact with a project that uses all three types of Dependency Injection. So don't sweat it, its simpler than it looks!
using System;

namespace Coding.Exercise
{
    public interface ILoggingService
    {
        void Log(string message);
    }

    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MyClassConstructorInjection
    {
        private readonly ILoggingService _loggingService;
        public MyClassConstructorInjection(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void PerformAction()
        {
            // TODO: Use _loggingService to log "Constructor Injection: Logging message."
            _loggingService.Log("Constructor Injection: Logging message.");

        }
    }

    public class MyClassSetterInjection
    {
        public ILoggingService LoggingService { private get; set; }

        public void PerformAction()
        {
            // TODO: Use LoggingService to log "Setter Injection: Logging message."
            LoggingService.Log("Setter Injection: Logging message.");
        }
    }

    public interface IDependencyInjector
    {
        void SetDependency(ILoggingService loggingService);
    }

    public class MyClassInterfaceInjection : IDependencyInjector
    {
        private ILoggingService _loggingService;
        public void SetDependency(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void PerformAction()
        {
            // TODO: Use _loggingService to log "Interface Injection: Logging message."
            _loggingService.Log("Interface Injection: Logging message.");

        }
    }

    public class Exercise
    {
        public void Run()
        {
            var loggingService = new LoggingService();

            var constructorInjection = new MyClassConstructorInjection(loggingService);
            // TODO: Call PerformAction on constructorInjection
            constructorInjection.PerformAction();

            var setterInjection = new MyClassSetterInjection { LoggingService = loggingService };
            // TODO: Call PerformAction on setterInjection
            setterInjection.PerformAction();
            var interfaceInjection = new MyClassInterfaceInjection();
            interfaceInjection.SetDependency(loggingService);
            // TODO: Call PerformAction on interfaceInjection
            interfaceInjection.PerformAction();
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.Run();

        }
    }
}
