
namespace Patterns.Common.DependencyInversionPrinciple
{
    using System;

    public class Jeep : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
        #endregion
    }
}
