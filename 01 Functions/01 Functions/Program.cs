namespace _01_Functions
{
    internal class Program
    {

        static void Main(string[] args) // void, er komt niks terug
        {
            {
                Program program = new Program(); // Variable om de program the runnen
                program.Run(); // Het is een progam function en runt ons programma
            }
        }

        // Function hier
        internal void Run() {
            Console.WriteLine("Dit is nu de start van mijn programma");
        }

    }
}