using CodedSignal_Interview_Practice.Arrays;

namespace CodedSignal_Interview_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstDuplicate firstDuplicate = new();
            Console.WriteLine(firstDuplicate.DuplicateFirst(new int[] { 2, 1, 3, 5, 3, 2 }));
        }
    }
}