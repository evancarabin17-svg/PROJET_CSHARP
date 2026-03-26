namespace ALGO03_EXO06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mdp = "azerty1234";

            Console.WriteLine("Veuillez saisir votre mot de passe : ");
            string mdpSaisi = Console.ReadLine();
            if (mdp == mdpSaisi)
            {
                Console.WriteLine("Mot de passe correct!");
            }
            else
            {
                Console.WriteLine("Mot de passe incorrect...");
            }
        }
    }
}
