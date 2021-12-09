using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on 'admin' ja sisestatud salasõna on 'admin1234';
            //siis konsoolis kuvatakse 'Tere tulemast!';
            //muul juhul kuvatakse konsoolis 'Vale Kasutajatunnus või salasõna, proovi uuesti!';

            Console.WriteLine("Palun, sisesta kasutajatunnus!");
            string userName = Console.ReadLine();
            Console.WriteLine("Palun, sisesta salasõna!");
            string userPassword = Console.ReadLine();

            //AND või OR

            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin12345" --> false

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere päevast!");
            }

            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti!");
            }


        }
    }
}



