
namespace Patterns.Common.InterfaceSegregationPrinciple.Bad
{
    using System;

    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }

        public void ProcessPayment()
        {
            //Not required for Cash/ offline Order
            throw new NotImplementedException();
        }
    }
}
