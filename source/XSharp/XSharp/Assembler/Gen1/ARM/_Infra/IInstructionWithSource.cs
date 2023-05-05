namespace XSharp.Assembler.ARM
{
    public interface IInstructionWithSource {
        XSharp.Assembler.ElementReference SourceRef {
            get;
            set;
        }

        RegistersEnum? SourceReg
        {
            get;
            set;
        }

        uint? SourceValue
        {
            get;
            set;
        }

        bool SourceIsIndirect {
            get;
            set;
        }

        int? SourceDisplacement {
            get;
            set;
        }
        bool SourceEmpty
        {
            get;
            set;
        }
    }
}
