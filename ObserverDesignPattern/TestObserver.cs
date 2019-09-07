////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "TestObserver.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPattern
{
    using System;

    /// <summary>
    /// TestObserver class has the function to check the working process of Observer
    /// </summary>
    public class TestObserver
    {
        /// <summary>
        /// Tests the observer pattern.
        /// </summary>
        public void TestObserverPattern()
        {
            string userInput;
            do
            {
                Subject subject = new Subject();
                Console.WriteLine("you want to add item to the store, y/n ?");
                userInput = Console.ReadLine();
                if (userInput.Equals("y"))
                {
                    subject.Inventory++;
                }
                else
                {
                    break;
                }
             
                Observer observer1 = new Observer("observer1");

                //// Observer1 takes a subscription to the store
                subject.Subscribe(observer1);

                // Observer2 takes a subscription to the store
                subject.Subscribe(new Observer("observer2"));
                
                //// Observer3 subscribes to notifications.
                subject.Subscribe(new Observer("observer3"));
                subject.Inventory++;

                //// Observer1 unsubscribes
                subject.UnSubscribe(observer1);
                Console.WriteLine("after unsbscribing observer1 only observer2 and observer3 will get notify");
                subject.Inventory++;
            }
            while ("y".Equals(userInput));
        }
    }
}
