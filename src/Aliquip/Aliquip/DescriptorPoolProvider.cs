﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Vulkan;

namespace Aliquip
{
    internal sealed class DescriptorPoolProvider : IDescriptorPoolProvider, IDisposable
    {
        private readonly Vk _vk;
        private readonly ISwapchainProvider _swapchainProvider;
        private readonly ILogicalDeviceProvider _logicalDeviceProvider;
        public DescriptorPool DescriptorPool { get; private set; }

        public DescriptorPoolProvider(Vk vk, ISwapchainProvider swapchainProvider, ILogicalDeviceProvider logicalDeviceProvider)
        {
            _vk = vk;
            _swapchainProvider = swapchainProvider;
            _logicalDeviceProvider = logicalDeviceProvider;
            
            Recreate();
        }

        public unsafe void Recreate()
        {
            var poolSize = new DescriptorPoolSize
                (DescriptorType.UniformBuffer, (uint) _swapchainProvider.SwapchainImages.Length);
            var poolInfo = new DescriptorPoolCreateInfo
                (poolSizeCount: 1, pPoolSizes: &poolSize, maxSets: (uint) _swapchainProvider.SwapchainImages.Length);

            _vk.CreateDescriptorPool(_logicalDeviceProvider.LogicalDevice, &poolInfo, null, out var descriptorPool).ThrowCode();
            DescriptorPool = descriptorPool;
        }

        public unsafe void Dispose()
        {
            _vk.DestroyDescriptorPool(_logicalDeviceProvider.LogicalDevice, DescriptorPool, null);
        }
    }
}
