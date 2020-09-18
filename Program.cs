using System;

namespace museumet
{
    class Program
    {
        static void Main(string[] args)
        {
            int room = 1;
            int choise = 0;

            bool isBurning = false;
            int count = 0;

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            
            // info
            Console.WriteLine("*************************************"); 
            Console.WriteLine($" Hej {name}!                        ");
            Console.WriteLine(" Välkommen till vårt museum!         ");
            Console.WriteLine(" Här kan du hitta många fina         ");
            Console.WriteLine(" konstverk från romartiden.          ");
            Console.WriteLine(" Nedanför ser du en karta på rummen. ");
            Console.WriteLine(" Du börjar i rum 1 aka hallen.       ");
            Console.WriteLine(" Ha en underbar upplevelse!          ");
            Console.WriteLine("         _____________               ");
            Console.WriteLine("         | 7 | 1 | 2 |               ");
            Console.WriteLine("         |_6_| 4 |_3_|               ");
            Console.WriteLine("             |_5_|                   ");
            Console.WriteLine("*************************************");

            Console.WriteLine("Tryck ENTER för att gå vidare.\n");
            Console.ReadLine();

            // meny
            while (true)
            {
                if (isBurning == true)
                {
                    count ++;

                    Console.WriteLine(" _____________ ");
                    Console.WriteLine(" | 7 | 1 | 2 | ");
                    Console.WriteLine(" |_6_| 4 |_3_| ");
                    Console.WriteLine("     |_5_|     \n");
                }
                else if (isBurning == false)
                {
                    Random random = new Random();
                    int chanse = random.Next(1, 11);
                    if (chanse == 2)
                    {
                        isBurning = true;
                        Console.WriteLine("Det BRINNER! Du måste ta dig ut så snabbt du kan!!");
                        Console.WriteLine("Du vill ha så få poäng som möjligt!");
                        Console.WriteLine(" _____________ ");
                        Console.WriteLine(" | 7 | 1 | 2 | ");
                        Console.WriteLine(" |_6_| 4 |_3_| ");
                        Console.WriteLine("     |_5_|     \n");
                    }

                }

                if (room == 1)
                {
                    if (isBurning == false)
                    {
                        Console.WriteLine("\nDu är i rum 1 även kallad hallen!");
                        Console.WriteLine("Finns tyvärr inte så mycket att se här.");
                        Console.WriteLine("Men det finns fina saker i de andra rummen!\n");
                    }
                    else if (isBurning == true)
                    {
                        Console.WriteLine("\nDu har kommit till hallen! Du klarade dig!");
                        Console.WriteLine($"Dina poäng blev {count}!");
                    }
                    
                    // om man vill lämna 
                    bool isLeaving = true;
                    while(isLeaving)
                    {
                        Console.WriteLine("Vill du lämna museumet?? j/n");
                        string choise2 = Console.ReadLine().ToLower();

                        if (choise2 == "n")
                        {
                            isLeaving = false;

                        }
                        else if (choise2 == "j")
                        {
                            Console.WriteLine("Tack för idag. Välkommen åter!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Fel val. Välj j eller n.");
                        }


                    }

                    Console.WriteLine("Tryck ENTER för att gå vidare.\n");
                    Console.ReadLine();

                    // Välja rum
                    Console.WriteLine("------------------------------"); 
                    Console.WriteLine("- Vilket rum vill du besöka? -");
                    Console.WriteLine("- [2] rum 2                  -");
                    Console.WriteLine("- [4] rum 4                  -");
                    Console.WriteLine("- [7] rum 7                  -");
                    Console.WriteLine("------------------------------");
                     // läser in
                    if (!Int32.TryParse(Console.ReadLine(),out choise))
                    {
                        Console.WriteLine("Det där va inget rum som du valde.");
                    }

                }
                else if (room == 2)
                {
                    Console.WriteLine("\nDu är i rum 2.");
                    Console.WriteLine("Här kan du se en vas från år 10 efk.");
                    Console.WriteLine("Dess inskription är typisk för den här tiden.");
                    Console.WriteLine("Den må vara liten men den är vacker.\n");

                    Console.WriteLine("Tryck ENTER för att gå vidare.\n");
                    Console.ReadLine();

                    // Välja rum
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("- Vilket rum vill du besöka? -");
                    Console.WriteLine("- [1] rum 1                  -");
                    Console.WriteLine("- [3] rum 3                  -");
                    Console.WriteLine("------------------------------");
                     // läser in
                    if (!Int32.TryParse(Console.ReadLine(),out choise))
                    {
                        Console.WriteLine("Det där va inget rum som du valde.");                    
                    }
                    
                }
                else if (room == 3)
                {
                    Console.WriteLine("\nDu är i rum nr 3.");
                    Console.WriteLine("Här hänger en stor tavla på Julius Caesar.");
                    Console.WriteLine("Bara så ni vet, han va mindre i verkligheten.");
                    Console.WriteLine("Mycket mycket mindre....\n");

                    Console.WriteLine("Tryck ENTER för att gå vidare.\n");
                    Console.ReadLine();

                    // Välja rum
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("- Vilket rum vill du besöka? -"); 
                    Console.WriteLine("- [2] rum 2                  -");
                    Console.WriteLine("- [4] rum 4                  -");
                    Console.WriteLine("------------------------------");
                     // läser in
                    if (!Int32.TryParse(Console.ReadLine(),out choise))
                    {
                        Console.WriteLine("Det där va inget rum som du valde.");
                    }
                    
                }
                else if (room == 4)
                {
                    Console.WriteLine("\nDu är i rum nr 4.");
                    Console.WriteLine("Här kan du njuta av tomheten");
                    Console.WriteLine("Hör du ekot??\n");

                    Console.WriteLine("Tryck ENTER för att gå vidare.\n");
                    Console.ReadLine();
                    
                    // Välja rum
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("- Vilket rum vill du besöka? -");
                    Console.WriteLine("- [1] rum 1                  -");
                    Console.WriteLine("- [3] rum 3                  -");
                    Console.WriteLine("- [5] rum 5                  -");
                    Console.WriteLine("- [6] rum 6                  -");
                    Console.WriteLine("------------------------------");
                     // läser in
                    if (!Int32.TryParse(Console.ReadLine(),out choise))
                    {
                        Console.WriteLine("Det där va inget rum som du valde.");
                    }
                    
                }
                else if (room == 5)
                {
                    Console.WriteLine("\nDu är i rum nr 5.");
                    Console.WriteLine("Här en klassiskt David Staty");
                    Console.WriteLine("Han ser ut att frysa lite stackaren!!\n");

                    Console.WriteLine("Tryck ENTER för att gå vidare.\n");
                    Console.ReadLine();

                    // Välja rum
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("- Vilket rum vill du besöka? -");
                    Console.WriteLine("- [4] rum 4                  -");
                    Console.WriteLine("------------------------------");
                     // läser in
                    if (!Int32.TryParse(Console.ReadLine(),out choise))
                    {
                        Console.WriteLine("Det där va inget rum som du valde.");
                    }
                    
                }
                else if (room == 6)
                {
                    Console.WriteLine("\nDu är i rum nr 6.");
                    Console.WriteLine("Den här udda skulpturen har det länge");
                    Console.WriteLine("diskuterats om vad det kan vara.");
                    Console.WriteLine("Låt fantasin flöda!!.\n");

                    Console.WriteLine("Tryck ENTER för att gå vidare.\n");
                    Console.ReadLine();

                    // Välja rum
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("- Vilket rum vill du besöka? -");
                    Console.WriteLine("- [4] rum 4                  -");
                    Console.WriteLine("- [7] rum 7                  -");
                    Console.WriteLine("------------------------------");
                     // läser in
                    if (!Int32.TryParse(Console.ReadLine(),out choise))
                    {
                        Console.WriteLine("Det där va inget rum som du valde.");
                    }
                    
                }
                else if (room == 7)
                {
                    Console.WriteLine("\nDu är i rum nr 7.");
                    Console.WriteLine("Kan ni se vem som är på detta lilla mynt?");
                    Console.WriteLine("Nä det kan ingen..\n");

                    Console.WriteLine("Tryck ENTER för att gå vidare.\n");
                    Console.ReadLine();

                    // Välja rum
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("- Vilket rum vill du besöka? -");
                    Console.WriteLine("- [1] rum 1                  -");
                    Console.WriteLine("- [6] rum 6                  -");
                    Console.WriteLine("------------------------------");
                     // läser in
                    if (!Int32.TryParse(Console.ReadLine(),out choise))
                    {
                        Console.WriteLine("Det där va inget rum som du valde.");
                    }
                    
                }
               

                if (room == choise)
                {
                    Console.WriteLine("Du är redan i detta rum. Välj igen!");
                }

                if (choise == 1)
                {
                    if (room == 1 || room == 2 || room == 4 || room == 7)
                    {
                        room = choise;

                    }
                    else
                    {
                        Console.WriteLine("Du har gått in i väggen. Försök igen!");
                    }
                }
                else if (choise == 2)
                {
                    if (room == 2 || room == 1 || room == 3)
                    {
                        room = choise;
                       
                    }
                    else
                    {
                        Console.WriteLine("Du har gått in i väggen. Försök igen!");
                    }
                }
                else if (choise == 3)
                {
                    if (room == 3 || room == 2 || room == 4)
                    {
                        room = choise;

                    }
                    else
                    {
                        Console.WriteLine("Du har gått in i väggen. Försök igen!");
                    }
                }
                else if (choise == 4)
                {
                    if (room == 4 || room == 1 || room == 3 || room == 5 || room == 6)
                    {
                        room = choise;
                       
                    }
                    else
                    {
                        Console.WriteLine("Du har gått in i väggen. Försök igen!");
                    }
                }
                else if (choise == 5)
                {
                    if (room == 5 || room == 4)
                    {
                        room = choise;
                        
                    }
                    else
                    {
                        Console.WriteLine("Du har gått in i väggen. Försök igen!");
                    }
                }
                else if (choise == 6)
                {
                    if (room == 6 || room == 4 || room == 7)
                    {
                        room = choise;

                    }
                    else
                    {
                        Console.WriteLine("Du har gått in i väggen. Försök igen!");
                    }
                }
                else if (choise == 7)
                {
                    if (room == 7 || room == 1 || room == 6)
                    {
                        room = choise;
                        
                    }
                    else
                    {
                        Console.WriteLine("Du har gått in i väggen. Försök igen!");
                    }
                }

            }
        }
    }
}
