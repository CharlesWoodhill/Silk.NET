﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis.CSharp;

namespace GenericMathsGenerator
{
    public class NegateValue : UnaryOperatorValue
    {
        protected override object Process(object f)
            => Type switch
            {
                Type.Numeric => -(float) f,
                Type.Boolean => !(bool) f,
                _ => throw new ArgumentException("cannot process unary unknown", nameof(f))
            };

        protected override string OpStr => "-";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.UnaryMinusExpression;
    }
}