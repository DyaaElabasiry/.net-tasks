namespace firstapp;

public class challenge3
{
    public static void RunChallenge()
    {
        Console.WriteLine("Enter a number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operation: ");
        string operation = Console.ReadLine();
        Console.WriteLine("Enter a second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case "+":
                Console.WriteLine("The result is:");
                Console.WriteLine(number1 + number2);
                break;
            case "-":
                Console.WriteLine("The result is:");
                Console.WriteLine(number1 - number2);
                break;
            case "*":
                Console.WriteLine("The result is:");
                Console.WriteLine(number1 * number2);
                break;
            case "/":
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                else
                {
                    Console.WriteLine("The result is:");
                    Console.WriteLine(number1 / number2);
                }
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}