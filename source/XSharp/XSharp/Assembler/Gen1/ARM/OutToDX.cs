namespace XSharp.Assembler.ARM
{
    [XSharp.Assembler.OpCode("out")]
    public class OutToDX : InstructionWithDestinationAndSize {
        public override void WriteText( XSharp.Assembler.Assembler aAssembler, System.IO.TextWriter aOutput )
        {
            aOutput.Write(mMnemonic);
            aOutput.Write(" DX, ");
            aOutput.Write(this.GetDestinationAsString());
        }
	}
}
