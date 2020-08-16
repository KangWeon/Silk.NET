// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_SysWMEvent")]
    public unsafe partial struct SysWMEvent
    {
        public SysWMEvent
        (
            uint type = default,
            uint timestamp = default,
            SysWMmsg* msg = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            Msg = msg;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "SDL_SysWMmsg *")]
        [NativeName("Type.Name", "SDL_SysWMmsg *")]
        [NativeName("Name", "msg")]
        public SysWMmsg* Msg;
    }
}