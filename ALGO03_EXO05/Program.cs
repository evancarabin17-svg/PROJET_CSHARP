namespace ALGO03_EXO05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choixOrdi = "P";

            Random hasard = new Random();
            Console.WriteLine("Tapez P pour pile et F pour face : ");
            string choixUtil = Console.ReadLine();

            if (hasard.Next(0, 2) == 0)
            {
                choixOrdi = "P";
            }
            else
            {
                choixOrdi = "F";
            }

            if (choixUtil == choixOrdi)
            {
                Console.WriteLine("Gagné");
            }
            else
            {
                Console.WriteLine("Perdu");
            }
        }
    }
}
