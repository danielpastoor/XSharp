#if ARM
using XSharp.ARM;
#else
using XSharp.x86;
#endif


namespace XSharp.Tokens {
    public class ZeroParamOp : Spruce.Tokens.AlphaNumList {
        protected OpCode mOpCode;

        protected ZeroParamOp(string aText, OpCode aOpCode) : base(aText) {
            mOpCode = aOpCode;
        }

        protected override object Transform(string aText) {
            return mOpCode;
        }
    }

    public class NOP : ZeroParamOp {
        public NOP() : base("NOP", OpCode.NOP) {
        }
    }

    public class Return : ZeroParamOp {
#if ARM

        public Return() : base("Return", OpCode.Bx_Lr) {
        }
#else

        public Return() : base("Return", OpCode.Ret) {
        }
#endif

    }

    public class PushAll : ZeroParamOp {
#if ARM
        public PushAll() : base("+All", OpCode.Add1) { // TODO Fix this | Wrong usage
        }
#else
 public PushAll() : base("+All", OpCode.PushAD) {
    }
#endif
    }

    public class PopAll : ZeroParamOp {
#if ARM
        public PopAll() : base("-All", OpCode.Pop) { // TODO Fix this | Wrong usage
        }
#else
        public PopAll() : base("-All", OpCode.PopAD) {
}
#endif


    }
}
