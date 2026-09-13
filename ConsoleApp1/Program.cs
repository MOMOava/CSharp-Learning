namespace ConsoleApp1
{
    internal class Program
    {static int  SumOdd (int[]arr)
        { int sum = 0;
        int i = 0;
        while (i < arr.Length)
            { if (!IsEven(arr[i]))
                    sum += arr[i];
                i++;

                    }return sum;
           
            


        }
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {  return true; }
            else { return false; }
}
        static void Main(string[] args)
        {
            int[] nums = { 7, 2, 9, 1, 15, 6 };

            int result = SumOdd(nums);
            Console.WriteLine(result);
           
        }
    }
}
