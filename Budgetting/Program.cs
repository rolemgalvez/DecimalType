

// Welcome message
Console.WriteLine("Budgetting");
Console.WriteLine("----------");
Console.WriteLine();

// Declare variables
decimal allowance = 12345M;
decimal foodPercentage = 0.40M;
decimal homeExpensesPercentage = 0.30M;
decimal educationPercentage = 0.20M;
decimal othersPercentage = 0.10M;

// Show results
Console.WriteLine($"Total Allowance = {allowance}");
Console.WriteLine($"Food (40%) = {allowance * foodPercentage}");
Console.WriteLine($"Home Expences (30%) = {allowance * homeExpensesPercentage}");
Console.WriteLine($"Education (20%) = {allowance * educationPercentage}");
Console.WriteLine($"Others (10%) = {allowance * othersPercentage}");
Console.ReadLine();