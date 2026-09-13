using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {static int CountEven(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    count++;
            return count;
        //必须返回count才能让程序正常运行
        }
        static void Main(string[] args)
        {
            int[] nums = { 7, 2, 9, 1, 15, 6 };
            Console.WriteLine(CountEven(nums));//使用了return返回的数字
            


         }
    }
}
