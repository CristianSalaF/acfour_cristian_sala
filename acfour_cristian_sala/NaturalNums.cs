
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

        private static void PrintUserNumbers(int[] nums)
        {
            for (int i = 0;i < nums.Length;i++)
            {
                Console.WriteLine(ResultText, i+1,nums[i]);
            }
        }
    }
}