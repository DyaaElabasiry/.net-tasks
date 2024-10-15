namespace firstapp;

public class challenge2
{
    public static void RunChallenge()
    {
        string highScorePlayer = "";
        int highScore = 0;
        while (true)
        {
            Console.WriteLine("\n\nEnter player name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter player score: ");
            int playerScore = Convert.ToInt32(Console.ReadLine());
            if (playerScore>highScore)
            {
                highScore = playerScore;
                highScorePlayer = playerName;
                Console.WriteLine("New high score is " + highScore );
                Console.WriteLine("New high score holder is " + highScorePlayer);
            }else
            {
                Console.WriteLine("The old high score of " + highScore + " could not be broken and is still held by " + highScorePlayer);
            }
        }
    }
}