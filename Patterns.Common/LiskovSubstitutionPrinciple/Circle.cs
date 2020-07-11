
namespace Patterns.Common.LiskovSubstitutionPrinciple
{
    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
