

// Welcome message
Console.WriteLine("USD to PHP");
Console.WriteLine("----------");
Console.WriteLine();

// Declare variables
decimal dollarAmount = 30.25M;
decimal pesoMultiplier = 58.15M;

decimal result = dollarAmount * pesoMultiplier;

// Show result
Console.WriteLine($"{dollarAmount} * {pesoMultiplier} = {result}");
Console.ReadLine();