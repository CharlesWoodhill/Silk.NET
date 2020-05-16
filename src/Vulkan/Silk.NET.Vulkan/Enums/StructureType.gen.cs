// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum StructureType
    {
        ApplicationInfo = 0,
        InstanceCreateInfo = 1,
        DeviceQueueCreateInfo = 2,
        DeviceCreateInfo = 3,
        SubmitInfo = 4,
        MemoryAllocateInfo = 5,
        MappedMemoryRange = 6,
        BindSparseInfo = 7,
        FenceCreateInfo = 8,
        SemaphoreCreateInfo = 9,
        EventCreateInfo = 10,
        QueryPoolCreateInfo = 11,
        BufferCreateInfo = 12,
        BufferViewCreateInfo = 13,
        ImageCreateInfo = 14,
        ImageViewCreateInfo = 15,
        ShaderModuleCreateInfo = 16,
        PipelineCacheCreateInfo = 17,
        PipelineShaderStageCreateInfo = 18,
        PipelineVertexInputStateCreateInfo = 19,
        PipelineInputAssemblyStateCreateInfo = 20,
        PipelineTessellationStateCreateInfo = 21,
        PipelineViewportStateCreateInfo = 22,
        PipelineRasterizationStateCreateInfo = 23,
        PipelineMultisampleStateCreateInfo = 24,
        PipelineDepthStencilStateCreateInfo = 25,
        PipelineColorBlendStateCreateInfo = 26,
        PipelineDynamicStateCreateInfo = 27,
        GraphicsPipelineCreateInfo = 28,
        ComputePipelineCreateInfo = 29,
        PipelineLayoutCreateInfo = 30,
        SamplerCreateInfo = 31,
        DescriptorSetLayoutCreateInfo = 32,
        DescriptorPoolCreateInfo = 33,
        DescriptorSetAllocateInfo = 34,
        WriteDescriptorSet = 35,
        CopyDescriptorSet = 36,
        FramebufferCreateInfo = 37,
        RenderPassCreateInfo = 38,
        CommandPoolCreateInfo = 39,
        CommandBufferAllocateInfo = 40,
        CommandBufferInheritanceInfo = 41,
        CommandBufferBeginInfo = 42,
        RenderPassBeginInfo = 43,
        BufferMemoryBarrier = 44,
        ImageMemoryBarrier = 45,
        MemoryBarrier = 46,
        LoaderInstanceCreateInfo = 47,
        LoaderDeviceCreateInfo = 48,
        SwapchainCreateInfoKhr = 1000001000,
        PresentInfoKhr = 1000001001,
        DeviceGroupPresentCapabilitiesKhr = 1000060007,
        ImageSwapchainCreateInfoKhr = 1000060008,
        BindImageMemorySwapchainInfoKhr = 1000060009,
        AcquireNextImageInfoKhr = 1000060010,
        DeviceGroupPresentInfoKhr = 1000060011,
        DeviceGroupSwapchainCreateInfoKhr = 1000060012,
        DisplayModeCreateInfoKhr = 1000002000,
        DisplaySurfaceCreateInfoKhr = 1000002001,
        DisplayPresentInfoKhr = 1000003000,
        XlibSurfaceCreateInfoKhr = 1000004000,
        XcbSurfaceCreateInfoKhr = 1000005000,
        WaylandSurfaceCreateInfoKhr = 1000006000,
        AndroidSurfaceCreateInfoKhr = 1000008000,
        Win32SurfaceCreateInfoKhr = 1000009000,
        NativeBufferAndroid = 1000010000,
        SwapchainImageCreateInfoAndroid = 1000010001,
        PhysicalDevicePresentationPropertiesAndroid = 1000010002,
        DebugReportCallbackCreateInfoExt = 1000011000,
        DebugReportCreateInfoExt = 1000011000,
        PipelineRasterizationStateRasterizationOrderAmd = 1000018000,
        DebugMarkerObjectNameInfoExt = 1000022000,
        DebugMarkerObjectTagInfoExt = 1000022001,
        DebugMarkerMarkerInfoExt = 1000022002,
        DedicatedAllocationImageCreateInfoNV = 1000026000,
        DedicatedAllocationBufferCreateInfoNV = 1000026001,
        DedicatedAllocationMemoryAllocateInfoNV = 1000026002,
        PhysicalDeviceTransformFeedbackFeaturesExt = 1000028000,
        PhysicalDeviceTransformFeedbackPropertiesExt = 1000028001,
        PipelineRasterizationStateStreamCreateInfoExt = 1000028002,
        ImageViewHandleInfoNvx = 1000030000,
        ImageViewAddressPropertiesNvx = 1000030001,
        TextureLodGatherFormatPropertiesAmd = 1000041000,
        StreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,
        RenderPassMultiviewCreateInfoKhr = 1000053000,
        PhysicalDeviceMultiviewFeaturesKhr = 1000053001,
        PhysicalDeviceMultiviewPropertiesKhr = 1000053002,
        ExternalMemoryImageCreateInfoNV = 1000056000,
        ExportMemoryAllocateInfoNV = 1000056001,
        ImportMemoryWin32HandleInfoNV = 1000057000,
        ExportMemoryWin32HandleInfoNV = 1000057001,
        Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
        PhysicalDeviceFeatures2Khr = 1000059000,
        PhysicalDeviceProperties2Khr = 1000059001,
        FormatProperties2Khr = 1000059002,
        ImageFormatProperties2Khr = 1000059003,
        PhysicalDeviceImageFormatInfo2Khr = 1000059004,
        QueueFamilyProperties2Khr = 1000059005,
        PhysicalDeviceMemoryProperties2Khr = 1000059006,
        SparseImageFormatProperties2Khr = 1000059007,
        PhysicalDeviceSparseImageFormatInfo2Khr = 1000059008,
        MemoryAllocateFlagsInfoKhr = 1000060000,
        DeviceGroupRenderPassBeginInfoKhr = 1000060003,
        DeviceGroupCommandBufferBeginInfoKhr = 1000060004,
        DeviceGroupSubmitInfoKhr = 1000060005,
        DeviceGroupBindSparseInfoKhr = 1000060006,
        BindBufferMemoryDeviceGroupInfoKhr = 1000060013,
        BindImageMemoryDeviceGroupInfoKhr = 1000060014,
        ValidationFlagsExt = 1000061000,
        VISurfaceCreateInfoNN = 1000062000,
        PhysicalDeviceTextureCompressionAstcHdrFeaturesExt = 1000066000,
        ImageViewAstcDecodeModeExt = 1000067000,
        PhysicalDeviceAstcDecodeFeaturesExt = 1000067001,
        PhysicalDeviceGroupPropertiesKhr = 1000070000,
        DeviceGroupDeviceCreateInfoKhr = 1000070001,
        PhysicalDeviceExternalImageFormatInfoKhr = 1000071000,
        ExternalImageFormatPropertiesKhr = 1000071001,
        PhysicalDeviceExternalBufferInfoKhr = 1000071002,
        ExternalBufferPropertiesKhr = 1000071003,
        PhysicalDeviceIDPropertiesKhr = 1000071004,
        ExternalMemoryBufferCreateInfoKhr = 1000072000,
        ExternalMemoryImageCreateInfoKhr = 1000072001,
        ExportMemoryAllocateInfoKhr = 1000072002,
        ImportMemoryWin32HandleInfoKhr = 1000073000,
        ExportMemoryWin32HandleInfoKhr = 1000073001,
        MemoryWin32HandlePropertiesKhr = 1000073002,
        MemoryGetWin32HandleInfoKhr = 1000073003,
        ImportMemoryFDInfoKhr = 1000074000,
        MemoryFDPropertiesKhr = 1000074001,
        MemoryGetFDInfoKhr = 1000074002,
        Win32KeyedMutexAcquireReleaseInfoKhr = 1000075000,
        PhysicalDeviceExternalSemaphoreInfoKhr = 1000076000,
        ExternalSemaphorePropertiesKhr = 1000076001,
        ExportSemaphoreCreateInfoKhr = 1000077000,
        ImportSemaphoreWin32HandleInfoKhr = 1000078000,
        ExportSemaphoreWin32HandleInfoKhr = 1000078001,
        D3D12FenceSubmitInfoKhr = 1000078002,
        SemaphoreGetWin32HandleInfoKhr = 1000078003,
        ImportSemaphoreFDInfoKhr = 1000079000,
        SemaphoreGetFDInfoKhr = 1000079001,
        PhysicalDevicePushDescriptorPropertiesKhr = 1000080000,
        CommandBufferInheritanceConditionalRenderingInfoExt = 1000081000,
        PhysicalDeviceConditionalRenderingFeaturesExt = 1000081001,
        ConditionalRenderingBeginInfoExt = 1000081002,
        PhysicalDeviceShaderFloat16Int8FeaturesKhr = 1000082000,
        PhysicalDeviceFloat16Int8FeaturesKhr = 1000082000,
        PhysicalDevice16BitStorageFeaturesKhr = 1000083000,
        PresentRegionsKhr = 1000084000,
        DescriptorUpdateTemplateCreateInfoKhr = 1000085000,
        PipelineViewportWScalingStateCreateInfoNV = 1000087000,
        SurfaceCapabilities2Ext = 1000090000,
        DisplayPowerInfoExt = 1000091000,
        DeviceEventInfoExt = 1000091001,
        DisplayEventInfoExt = 1000091002,
        SwapchainCounterCreateInfoExt = 1000091003,
        PresentTimesInfoGoogle = 1000092000,
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
        PipelineViewportSwizzleStateCreateInfoNV = 1000098000,
        PhysicalDeviceDiscardRectanglePropertiesExt = 1000099000,
        PipelineDiscardRectangleStateCreateInfoExt = 1000099001,
        PhysicalDeviceConservativeRasterizationPropertiesExt = 1000101000,
        PipelineRasterizationConservativeStateCreateInfoExt = 1000101001,
        PhysicalDeviceDepthClipEnableFeaturesExt = 1000102000,
        PipelineRasterizationDepthClipStateCreateInfoExt = 1000102001,
        HdrMetadataExt = 1000105000,
        PhysicalDeviceImagelessFramebufferFeaturesKhr = 1000108000,
        FramebufferAttachmentsCreateInfoKhr = 1000108001,
        FramebufferAttachmentImageInfoKhr = 1000108002,
        RenderPassAttachmentBeginInfoKhr = 1000108003,
        AttachmentDescription2Khr = 1000109000,
        AttachmentReference2Khr = 1000109001,
        SubpassDescription2Khr = 1000109002,
        SubpassDependency2Khr = 1000109003,
        RenderPassCreateInfo2Khr = 1000109004,
        SubpassBeginInfoKhr = 1000109005,
        SubpassEndInfoKhr = 1000109006,
        SharedPresentSurfaceCapabilitiesKhr = 1000111000,
        PhysicalDeviceExternalFenceInfoKhr = 1000112000,
        ExternalFencePropertiesKhr = 1000112001,
        ExportFenceCreateInfoKhr = 1000113000,
        ImportFenceWin32HandleInfoKhr = 1000114000,
        ExportFenceWin32HandleInfoKhr = 1000114001,
        FenceGetWin32HandleInfoKhr = 1000114002,
        ImportFenceFDInfoKhr = 1000115000,
        FenceGetFDInfoKhr = 1000115001,
        PhysicalDevicePerformanceQueryFeaturesKhr = 1000116000,
        PhysicalDevicePerformanceQueryPropertiesKhr = 1000116001,
        QueryPoolPerformanceCreateInfoKhr = 1000116002,
        PerformanceQuerySubmitInfoKhr = 1000116003,
        AcquireProfilingLockInfoKhr = 1000116004,
        PerformanceCounterKhr = 1000116005,
        PerformanceCounterDescriptionKhr = 1000116006,
        PhysicalDevicePointClippingPropertiesKhr = 1000117000,
        RenderPassInputAttachmentAspectCreateInfoKhr = 1000117001,
        ImageViewUsageCreateInfoKhr = 1000117002,
        PipelineTessellationDomainOriginStateCreateInfoKhr = 1000117003,
        PhysicalDeviceSurfaceInfo2Khr = 1000119000,
        SurfaceCapabilities2Khr = 1000119001,
        SurfaceFormat2Khr = 1000119002,
        PhysicalDeviceVariablePointersFeaturesKhr = 1000120000,
        PhysicalDeviceVariablePointerFeaturesKhr = 1000120000,
        DisplayProperties2Khr = 1000121000,
        DisplayPlaneProperties2Khr = 1000121001,
        DisplayModeProperties2Khr = 1000121002,
        DisplayPlaneInfo2Khr = 1000121003,
        DisplayPlaneCapabilities2Khr = 1000121004,
        IosSurfaceCreateInfoMvk = 1000122000,
        MacosSurfaceCreateInfoMvk = 1000123000,
        MemoryDedicatedRequirementsKhr = 1000127000,
        MemoryDedicatedAllocateInfoKhr = 1000127001,
        DebugUtilsObjectNameInfoExt = 1000128000,
        DebugUtilsObjectTagInfoExt = 1000128001,
        DebugUtilsLabelExt = 1000128002,
        DebugUtilsMessengerCallbackDataExt = 1000128003,
        DebugUtilsMessengerCreateInfoExt = 1000128004,
        AndroidHardwareBufferUsageAndroid = 1000129000,
        AndroidHardwareBufferPropertiesAndroid = 1000129001,
        AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        ImportAndroidHardwareBufferInfoAndroid = 1000129003,
        MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        ExternalFormatAndroid = 1000129005,
        PhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000,
        SamplerReductionModeCreateInfoExt = 1000130001,
        PhysicalDeviceInlineUniformBlockFeaturesExt = 1000138000,
        PhysicalDeviceInlineUniformBlockPropertiesExt = 1000138001,
        WriteDescriptorSetInlineUniformBlockExt = 1000138002,
        DescriptorPoolInlineUniformBlockCreateInfoExt = 1000138003,
        SampleLocationsInfoExt = 1000143000,
        RenderPassSampleLocationsBeginInfoExt = 1000143001,
        PipelineSampleLocationsStateCreateInfoExt = 1000143002,
        PhysicalDeviceSampleLocationsPropertiesExt = 1000143003,
        MultisamplePropertiesExt = 1000143004,
        BufferMemoryRequirementsInfo2Khr = 1000146000,
        ImageMemoryRequirementsInfo2Khr = 1000146001,
        ImageSparseMemoryRequirementsInfo2Khr = 1000146002,
        MemoryRequirements2Khr = 1000146003,
        SparseImageMemoryRequirements2Khr = 1000146004,
        ImageFormatListCreateInfoKhr = 1000147000,
        PhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000,
        PhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001,
        PipelineColorBlendAdvancedStateCreateInfoExt = 1000148002,
        PipelineCoverageToColorStateCreateInfoNV = 1000149000,
        BindAccelerationStructureMemoryInfoKhr = 1000165006,
        WriteDescriptorSetAccelerationStructureKhr = 1000165007,
        AccelerationStructureBuildGeometryInfoKhr = 1000150000,
        AccelerationStructureCreateGeometryTypeInfoKhr = 1000150001,
        AccelerationStructureDeviceAddressInfoKhr = 1000150002,
        AccelerationStructureGeometryAabbsDataKhr = 1000150003,
        AccelerationStructureGeometryInstancesDataKhr = 1000150004,
        AccelerationStructureGeometryTrianglesDataKhr = 1000150005,
        AccelerationStructureGeometryKhr = 1000150006,
        AccelerationStructureMemoryRequirementsInfoKhr = 1000150008,
        AccelerationStructureVersionKhr = 1000150009,
        CopyAccelerationStructureInfoKhr = 1000150010,
        CopyAccelerationStructureToMemoryInfoKhr = 1000150011,
        CopyMemoryToAccelerationStructureInfoKhr = 1000150012,
        PhysicalDeviceRayTracingFeaturesKhr = 1000150013,
        PhysicalDeviceRayTracingPropertiesKhr = 1000150014,
        RayTracingPipelineCreateInfoKhr = 1000150015,
        RayTracingShaderGroupCreateInfoKhr = 1000150016,
        AccelerationStructureCreateInfoKhr = 1000150017,
        RayTracingPipelineInterfaceCreateInfoKhr = 1000150018,
        PipelineCoverageModulationStateCreateInfoNV = 1000152000,
        PhysicalDeviceShaderSMBuiltinsFeaturesNV = 1000154000,
        PhysicalDeviceShaderSMBuiltinsPropertiesNV = 1000154001,
        SamplerYcbcrConversionCreateInfoKhr = 1000156000,
        SamplerYcbcrConversionInfoKhr = 1000156001,
        BindImagePlaneMemoryInfoKhr = 1000156002,
        ImagePlaneMemoryRequirementsInfoKhr = 1000156003,
        PhysicalDeviceSamplerYcbcrConversionFeaturesKhr = 1000156004,
        SamplerYcbcrConversionImageFormatPropertiesKhr = 1000156005,
        BindBufferMemoryInfoKhr = 1000157000,
        BindImageMemoryInfoKhr = 1000157001,
        DrmFormatModifierPropertiesListExt = 1000158000,
        DrmFormatModifierPropertiesExt = 1000158001,
        PhysicalDeviceImageDrmFormatModifierInfoExt = 1000158002,
        ImageDrmFormatModifierListCreateInfoExt = 1000158003,
        ImageDrmFormatModifierExplicitCreateInfoExt = 1000158004,
        ImageDrmFormatModifierPropertiesExt = 1000158005,
        ValidationCacheCreateInfoExt = 1000160000,
        ShaderModuleValidationCacheCreateInfoExt = 1000160001,
        DescriptorSetLayoutBindingFlagsCreateInfoExt = 1000161000,
        PhysicalDeviceDescriptorIndexingFeaturesExt = 1000161001,
        PhysicalDeviceDescriptorIndexingPropertiesExt = 1000161002,
        DescriptorSetVariableDescriptorCountAllocateInfoExt = 1000161003,
        DescriptorSetVariableDescriptorCountLayoutSupportExt = 1000161004,
        PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,
        PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,
        PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,
        PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,
        RayTracingPipelineCreateInfoNV = 1000165000,
        AccelerationStructureCreateInfoNV = 1000165001,
        GeometryNV = 1000165003,
        GeometryTrianglesNV = 1000165004,
        GeometryAabbNV = 1000165005,
        BindAccelerationStructureMemoryInfoNV = 1000165006,
        WriteDescriptorSetAccelerationStructureNV = 1000165007,
        AccelerationStructureMemoryRequirementsInfoNV = 1000165008,
        PhysicalDeviceRayTracingPropertiesNV = 1000165009,
        RayTracingShaderGroupCreateInfoNV = 1000165011,
        AccelerationStructureInfoNV = 1000165012,
        PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,
        PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,
        PhysicalDeviceMaintenance3PropertiesKhr = 1000168000,
        DescriptorSetLayoutSupportKhr = 1000168001,
        PhysicalDeviceImageViewImageFormatInfoExt = 1000170000,
        FilterCubicImageViewImageFormatPropertiesExt = 1000170001,
        DeviceQueueGlobalPriorityCreateInfoExt = 1000174000,
        PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKhr = 1000175000,
        PhysicalDevice8BitStorageFeaturesKhr = 1000177000,
        ImportMemoryHostPointerInfoExt = 1000178000,
        MemoryHostPointerPropertiesExt = 1000178001,
        PhysicalDeviceExternalMemoryHostPropertiesExt = 1000178002,
        PhysicalDeviceShaderAtomicInt64FeaturesKhr = 1000180000,
        PhysicalDeviceShaderClockFeaturesKhr = 1000181000,
        PipelineCompilerControlCreateInfoAmd = 1000183000,
        CalibratedTimestampInfoExt = 1000184000,
        PhysicalDeviceShaderCorePropertiesAmd = 1000185000,
        DeviceMemoryOverallocationCreateInfoAmd = 1000189000,
        PhysicalDeviceVertexAttributeDivisorPropertiesExt = 1000190000,
        PipelineVertexInputDivisorStateCreateInfoExt = 1000190001,
        PhysicalDeviceVertexAttributeDivisorFeaturesExt = 1000190002,
        PresentFrameTokenGgp = 1000191000,
        PipelineCreationFeedbackCreateInfoExt = 1000192000,
        PhysicalDeviceDriverPropertiesKhr = 1000196000,
        PhysicalDeviceFloatControlsPropertiesKhr = 1000197000,
        PhysicalDeviceDepthStencilResolvePropertiesKhr = 1000199000,
        SubpassDescriptionDepthStencilResolveKhr = 1000199001,
        PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
        PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
        PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
        PhysicalDeviceFragmentShaderBarycentricFeaturesNV = 1000203000,
        PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
        PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
        PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
        CheckpointDataNV = 1000206000,
        QueueFamilyCheckpointPropertiesNV = 1000206001,
        PhysicalDeviceTimelineSemaphoreFeaturesKhr = 1000207000,
        PhysicalDeviceTimelineSemaphorePropertiesKhr = 1000207001,
        SemaphoreTypeCreateInfoKhr = 1000207002,
        TimelineSemaphoreSubmitInfoKhr = 1000207003,
        SemaphoreWaitInfoKhr = 1000207004,
        SemaphoreSignalInfoKhr = 1000207005,
        PhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
        QueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
        QueryPoolCreateInfoIntel = 1000210000,
        InitializePerformanceApiInfoIntel = 1000210001,
        PerformanceMarkerInfoIntel = 1000210002,
        PerformanceStreamMarkerInfoIntel = 1000210003,
        PerformanceOverrideInfoIntel = 1000210004,
        PerformanceConfigurationAcquireInfoIntel = 1000210005,
        PhysicalDeviceVulkanMemoryModelFeaturesKhr = 1000211000,
        PhysicalDevicePciBusInfoPropertiesExt = 1000212000,
        DisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
        SwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
        ImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        MetalSurfaceCreateInfoExt = 1000217000,
        PhysicalDeviceFragmentDensityMapFeaturesExt = 1000218000,
        PhysicalDeviceFragmentDensityMapPropertiesExt = 1000218001,
        RenderPassFragmentDensityMapCreateInfoExt = 1000218002,
        PhysicalDeviceScalarBlockLayoutFeaturesExt = 1000221000,
        PhysicalDeviceSubgroupSizeControlPropertiesExt = 1000225000,
        PipelineShaderStageRequiredSubgroupSizeCreateInfoExt = 1000225001,
        PhysicalDeviceSubgroupSizeControlFeaturesExt = 1000225002,
        PhysicalDeviceShaderCoreProperties2Amd = 1000227000,
        PhysicalDeviceCoherentMemoryFeaturesAmd = 1000229000,
        PhysicalDeviceMemoryBudgetPropertiesExt = 1000237000,
        PhysicalDeviceMemoryPriorityFeaturesExt = 1000238000,
        MemoryPriorityAllocateInfoExt = 1000238001,
        SurfaceProtectedCapabilitiesKhr = 1000239000,
        PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
        PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKhr = 1000241000,
        AttachmentReferenceStencilLayoutKhr = 1000241001,
        AttachmentDescriptionStencilLayoutKhr = 1000241002,
        PhysicalDeviceBufferDeviceAddressFeaturesExt = 1000244000,
        PhysicalDeviceBufferAddressFeaturesExt = 1000244000,
        BufferDeviceAddressInfoExt = 1000244001,
        BufferDeviceAddressCreateInfoExt = 1000244002,
        PhysicalDeviceToolPropertiesExt = 1000245000,
        ImageStencilUsageCreateInfoExt = 1000246000,
        ValidationFeaturesExt = 1000247000,
        PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
        CooperativeMatrixPropertiesNV = 1000249001,
        PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
        PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,
        PipelineCoverageReductionStateCreateInfoNV = 1000250001,
        FramebufferMixedSamplesCombinationNV = 1000250002,
        PhysicalDeviceFragmentShaderInterlockFeaturesExt = 1000251000,
        PhysicalDeviceYcbcrImageArraysFeaturesExt = 1000252000,
        PhysicalDeviceUniformBufferStandardLayoutFeaturesKhr = 1000253000,
        SurfaceFullScreenExclusiveInfoExt = 1000255000,
        SurfaceCapabilitiesFullScreenExclusiveExt = 1000255002,
        SurfaceFullScreenExclusiveWin32InfoExt = 1000255001,
        HeadlessSurfaceCreateInfoExt = 1000256000,
        PhysicalDeviceBufferDeviceAddressFeaturesKhr = 1000257000,
        BufferDeviceAddressInfoKhr = 1000244001,
        BufferOpaqueCaptureAddressCreateInfoKhr = 1000257002,
        MemoryOpaqueCaptureAddressAllocateInfoKhr = 1000257003,
        DeviceMemoryOpaqueCaptureAddressInfoKhr = 1000257004,
        PhysicalDeviceLineRasterizationFeaturesExt = 1000259000,
        PipelineRasterizationLineStateCreateInfoExt = 1000259001,
        PhysicalDeviceLineRasterizationPropertiesExt = 1000259002,
        PhysicalDeviceHostQueryResetFeaturesExt = 1000261000,
        PhysicalDeviceIndexTypeUint8FeaturesExt = 1000265000,
        DeferredOperationInfoKhr = 1000268000,
        PhysicalDevicePipelineExecutablePropertiesFeaturesKhr = 1000269000,
        PipelineInfoKhr = 1000269001,
        PipelineExecutablePropertiesKhr = 1000269002,
        PipelineExecutableInfoKhr = 1000269003,
        PipelineExecutableStatisticKhr = 1000269004,
        PipelineExecutableInternalRepresentationKhr = 1000269005,
        PhysicalDeviceShaderDemoteToHelperInvocationFeaturesExt = 1000276000,
        PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,
        GraphicsShaderGroupCreateInfoNV = 1000277001,
        GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,
        IndirectCommandsLayoutTokenNV = 1000277003,
        IndirectCommandsLayoutCreateInfoNV = 1000277004,
        GeneratedCommandsInfoNV = 1000277005,
        GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,
        PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,
        PhysicalDeviceTexelBufferAlignmentFeaturesExt = 1000281000,
        PhysicalDeviceTexelBufferAlignmentPropertiesExt = 1000281001,
        CommandBufferInheritanceRenderPassTransformInfoQCom = 1000282000,
        RenderPassTransformBeginInfoQCom = 1000282001,
        PhysicalDeviceRobustness2FeaturesExt = 1000286000,
        PhysicalDeviceRobustness2PropertiesExt = 1000286001,
        SamplerCustomBorderColorCreateInfoExt = 1000287000,
        PhysicalDeviceCustomBorderColorPropertiesExt = 1000287001,
        PhysicalDeviceCustomBorderColorFeaturesExt = 1000287002,
        PipelineLibraryCreateInfoKhr = 1000290000,
        PhysicalDevicePrivateDataFeaturesExt = 1000295000,
        DevicePrivateDataCreateInfoExt = 1000295001,
        PrivateDataSlotCreateInfoExt = 1000295002,
        PhysicalDevicePipelineCreationCacheControlFeaturesExt = 1000297000,
        PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,
        DeviceDiagnosticsConfigCreateInfoNV = 1000300001,
        ReservedQCom = 1000309000,
        PhysicalDeviceSubgroupProperties = 1000094000,
        BindBufferMemoryInfo = 1000157000,
        BindImageMemoryInfo = 1000157001,
        PhysicalDevice16BitStorageFeatures = 1000083000,
        MemoryDedicatedRequirements = 1000127000,
        MemoryDedicatedAllocateInfo = 1000127001,
        MemoryAllocateFlagsInfo = 1000060000,
        DeviceGroupRenderPassBeginInfo = 1000060003,
        DeviceGroupCommandBufferBeginInfo = 1000060004,
        DeviceGroupSubmitInfo = 1000060005,
        DeviceGroupBindSparseInfo = 1000060006,
        BindBufferMemoryDeviceGroupInfo = 1000060013,
        BindImageMemoryDeviceGroupInfo = 1000060014,
        PhysicalDeviceGroupProperties = 1000070000,
        DeviceGroupDeviceCreateInfo = 1000070001,
        BufferMemoryRequirementsInfo2 = 1000146000,
        ImageMemoryRequirementsInfo2 = 1000146001,
        ImageSparseMemoryRequirementsInfo2 = 1000146002,
        MemoryRequirements2 = 1000146003,
        SparseImageMemoryRequirements2 = 1000146004,
        PhysicalDeviceFeatures2 = 1000059000,
        PhysicalDeviceProperties2 = 1000059001,
        FormatProperties2 = 1000059002,
        ImageFormatProperties2 = 1000059003,
        PhysicalDeviceImageFormatInfo2 = 1000059004,
        QueueFamilyProperties2 = 1000059005,
        PhysicalDeviceMemoryProperties2 = 1000059006,
        SparseImageFormatProperties2 = 1000059007,
        PhysicalDeviceSparseImageFormatInfo2 = 1000059008,
        PhysicalDevicePointClippingProperties = 1000117000,
        RenderPassInputAttachmentAspectCreateInfo = 1000117001,
        ImageViewUsageCreateInfo = 1000117002,
        PipelineTessellationDomainOriginStateCreateInfo = 1000117003,
        RenderPassMultiviewCreateInfo = 1000053000,
        PhysicalDeviceMultiviewFeatures = 1000053001,
        PhysicalDeviceMultiviewProperties = 1000053002,
        PhysicalDeviceVariablePointersFeatures = 1000120000,
        PhysicalDeviceVariablePointerFeatures = 1000120000,
        ProtectedSubmitInfo = 1000145000,
        PhysicalDeviceProtectedMemoryFeatures = 1000145001,
        PhysicalDeviceProtectedMemoryProperties = 1000145002,
        DeviceQueueInfo2 = 1000145003,
        SamplerYcbcrConversionCreateInfo = 1000156000,
        SamplerYcbcrConversionInfo = 1000156001,
        BindImagePlaneMemoryInfo = 1000156002,
        ImagePlaneMemoryRequirementsInfo = 1000156003,
        PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
        SamplerYcbcrConversionImageFormatProperties = 1000156005,
        DescriptorUpdateTemplateCreateInfo = 1000085000,
        PhysicalDeviceExternalImageFormatInfo = 1000071000,
        ExternalImageFormatProperties = 1000071001,
        PhysicalDeviceExternalBufferInfo = 1000071002,
        ExternalBufferProperties = 1000071003,
        PhysicalDeviceIDProperties = 1000071004,
        ExternalMemoryBufferCreateInfo = 1000072000,
        ExternalMemoryImageCreateInfo = 1000072001,
        ExportMemoryAllocateInfo = 1000072002,
        PhysicalDeviceExternalFenceInfo = 1000112000,
        ExternalFenceProperties = 1000112001,
        ExportFenceCreateInfo = 1000113000,
        ExportSemaphoreCreateInfo = 1000077000,
        PhysicalDeviceExternalSemaphoreInfo = 1000076000,
        ExternalSemaphoreProperties = 1000076001,
        PhysicalDeviceMaintenance3Properties = 1000168000,
        DescriptorSetLayoutSupport = 1000168001,
        PhysicalDeviceShaderDrawParametersFeatures = 1000063000,
        PhysicalDeviceShaderDrawParameterFeatures = 1000063000,
        PhysicalDeviceVulkan11Features = 49,
        PhysicalDeviceVulkan11Properties = 50,
        PhysicalDeviceVulkan12Features = 51,
        PhysicalDeviceVulkan12Properties = 52,
        ImageFormatListCreateInfo = 1000147000,
        AttachmentDescription2 = 1000109000,
        AttachmentReference2 = 1000109001,
        SubpassDescription2 = 1000109002,
        SubpassDependency2 = 1000109003,
        RenderPassCreateInfo2 = 1000109004,
        SubpassBeginInfo = 1000109005,
        SubpassEndInfo = 1000109006,
        PhysicalDevice8BitStorageFeatures = 1000177000,
        PhysicalDeviceDriverProperties = 1000196000,
        PhysicalDeviceShaderAtomicInt64Features = 1000180000,
        PhysicalDeviceShaderFloat16Int8Features = 1000082000,
        PhysicalDeviceFloatControlsProperties = 1000197000,
        DescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,
        PhysicalDeviceDescriptorIndexingFeatures = 1000161001,
        PhysicalDeviceDescriptorIndexingProperties = 1000161002,
        DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,
        DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,
        PhysicalDeviceDepthStencilResolveProperties = 1000199000,
        SubpassDescriptionDepthStencilResolve = 1000199001,
        PhysicalDeviceScalarBlockLayoutFeatures = 1000221000,
        ImageStencilUsageCreateInfo = 1000246000,
        PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,
        SamplerReductionModeCreateInfo = 1000130001,
        PhysicalDeviceVulkanMemoryModelFeatures = 1000211000,
        PhysicalDeviceImagelessFramebufferFeatures = 1000108000,
        FramebufferAttachmentsCreateInfo = 1000108001,
        FramebufferAttachmentImageInfo = 1000108002,
        RenderPassAttachmentBeginInfo = 1000108003,
        PhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,
        PhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,
        PhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,
        AttachmentReferenceStencilLayout = 1000241001,
        AttachmentDescriptionStencilLayout = 1000241002,
        PhysicalDeviceHostQueryResetFeatures = 1000261000,
        PhysicalDeviceTimelineSemaphoreFeatures = 1000207000,
        PhysicalDeviceTimelineSemaphoreProperties = 1000207001,
        SemaphoreTypeCreateInfo = 1000207002,
        TimelineSemaphoreSubmitInfo = 1000207003,
        SemaphoreWaitInfo = 1000207004,
        SemaphoreSignalInfo = 1000207005,
        PhysicalDeviceBufferDeviceAddressFeatures = 1000257000,
        BufferDeviceAddressInfo = 1000244001,
        BufferOpaqueCaptureAddressCreateInfo = 1000257002,
        MemoryOpaqueCaptureAddressAllocateInfo = 1000257003,
        DeviceMemoryOpaqueCaptureAddressInfo = 1000257004,
    }
}
