namespace RockPaperScissors;

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
