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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVisibilityMaskKHR")]
    public unsafe partial struct VisibilityMaskKHR
    {
        public VisibilityMaskKHR
        (
            StructureType? type = StructureType.TypeVisibilityMaskKhr,
            void* next = null,
            uint? vertexCapacityInput = null,
            uint? vertexCountOutput = null,
            Vector2f* vertices = null,
            uint? indexCapacityInput = null,
            uint? indexCountOutput = null,
            uint* indices = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (vertexCapacityInput is not null)
            {
                VertexCapacityInput = vertexCapacityInput.Value;
            }

            if (vertexCountOutput is not null)
            {
                VertexCountOutput = vertexCountOutput.Value;
            }

            if (vertices is not null)
            {
                Vertices = vertices;
            }

            if (indexCapacityInput is not null)
            {
                IndexCapacityInput = indexCapacityInput.Value;
            }

            if (indexCountOutput is not null)
            {
                IndexCountOutput = indexCountOutput.Value;
            }

            if (indices is not null)
            {
                Indices = indices;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCapacityInput")]
        public uint VertexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCountOutput")]
        public uint VertexCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrVector2f*")]
        [NativeName("Type.Name", "XrVector2f")]
        [NativeName("Name", "vertices")]
        public Vector2f* Vertices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCapacityInput")]
        public uint IndexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCountOutput")]
        public uint IndexCountOutput;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indices")]
        public uint* Indices;
    }
}
