namespace XSharp.Assembler.ARM
{
    [XSharp.Assembler.OpCode("NOP")]
    public class Noop : Instruction
    {
    }

    [XSharp.Assembler.OpCode("NOP ; INT3")]
    public class DebugNoop : Instruction
    {
    }
}