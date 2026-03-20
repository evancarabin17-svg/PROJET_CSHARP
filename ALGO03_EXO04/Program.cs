namespace ALGO03_EXO04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

            Console.WriteLine("Veuillez saisir deux nombres entiers :");
            int nombre1 = Convert.ToInt32(Console.ReadLine());
            int nombre2 = Convert.ToInt32(Console.ReadLine());
            if (nombre1 > nombre2)
            {
                max = nombre1;
            }
            else
            {
                max = nombre2;
            }
            Console.WriteLine("Le plus grand nombre est : " + max);
        }
    }
}
