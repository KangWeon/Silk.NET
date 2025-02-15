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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.I3D
{
    [Extension("I3D_image_buffer")]
    public unsafe partial class I3DImageBuffer : NativeExtension<WGL>
    {
        public const string ExtensionName = "I3D_image_buffer";
        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] nint* pEvent, [Flow(FlowDirection.In)] nint* pAddress, [Flow(FlowDirection.In)] uint* pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] nint* pEvent, [Flow(FlowDirection.In)] nint* pAddress, [Flow(FlowDirection.In)] in uint pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] nint* pEvent, [Flow(FlowDirection.In)] in nint pAddress, [Flow(FlowDirection.In)] uint* pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] nint* pEvent, [Flow(FlowDirection.In)] in nint pAddress, [Flow(FlowDirection.In)] in uint pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] in nint pEvent, [Flow(FlowDirection.In)] nint* pAddress, [Flow(FlowDirection.In)] uint* pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] in nint pEvent, [Flow(FlowDirection.In)] nint* pAddress, [Flow(FlowDirection.In)] in uint pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] in nint pEvent, [Flow(FlowDirection.In)] in nint pAddress, [Flow(FlowDirection.In)] uint* pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglAssociateImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] in nint pEvent, [Flow(FlowDirection.In)] in nint pAddress, [Flow(FlowDirection.In)] in uint pSize, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglCreateImageBufferI3D", Convention = CallingConvention.Winapi)]
        public partial nint CreateImageBufferI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint dwSize, [Flow(FlowDirection.In)] uint uFlags);

        [NativeApi(EntryPoint = "wglDestroyImageBufferI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DestroyImageBufferI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] nint pAddress);

        [NativeApi(EntryPoint = "wglReleaseImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ReleaseImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] nint* pAddress, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "wglReleaseImageBufferEventsI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ReleaseImageBufferEventsI3D([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] in nint pAddress, [Flow(FlowDirection.In)] uint count);

        public I3DImageBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

