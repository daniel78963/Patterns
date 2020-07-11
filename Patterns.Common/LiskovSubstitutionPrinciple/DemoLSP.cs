
namespace Patterns.Common.LiskovSubstitutionPrinciple
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DemoLSP
    {
        public DemoLSP()
        {
            Shape shape = new Circle();
            Console.WriteLine(shape.GetShape());
            shape = new Triangle();
            Console.WriteLine(shape.GetShape());
        }
    }
}
