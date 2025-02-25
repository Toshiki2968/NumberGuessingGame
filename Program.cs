while (true)
{
    // ウェルカムメッセージの表示
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

    var sw = new System.Diagnostics.Stopwatch();
    sw.Start();

    var attemptsCount = 0;
    while (true)
    {
        attemptsCount++;

        switch (inputLevel)
        {
            case "1":
                if (attemptsCount > 10) return;
                break;
            case "2":
                if (attemptsCount > 5) return;
                break;
            case "3":
                if (attemptsCount > 3) return;
                break;
            default:
                break;
        }

        Console.Write("Enter your guess: ");
        var inputGuess = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputGuess)) return;
        if (!Int32.TryParse(inputLevel, out _))
        {
            Console.WriteLine("数値を入力してください");
        }
        var guess = Int32.Parse(inputGuess);
        if (guess == randomNumber)
        {
            sw.Stop();
            Console.WriteLine($"Congratulations! You guessed the correct number in {attemptsCount} attempts.");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            break;
        }
        if (guess > randomNumber)
        {
            Console.WriteLine($"Incorrect! The number is less than {guess}.");
            continue;
        }

        Console.WriteLine($"Incorrect! The number is greater than {guess}.");
        continue;
    }

    Console.WriteLine("もう一度プレイしますか(y/n)");
    var retryAnswer = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(retryAnswer)) return;
    if (retryAnswer == "y"){
        continue;
    }
    return;

}




// レベル入力チェック
bool IsInputLevelCorrect(string inputLevel)
{
    if (!Int32.TryParse(inputLevel, out _)) return false;

    var level = Int32.Parse(inputLevel);
    if (level < 1 || level > 3) return false;
    return true;
}