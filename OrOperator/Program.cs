using System;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on 'admin' ja sisestatud salasõna on 'admin1234';
            //siis konsoolis kuvatakse 'Tere tulemast!';
            //muul juhul kuvatakse konsoolis 'Vale Kasutajatunnus või salasõna, proovi uuesti!';

            //OR (või) operaator,pipes

            // true || true --> true
            // false || true --> true 
            // true || false --> true
            // false || false --> false

            Console.WriteLine("Palun, sisesta kasutajatunnus!");
            string userName = Console.ReadLine();
            Console.WriteLine("Palun, sisesta salasõna!");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool! Proovi uuesti");
            }

            else

            {
                Console.WriteLine("Tere päevast!");
            }










        }
    }
}


