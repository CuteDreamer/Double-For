namespace Double_For
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество ступеней лестницы: ");
            int stairs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < stairs; i++)
            {
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("***");

                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("  *");                       // или вот так
            }

            Console.WriteLine("Второй вариант. Чур ногами не бить))))))");
            Console.WriteLine();

            for (int i = 0; i < stairs; i++)                    // так как стринг - это класс, создаем обьект типа string :D
            {
                string otstup = new string(' ', i * 2);
                Console.WriteLine(otstup + "***");
                Console.WriteLine(otstup + "  *");
            }
        }
    }
}


