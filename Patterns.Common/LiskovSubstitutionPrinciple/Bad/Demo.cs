
namespace Patterns.Common.LiskovSubstitutionPrinciple.Bad
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Demo
    {
        public Demo()
        {
            Triangle triangle = new Circle();
            triangle.GetShape();
        }
    }
}
