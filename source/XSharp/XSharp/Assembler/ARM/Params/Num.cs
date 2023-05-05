using System;

namespace XSharp.ARM.Params
{
    public abstract class Num : Param {
    }

    public class i08u : Num {
        public override bool IsMatch(object aValue) {
            return aValue is byte;
        }
    }

    public class i16u : Num {
        public override bool IsMatch(object aValue) {
            return aValue is UInt16;
        }
    }

    public class i32u : Num {
        public override bool IsMatch(object aValue) {
            return aValue is UInt32;
        }
    }
}
