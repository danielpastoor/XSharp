namespace XSharp.Assembler.ARM
{
    [XSharp.Assembler.OpCode("pop")]
	public class Pop: InstructionWithDestinationAndSize{
        public Pop() : base("pop")
        {
        }
	}

}