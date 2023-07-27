namespace qsharp {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Math;

    operation SetQubitState(desired : Result, target : Qubit) : Unit {
        if desired != M(target) {
            X(target);
        }
    }

    @EntryPoint()
    operation TestQuantumTransportation(count : Int) : (Int, Int) {
        mutable totalOnes = 0;

        // allocate the qubits
        use (q1, q2, q3) = (Qubit(), Qubit(), Qubit());   
        for test in 1..count {
            SetQubitState(One, q1);
            SetQubitState(Zero, q2);
            SetQubitState(Zero, q3);

            // Place q1 in superposition
            H(q1);

            // create bell state
            H(q2);
            CNOT(q2, q3);

            // Entangle message qbit
            CNOT(q1, q2);
            H(q1);

            // Measure message and ebit
            let message = M(q1);
            let ebit = M(q2);
            
            // conditionally perform gates for receiver
            if (message == One) {
                Z(q3);
            }
            if (ebit == One) {
                X(q3);
            }
            
            // Gather results
            let result = M(q3);
            if (result == One) {
                set totalOnes += 1;
            }
        }
    
        // reset the qubits
        SetQubitState(Zero, q1);             
        SetQubitState(Zero, q2);
        SetQubitState(Zero, q3); 
        
    
        // Display the times that |0> is returned, and times that |1> is returned when measuring the qbit result
        Message($"0: {count - totalOnes}");
        Message($"1: {totalOnes}");
        return (count - totalOnes, totalOnes );

    }
}