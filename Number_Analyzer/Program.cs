Console.WriteLine("Hello! Welcome to the number analyzer please enter your name");
string userName = Console.ReadLine();


while (true)
{
    Console.WriteLine("Please enter an integer between 1 and 100");
    int userNumber = int.Parse(Console.ReadLine());


    if (userNumber > 100)
    {
        Console.WriteLine($"{userName} {userNumber} is too big");
    }

    //nested odd if statements
    if (userNumber % 2 == 1)
    {
        if (userNumber < 60)
        {
            Console.WriteLine($"{userName} you entered {userNumber} which is odd and less than 60");
        }
        else 
        {
            Console.WriteLine($"{userName} you entered {userNumber} which is odd and greater than 60");
        }
    }

    //nested even if statements
    if (userNumber % 2 == 0)
    {
        if (userNumber >= 2 && userNumber <= 25)
        {
            Console.WriteLine($"{userName} you entered {userNumber} which is even and less than 25");
        }
        else if (userNumber <= 60)
        {
            Console.WriteLine($"{userName} you entered {userNumber} which is even and between 26 and 60");
        }
        else
        {
            Console.WriteLine($"{userName} you entered {userNumber} which is even and greater than 60");
        }
    }


    // prompt for loop
    Console.WriteLine("Would you like to restart? Enter Yes or Y to continue, or enter any other key to exit.");
    var restartNumberAnalyzer = Console.ReadLine();


    if (restartNumberAnalyzer.ToLower() != "yes")
        if (restartNumberAnalyzer.ToLower() != "y")
        {
            Console.WriteLine("Goodbye!");
            break;
        }




}

Console.ReadKey();





