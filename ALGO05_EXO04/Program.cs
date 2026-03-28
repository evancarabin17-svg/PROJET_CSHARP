namespace ALGO05_EXO04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int victoires = 0;
            int defaites = 0;
            int manche = 0;
            int choixOrdi = 0;

            Random hasard = new Random();
            for (manche = 1; manche < 10; manche++)
            {
                Console.WriteLine("Veuillez saisir 0 pour Pile ou 1 pour Face");
                int choixUtil = Convert.ToInt32(Console.ReadLine());
                choixOrdi = hasard.Next(0, 2);
                if (choixUtil == choixOrdi)
                {
                    victoires = victoires + 1;
                }
                else
                {
                    defaites = defaites + 1;
                }
            }
            Console.WriteLine("Vous avez gagné " + victoires +" manches.");
            Console.WriteLine("Vous avez perdu " + defaites + " manches.");
        }
    }
}
