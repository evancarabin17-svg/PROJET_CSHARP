namespace ALGO04_EXO02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mois ="";
            string SousChaîne = "";
            Console.WriteLine("Saisir un date au format jj/mm/aaaa");
            string date = Console.ReadLine();
            switch (SousChaîne = date.Substring(3, 2))
            {
                case "01":
                    mois = "Janvier";
                    break;
                case "02":
                    mois = "Février";
                    break;
                case "03":
                    mois = "Mars";
                    break;
                case "04":
                    mois = "Avril";
                    break;
                case "05":
                    mois = "Mai";
                    break;
                case "06":
                    mois = "Juin";
                    break;
                case "07":
                    mois = "Juillet";
                    break;
                case "08":
                    mois = "Août";
                    break;
                case "09":
                    mois = "Septembre";
                    break;
                case "10":
                    mois = "Octobre";
                    break;
                case "11":
                    mois = "Novembre";
                    break;
                case "12":
                    mois = "Décembre";
                    break;
            }
            Console.WriteLine(date.Substring(0, 2) + mois + date.Substring(6, 4));
        }
    }
}
