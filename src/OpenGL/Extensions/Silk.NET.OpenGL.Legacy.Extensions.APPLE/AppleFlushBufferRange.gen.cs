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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_flush_buffer_range")]
    public unsafe partial class AppleFlushBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_flush_buffer_range";
        [NativeApi(EntryPoint = "glBufferParameteriAPPLE")]
        public partial void BufferParameter([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glFlushMappedBufferRangeAPPLE")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        public AppleFlushBufferRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

