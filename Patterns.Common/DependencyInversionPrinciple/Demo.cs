
namespace Patterns.Common.DependencyInversionPrinciple
{
    public class Demo
    {
        public Demo()
        {
            IAutomobile automobile = new Jeep();
            //IAutomobile automobile = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobile.Ignition();
            automobile.Stop();

            //In the above code, automobile interface is in an abstraction layer and AutomobileController 
            //as the higher-level module.Here, we have integrated all in a single code but in real-world,
            //each abstraction layer is a separate class with additional functionality.Here products are
            //completely decoupled from the consumer using automobile interface. The object is injected into
            // the constructor of the AutomobileController class in reference to the interface automobile. 
            // The constructor where the object gets injected is called injection constructor.
        }
    }
}
