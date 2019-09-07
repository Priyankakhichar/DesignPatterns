////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Program.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;

    /// <summary>
    /// class that have main method
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("please select any one which you want to run");
            Console.WriteLine("1. for adapter");
            Console.WriteLine("2. for factory");
            Console.WriteLine("3. for Prototype");
            Console.WriteLine("4. for facade");
            Console.WriteLine("5. for Proxy");
            Console.WriteLine("6. for Observer");
            Console.WriteLine("7. for Decorator");
            Console.WriteLine("8. for Visitor");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: Adaptee adaptee = new Adaptee();
                    adaptee.CheckAdapter();
                    break;

                case 2: FactoryDesignPattern.TestFactory factory = new FactoryDesignPattern.TestFactory();
                    factory.TestComputerFactory();
                    break;

                case 3: ProtoTypeDesignPattern.ProtoTypePatternTest test = new ProtoTypeDesignPattern.ProtoTypePatternTest();
                    test.ProtoTypePatternTestStart();
                    break;

                case 4: FacadeDesignPattern.TestFacadeAddress facade = new FacadeDesignPattern.TestFacadeAddress();
                    facade.TestFacade();
                    break;

                case 5: ProxyDesignPattern.ProxyTest proxyTest = new ProxyDesignPattern.ProxyTest();
                    proxyTest.CheckProxy();
                    break;

                case 6:
                    ObserverDesignPattern.TestObserver observer = new ObserverDesignPattern.TestObserver();
                    observer.TestObserverPattern();
                    break;

                case 7:
                    DecoratorDesignPattern.DemoDecorator demo = new DecoratorDesignPattern.DemoDecorator();
                    demo.DemoDecoratorStart();
                    break;

                case 8: VisitorDesignPattern.ShoppingCartClient cart = new VisitorDesignPattern.ShoppingCartClient();
                    cart.ShoppingCart();
                    break;
            }
        }
    }
}
