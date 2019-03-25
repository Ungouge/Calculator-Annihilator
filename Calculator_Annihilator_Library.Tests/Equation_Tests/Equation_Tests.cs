﻿using System;
using Xunit;
using Calculator_Annihilator_Library;
using Common_Library;

namespace Calculator_Annihilator_Library.Tests
{
    /// <summary>
    /// Test proper reading of text with equation by Equation class and tests does repairs of incorrectnesses
    /// are done by class according to business logic via method Recreate_Equation(). 
    /// </summary>
    public partial class Equation_Tests
    {
        private Equation _equation;

        public Equation_Tests()
        {
            _equation = null;
        }
    }
}