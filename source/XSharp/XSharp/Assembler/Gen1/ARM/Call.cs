namespace XSharp.Assembler.ARM
{
    [XSharp.Assembler.OpCode("Call")]
	public class Call: JumpBase {
        public Call():base("Call") {
            mNear = false;
        }
	}
}
