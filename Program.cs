using CSharp_OOP_Abstraction.Abstract;
using CSharp_OOP_Abstraction.Interface;

namespace CSharpOOPAbstraction;

internal class Program
{
    static void Main(string[] args)
    {
        AbstractPayment abstractPayment = new AbstractPayment();
        abstractPayment.Init();

        InterfacePayment interfacePayment = new InterfacePayment();
        interfacePayment.Init();
    }
}
