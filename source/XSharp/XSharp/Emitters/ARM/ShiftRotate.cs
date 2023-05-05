using System;
using Spruce.Attribs;
using XSharp.ARM;
using XSharp.Tokens;

namespace XSharp.ARM.Emitters {
    /// <summary>
    /// Class that performs shift and rotate assmebly operations
    /// </summary>
    /// <seealso cref="Emitters" />
    public class ShiftRotate : Emitters {
        public ShiftRotate(Compiler aCompiler, XSharp.ARM.Assemblers.Assembler aAsm) : base(aCompiler, aAsm) {
        }

        [Emitter(typeof(Reg), typeof(OpShift), typeof(Int08u))]
        protected void ShiftRegister(Register aRegister, string aOpShift, object aNumBits) {
            switch (aOpShift) {
                case "<<":
                    Asm.Emit(OpCode.Lsl, aRegister, aNumBits);
                    break;

                case ">>":
                    Asm.Emit(OpCode.Lsr, aRegister, aNumBits);
                    break;

                default:
                    throw new Exception("Unsupported shift operator");
            }
        }

        [Emitter(typeof(Reg), typeof(OpRotate), typeof(Int08u))]
        protected void RotateRegister(Register aRegister, object aOpRotate, object aNumBits) {
            switch (aOpRotate) {
                case "<~":
                    Asm.Emit(OpCode.Ror, aRegister, aNumBits);
                    break;

                case "~>":
                    Asm.Emit(OpCode.Ror, aRegister, aNumBits);
                    break;

                default:
                    throw new Exception("Unsupported rotate operator");
            }
        }
    }
}
