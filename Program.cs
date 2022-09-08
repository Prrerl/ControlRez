namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Сколько слов вы собираетесь ввести? ");
            int val = Convert.ToInt32(Console.ReadLine());
            string[] arr1 = new string[val];
            int cntr = 0;
            int condCntr = 0;
            Console.WriteLine("Введите слова ");
            while (cntr < val)
            {
                arr1[cntr] = Console.ReadLine();
                if (arr1[cntr].Length <= 3)
                {
                    condCntr++;
                }
                cntr++;
            }
            if (condCntr > 0) 