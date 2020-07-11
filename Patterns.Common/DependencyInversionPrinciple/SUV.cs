
namespace Patterns.Common.DependencyInversionPrinciple
{
    using System;

    public class SUV : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
        #endregion
    }
}
