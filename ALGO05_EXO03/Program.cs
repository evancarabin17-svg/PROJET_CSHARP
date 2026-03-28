namespace ALGO05_EXO03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorielle = 0;
            int i = 0;

            Console.WriteLine("Donnez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            factorielle = factorielle + nombre;
            for (i = 1; i < nombre; i++)
            {
                factorielle = factorielle * i;
            }
            Console.WriteLine(factorielle);
        }
    }
}
