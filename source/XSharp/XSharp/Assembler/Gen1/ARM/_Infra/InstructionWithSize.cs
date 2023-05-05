namespace XSharp.Assembler.ARM
{
    public abstract class InstructionWithSize: Instruction, IInstructionWithSize {
        protected InstructionWithSize() {
            
        }

        public byte Size {
            get;
            set;
        }
    }
}
