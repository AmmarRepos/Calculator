// First Assginement Calculator
// This method capture the user input
static double readUserInput(ref string message)
{
    Console.WriteLine(message);
    double.TryParse(Console.ReadLine(), out double userInput);
    return userInput;
}

static void Addition(double aNum, double bNum)
{
    Console.WriteLine($"The answer is: {aNum + bNum}");
}

// Subtraction method
static void Subtraction(double aNum, double bNum)
{
    Console.WriteLine($"The answer is: {aNum - bNum}");
}

// Multiplication method
static void Multiplication(double aNum, double bNum)
{
    Console.WriteLine($"The answer is: {aNum * bNum}");
}

// Division Method and Division by zero is handled
static void Division(double aNum, double bNum)
{ 
    if (bNum == 0)
    Console.WriteLine($"The answer is: Infinity");
    else
    Console.WriteLine($"The answer is: {aNum / bNum}");
}


// A switch statement to select the correct method to run according to
// user choice
static void SelectOperation(string userOperation, ref double aNum, ref double bNum)
{
    switch (userOperation)
    {
        case "+":
            Addition(aNum, bNum);
            break;
        case "-":
            Subtraction(aNum, bNum);
            break;
        case "*":
            Multiplication(aNum, bNum);
            break;
        case "/":
            Division(aNum, bNum);
            break;
        default:
            break;
    }
}


// The entry-point of the program 
string userOperation, message;
double aNum, bNum;
while (true)
{
    Console.WriteLine("type an operations {+ - * /} or x to exit");
    userOperation = Console.ReadLine()!;
    if (userOperation.ToLower() == "x")
        break;
    message = "Please input first number: ";
    aNum = readUserInput(ref message);
    message = "Please input second number: ";
    bNum = readUserInput(ref message);
    SelectOperation(userOperation, ref aNum, ref bNum);
}