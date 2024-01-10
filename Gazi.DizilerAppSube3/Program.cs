namespace Gazi.DizilerAppSube3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diziler - Arrays

            //int[] numbers = new int[3];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40; // IndexOutOfRangeException,

            //int[] numbers = { 10, 20, 30 };
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]); // Kod Tekrarı 

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}           

            //Array.Sort(numbers);
            //for (int i = 0;i < numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("How many names do you want to sort?");
            //int howmany = int.Parse(Console.ReadLine());

            //string[] names = new string[howmany];           

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"Enter the {i + 1}. name");
            //    names [i] = Console.ReadLine(); 
            //}

            //Array.Sort(names);
            //Console.WriteLine("Sorted Names:");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} - {names[i]}");
            //}

            //Console.WriteLine("How many numbers do you want to sort?");
            //int howmany = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the starting number");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the ending number");
            //int end = int.Parse(Console.ReadLine());

            //int[] numbers = new int[howmany];

            //for (int i = 0; i < howmany; i++)
            //{
            //    Random rnd = new Random();
            //    numbers[i] = rnd.Next(start, end);
            //}
            //Array.Sort(numbers);
            //for (int i = 0;i < howmany; i++)
            //{
            //    Console.WriteLine($"Your numbers are: {numbers[i]}");
            //}

            // Ödev 

            Random rnd = new Random();
            Console.WriteLine("Enter the starting number:");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending number:");
            byte end = byte.Parse(Console.ReadLine());
            Console.WriteLine("How many numbers do you want to array?:");
            byte howMany = byte.Parse(Console.ReadLine());

            int[] numbers = new int[howMany];
            int number;
            for (int i = 0; i < numbers.Length; i++)
            {
                number = rnd.Next(start, end);
                if (i == 0)
                {
                    numbers[i] = number;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = number;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

//numbers: referans -> heap bölgesindeki değerlerin adresini tutan yapılara referans denir.
//Index: Dizi elemanlarının numaralarıdır, 0'dan başlar.