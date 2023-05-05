namespace XSharp.Emitters.ARM {
    public abstract class Emitters {
        protected Compiler Compiler { get; }
        protected XSharp.ARM.Assemblers.Assembler Asm { get; }

        protected Emitters(Compiler aCompiler, XSharp.ARM.Assemblers.Assembler aAsm) {
            Compiler = aCompiler;
            Asm = aAsm;
        }
    }
}
