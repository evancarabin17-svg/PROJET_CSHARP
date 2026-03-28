namespace ALGO05_EXO09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somme = 0; 
            int nbrNotes = 0;

            Console.WriteLine("Combien d'élèves composent la classe ?");
            int nbrEleves = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Note :");
                int note = Convert.ToInt32(Console.ReadLine());
                somme = somme + note;
                nbrNotes = nbrNotes + 1;
            }
            while (nbrNotes < nbrEleves);
            Console.WriteLine("La moyenne de la classe est de : " + somme / nbrEleves);
        }
    }
}
