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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrLoaderInitOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result InitializeLoader(this KhrLoaderInit thisApi, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<LoaderInitInfoBaseHeaderKHR> loaderInitInfo)
        {
            // SpanOverloader
            return thisApi.InitializeLoader(in loaderInitInfo.GetPinnableReference());
        }

    }
}

