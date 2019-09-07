////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ISubject.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ObserverDesignPattern
{
    /// <summary>
    /// interface subject
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Subscribes the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Subscribe(Observer observer);

        /// <summary>
        /// UnSubscribe the specified observer
        /// </summary>
        /// <param name="observer">The observer.</param>
        void UnSubscribe(Observer observer);

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }
}
