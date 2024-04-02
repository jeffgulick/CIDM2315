namespace RockPaperScissors;

public class ComputerPlayer
{
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
