namespace Calculator
{
   public class Interaction
    {
        public static bool EvalUserInput(string userOperation)
        {
            double aNum, bNum;
            double[] nums;
            switch (userOperation)
            {
                case "+":
                    Console.Write("Please input first number: ");
                    aNum = Interaction.UserInputToDouble();
                    Console.Write("Please input second number: ");
                    bNum = Interaction.UserInputToDouble();
                    Operations.Addition(aNum, bNum);
                    return true;
                case "-":
                    Console.Write("Please input first number: ");
                    aNum = Interaction.UserInputToDouble();
                    Console.Write("Please input second number: ");
                    bNum = Interaction.UserInputToDouble();
                    Operations.Subtraction(aNum, bNum);
                    return true;
                case "*":
                    Console.Write("Please input first number: ");
                    aNum = Interaction.UserInputToDouble();
                    Console.Write("Please input second number: ");
                    bNum = Interaction.UserInputToDouble();
                    Operations.Multiplication(aNum, bNum);
                    return true;
                case "/":
                    Console.Write("Please input first number: ");
                    aNum = Interaction.UserInputToDouble();
                    Console.Write("Please input second number: ");
                    bNum = Interaction.UserInputToDouble();
                    Operations.Division(aNum, bNum);
                    return true;
                case "x":
                    Console.Write("Thank you and good bye.");
                    return false;
                case "sum":
                    Console.Write("Please input numbers ex. 1,2,10, ...: ");
                    nums = Interaction.UserInputToArray();
                    Operations.Addition(nums);
                    return true;
                case "sub":
                    Console.Write("Please input numbers ex. 1,2,10, ...: ");
                    nums = Interaction.UserInputToArray();
                    Operations.Subtraction(nums);
                    return true;
                default:
                    return true;
            }
        }

        public static double[] UserInputToArray()
        {
            string numsRep = Console.ReadLine()!;
            string[] arrRep = numsRep.Split(",");
            double[] nums = new double[arrRep.Length];
            int i = 0;
            foreach (string num in arrRep)
            {
                nums[i] = (double.Parse(num));
                i++;
            }
            return nums;
        }

        public static double UserInputToDouble()
        {
            try
            {
                double num = double.Parse(Console.ReadLine()!);
                return num;
            }
            catch
            {
                Console.Write("Please input a number: ");
                return UserInputToDouble();
            }
    }
    }
}

