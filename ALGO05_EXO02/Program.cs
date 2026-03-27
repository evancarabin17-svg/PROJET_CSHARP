namespace ALGO05_EXO02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;
            int min = 20;
            int max = 0;
            int i = 0;

            Console.WriteLine("Combien d'élèves composent la classe ?");
            int nbrEleves = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < nbrEleves; i++)
            {
                Console.WriteLine("Note : ");
                int note = Convert.ToInt32(Console.ReadLine());
                somme = somme + note;
                if (note < min)
                {
                    min = note;
                }
                if (note > max)
                {  
                    max = note;
                }
            }
            Console.WriteLine("La moyenne est de : " + somme / nbrEleves);
            Console.WriteLine("La note la plus faible est : " + min);
            Console.WriteLine("La note la plus élevée est : " + max);

        }
    }
}
