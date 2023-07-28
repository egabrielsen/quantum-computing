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
    operation Hadamard(count: Int) : (Int, Int) {
        mutable totalOnes = 0;

        use q = Qubit();

        for test in 1..count {
            SetQubitState(Zero, q);
            
            H(q);

            let result = M(q);

            if (result == One) {
                set totalOnes += 1;
            }
        }

       

        Message($"0: {count - totalOnes}");
        Message($"1: {totalOnes}");
        return (count - totalOnes, totalOnes );
    }
}
