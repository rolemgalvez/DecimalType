

// Welcome message
Console.WriteLine("Withdraw Amount");
Console.WriteLine("---------------");
Console.WriteLine();

// Declare variables
decimal balance = 34008M;
decimal withdrawal = 100.50M;

decimal updatedBalance = balance - withdrawal;

// Show result
Console.WriteLine($"{balance} - {withdrawal} = {updatedBalance}");
Console.ReadLine();