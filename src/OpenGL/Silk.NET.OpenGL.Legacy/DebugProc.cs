// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.OpenGL.Legacy
{
    public delegate void DebugProc(GLEnum source, GLEnum type, int id, GLEnum severity, int length, nint message, nint userParam);
}
