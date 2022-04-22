using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm käsib kasutajal sisestada tema lemmik värk
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas"
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} üksarvik"

            Console.WriteLine("Sisesta oma lemmik värv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;

            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
