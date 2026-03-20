namespace ALGO02_EXO09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heures = 0;
            int minutes = 0;

            Console.WriteLine("Donnez les secondes : ");
            int secondes = Convert.ToInt32(Console.ReadLine());
            heures = secondes / 3600;
            secondes = secondes - heures * 3600;
            minutes = secondes / 60;
            secondes = secondes - minutes * 60;
            Console.WriteLine(heures + "h " + minutes + "min " + secondes + "sec ");
        }
    }
}
