// First Assginement Calculator
using Assignments;

static double Addition(double aNum, double bNum)
{
    return aNum + bNum;
}

// Subtraction method
static double Subtraction(double aNum, double bNum)
{
    return aNum - bNum;
}

// Multiplication method
static double Multiplication(double aNum, double bNum)
{
    return aNum * bNum;
}

// Division Method and Division by zero is handled
static double Division(double aNum, double bNum)
{ 
    if (bNum == 0)
    {
        Console.WriteLine($"The answer is: Infinity");
        return aNum / bNum;
    }
    else
        return aNum / bNum;
}


// A switch statement to select the correct method to run according to
// user choice
static double Calculator(string userOperation, ref double aNum, ref double bNum)
{
    switch (userOperation)
    {
        case "+":
            return Addition(aNum, bNum);
        case "-":
            return Subtraction(aNum, bNum);
        case "*":
            return Multiplication(aNum, bNum);
        case "/":
            return Division(aNum, bNum);
        default:
            return 0;
    }
}


// The entry-point of the program 
string userOperation;
double aNum, bNum, cNum;
while (true)
{
    Console.WriteLine("type an operations {+ - * /} or x to exit");
    userOperation = Console.ReadLine()!;
    if (userOperation.ToLower() == "x")
        break;
    Console.Write("Please input first number: ");
    aNum = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Please input second number: ");
    bNum = double.Parse(Console.ReadLine()!);
    cNum = Calculator(userOperation, ref aNum, ref bNum);
    Console.WriteLine($"The answer is: {cNum} \n--------------------------");
}