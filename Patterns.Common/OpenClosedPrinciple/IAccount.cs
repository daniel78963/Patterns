
namespace Patterns.Common.OpenClosedPrinciple
{
    interface IAccount
    {
        // members and function declaration, properties
        decimal Balance { get; set; }
        decimal CalcInterest();
    }
}
