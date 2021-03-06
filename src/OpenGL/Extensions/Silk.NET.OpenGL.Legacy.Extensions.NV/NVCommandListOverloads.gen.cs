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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVCommandListOverloads
    {
        public static unsafe void CreateCommandLists(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> lists)
        {
            // SpanOverloader
            thisApi.CreateCommandLists(n, out lists.GetPinnableReference());
        }

        public static unsafe void CreateStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> states)
        {
            // SpanOverloader
            thisApi.CreateStates(n, out states.GetPinnableReference());
        }

        public static unsafe void DeleteCommandLists(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> lists)
        {
            // SpanOverloader
            thisApi.DeleteCommandLists(n, in lists.GetPinnableReference());
        }

        public static unsafe void DeleteStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states)
        {
            // SpanOverloader
            thisApi.DeleteStates(n, in states.GetPinnableReference());
        }

        public static unsafe void DrawCommands(this NVCommandList thisApi, [Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommands(primitiveMode, buffer, indirects, in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommands(this NVCommandList thisApi, [Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommands(primitiveMode, buffer, in indirects.GetPinnableReference(), sizes, count);
        }

        public static unsafe void DrawCommands(this NVCommandList thisApi, [Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommands(primitiveMode, buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsAddress(primitiveMode, indirects, in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsAddress(primitiveMode, in indirects.GetPinnableReference(), sizes, count);
        }

        public static unsafe void DrawCommandsAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsAddress(primitiveMode, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, states, fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, states, fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

    }
}

