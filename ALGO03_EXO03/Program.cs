namespace ALGO03_EXO03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int billets500 = 0;
            int billets200 = 0;
            int billets100 = 0;
            int billets50 = 0;
            int billets20 = 0;
            int billets10 = 0;
            int billets5 = 0;
            int pieces2 = 0;
            int pieces1 = 0;

            Console.WriteLine("Donner la somme : ");
            int somme = Convert.ToInt32(Console.ReadLine());
            if (somme >= 500)
            {
                billets500 = somme / 500;
                somme = somme - billets500 * 500;
            }
            if (somme >= 200)
            {
                billets200 = somme / 200;
                somme = somme - billets200 * 200;
            }
            if (somme >= 100)
            {
                billets100 = somme / 100;
                somme = somme - billets100 * 100;
            }
            if (somme >= 50)
            {
                billets50 = somme / 50;
                somme = somme - billets50 * 50;
            }
            if (somme >= 20)
            {
                billets20 = somme / 20;
                somme = somme - billets20 * 20;
            }
            if (somme >= 10)
            {
                billets10 = somme / 10;
                somme = somme - billets10 * 10;
            }
            if (somme >= 5)
            {
                billets5 = somme / 5;
                somme = somme - billets5 * 5;
            }
            if (somme >= 2)
            {
                pieces2 = somme / 2;
                somme = somme - pieces2 * 2;
            }
            pieces1 = somme;

            Console.WriteLine(billets500 + " billet(s) de 500€");
            Console.WriteLine(billets200 + " billet(s) de 200€");
            Console.WriteLine(billets100 + " billet(s) de 100€");
            Console.WriteLine(billets50 + " billet(s) de 50€");
            Console.WriteLine(billets20 + " billet(s) de 20€");
            Console.WriteLine(billets10 + " billet(s) de 10€");
            Console.WriteLine(billets5 + " billet(s) de 5€");
            Console.WriteLine(pieces2 + " piece(s) de 2€");
            Console.WriteLine(pieces1 + " piece(s) de 1€");
        }
    }
}
