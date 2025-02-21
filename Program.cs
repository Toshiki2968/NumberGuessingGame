// ウェルカムメッセージの表示
using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("You have 5 chances to guess the correct number");

Console.WriteLine("Please select the difficulty level:");
Console.WriteLine("1. Easy (10 chances)");
Console.WriteLine("2. Medium (5 chances)");
Console.WriteLine("3. Hard (3 chances)");

Console.Write("Enter your choice: ");
var inputLevel = Console.ReadLine();

if (string.IsNullOrWhiteSpace(inputLevel)) return;
if (!IsInputLevelCorrect(inputLevel))
{
    Console.WriteLine("1～3の数値を入力してください");
}

switch (inputLevel)
{
    case "1":
        Console.WriteLine($"Great! You have selected the Easy difficulty level.");
        break;
    case "2":
        Console.WriteLine($"Great! You have selected the Medium difficulty level.");
        break;
    case "3":
        Console.WriteLine($"Great! You have selected the Hard difficulty level.");
        break;
    default:
        Console.WriteLine("Let's start the game!");
        break;
}

var random = new Random();
var randomNumber = random.Next(1, 101);

while (true)
{
    Console.Write("Enter your guess: ");
    var inputGuess = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(inputGuess)) return;
    if (!Int32.TryParse(inputLevel, out _))
    {
        Console.WriteLine("数値を入力してください");
    }

    if (Int32.Parse(inputGuess) != randomNumber)
    {
    }
}



// レベル入力チェック
bool IsInputLevelCorrect(string inputLevel)
{
    if (!Int32.TryParse(inputLevel, out _)) return false;

    var level = Int32.Parse(inputLevel);
    if (level < 1 || level > 3) return false;
    return true;
}