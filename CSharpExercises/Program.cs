namespace CSharpExercises;

internal class Program
{
    static void Main(string[] args)
    {
        var randomGenerator = new Random();
        var input = GetUserCommand();

        while (input != "quit")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();


            // do stuff
            switch (input)
            {
                case "grade":
                    GradeTranslator();
                    break;

                case "grade2":
                    GradeTranslatorWithDictionary();
                    break;

                case "dice20":
                    for (int i = 0; i <= 20; i++)
                    {
                        Console.WriteLine($"Dice rolls {randomGenerator.Next(1, 7)}");
                    }
                    break;

                case "blackjack":
                    PlayBlackJack();
                    break;

                default:
                    Console.WriteLine("Unknown module");
                    break;
            }

            Console.WriteLine();
            input = GetUserCommand();
        }
    }

    static string GetUserCommand()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Choose Module: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        return Console.ReadLine()!;
    }

    static void PlayBlackJack()
    {
        var generator = new Random();
        var cards = new Dictionary<int, string>()
        {
            { 1, "1 of hearts" },
            { 2, "2 of hearts" },
            { 3, "3 of hearts" },
            { 4, "4 of hearts" },
            { 5, "5 of hearts" },
            { 6, "6 of hearts" },
            { 7, "7 of hearts" },
            { 8, "8 of hearts" },
            { 9, "9 of hearts" },
            { 10, "10 of hearts" },
            { 11, "Jack of hearts" },   // 10
            { 12, "Queen of hearts" },  // 10
            { 13, "King of hearts" },   // 10
            { 14, "Ace of hearts" },    // 1 or 11
        };
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Welcome to BlackJack Deluxe");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("Player goes first!");

        var gameOver = false;
        var playerScore = 0;
        var dealerScore = 0;

        while (!gameOver)
        {
            if (playerScore > 0)
            {
                Console.WriteLine();
                SetColor(ConsoleColor.Cyan);
                Console.WriteLine("What do you want to do ? Draw or Fold?");
                Console.Write(" > ");
                SetColor(ConsoleColor.White);
                var cmd = Console.ReadLine();
            }

            var cardNo = generator.Next(1, cards.Count);
            Console.Write($"Dealer deals you ");
            SetColor(ConsoleColor.DarkRed);
            Console.WriteLine(cards[cardNo]);
            SetColor(ConsoleColor.White);

            playerScore += cardNo > 9 ? 10 : cardNo;

            if (playerScore > 21)
            {
                SetColor(ConsoleColor.Red);
                Console.WriteLine("You're busted!");
                SetColor(ConsoleColor.White);
                gameOver = true;
            }
            else if (playerScore == 21)
            {
                SetColor(ConsoleColor.Green);
                Console.WriteLine("You Win!");
                SetColor(ConsoleColor.White);
                gameOver = true;
            }

            Console.Write("You stand at ");
            SetColor(ConsoleColor.Yellow);
            Console.WriteLine(playerScore);
        }

        DoSomething();
    }

    static void SetColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    static void DoSomething()
    {
        // do stuff
        // do more stuff
        // do even more stuff
    }

    static void GradeTranslator()
    {
        Console.Write("Give us a grade: ");
        var input = Console.ReadLine()!;

        Console.Write("Your grade is ");
        switch (input)
        {
            case "A":
                Console.WriteLine("Average");
                break;
            case "E":
                Console.WriteLine("Excellent");
                break;
            case "G":
                Console.WriteLine("Good");
                break;
            case "V":
                Console.WriteLine("Very Good");
                break;
            case "F":
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("WTF?!");
                break;
        }
    }

    static void GradeTranslatorWithDictionary()
    {
        var dict = new Dictionary<string, string>
        {
            { "E", "Excellent" },
            { "V", "Very Good" },
            { "G", "Good" },
            { "A", "Average" },
            { "F", "Fail" }
        };

        Console.Write("Give us a grade: ");
        var input = Console.ReadLine()!;

        Console.Write("Your grade is ");
        if (dict.ContainsKey(input.ToUpper())) Console.WriteLine(dict[input.ToUpper()]);
        else Console.WriteLine("WTF?!");
    }

    static void StringLength_OddOrEven()
    {
        Console.WriteLine("Give us a sentence");
        var input = Console.ReadLine()!;

        var rest = input.Length % 2;
        if (rest == 0)
        {
            Console.WriteLine($"Length ({input.Length}) is Even");
        }
        else
        {
            Console.WriteLine("Length ({input.Length}) is Odd");
        }
    }

    static void DoCalculus()
    {
        Console.WriteLine("Let's do sums!");

        Console.Write("First number: ");
        var first = int.Parse(Console.ReadLine()!);

        Console.Write("Second number: ");
        var second = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"{first} + {second} = {first + second}");
        Console.WriteLine($"{first} - {second} = {first - second}");
        Console.WriteLine($"{first} * {second} = {first * second}");
        Console.WriteLine($"{first} / {second} = {first / second} (with rest: {first % second})");
    }
}
