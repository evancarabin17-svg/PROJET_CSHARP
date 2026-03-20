namespace ALGO02_EXO02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prixPoint = 3.25;
            double tauxRetenue = 0.2;
            int salaireBrut = 0;
            int salaireNet = 0;

            Console.WriteLine("Saisir l'indice : ");
            int indice = Convert.ToInt32(Console.ReadLine());
            salaireBrut = (int)(indice * prixPoint);
            salaireNet = (int)(salaireBrut - (salaireBrut * tauxRetenue));
            Console.WriteLine("indice : " + indice);
            Console.WriteLine("Prix du point : " + prixPoint);
            Console.WriteLine("Taux de retenue : " + tauxRetenue);
            Console.WriteLine("Salaire Brut : " + salaireBrut);
            Console.WriteLine("SalaireNet : " + salaireNet);
        }
    }
}
