

// Welcome message
Console.WriteLine("Deposit Amount");
Console.WriteLine("--------------");
Console.WriteLine();

// Declare variables
decimal balance = 12345M;
int deposit = 560;

decimal updatedBalance = balance + deposit;

// Show result
Console.WriteLine($"{balance} + {deposit} = {updatedBalance}");
Console.ReadLine();