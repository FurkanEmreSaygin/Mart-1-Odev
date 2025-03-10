class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.Write("Enter Card Number: ");
        string cardNumber = Console.ReadLine();

        Console.Write("Enter Expiry Date (MM/YY): ");
        string expiry = Console.ReadLine();

        Console.Write("Enter CVV: ");
        string cvv = Console.ReadLine();

        Console.WriteLine($"Processing credit card payment of {amount} TL...");
        Console.WriteLine("Payment successful!");
    }
}
