
namespace Patterns.Common.DependencyInversionPrinciple
{
    public class AutomobileController
    {
        IAutomobile m_Automobile;

        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        }

        public void Ignition()
        {
            m_Automobile.Ignition();
        }

        public void Stop()
        {
            m_Automobile.Stop();
        }
    }
}
