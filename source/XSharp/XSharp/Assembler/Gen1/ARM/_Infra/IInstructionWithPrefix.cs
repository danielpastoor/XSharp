using System;

namespace XSharp.Assembler.ARM
{
    [Flags]
    public enum InstructionPrefixes {
        None,
        Lock,
        Repeat,
        RepeatTillEqual
    }

    public interface IInstructionWithPrefix {
        InstructionPrefixes Prefixes {
            get;
            set;
        }
    }
}
