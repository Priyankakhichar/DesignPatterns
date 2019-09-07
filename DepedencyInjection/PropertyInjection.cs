////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "INotificationAction.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DepedencyInjection
{
    using System;

    /// <summary>
    /// Notification Action
    /// </summary>
    public interface INotificationAction
    {
        /// <summary>
        /// Acts the on notification.
        /// </summary>
        /// <param name="message">The message.</param>
        void ActOnNotification(string message);
    }

    /// <summary>
    /// Demo class
    /// </summary>
    public class Demo
    {
        /// <summary>
        /// The task
        /// </summary>
        private INotificationAction task = null;

        /// <summary>
        /// Notify the specified at.
        /// </summary>
        /// <param name="at">At.</param>
        /// <param name="messages">The messages.</param>
        public void Notify(INotificationAction at, string messages)
        {
            this.task = at;
            this.task.ActOnNotification(messages);
        }
    }

    /// <summary>
    /// Event Log Writer
    /// </summary>
    /// <seealso cref="DesignPattern.DepedencyInjection.INotificationAction" />
    public class EventLogWriter : INotificationAction
    {
        /// <summary>
        /// Acts the on notification.
        /// </summary>
        /// <param name="message">The message.</param>
        public void ActOnNotification(string message)
        {
            // Write to event log here
            Console.WriteLine("using property injection");
        }
    }

    /// <summary>
    /// Property Injection
    /// </summary>
    public class PropertyInjection
    {
        /// <summary>
        /// Tests the property injection.
        /// </summary>
        public void TestPropertyInjection()
        {
            EventLogWriter elw = new EventLogWriter();
            Demo at = new Demo();
            at.Notify(elw, "to logg");
            Console.ReadKey();
        }
    }
}
