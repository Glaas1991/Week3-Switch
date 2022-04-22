using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A" siis konsool kuvab "Suurepärane!"
            //"B" siis konsool kuvab "Väga hea!"
            //"C" siis konsool kuvab "Hea!"
            //"D" siis konsool kuvab "Rahuldav!"
            //"E" siis konsool kuvab "Kasin!"
            //"F" siis konsool kuvab "Puudulik!"
            //kui kasutaja sisestab midagi muud siis konsool kuvab "vale väärtus"

            //kasutame If

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if(userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if(userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if(userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if(userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if(userResult =='F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine("Vale väärtus!");
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
