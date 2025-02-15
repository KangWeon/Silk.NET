// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.WGL.Extensions.EXT
{
    public static class ExtPixelFormatOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] Span<int> piFormats, [Flow(FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] int* piAttributes, [Flow(FlowDirection.Out)] Span<int> piValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, out piValues.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] Span<int> piAttributes, [Flow(FlowDirection.Out)] int* piValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, out piAttributes.GetPinnableReference(), piValues);
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] Span<int> piAttributes, [Flow(FlowDirection.Out)] Span<int> piValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, out piAttributes.GetPinnableReference(), out piValues.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] int* piAttributes, [Flow(FlowDirection.Out)] Span<float> pfValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, out pfValues.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] Span<int> piAttributes, [Flow(FlowDirection.Out)] float* pfValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, out piAttributes.GetPinnableReference(), pfValues);
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ExtPixelFormat thisApi, [Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] Span<int> piAttributes, [Flow(FlowDirection.Out)] Span<float> pfValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, out piAttributes.GetPinnableReference(), out pfValues.GetPinnableReference());
        }

    }
}

