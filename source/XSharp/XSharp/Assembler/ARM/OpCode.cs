namespace XSharp.ARM {
    // https://iitd-plos.github.io/col718/ref/arm-instructionset.pdf

    // http://imrannazar.com/arm-opcode-map

    // https://developer.arm.com/documentation/den0013/d/ARM-Thumb-Unified-Assembly-Language-Instructions/Instruction-set-basics/Constant-and-immediate-values

    // Please add ops in alphabetical order
    public enum OpCode {
        Add,    // Add
        And,    // And
        Cmp,    // Compare
        Sub1,   // Decrement
        Div,    // Divide
        LDR,     // In Oprator
        Add1,   // Increment
        //IRet,   // Interrupt return // TODO: This is not an ARM instruction
        Beq,     // Jump if equal
        Bhi,     // Jump if above
        Bcc,    // Jump if above or equal
        Blo,     // Jump if below
        Bls,    // Jump if below or equal
        B,    // Jump
        Bne,    // Jump if not equal
        Mov,    // Move
        Mul,    // Multiply
        NOP,    // No op
        Mvn,    // Not
        Orr,    // Or
        STR,    // Out
        Pop,    // Pop
        //PopAD,  // Pop all // TODO: This is not an ARM instruction
        Push,   // Push
        //PushAD, // Push all // TODO: This is not an ARM instruction
        //Rem,    // Remainder // TODO: This is not an ARM instruction | This is not a single ARM instruction, but you can use the SDIV or UDIV instruction to perform integer division and then use the MUL instruction to multiply the quotient by the divisor and subtract the result from the dividend to get the remainder.
        Bx_Lr,    // Return
        Ror,    // Rotate Left && // Rotate Right
        //Ror,    // Rotate Right
        Lsl,     // Logical Shift Left
        Lsr,     // Logical Shift Right
        Sub,    // Subtract
        Tst,   // Test - logical compare
    }
}
