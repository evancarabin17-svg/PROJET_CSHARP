namespace ALGO04_EXO01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Saisissez deux nombres : ");
            int nombre1 = Convert.ToInt32(Console.ReadLine());
            int nombre2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 : Addition");
            Console.WriteLine("2 : Soustraction");
            Console.WriteLine("3 : Multiplication");
            Console.WriteLine("4 : Division");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine(nombre1 + nombre2);
                    break;
                case 2:
                    Console.WriteLine(nombre1 - nombre2);
                    break;
                case 3:
                    Console.WriteLine(nombre1 * nombre2);
                    break;
                case 4:
                    Console.WriteLine(nombre1 / nombre2);
                    break;
            }

        }
    }
}
