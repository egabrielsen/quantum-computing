namespace qsharp {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;

    operation SetQubitState(desired : Result, target : Qubit) : Unit {
        if desired != M(target) {
            X(target);
        }
    }
    
    @EntryPoint()
    operation SwapQubits(count: Int) : (Int, Int, Int, Int) {
        mutable state_00 = 0;
        mutable state_01 = 0;
        mutable state_10 = 0;
        mutable state_11 = 0;


        use (q0, q1) = (Qubit(), Qubit());

        for test in 1..count {
            SetQubitState(Zero, q0);
            SetQubitState(Zero, q1);
            
            // Flip state q0
            X(q0);

            // Perform Swap
            CNOT(q0, q1);
            CNOT(q1, q0);
            CNOT(q0, q1);
            

            let q0_result = M(q0);
            let q1_result = M(q1);

            if (q0_result == Zero and q1_result == Zero) {
                set state_00 += 1;
            }
            if (q0_result == Zero and q1_result == One) {
                set state_01 += 1;
            }
            if (q0_result == One and q1_result == Zero) {
                set state_10 += 1;
            }
            if (q0_result == One and q1_result == One) {
                set state_11 += 1;
            }
        }

        Message($"00: {state_00}");
        Message($"01: {state_01}");
        Message($"11: {state_10}");
        Message($"11: {state_11}");
        return (state_00, state_01, state_10, state_11);
    }
}
