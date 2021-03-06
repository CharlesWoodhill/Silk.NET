// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbTessellationShaderOverloads
    {
        public static unsafe void PatchParameter(this ArbTessellationShader thisApi, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.PatchParameter(pname, in values.GetPinnableReference());
        }

        public static unsafe void PatchParameter(this ArbTessellationShader thisApi, [Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.PatchParameter(pname, in values.GetPinnableReference());
        }

    }
}

