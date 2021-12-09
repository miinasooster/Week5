using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti ehk cpu ja kasutaja;
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mägija viskas rohkem;
            //mängija, kes viskab rohkem see on võitja;
            //*täringuid visatakse 3 korda;
            //programm kuulutab võitja;

            int sum = 0;
            for (int i = 0; i < 3; i++)

            {



                Random rnd = new Random();




            int CpuRandom = rnd.Next(1, 7); //arvuti
            int userRandom = rnd.Next(1, 7); //kasutaja

            int CpuScore = 0;
            int userScore = 0;

         

            {

                Console.WriteLine($"Arvuti viskas {CpuRandom}, kasutaja viskas { userRandom}");

            if (CpuRandom < userRandom)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                userScore++;
            }

            else if (CpuRandom > userRandom)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
                CpuScore++;
            }

            else
            {
                Console.WriteLine("Viik");
                
            }

            }

                Console.WriteLine($"Arvuti viskas kokku {CpuScore}, kasutaja viskas { userScore}");

                if (CpuScore < userScore)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    
                }

                else if (CpuScore > userScore)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    
                }

                else
                {
                    Console.WriteLine("Viik");




                }

            }



        }
    }
}
