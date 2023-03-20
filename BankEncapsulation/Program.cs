namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Welcome to the bank");

            while (true)
            {
                Console.WriteLine("Enter 'D' to deposit money or 'B' to retrieve your balance");
                string input = Console.ReadLine();

                if (input.ToLower() == "d")
                {
                    Console.WriteLine("Enter deposit amount");
                    double amount = double.Parse(Console.ReadLine());
                    account.Deposit(amount);
                    Console.WriteLine("Deposit successful");
                }
                else if (input.ToLower() == "b")
                {
                    double balance = account.GetBalance();
                    Console.WriteLine($"Your current balance is: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Invalid input please try again");
                }
                Console.WriteLine();
            }
        }
    }
}
