namespace Assignment_3._2._5
{
    internal class Program
    {
        public static int Search(int[] array, int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(input, int.Parse);

            do //always user to search for another item in array if desired
            {
                Console.WriteLine("Which item would you like to search for: ");
                int item = int.Parse(Console.ReadLine());

                int result = Search(array, item);
                if (result != -1)
                {
                    Console.WriteLine($"Item found at index: {result}");
                }
                else
                {
                    Console.WriteLine("-1");
                }
                Console.WriteLine("Would you like to search for another item? (Y/N)");
            }
            while (Console.ReadLine().ToUpper() == "Y");


        }
    }
}
