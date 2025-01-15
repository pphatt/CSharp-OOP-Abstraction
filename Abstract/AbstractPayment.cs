namespace CSharp_OOP_Abstraction.Abstract;

public abstract class Payment
{
    public abstract string ProcessPayment(decimal amount);
}

public class CashPayment : Payment
{
    public override string ProcessPayment(decimal amount)
    {
        return $"Transaction is paid in cash with the amount of {amount}$";
    }
}

public class CreditCardPayment : Payment
{
    public override string ProcessPayment(decimal amount)
    {
        return $"Transaction is paid by credit card with the amount of {amount}$";
    }
}

public class AbstractPayment
{
    public void Init()
    {
        CashPayment cashPayment = new CashPayment();
        Console.WriteLine(cashPayment.ProcessPayment(100));

        CreditCardPayment creditCardPayment = new CreditCardPayment();
        Console.WriteLine(creditCardPayment.ProcessPayment(100));
    }
}
