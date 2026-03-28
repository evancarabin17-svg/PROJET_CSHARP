namespace ALGO05_EXO11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int victoires = 0;
            int defaites = 0;
            int manche = 0;
            Random hasard = new Random();


            do
            {
                manche = manche + 1;
                Console.WriteLine("Veuillez saisir 0 pour Pile ou 1 pour Face.");
                int choixUtil = Convert.ToInt32(Console.ReadLine());
                int choixOrdi = hasard.Next(0, 2);
                if (choixUtil == choixOrdi)
                {
                    victoires = victoires + 1;
                }
                else
                {
                    defaites = defaites + 1;
                }
            }
            while (manche < 10);
            Console.WriteLine("Vous avez gagné " + victoires + " manches");
            Console.WriteLine("Vous avez perdu " + defaites + " manches");
        }
    }
}
