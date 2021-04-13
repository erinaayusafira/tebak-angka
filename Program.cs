using System;

namespace TebakAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random random = new Random();
            int randNumber = random.Next(0,100);
            bool guessed = false;
            int guesses = 0;

            ConsoleColor prevColor = Console.ForegroundColor;

            while(!guessed){
                Console.Write("Tebak! angka berapa yang saya pikirkan ? : ");
                int ans = Convert.ToInt32(Console.ReadLine());

                guesses +=1;
                Console.Clear();
                if(ans == randNumber){
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Selamat Kamu Menebak dengan Benar");
                    Console.ForegroundColor = prevColor;
                    Console.WriteLine("Kamu perlu menebak {0} kali", guesses);
                    break;
                }
                else if(ans > randNumber){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Angkanya lebih kecil daripada yang kamu tebak");
                    Console.ForegroundColor = prevColor;
                }
                else if(ans < randNumber){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Angkanya lebih besar daripada yang kamu tebak");
                    Console.ForegroundColor = prevColor;
                }
            }
            Console.ReadKey();
        }
    }
}
