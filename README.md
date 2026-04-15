# quantum_computing
A collection of quantum computing circuits for learning and research purposes

Each circuit is completed using a variety of different Quantum Circuit API's and languages provided by the following for experimentation: 

- **IBM**: [Qiskit](https://www.ibm.com/quantum/qiskit)
- **Google**: [Cirq](https://quantumai.google/cirq)
- **AWS**: [Braket](https://aws.amazon.com/braket/)
- **Microsoft**: [Q-sharp](https://learn.microsoft.com/en-us/azure/quantum/qsharp-overview)

There are many other languages and api's out there for programming your own quantum circuits. Here are several more known in the field. Most are API's that are written in Python: 
- PennyLane (Xanadu)
- Ocean SDK (D-Wave)
- Strawberry Fields (Xanadu)
- QuTiP (Quantum Toolbox in Python)

## What is Quantum Computing?
Quantum computing is a type of computing that uses the principles of quantum mechanics to process information. Unlike classical computers, which use bits (0 or 1), quantum computers use qubits, which can be in a state of 0, 1, or both at the same time (called superposition).

Quantum computers also use entanglement, a phenomenon where qubits become linked and the state of one can depend on the state of another, no matter how far apart they are.

These properties allow quantum computers to solve certain problems—like factoring large numbers, simulating molecules, or optimizing complex systems—much faster than classical computers.

## Basic Gates
The following are example circuits and gates that make up the building blocks of Quantum Circuitry. Here are a few single qubit gates and 2-qubit gates that demonstrate things you can do with qubits

### [Hadamard Gate](circuits/basic/hadamard/README.md)
A Hadamard gate (often denoted as H) is one of the most fundamental quantum logic gates. It plays a key role in many quantum algorithms by creating superposition.

### Pauli-X (Not) Gate
The Pauli-X gate is one of the most basic and important quantum logic gates. It's often called the quantum NOT gate because it flips the state of a qubit, just like a classical NOT gate flips a bit.

### Entanglement
Entanglement is one of the most fascinating and fundamental phenomena in quantum mechanics. It describes a situation where two or more quantum particles become linked in such a way that the state of one particle is dependent on the state of the other, no matter how far apart they are.

### Qubit Swap
A Qubit Swap is a quantum operation that exchanges the states of two qubits. It's the quantum equivalent of swapping the values of two variables in classical computing.

## Algorithms
The following are more complex circuits that show the power of quantum computing and its ability to perform tasks with exponential speedup from that of a Classical Computer. Here we will demonstrate a few most popular algorithms that have been explored

### Grover's Search Algorithm
Grover's Search Algorithm is a quantum algorithm designed to search an unsorted database or solve a black-box function problem quadratically faster than any classical algorithm.

### Quantum Teleportation
Quantum teleportation is a method of transmitting quantum information (like the state of a qubit) from one location to another without physically moving the particle itself. It relies on the principles of entanglement and quantum measurement.

