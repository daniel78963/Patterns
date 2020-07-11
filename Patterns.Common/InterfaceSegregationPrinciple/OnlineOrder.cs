using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Common.InterfaceSegregationPrinciple
{
    public class OnlineOrder : IOrder, IPayment
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }

        public void ProcessPayment()
        {
            //process through credit card
        }
    }
}
