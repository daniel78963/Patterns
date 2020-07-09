using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Common.SingleResponsibilityPrinciple
{
    public class GarageStationSRP
    {
        IGarageUtility _garageUtil;

        public GarageStationSRP(IGarageUtility garageUtil)
        {
            this._garageUtil = garageUtil;
        }
        public void OpenForService()
        {
            _garageUtil.OpenGate();
        }
        public void DoService()
        {
            //Check if service station is opened and then
            //finish the vehicle service
        }
        public void CloseGarage()
        {
            _garageUtil.CloseGate();
        }
    }
}
