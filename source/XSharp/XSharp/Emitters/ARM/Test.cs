using Spruce.Attribs;
using XSharp.Assembler.ARM;
using XSharp.Tokens;
using XSharp.ARM;

namespace XSharp.ARM.Emitters {
    /// <summary>
    /// TEST: Logical compare
    /// </summary>
    /// <seealso cref="Emitters" />
    public class Test : Emitters {
        public Test(Compiler aCompiler, XSharp.ARM.Assemblers.Assembler aAsm) : base(aCompiler, aAsm) {
        }

        [Emitter(typeof(Reg08), typeof(TestKeyword), typeof(Int08u))]
        [Emitter(typeof(Reg16), typeof(TestKeyword), typeof(Int16u))]
        [Emitter(typeof(Reg32), typeof(TestKeyword), typeof(Int32u))]
        protected void TestRegWithInt(Register aRegister, string aTestKeyword, object aValue) {
            Asm.Emit(OpCode.Tst, aRegister, aValue);
        }
    }
}
