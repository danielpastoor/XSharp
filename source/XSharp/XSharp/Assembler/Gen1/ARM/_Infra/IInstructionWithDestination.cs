namespace XSharp.Assembler.ARM
{
    public interface IInstructionWithDestination {
        XSharp.Assembler.ElementReference DestinationRef {
            get;
            set;
        }

        RegistersEnum? DestinationReg
        {
            get;
            set;
        }

        uint? DestinationValue
        {
            get;
            set;
        }

        bool DestinationIsIndirect {
            get;
            set;
        }

        int? DestinationDisplacement {
            get;
            set;
        }

        bool DestinationEmpty
        {
            get;
            set;
        }
    }
}
