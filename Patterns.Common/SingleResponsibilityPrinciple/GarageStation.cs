using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Common.SingleResponsibilityPrinciple
{
    public class GarageStation
    {
        public void DoOpenGate()
        {
            //Open the gate functinality
        }

        public void PerformService(Vehicle vehicle)
        {
            //Check if garage is opened
            //finish the vehicle service
        }

        public void DoCloseGate()
        {
            //Close the gate functinality
        }
    }
}
