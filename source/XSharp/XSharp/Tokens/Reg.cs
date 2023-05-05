using Spruce.Attribs;
using Spruce.Tokens;

#if ARM
using Register = XSharp.ARM.Register;
#else
using Register = XSharp.x86.Register;
#endif

namespace XSharp.Tokens {
    [GroupToken(typeof(Reg08), typeof(Reg16), typeof(Reg32))]
    public class Reg : AlphaNumList {
        protected Reg(string aText) : this(new[] { aText }) { }
        protected Reg(string[] aList) : base(aList) { }

        protected override object Transform(string aText) {
            return new Register(aText);
        }
    }

    public class Reg08 : Reg {
        public Reg08() : base(Register.Names.Reg08) { }
    }

    public class Reg16 : Reg {
        public Reg16() : base(Register.Names.Reg16) { }
    }

    public class Reg32 : Reg {
        public Reg32() : base(Register.Names.Reg32) { }
    }
}
