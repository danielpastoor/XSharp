﻿using System;

#if ARM
using XSharp.Assembler.ARM.SSE;
#else
using XSharp.Assembler.x86.SSE;
#endif

using static XSharp.XSRegisters;

namespace XSharp
{
  partial class XS
  {
    public static class SSE2
    {
      public static void AddSD(RegisterXMM destination, RegisterXMM source)
      {
        DoDestinationSource<AddSD>(destination, source);
      }

      public static void DivSD(RegisterXMM destination, RegisterXMM source)
      {
        new DivSD
        {
          DestinationReg = destination,
          SourceReg = source
        };
      }

      public static void MulSD(RegisterXMM destination, RegisterXMM source)
      {
        DoDestinationSource<MulSD>(destination, source);
      }

      public static void SubSD(RegisterXMM destination, RegisterXMM source)
      {
        DoDestinationSource<SubSD>(destination, source);
      }

      public static void CompareSD(RegisterXMM destination, RegisterXMM source, ComparePseudoOpcodes comparision)
      {
        new CompareSD()
        {
          DestinationReg = destination,
          SourceReg = source,
          pseudoOpcode = (byte)comparision
        };
      }

      public static void ConvertSD2SIAndTruncate(Register32 destination, RegisterXMM source)
      {
        new ConvertSD2SIAndTruncate
        {
          DestinationReg = destination,
          SourceReg = source
        };
      }

      public static void ConvertSS2SD(RegisterXMM destination, Register32 source, bool sourceIsIndirect = false)
      {
        new ConvertSS2SD()
        {
          DestinationReg = destination,
          SourceReg = source,
          SourceIsIndirect = sourceIsIndirect
        };
      }

      public static void ConvertSD2SS(RegisterXMM destination, Register32 source, bool sourceIsIndirect = false)
      {
        new ConvertSD2SS()
        {
          DestinationReg = destination,
          SourceReg = source,
          SourceIsIndirect = sourceIsIndirect
        };
      }

      public static void ConvertSI2SD(RegisterXMM destination, Register32 source, bool sourceIsIndirect = false, int? sourceDisplacement = null, bool destinationIsIndirect = false, int? destinationDisplacement = null)
      {
        new ConvertSI2SD()
        {
          DestinationReg = destination,
          DestinationIsIndirect = destinationIsIndirect,
          DestinationDisplacement = destinationDisplacement,
          SourceReg = source,
          SourceIsIndirect = sourceIsIndirect,
          SourceDisplacement = sourceDisplacement
        };
      }

      public static void MoveSD(RegisterXMM destination, RegisterXMM source)
      {
        DoDestinationSource<MoveSD>(destination, source);
      }

      public static void MoveSD(RegisterXMM destination, Register32 source, bool sourceIsIndirect = false)
      {
        new MoveSD()
        {
          DestinationReg = destination,
          SourceReg = source,
          SourceIsIndirect = sourceIsIndirect
        };
      }

      public static void MoveSD(Register32 destination, RegisterXMM source, bool destinationIsIndirect = false)
      {
        new MoveSD()
        {
          DestinationReg = destination,
          DestinationIsIndirect = destinationIsIndirect,
          SourceReg = source
        };
      }

      public static void XorPD(RegisterXMM destination, RegisterXMM source, bool destinationIsIndirect = false, int? destinationDisplacement = null, bool sourceIsIndirect = false, int? sourceDisplacement = null)
      {
        DoDestinationSource<XorPD>(destination, source, destinationIsIndirect, destinationDisplacement, sourceIsIndirect, sourceDisplacement);
      }

      public static void XorPD(RegisterXMM destination, String sourceLabel, bool destinationIsIndirect = false, int? destinationDisplacement = null, bool sourceIsIndirect = false, int? sourceDisplacement = null)
      {
        DoDestinationSource<XorPD>(destination, sourceLabel, destinationIsIndirect, destinationDisplacement, sourceIsIndirect, sourceDisplacement);
      }
    }
  }
}
