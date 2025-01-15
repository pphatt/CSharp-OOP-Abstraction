namespace CSharp_OOP_Abstraction.Interface;

public interface Payment
{
    string ProcessPayment(decimal amount);
}

public class CashPayment : Payment
{
    public string ProcessPayment(decimal amount)
    {
        return $"Transaction is paid in cash with the amount of {amount}$";
    }
}

public class CreditCardPayment : Payment
{
    public string ProcessPayment(decimal amount)
    {
        return $"Transaction is paid by credit card with the amount of {amount}$";
    }
}

public class InterfacePayment
{
    public void Init()
    {
        CashPayment cashPayment = new CashPayment();
        Console.WriteLine(cashPayment.ProcessPayment(123));

        CreditCardPayment creditCardPayment = new CreditCardPayment();
        Console.WriteLine(creditCardPayment.ProcessPayment(123));
    }
}
