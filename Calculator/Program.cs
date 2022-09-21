// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

static double readUserInput(string cardinality)
{
    Console.Write($"Please enter {cardinality}: ");
    double userInput = Convert.ToDouble(Console.ReadLine());
    return userInput;
}


static double Addition()
{
    double aNum = readUserInput("First Number");
    double bNum = readUserInput("Second Number");
    double cNum = aNum + bNum;
    Console.WriteLine($"The answer is: {cNum}");
    return cNum;
}


static double Subtraction()
{
    double aNum = readUserInput("First Number");
    double bNum = readUserInput("Second Number");
    double cNum = aNum - bNum;
    Console.WriteLine($"The answer is: {cNum}");
    return cNum;
}


static double Multiplication()
{
    double aNum = readUserInput("First Number");
    double bNum = readUserInput("Second Number");
    double cNum = aNum * bNum;
    Console.WriteLine($"The answer is: {cNum}");
    return cNum;
}


static double Division()
{
    double aNum = readUserInput("Numerator");
    double bNum = readUserInput("Denominator");
    if (bNum == 0)
    {
        Console.WriteLine("Denominator cannot be zero");
        bNum = readUserInput("Denominator");
    }
    double cNum = aNum / bNum;
    Console.WriteLine($"The answer is: {cNum}");
    return cNum;
}



static void SelectOperation()
{
    Console.WriteLine("Please Select an Operation {+ - * /}");
    string operation = Console.ReadLine();
    switch (operation)
    {
        case "+":
            Addition();
            break;
        case "-":
            Subtraction();
            break;
        case "*":
            Multiplication();
            break;
        case "/":
            Division();
            break;
        default:
            Console.WriteLine("Please Select one of these operations {+ - * /}");
            SelectOperation();
            break;
    }
}


string userOpt = "";
while (userOpt != "yes")
{
    SelectOperation();
    Console.WriteLine("Do you want to exit (yes or no)?");
    userOpt = Console.ReadLine();
}
