class BankTransferPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.Write("Enter IBAN: ");
        string iban = Console.ReadLine();

        Console.WriteLine($"Bank transfer of {amount} TL to {iban} is in process...");
        Console.WriteLine("Payment successful!");
    }
}
