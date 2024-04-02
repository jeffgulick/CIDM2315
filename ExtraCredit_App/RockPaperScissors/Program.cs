namespace RockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer();

    while (true)
    {

        Console.WriteLine($"****Rock Paper Scissors, Start!!****\nYou have {human.points} points");

        string humanChoice = human.HumanDecision();
        string computerChoice = computer.ComputerDecision();
        Console.WriteLine($"--> Computer Decision: {computerChoice}");

        CompareDecisions(humanChoice, computerChoice, human, computer);
        
        Console.WriteLine("Do you want to play again? (yes/no)");
        string playAgain = Console.ReadLine()!.ToLower();

        if (playAgain == "no")
        {
            Console.WriteLine("Thanks for playing!");
            break;
        }

        if(human.points <= 0)
        {
            Console.WriteLine("You lost all your points, game over!");
            break;
        }
    }
    
    }

    public static void CompareDecisions(string humanChoice, string computerChoice, HumanPlayer human, ComputerPlayer computer)
    {
        if (humanChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if (humanChoice == "rock" && computerChoice == "scissors" ||
                 humanChoice == "paper" && computerChoice == "rock" ||
                 humanChoice == "scissors" && computerChoice == "paper")
        {
            Console.WriteLine("You win!");
            human.WinRound();
        }
        else
        {
            Console.WriteLine("You lose!");
            human.LoseRound();

        }
    }
}
