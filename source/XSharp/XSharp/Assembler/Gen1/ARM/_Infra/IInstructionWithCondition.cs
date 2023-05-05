namespace XSharp.Assembler.ARM
{
    public interface IInstructionWithCondition {
        ConditionalTestEnum Condition {
            get;
            set;
        }
    }
}
