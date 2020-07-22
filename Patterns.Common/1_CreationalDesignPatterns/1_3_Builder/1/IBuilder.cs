﻿
namespace Patterns.Common._1_CreationalDesignPatterns._1_3_Builder._1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
