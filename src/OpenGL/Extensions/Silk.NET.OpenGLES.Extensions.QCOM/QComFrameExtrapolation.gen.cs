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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_frame_extrapolation")]
    public unsafe partial class QComFrameExtrapolation : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_frame_extrapolation";
        [NativeApi(EntryPoint = "glExtrapolateTex2DQCOM")]
        public partial void ExtrapolateTex2D([Flow(FlowDirection.In)] uint src1, [Flow(FlowDirection.In)] uint src2, [Flow(FlowDirection.In)] uint output, [Flow(FlowDirection.In)] float scaleFactor);

        public QComFrameExtrapolation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

