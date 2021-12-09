using System;

namespace LogInValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on 'admin' ja sisestatud salasõna on 'admin1234';
            //siis konsoolis kuvatakse 'Tere tulemast!';
            //muul juhul kuvatakse konsoolis 'Vale Kasutajatunnus või salasõna, proovi uuesti!';
            //kasutajal on 3 katset

            

            int i = 0;
            while (i < 3) 

            {

                Console.WriteLine("Palun, sisesta kasutajatunnus!");
                string userName = Console.ReadLine();
                Console.WriteLine("Palun, sisesta salasõna!");
                string userPassword = Console.ReadLine();


                if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere päevast!");
                    break;
            }

            else
            {
                    i++;
                Console.WriteLine($"Vale kasutajatunnus või salasõna.Sul on jäänud {3 - i} katset");
            }

            }
        }
    }
}
