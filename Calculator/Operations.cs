namespace Calculator
{
    public class Operations
    {
        // Addition
        public static double Addition(double aNum, double bNum)
        {
            double ans = aNum + bNum;
            Console.WriteLine($"The answer is: {ans} \n--------------------------");
            return ans;
        }
        // Overloading
        public static double Addition(double[] nums)
        {
            double ans = nums.Sum();
            Console.WriteLine($"The answer is: {ans} \n--------------------------");
            return ans;
        }
        // Subtraction
        public static double Subtraction(double aNum, double bNum)
        {
            double ans = aNum - bNum;
            Console.WriteLine($"The answer is: {ans} \n--------------------------");
            return ans;
        }
        // Overloading
        public static double Subtraction(double[] nums)
        {
            double ans = 0;
            foreach (double num in nums)
                ans-=num;
            Console.WriteLine($"The answer is: {ans} \n--------------------------");
            return ans;
        }
        // Multiplication
        public static double Multiplication(double aNum, double bNum)
        {
            double ans = aNum * bNum;
            Console.WriteLine($"The answer is: {ans} \n--------------------------");
            return ans;
        }
        // Division
        public static double Division(double aNum, double bNum)
        {
            double ans;
            ans = aNum / bNum;
            if (aNum == 0 && bNum == 0)
                Console.WriteLine($"The answer is: {ans} (i.e., Undefined) \n--------------------------");
            else if (bNum == 0)
                Console.WriteLine($"The answer is: {ans} (i.e., Infinity) \n--------------------------");
            else
                Console.WriteLine($"The answer is: {ans} \n--------------------------");
            //Console.WriteLine($"{ans.GetType().Name}");
            return ans;
        }

    }
}

