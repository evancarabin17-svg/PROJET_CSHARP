namespace ALGO02_EXO06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir y : ");
            int y = Convert.ToInt32(Console.ReadLine());
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
}
