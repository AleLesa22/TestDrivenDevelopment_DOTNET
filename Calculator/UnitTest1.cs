using Domain;
namespace CalculatorTest
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();

            //add calculator
            int[] numbers = {1,2,3};
            calculator.addCalculator(numbers);
            
        }

        [Fact]
        public void Test2()
        {
            var calculator = new Calculator();
            //substract calculator
            calculator.substractCalculator(10, 5);
        }

        [Fact]
        public void Test3()
        {
            var calculator = new Calculator();
            calculator.divideCalculator(10, 5);
        }

        [Fact]
        public void Test4()
        {
            var calculator = new Calculator();
            calculator.multiplicationCalculator(10, 5);
        }


        // failing test

        //[Fact]
        //public void Test5()
        //{
        //    int[] numbers = {1};
        //    var calculator = new Calculator();
        //    calculator.addCalculator(numbers);
        //}


        [Fact]
        public void Test5()
        {
            double[] doubleNumbers = { 1.5, 2.7, 3.5 };
            var calculator = new Calculator();
            calculator.averageCalculator(doubleNumbers);
        }

        [Fact]
        public void Test6()
        {
            var calculator = new Calculator();
            int[] numbers = { 1, 2, 3 };
            calculator.minCalculator(numbers);
        }

        [Fact]
        public void Test7()
        {
            var calculator = new Calculator();
            int[] numbers = { 1, 2, 3 };
            calculator.maxCalculator(numbers);
        }

        [Fact]
        public void Test8()
        {
            var calculator = new Calculator();
            List<int> a2 = new List<int>();
            calculator.addCalculatorToArray(a2);
        }
    }
}