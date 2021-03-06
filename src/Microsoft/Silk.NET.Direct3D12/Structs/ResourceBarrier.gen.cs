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
    [NativeName("Name", "D3D12_RESOURCE_BARRIER")]
    public unsafe partial struct ResourceBarrier
    {
        public ResourceBarrier
        (
            ResourceBarrierType? type = null,
            ResourceBarrierFlags? flags = null,
            ResourceBarrierUnion? anonymous = null,
            ResourceTransitionBarrier? transition = null,
            ResourceAliasingBarrier? aliasing = null,
            ResourceUavBarrier? uAV = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (transition is not null)
            {
                Transition = transition.Value;
            }

            if (aliasing is not null)
            {
                Aliasing = aliasing.Value;
            }

            if (uAV is not null)
            {
                UAV = uAV.Value;
            }
        }


        [NativeName("Type", "D3D12_RESOURCE_BARRIER_TYPE")]
        [NativeName("Type.Name", "D3D12_RESOURCE_BARRIER_TYPE")]
        [NativeName("Name", "Type")]
        public ResourceBarrierType Type;

        [NativeName("Type", "D3D12_RESOURCE_BARRIER_FLAGS")]
        [NativeName("Type.Name", "D3D12_RESOURCE_BARRIER_FLAGS")]
        [NativeName("Name", "Flags")]
        public ResourceBarrierFlags Flags;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L2754_C5")]
        [NativeName("Name", "anonymous1")]
        public ResourceBarrierUnion Anonymous;
#if NETSTANDARD2_1
        public ref ResourceTransitionBarrier Transition
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Transition;
        }
#else
        public ResourceTransitionBarrier Transition
        {
            get => Anonymous.Transition;
            set => Anonymous.Transition = value;
        }
#endif

#if NETSTANDARD2_1
        public ref ResourceAliasingBarrier Aliasing
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Aliasing;
        }
#else
        public ResourceAliasingBarrier Aliasing
        {
            get => Anonymous.Aliasing;
            set => Anonymous.Aliasing = value;
        }
#endif

#if NETSTANDARD2_1
        public ref ResourceUavBarrier UAV
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.UAV;
        }
#else
        public ResourceUavBarrier UAV
        {
            get => Anonymous.UAV;
            set => Anonymous.UAV = value;
        }
#endif

    }
}
