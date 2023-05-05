namespace XSharp.Assembler.ARM
{
    [OpCode("mov")]
    public class Mov : InstructionWithDestinationAndSourceAndSize
    {
        public Mov() : base("mov")
        {
        }
    }
}
