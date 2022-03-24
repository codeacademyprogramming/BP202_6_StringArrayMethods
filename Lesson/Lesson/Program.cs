using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String methods

            string word = "hello-world-salam-qaqa";
            //word = word.Trim();

            Console.WriteLine(word);
            Console.WriteLine(word.TrimEnd()+"|");


            Console.WriteLine(word.ToLower() + "|");
            Console.WriteLine(word.Replace("Hel","Tar") + "|");
            Console.WriteLine(word.Substring(5,2));
            Console.WriteLine(word.LastIndexOf('l'));
            Console.WriteLine(word.Contains(" h"));
            Console.WriteLine(word.EndsWith("lo   "));
            var result = word.Split("-");
            Console.WriteLine("words:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var resultWord = String.Join(" ", result);
            Console.WriteLine(resultWord);
            #endregion

            #region Array methods

            string[] newArr = new string[result.Length+2];

            result.CopyTo(newArr, 2);

            Console.WriteLine("words:");
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
            int[] nums = { 333, 40, 5, 60, 7, 8, };

            Array.Clear(nums, 2, 1);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            int[] newNums = new int[3];

            Array.Copy(nums, 2, newNums, 2, 0);

            Console.WriteLine("\n======newNums=======\n");
            foreach (var item in newNums)
            {
                Console.WriteLine(item);
            }

            Array.Resize(ref newNums, newNums.Length + 1);
            Console.WriteLine("length: "+newNums.Length);
            Array.Sort(nums);
            Array.Reverse(nums);

            Console.WriteLine("Sorted nums");

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Char methods

            Console.WriteLine(char.IsUpper('A'));
            Console.WriteLine(char.IsLower('a'));
            Console.WriteLine(char.IsLetterOrDigit('a'));
            Console.WriteLine(char.ToUpper('4'));
            #endregion





        }
    }
}
