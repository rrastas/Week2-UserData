using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis "Oled liiga noor, et juhilube saada"
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis "Oled piisavalt vana, et juhilube saada"
            //kui kasutaja on 18, siis programm kuvab konsoolis "Palju õnne! Nüüd sa saad juhilube taotleda
            

            Console.WriteLine("Tere, palun sisestage oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            //Arvutan vanuse vahe, kaua peab veel ootama, et saaks juhilube taotleda.
            int userAge2 = 18 - userAge;

            
            if (userAge < 18)
            {
                Console.WriteLine($"Oled liiga noor, et juhilube saada. Pead veel {userAge2} aastat ootama.");

            }

            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");
            }

            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilube taotleda.");
            }

            Console.WriteLine("Kena päeva jätku!");



        }
    }
}
