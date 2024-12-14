using System;

namespace acfour_cristian_sala
{
    public class NaturalNums
    {
        private const string PromptQuantity = "Quants nombres vols introduïr?";
        private const string PromptNumber = "Introdueix un nombre: ";

        private const string ErrNotNatural = "Error, el nombre no es natural";

        private const string ResultText = "El nombre {0} es: {1}";

        private const int MinNum = 0;

        static void Main(string[] args)
        {
            int quantity = 0;
            int[] nums;

            Console.WriteLine(PromptQuantity);
            quantity = GetInput();
            nums = new int[quantity];

            GetUserNumbers(quantity, nums);

            SortUserNums(ref nums, 0, (nums.Length-1));

            PrintUserNumbers(nums);
        }

        private static void GetUserNumbers(int quantity, int[] nums)
        {
            for (int i = 0; i < quantity; i++)
            {
                nums[i] = GetInput();
            }
        }

        private static int GetInput()
        {
            bool validInput = false;
            int number = 0;

            while (!validInput)
            {
                Console.WriteLine(PromptNumber);
                validInput = int.TryParse(Console.ReadLine(), out number);

                if (validInput) 
                {
                    validInput = CheckNaturalNumber(number);
                    if (!validInput) Console.WriteLine(ErrNotNatural);
                }
            }
            return number;
        }

        private static bool CheckNaturalNumber(int number)
        {
            return number >= MinNum;
        }

        private static void SortUserNums(ref int[] nums, int posLow, int posHigh)
        {
            //Array.Sort(nums); fa servir quicksort

            if (posLow < posHigh)
            {
                int pi = Partition(nums, posLow, posHigh);
                SortUserNums(ref nums, posLow, pi - 1);
                SortUserNums(ref nums, pi + 1, posHigh);
            }
        }

        public static int Partition(int[] nums, int posLow, int posHigh)
        {
            int pivot = nums[posHigh];
            int i = (posLow - 1);

            for (int j = posLow; j <= posHigh - 1; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    Swap(nums, i, j);
                }
            }
            Swap(nums, i + 1, posHigh);
            return (i + 1);
        }

        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }


        private static void PrintUserNumbers(int[] nums)
        {
            for (int i = 0;i < nums.Length;i++)
            {
                Console.WriteLine(ResultText, i+1,nums[i]);
            }
        }
    }
}