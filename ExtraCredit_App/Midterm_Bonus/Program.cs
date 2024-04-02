namespace Midterm_Bonus;

class Program
{
    static void Main(string[] args)
    {
        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer(5);

    while (true)
    {

        Console.WriteLine($"****Rock Paper Scissors, Start!!****\nYou have {human.points} points");

        string humanChoice = human.HumanDecision();
        string computerChoice = computer.ComputerDecision();
        Console.WriteLine($"--> Computer Decision: {computerChoice}");

        CompareDecisions(humanChoice, computerChoice, human, computer);
        
        Console.WriteLine("Do you want to play again? Input y to continue, or n to exit");
        string playAgain = Console.ReadLine()!.ToLower();
        
        if (playAgain == "n")
        {
            Console.WriteLine("Thanks for playing!");
            break;
        }

        if (human.points <=0)
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
            computer.LoseRound();
        }
        else
        {
            Console.WriteLine("You lose!");
            computer.WinRound();
            human.LoseRound();

        }
    }
}

public class ComputerPlayer
{
    public int points { get; private set; }

    public ComputerPlayer(int initial)
    {
        points = initial;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string ComputerDecision()
    {
        Random random = new Random();
        int rnd_num = random.Next(0, 3);

        switch (rnd_num)
        {
            case 0:
                return "rock";
            case 1:
                return "paper";
            case 2:
                return "scissors";
            default:
                return "error";
        }
    }
}

public class HumanPlayer
{
    public int points { get; private set; }

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Enter your choice: rock, paper, or scissors");
        
        string choice = Console.ReadLine()!.ToLower();

        if(choice != "rock" && choice != "paper" && choice != "scissors")
        {
            Console.WriteLine("Invalid choice, try again");
            return HumanDecision();
        }

        Console.WriteLine($"--> Your Decision: {choice}");
        return choice;
    }
}
