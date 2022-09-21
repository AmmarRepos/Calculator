// First Assginement Calculator

// This method capture the user input
static double readUserInput(string cardinality)
{
    Console.Write($"Please enter {cardinality}: ");
    double userInput = Convert.ToDouble(Console.ReadLine());
    return userInput;
}

// Addition method
static double Addition()
{
    double aNum = readUserInput("First Number");
    double bNum = readUserInput("Second Number");
    double cNum = aNum + bNum;
    Console.WriteLine($"The answer is: {cNum}");
    return cNum;
}

// Subtraction method
static double Subtraction()
{
    double aNum = readUserInput("First Number");
    double bNum = readUserInput("Second Number");
    double cNum = aNum - bNum;
    Console.WriteLine($"The answer is: {cNum}");
    return cNum;
}

// Multiplication method
static double Multiplication()
{
    double aNum = readUserInput("First Number");
    double bNum = readUserInput("Second Number");
    double cNum = aNum * bNum;
    Console.WriteLine($"The answer is: {cNum}");
    return cNum;
}

// Division Method and Division by zero is handled
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


// A switch statement to select the correct method to run according to
// user choice
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



// The entry-point of the program 
string userOpt = "";
while (userOpt != "yes")
{
    SelectOperation();
    Console.WriteLine("Do you want to exit (yes or no)?");
    userOpt = Console.ReadLine();
}
