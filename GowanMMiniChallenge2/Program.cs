//Madeline Gowan
//10-18-22
//Mini Challenge 2 - Redo
//In this challenge the user would enter two numbers, and the program must
//recognize them as numbers with value, and add the values together.

//peer review - Marcel R. It worked ass intended, I liked the use of if else
//to choose paths with perimeters and how the while loop made use of the already
//existing "Y" string to set the breakout condition. Data types for the
//numbers could be redone to match Ie. all int or all long, but other than
//that a great and fun program!

Console.Clear();

Console.Write("This is a math game, wanna play? Y or N: ");
string play = Console.ReadLine().ToUpper();

if (play == "N")
{
    Console.WriteLine("Okay, goodbye.");
}
else if (play != "Y" && play != "N")
{
    Console.WriteLine("Invalid response. Please try again.");
    Console.Write("Would you like to play? Y or N: ");
    play = Console.ReadLine().ToUpper();
}

while (play == "Y")
{
    Console.WriteLine("Let's add two numbers!");
    Console.WriteLine("Enter your first number: ");
    string numberOne = Console.ReadLine();
    long num;
    bool validNum1 = long.TryParse(numberOne, out num);

    Console.WriteLine("Enter your second number: ");
    string numberTwo = Console.ReadLine();
    bool validNum2 = long.TryParse(numberTwo, out num);


    if (validNum1 && validNum2)
    {
        int num1 = Convert.ToInt32(numberOne);
        int num2 = Convert.ToInt32(numberTwo);

        Console.WriteLine("Let's add them together! And the sum is...");
        Console.WriteLine(num1 + num2);

        Console.Write("That was fun. Do you want to play again? Y or N: ");
        play = Console.ReadLine().ToUpper();

    }
    else
    {
        Console.WriteLine("Those are not valid responses.");
        Console.Write("Would you like to try again? Y or N: ");
        play = Console.ReadLine().ToUpper();
    }

}
