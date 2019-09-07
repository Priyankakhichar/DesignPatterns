////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Observer.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPattern
{
    using System;

    /// <summary>
    /// Observer class giving the notification
    /// </summary>
    /// <seealso cref="DesignPattern.ObserverDesignPattern.IObserver" />
    public class Observer : IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Observer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Observer(string name)
        {
            this.ObserverName = name;
        }

        /// <summary>
        /// Gets the name of the observer.
        /// </summary>
        /// <value>
        /// The name of the observer.
        /// </value>
        public string ObserverName
        {
            get;
            private set;
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("{0} : new item arrived to the store ", this.ObserverName);
        }
    }
}
