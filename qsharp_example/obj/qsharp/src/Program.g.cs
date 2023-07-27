//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsharp_example\",\"Name\":\"SetQubitState\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsharp_example\",\"Name\":\"SetQubitState\"},\"Attributes\":[],\"SourceFile\":\"/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"qsharp_example\",\"Name\":\"TestQuantumTransportation\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":11,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"qsharp_example\",\"Name\":\"TestQuantumTransportation\"},\"Attributes\":[],\"SourceFile\":\"/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace qsharp_example
{
    [SourceLocation("/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs", OperationFunctor.Body, 6, 13)]
    public partial class SetQubitState : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public SetQubitState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "SetQubitState";
        String ICallable.FullName => "qsharp_example.SetQubitState";
        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> __Body__ => (__in__) =>
        {
            var (desired,target) = __in__;
#line 7 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
            if ((desired != Microsoft__Quantum__Intrinsic__M.Apply(target)))
            {
#line 8 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__((Result,Qubit) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit target)
        {
            return __m__.Run<SetQubitState, (Result,Qubit), QVoid>((desired, target));
        }
    }

    [SourceLocation("/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs", OperationFunctor.Body, 13, -1)]
    public partial class TestQuantumTransportation : Operation<Int64, (Int64,Int64)>, ICallable
    {
        public TestQuantumTransportation(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQuantumTransportation";
        String ICallable.FullName => "qsharp_example.TestQuantumTransportation";
        public static EntryPointInfo<Int64, (Int64,Int64)> Info => new EntryPointInfo<Int64, (Int64,Int64)>(typeof(TestQuantumTransportation));
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> SetQubitState__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        public override Func<Int64, (Int64,Int64)> __Body__ => (__in__) =>
        {
            var count = __in__;
#line 14 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
            var totalOnes = 0L;
#line hidden
            {
#line 17 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                var (q1,q2,q3) = (Allocate__.Apply(), Allocate__.Apply(), Allocate__.Apply());
#line hidden
                bool __arg1__ = true;
                try
                {
#line 18 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                    foreach (var test in new QRange(1L, count))
#line hidden
                    {
#line 19 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        SetQubitState__.Apply((Result.One, q1));
#line 20 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        SetQubitState__.Apply((Result.Zero, q2));
#line 21 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        SetQubitState__.Apply((Result.Zero, q3));
#line 24 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        Microsoft__Quantum__Intrinsic__H.Apply(q1);
#line 27 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        Microsoft__Quantum__Intrinsic__H.Apply(q2);
#line 28 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        Microsoft__Quantum__Intrinsic__CNOT.Apply((q2, q3));
#line 31 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        Microsoft__Quantum__Intrinsic__CNOT.Apply((q1, q2));
#line 32 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        Microsoft__Quantum__Intrinsic__H.Apply(q1);
#line 35 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        var message = Microsoft__Quantum__Intrinsic__M.Apply(q1);
#line 36 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        var ebit = Microsoft__Quantum__Intrinsic__M.Apply(q2);
#line 39 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        if ((message == Result.One))
                        {
#line 40 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                            Microsoft__Quantum__Intrinsic__Z.Apply(q3);
                        }

#line 42 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        if ((ebit == Result.One))
                        {
#line 43 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                            Microsoft__Quantum__Intrinsic__X.Apply(q3);
                        }

#line 47 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        var result = Microsoft__Quantum__Intrinsic__M.Apply(q3);
#line 48 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                        if ((result == Result.One))
                        {
#line 49 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                            totalOnes = (totalOnes + 1L);
                        }
                    }

#line 54 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                    SetQubitState__.Apply((Result.Zero, q1));
#line 55 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                    SetQubitState__.Apply((Result.Zero, q2));
#line 56 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                    SetQubitState__.Apply((Result.Zero, q3));
#line 60 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                    Message__.Apply(String.Format("0: {0}", (count - totalOnes)));
#line 61 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                    Message__.Apply(String.Format("1: {0}", totalOnes));
#line 62 "/Users/erikgabrielsen/Desktop/Dialexa-Internal/QuantumComputing/quantum-computing/qsharp_example/Program.qs"
                    return ((count - totalOnes), totalOnes);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(q1);
#line hidden
                        Release__.Apply(q2);
#line hidden
                        Release__.Apply(q3);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.SetQubitState__ = this.__Factory__.Get<ICallable<(Result,Qubit), QVoid>>(typeof(SetQubitState));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __DataIn__(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __DataOut__((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 count)
        {
            return __m__.Run<TestQuantumTransportation, Int64, (Int64,Int64)>(count);
        }
    }
}