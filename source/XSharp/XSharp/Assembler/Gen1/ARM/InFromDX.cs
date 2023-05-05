namespace XSharp.Assembler.ARM
{
    [XSharp.Assembler.OpCode("in")]
    public class InFromDX : InstructionWithDestinationAndSize {
        public override void WriteText( XSharp.Assembler.Assembler aAssembler, System.IO.TextWriter aOutput )
        {
            base.WriteText(aAssembler, aOutput);
            aOutput.Write(", DX");
        }
    }
}
