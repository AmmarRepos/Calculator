// First Assginement Calculator
using Calculator;

// The entry-point of the program 
string userOperation;
bool repeat = true;
while (repeat)
{
    Console.WriteLine("type an operations {+ - * / sum sub} or x to exit");
    userOperation = Console.ReadLine()!;
    repeat = Interaction.EvalUserInput(userOperation);
}


