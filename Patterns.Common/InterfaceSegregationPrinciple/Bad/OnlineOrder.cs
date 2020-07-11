namespace Patterns.Common.InterfaceSegregationPrinciple.Bad
{
    public class OnlineOrder : IOrder
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
