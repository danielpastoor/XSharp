﻿#if ARM
using XSharp.Assembler.ARM.SSE;
#else
using XSharp.Assembler.x86.SSE;
#endif

namespace XSharp
{
  partial class XS
  {
    public static class SSE3
    {
      public static void MoveDoubleAndDuplicate(XSRegisters.RegisterXMM destination, XSRegisters.Register32 source, bool sourceIsIndirect = false)
      {
        new MoveDoubleAndDuplicate()
        {
          DestinationReg = destination,
          SourceReg = source,
          SourceIsIndirect = sourceIsIndirect
        };
      }

    }
  }
}
