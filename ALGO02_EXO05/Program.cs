namespace ALGO02_EXO05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;

            Console.WriteLine("Saisir x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir y : ");
            int y = Convert.ToInt32(Console.ReadLine());
            tmp = x;
            x = y;
            y = tmp;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
}
