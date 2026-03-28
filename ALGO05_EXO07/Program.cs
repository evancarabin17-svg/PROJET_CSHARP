namespace ALGO05_EXO07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;
            int nbrEleves = 0;
            bool continuer = true;

            while (continuer == true)
            {
                Console.WriteLine("Note ? :");
                int note = Convert.ToInt32(Console.ReadLine());
                somme = somme + note;
                nbrEleves = nbrEleves + 1;
                Console.WriteLine("saisir true pour continuer ou flase pour arrêter");
                continuer = bool.Parse(Console.ReadLine());
            }
            Console.WriteLine("La moyenne de la classe est de : " + somme / nbrEleves);
        }
    }
}
