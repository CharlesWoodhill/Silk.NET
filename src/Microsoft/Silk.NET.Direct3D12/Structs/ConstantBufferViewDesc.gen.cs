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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_CONSTANT_BUFFER_VIEW_DESC")]
    public unsafe partial struct ConstantBufferViewDesc
    {
        public ConstantBufferViewDesc
        (
            ulong? bufferLocation = null,
            uint? sizeInBytes = null
        ) : this()
        {
            if (bufferLocation is not null)
            {
                BufferLocation = bufferLocation.Value;
            }

            if (sizeInBytes is not null)
            {
                SizeInBytes = sizeInBytes.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "BufferLocation")]
        public ulong BufferLocation;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SizeInBytes")]
        public uint SizeInBytes;
    }
}
