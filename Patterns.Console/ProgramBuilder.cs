﻿
namespace Patterns.Console
{
    using Patterns.Common._1_CreationalDesignPatterns._1_3_Builder._1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ProgramBuilder
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());

            Console.ReadKey();

            //Output.txt: Execution result
            //Standard basic product:
            //Product parts: PartA1

            //Standard full featured product:
            //Product parts: PartA1, PartB1, PartC1

            //Custom product:
            //Product parts: PartA1, PartC1
        }
    }
}
