﻿namespace XSharp.Assembler.ARM
{
    /// <summary>
    /// Subtracts the source operand from the destination operand and 
    /// replaces the destination operand with the result. 
    /// </summary>
    [XSharp.Assembler.OpCode("sbb")]
	public class SubWithCarry : InstructionWithDestinationAndSourceAndSize
	{
}
}
