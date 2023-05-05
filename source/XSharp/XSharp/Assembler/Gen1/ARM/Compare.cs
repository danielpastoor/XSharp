namespace XSharp.Assembler.ARM
{
    [XSharp.Assembler.OpCode("cmp")]
	public class Compare: InstructionWithDestinationAndSourceAndSize {
        public Compare() : base("cmp")
        {
        }
	}
}