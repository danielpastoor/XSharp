using XSharp.ARM;

namespace XSharp.ARM.Assemblers {
    public abstract class Assembler {
        public abstract void Emit(OpCode aOp, params object[] aParams);
    }
}
