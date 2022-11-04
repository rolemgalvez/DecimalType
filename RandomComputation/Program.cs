

// Welcome message
Console.WriteLine("Random Computation");
Console.WriteLine("------------------");
Console.WriteLine();

// Declare variables
int firstNumber = 123;
decimal secondNumber = 345.123M;
int thirdNumber = 842;
decimal fourthNumber = 12;
int fifthNumber = 203;

decimal result = (firstNumber + secondNumber) - (thirdNumber * fourthNumber) / fifthNumber;
string computation = $"({firstNumber} + {secondNumber}) - ({thirdNumber} * {fourthNumber}) / {fifthNumber}";

// Show result
Console.WriteLine($"{computation} = {result}");
Console.ReadLine();