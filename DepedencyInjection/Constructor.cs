////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Constructor.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DepedencyInjection
{
    /// <summary>
    /// Constructor
    /// </summary>
    public class Constructor
    {
        /// <summary>
        /// Tests the constructor injection.
        /// </summary>
        public void TestConstructorInjection()
        {
            ConstructorInjection injection = new ConstructorInjection(new Format());
            injection.Print();
        }
    }
}
