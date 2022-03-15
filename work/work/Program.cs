using System;
using work.Models;
namespace work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = GetInputInt("Nece eded kitab daxil edeceksizin?", 0);
            Book[] info = new Book[length];

            for (int i = 0; i < length; i++)
            {
                int No = GetInputInt($"{i + 1}.ci kitabin nomresi: ", 1);
                string Name = GetInputStr($"{i + 1}.ci kitabin adi: ",2,50 );
                int Price = GetInputInt($"{i + 1}.ci kitabin qiymeti: ", 10);
                int Count  = GetInputInt($"{i + 1}.ci kitabin deyeri: ", 15);
                string Genre= GetInputStr($"{i + 1}.ci kitabin janri: ", 2, 5);

                info[i] = new Book(Genre, No, Name, Price)
                {
                    Count = Count
                };
               
                
                
                foreach (var a in info)
                {
                    Console.WriteLine(a.GetInfo());
                }
            }



            static int GetInputInt(string name, int min, int max = int.MaxValue)
            {
                int input;
                do
                {
                    Console.WriteLine(name );
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input < min || input > max);

                return input;
            }
            static string GetInputStr(string name, int min, int max = int.MaxValue)
            {
                string input;
                do
                {
                    Console.WriteLine(name);
                    input = Console.ReadLine();
                } while (input.Length < min || input.Length > max);

                return input;
            }

            
            
            
        }
    }
}
