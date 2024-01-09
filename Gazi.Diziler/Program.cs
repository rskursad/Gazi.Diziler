namespace Gazi.Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DİZİ-ARRAY
            //int number = 10;
            //int[] numbers = new int[3];
            //numbers[0] = 50;
            //numbers[1] = 10;
            //numbers[2] = 30;
            ////numbers[3] = 10;//IndexOutOfRangeException

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine();
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("For sort (A-Z)");
            //Console.WriteLine("How many names do you want to sort?");
            //int namecount = int.Parse(Console.ReadLine());
            //string[] names= new string[namecount];
            //for (int i = 0; i < names.Length; i++) 
            //{
            //    Console.WriteLine($"Enter {i+1}. name: ");
            //    names[i] = Console.ReadLine();
            //}
            //Array.Sort(names);
            //for(int i = 0;i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //
            //Console.WriteLine("How many numbers do you want to sort?");
            //int numbercount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ender starting number");
            //int start =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number");
            //int end=int.Parse(Console.ReadLine());
            //int[] numbers=new int[numbercount];
            //Random rnd = new Random();

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    numbers[i] = rnd.Next(start, end);

            //}
            //Array.Sort(numbers);
            //for (int i = 0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //

            //ÖDEV: Generated random numbers must be unique. DO IT and upload to your own GİTHUB

            Console.WriteLine("How many numbers do you want to sort?");
            int numbercount = int.Parse(Console.ReadLine());
            Console.WriteLine("Ender starting number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number");
            int end = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbercount];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(start, end);
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        i--;
                        break;
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
//numbers: referans -> heap bölgesindeki değerlerin adresini tutan yapılar.
//index: Dizi elemanlarına ulaşmak çin kullanılan sayılar.Index ler 0 dan başlar.
