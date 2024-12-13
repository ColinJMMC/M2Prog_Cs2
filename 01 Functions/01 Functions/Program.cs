namespace _01_Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "Skyrim is the fifth installment of what epic open-world videogame series by Bethesda Softworks?",
            "Which Legend of Zelda game that picks up after Ocarina of Time was released for N64 in 2000 and remade for Nintendo 3DS in 2015?",
            "What arcade game was called Puckman in Japan?",
            "In July 2023, video game company EA announced that players will be able to explore Wakanda in an upcoming open-world video game based on the adventures of what Marvel superhero?\r\n",
            "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?",
            "In May 2022, the government of what European nation banned its employees from using American gaming terms such as \"e-sports,\" instead using their domestic language counterparts like \"jeu video de competition?\"\r\n",
            "Regarded as one of the greatest video games of all time, what 1981 arcade game features the titular amphibian trying to cross a road without getting squashed by cars, and a river without getting eaten by predators?\r\n",
            "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?",
            "What Will Wright created video game series released in 2000 (with sequels in 2004, 2009, and 2014) saw players watching and directing characters to mundane things like eating, sleeping, and cleaning their houses?\r\n",
            "What 1997 N64 video game, features James Bond and is named after the 1995 film?"
        };


        static void Main(string[] args) // void, er komt niks terug
        {
            {
                Program program = new Program(); // Variable om de program the runnen
                program.Run();
                
            }
        }

        // Function hier
        internal void Run()
        {
            string vraag0 = GetVraag(GetRandomVraag);
            Console.WriteLine(vraag0);

            //Console.WriteLine("Why do round pizzas come in square boxes?");
            //string antwoord = Console.ReadLine();

            //Console.WriteLine(antwoord);

            //vraag1();
            //Vraag2();
            //Vraag3();
            //Vraag4();
            //Vraag5();
            //Vraag6();
            //string antwoord2 = Vraag7();
            //Console.WriteLine(antwoord2);
        }

        internal string GetVraag(int vraagIndex) {
            return vragen[vraagIndex];
        }

        internal string GetRandomVraag()
        {
            int random = 0, 9;
            return GetVraag(random);
        }

    //    internal void vraag1()
    //    {
    //        Console.WriteLine("How much money do you have?");
    //        string antwoord = Console.ReadLine();

    //        Console.WriteLine(antwoord);
    //    }

    //    internal void Vraag2()
    //    {
    //        Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
    //        string antwoord = Console.ReadLine();

    //        Console.WriteLine(antwoord);
    //    }

    //    internal void Vraag3()
    //    {
    //        Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
    //        string antwoord = Console.ReadLine();

    //        Console.WriteLine(antwoord);
    //    }

    //    internal void Vraag4()
    //    {
    //        Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
    //        string antwoord = Console.ReadLine();

    //        Console.WriteLine(antwoord);
    //    }

    //    internal void Vraag5()
    //    {
    //        Console.WriteLine("What would you do if you won a million dollars?");
    //        string antwoord = Console.ReadLine();

    //        Console.WriteLine(antwoord);
    //    }

    //    internal void Vraag6()
    //    {
    //        Console.WriteLine("What is the worst game you played but that you liked anyway?");
    //        string antwoord = Console.ReadLine();

    //        Console.WriteLine(antwoord);
    //    }

    //    internal string Vraag7()
    //    {
    //        Console.WriteLine("How many kids do you have?");
    //        string antwoord = Console.ReadLine();

    //        return antwoord;
    //    }

        }
    }