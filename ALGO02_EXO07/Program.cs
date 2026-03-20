namespace ALGO02_EXO07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int coef1 = 3;
            const int coef2 = 4;
            const int coef3 = 2;

            Console.WriteLine("Donner la note obtenue à l'épreuve 1 : ");
            int note1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donner la note obtenue à l'épreuve 2 : ");
            int note2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donner la note obtenue à l'épreuve 3 : ");
            int note3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Epreuve 1 : " + note1, coef1);
            Console.WriteLine("Epreuve 2 : " + note2, coef2);
            Console.WriteLine("Epreuve 3 : " + note3, coef3);
            Console.WriteLine((note1 * coef1 + note2 * coef2 + note3 * coef3) / (coef1 + coef2 + coef3));
        }
    }
}
