namespace ALGO03_EXO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heures = 0;
            int minutes = 0;

            Console.WriteLine("Combien de secondes : ");
            int secondes = Convert.ToInt32(Console.ReadLine());
            if (secondes > 3600)
            {
                heures = secondes / 3600;
                secondes = secondes - heures * 3600;
            }
            if (secondes > 60)
            {
                minutes = secondes / 60;
                secondes = secondes - minutes * 60;
            }

            Console.WriteLine(heures + " h," + minutes + " m," + secondes + " s");
        }
    }
}
