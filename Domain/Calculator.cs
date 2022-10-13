namespace Domain
{
    public class Calculator
    {
        public int Sum(int left, int right)
        {
            return left + right;
        }

        //add calculator
        public int addCalculator(int[] numbers)
        {
            int sumOfNumbers = 0;
            if(numbers.Length == 1 || numbers.Length == 0)
            {
                throw new Exception("Array items cannot be 1 or 0");
            }
            else
            {
                for(int i=0; i<numbers.Length; i++)
                {
                    sumOfNumbers += numbers[i];
                }
            }
            return sumOfNumbers;
        }


        //substract calculator
        public int substractCalculator(int a, int b)
        {
            return a - b;
        }

        //division calculator
        public int divideCalculator(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Error Dividing by zero!");
            }
            else
            {
                return a / b;
            }
        }

        //multiplication calculator
        public int multiplicationCalculator(int a, int b)
        {
            return a * b;
        }


        //average function calculator
        public double averageCalculator(double[] numbers)
        {
            if(numbers.Length<=1 || numbers==null)
            {
                throw new Exception("You cant have length of one.");
            }
            else
            {
                double average = 0;
                for(int i=0; i<numbers.Length; i++)
                {
                    average += numbers[i];
                }
                average = average / numbers.Length;
                return average;
            }
        }

        public int minCalculator(int[] numbers)
        {
            int min = 2147483646;
            if (numbers.Length<=1)
            {
                throw new Exception("You only have one element in array");
            }
            else
            {
                for(int i=0; i<numbers.Length; i++)
                {
                    if (numbers[i]<min)
                    {
                        min = numbers[i];
                    }
                }
                return min;
            }

        }

        public int maxCalculator(int[] numbers)
        {
            int max = 0;
            if (numbers.Length <= 1)
            {
                throw new Exception("You only have one element in array");
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
                return max;
            }
        }

        //add calculator to array
        public void addCalculatorToArray(List<int> a1)
        {
            if(a1==null)
            {
                throw new Exception();
            }
            else
            {
                List<int> a2 = new List<int>();
                for(int i=0; i<a1.Count; i++)
                {
                    a2.Add(a2[i]);   
                }
            }
        }
    }
}