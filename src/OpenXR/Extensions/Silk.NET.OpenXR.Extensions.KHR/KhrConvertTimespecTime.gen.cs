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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_convert_timespec_time")]
    public unsafe partial class KhrConvertTimespecTime : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_convert_timespec_time";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public unsafe partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ValueTuple<nint,nint>* timespecTime, [Count(Count = 0)] long* time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public unsafe partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ValueTuple<nint,nint>* timespecTime, [Count(Count = 0)] ref long time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public unsafe partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ValueTuple<nint,nint> timespecTime, [Count(Count = 0)] long* time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimespecTimeToTimeKHR")]
        public partial Result ConvertTimespecTimeToTime([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ValueTuple<nint,nint> timespecTime, [Count(Count = 0)] ref long time);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR")]
        public unsafe partial Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ValueTuple<nint,nint>* timespecTime);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrConvertTimeToTimespecTimeKHR")]
        public partial Result ConvertTimeToTimespecTime([Count(Count = 0)] Instance instance, [Count(Count = 0)] long time, [Count(Count = 0)] ref ValueTuple<nint,nint> timespecTime);

        public KhrConvertTimespecTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

