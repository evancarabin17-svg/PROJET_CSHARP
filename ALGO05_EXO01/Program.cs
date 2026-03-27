namespace ALGO05_EXO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;
            int i = 0;

            Console.WriteLine("Combien d'élèves composent la classe ?");
            int nbrEleves = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < nbrEleves; i++)
            {
                Console.WriteLine("Note : ");
                int note = Convert.ToInt32(Console.ReadLine());
                somme = somme + note;
            }
            Console.WriteLine("La moyenne est de : " + somme / nbrEleves);
        }
    }
}
