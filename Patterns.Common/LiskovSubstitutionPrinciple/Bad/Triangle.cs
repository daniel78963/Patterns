
namespace Patterns.Common.LiskovSubstitutionPrinciple.Bad
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Triangle
    {
        public virtual string GetShape()
        {
            return " Triangle ";
        }
    }
}
