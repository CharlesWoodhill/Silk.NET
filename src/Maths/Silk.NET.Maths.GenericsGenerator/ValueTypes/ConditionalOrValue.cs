﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public sealed class ConditionalOrValue : BinaryOperatorValue
    {
        public override Type Type => Type.Boolean;

        protected override object Process(object left, object right)
        {
            if (Type == Type.Boolean)
                return (bool) left || (bool) right;

            throw new ArgumentException("Cannot or non-bool values");
        }

        protected override string OpStr => "||";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.LogicalOrExpression;
        public override void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine("BEGIN CONDITIONAL OR");

            indentation++;
            Right.DebugWrite(writer, indentation);
            Left.DebugWrite(writer, indentation);
        }
    }
}