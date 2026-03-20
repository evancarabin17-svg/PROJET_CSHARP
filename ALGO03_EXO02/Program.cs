namespace ALGO03_EXO02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donner un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            if (nombre % 2 == 0)
            {
                Console.WriteLine(nombre);
            }
            else
            {
                Console.WriteLine(nombre - 1);
            }
        }
    }
}
