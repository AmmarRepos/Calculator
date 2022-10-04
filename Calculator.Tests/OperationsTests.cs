namespace Calculator.Tests
{
    public class AdditionTests
    {
        [Fact]
        public void Addition_Logic()
        {
            double aNum = 10, bNum = 10;
            double ans = Operations.Addition(aNum, bNum);
            Assert.Equal(20, ans);
        }
        [Fact]
        public void Addition_Array()
        {
            double[] nums = { 10, 20, 30 };
            double ans = Operations.Addition(nums);
            Assert.Equal(60, ans);
        }
    }
    public class DivisionTests
    {
        [Fact]
        public void Division_Logic()
        {
            double aNum = 10, bNum = 10;
            double ans = Operations.Division(aNum, bNum);
            Assert.Equal(1, ans);
        }
        [Fact]
        public void Division_By_Zero()
        {
            double aNum = 10, bNum = 0;
            double ans = Operations.Division(aNum, bNum);
            Assert.Equal(double.PositiveInfinity, ans);
        }

        [Fact]
        public void Division_Undefined()
        {
            double aNum = 0, bNum = 0;
            double ans = Operations.Division(aNum, bNum);
            Assert.Equal(double.NaN, ans);
        }

        [Fact]
        public void Division_Return_Type()
        {
            double aNum = 0, bNum = 0;
            double ans = Operations.Division(aNum, bNum);
            Assert.IsType<Double>(ans);
        }
    }
}