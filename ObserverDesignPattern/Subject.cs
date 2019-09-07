////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Subject.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPattern
{
    using System.Collections.Generic;

    /// <summary>
    /// Subject class have function to add observer to the list and remove observer from the list
    /// </summary>
    /// <seealso cref="DesignPattern.ObserverDesignPattern.ISubject" />
    public class Subject : ISubject
    {
        /// <summary>
        /// The observer list
        /// </summary>
        private List<Observer> observerList = new List<Observer>();

        /// <summary>
        /// The item
        /// </summary>
        private int item;

        /// <summary>
        /// Gets or sets the inventory.
        /// </summary>
        /// <value>
        /// The inventory.
        /// </value>
        public int Inventory
        {
            get
            {
                return this.item;
            }

            set
            {
                ////if increase in inventory it will notify.
                if (value > this.item)
                {
                    this.Notify();
                }

                this.item = value;
            }
        }

        /// <summary>
        /// Subscribes the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Subscribe(Observer observer)
        {
            this.observerList.Add(observer);
        }

        /// <summary>
        /// UnSubscribe the specified observer
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void UnSubscribe(Observer observer)
        {
            this.observerList.Remove(observer);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            this.observerList.ForEach(x => x.Update());
        }
    }
}
