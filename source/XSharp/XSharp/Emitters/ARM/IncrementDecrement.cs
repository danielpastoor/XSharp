using System;
using Spruce.Attribs;
using XSharp.Assembler.ARM;
using XSharp.Tokens;
using XSharp.ARM;

namespace XSharp.Emitters.ARM {
    /// <summary>
    /// Class that performs increment and decrement assmebly operations
    /// </summary>
    /// <seealso cref="Emitters" />
    public class IncrementDecrement : Emitters {
        public IncrementDecrement(Compiler aCompiler, XSharp.ARM.Assemblers.Assembler aAsm) : base(aCompiler, aAsm) {
        }

        /// <summary>
        /// Increments the decrement register.
        /// </summary>
        [Emitter(typeof(Reg), typeof(OpIncDec))]
        protected void IncrementDecrementRegister(Register aRegister, string aOpIncrementDecrement) {
            switch (aOpIncrementDecrement) {
                case "++":
                    Asm.Emit(OpCode.Add1, aRegister);
                    break;

                case "--":
                    Asm.Emit(OpCode.Sub1, aRegister);
                    break;

                default:
                    throw new Exception("Unsupported increment decrement operator");
            }
        }
    }
}
