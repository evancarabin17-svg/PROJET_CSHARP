namespace ALGO05_EXO08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random hasard = new Random();
            int nombreMagique = hasard.Next(1, 101);
            int proposition = 0;    

            while (nombreMagique != proposition)
            {
                Console.WriteLine("Veuillez choisir un nombre.");
                proposition = Convert.ToInt32(Console.ReadLine());
                if (nombreMagique != proposition)
                {
                    Console.WriteLine("Ce n'est pas le bon nombre !");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique !");
                }
            }
        }
    }
}
