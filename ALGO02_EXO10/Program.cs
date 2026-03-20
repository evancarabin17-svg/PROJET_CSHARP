namespace ALGO02_EXO10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            nombre = nombre / 2;
            nombre = nombre * 2;
            Console.WriteLine(nombre);
        }
    }
}
