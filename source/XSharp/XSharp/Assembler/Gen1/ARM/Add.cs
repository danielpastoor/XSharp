namespace XSharp.Assembler.ARM
{
    [XSharp.Assembler.OpCode("add")]
	public class Add: InstructionWithDestinationAndSourceAndSize {
        public Add() : base("add")
        {
        }
	}
}
