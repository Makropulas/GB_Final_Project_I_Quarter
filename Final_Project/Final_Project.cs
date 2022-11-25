namespace I_Quarter
{
    internal class Final_Projects
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите строки через пробел: ");
            string[] array = Console.ReadLine()!.Split(" ");
            Console.WriteLine();
            string[] newArray = FillNewArray(array);
            Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", newArray)}]");
            Console.ReadKey();
        }
        public static string[] FillNewArray(string[] oldArray)
        {
            int count = 0;
            foreach (var element in oldArray)
            {
                if (element.Length <= 3) count++;
            }          
            string[] result = new string[count];
            for (int i = 0, j = 0; i < oldArray.Length; i++)
            {
                if (oldArray[i].Length <= 3)
                {
                    result[j] = oldArray[i];
                    j++;
                }
            }
            return result;
        }
    }
}