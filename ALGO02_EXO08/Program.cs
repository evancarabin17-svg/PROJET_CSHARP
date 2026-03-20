namespace ALGO02_EXO08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double txTVA = 0.2;
            int prixTTC = 0;
            int tva = 0;

            Console.WriteLine("Saisir le prix hors taxes : ");
            int prixHT = Convert.ToInt32(Console.ReadLine());
            tva = (int)(prixHT * txTVA);
            prixTTC = (int)(prixHT + tva);
            Console.WriteLine("La TVA est de : " + tva);
            Console.WriteLine("Le prix TTC est de : " + prixTTC);
        }
    }
}
