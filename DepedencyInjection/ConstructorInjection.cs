////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ConstructorInjection.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DepedencyInjection
{
    /// <summary>
    /// ConstructorInjection
    /// </summary>
    public class ConstructorInjection
    {
        /// <summary>
        /// The text
        /// </summary>
        private IText text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructorInjection"/> class.
        /// </summary>
        /// <param name="t1">The t1.</param>
        public ConstructorInjection(IText t1)
        {
            this.text = t1;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            this.text.Print();
        }
    }
}
