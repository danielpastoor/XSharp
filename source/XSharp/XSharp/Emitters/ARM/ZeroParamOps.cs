using Spruce.Attribs;
using XSharp.ARM;
using XSharp.Tokens;

namespace XSharp.Emitters.ARM {
    /// <summary>
    /// Operations without any parameters
    /// </summary>
    /// <seealso cref="Emitters" />
    public class ZeroParamOps : Emitters {
        public ZeroParamOps(Compiler aCompiler, XSharp.ARM.Assemblers.Assembler aAsm) : base(aCompiler, aAsm) {
        }

        [Emitter(typeof(NOP))]
        [Emitter(typeof(Return))]
        [Emitter(typeof(PushAll))]
        [Emitter(typeof(PopAll))]
        protected void ZeroParamOp(OpCode aOpCode) {
            if (aOpCode == OpCode.Bx_Lr && Compiler.Blocks.Current()?.Type == Compiler.BlockType.If) {
                Asm.Emit(OpCode.B, Compiler.CurrentFunctionExitLabel);
                return;
            }

            Asm.Emit(aOpCode);
        }
    }
}
