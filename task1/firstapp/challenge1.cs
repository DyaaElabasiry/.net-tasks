namespace firstapp;

public class challenge1
{
    public static void RunChallenge()
    {
        
        Console.WriteLine("register user name");
        string userName = Console.ReadLine();
        Console.WriteLine("register user password");
        string password = Console.ReadLine();

        Console.WriteLine("login user name");
        string loginUserName = Console.ReadLine();
        Console.WriteLine("login user password");
        string loginPassword = Console.ReadLine();

        if (userName == loginUserName && password == loginPassword) {
            Console.WriteLine("login successful");
        }
        else {
            Console.WriteLine("login failed");
        }
    }
}

