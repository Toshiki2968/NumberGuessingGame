# NumberGuessingGame CLI

## 概要  
NumberGuessingGame CLI は、[roadmap.sh](https://roadmap.sh/projects/number-guessing-game)のコマンドラインで行う簡単な数字推測ゲームです。  
1 から 100 の範囲でランダムに生成された数値を、ユーザーが推測して当てるゲームです。

## 環境構築  

### 1. 必要なツール  
- .NET SDK（バージョン 8.0 以上）  
- C# 開発環境（Visual Studio, VS Code など）  

### 2. プロジェクトのセットアップ  
```sh
git clone https://github.com/Toshiki2968/NumberGuessingGame.git
cd NumberGuessingGame
dotnet build
dotnet run
```

## 使用例
``` sh
Welcome to the Number Guessing Game!
I'm thinking of a number between 1 and 100.
You have 5 chances to guess the correct number.

Please select the difficulty level:
1. Easy (10 chances)
2. Medium (5 chances)
3. Hard (3 chances)

Enter your choice: 2

Great! You have selected the Medium difficulty level.
Let's start the game!

Enter your guess: 50
Incorrect! The number is less than 50.

Enter your guess: 25
Incorrect! The number is greater than 25.

Enter your guess: 35
Incorrect! The number is less than 35.

Enter your guess: 30
Congratulations! You guessed the correct number in 4 attempts.
```