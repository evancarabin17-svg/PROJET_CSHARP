namespace ALGO05_EXO06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;
            int nbrNotes = 0;

            Console.WriteLine("Combien d'élèves composent la classe ?");
            int nbrEleves = Convert.ToInt32(Console.ReadLine());
            while (nbrNotes < nbrEleves)
            {
                Console.WriteLine("Note ? :");
                int note = Convert.ToInt32(Console.ReadLine());
                somme = somme + note;
                nbrNotes = nbrNotes + 1;
            }
            Console.WriteLine("La moyenne de la classe est de : " + somme / nbrEleves);
        }
    }
}
