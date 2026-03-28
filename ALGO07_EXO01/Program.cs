namespace ALGO07_EXO01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void permuter(int nb1, int nb2)
            {
                int temp = nb1;
                nb1 = nb2;
                nb1 = temp;
            }
        }
    }
}
