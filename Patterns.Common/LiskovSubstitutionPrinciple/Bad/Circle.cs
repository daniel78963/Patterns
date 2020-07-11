
namespace Patterns.Common.LiskovSubstitutionPrinciple.Bad
{
    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
