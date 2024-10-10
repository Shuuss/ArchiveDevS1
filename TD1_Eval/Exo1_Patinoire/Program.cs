namespace Exo1_Patinoire
{
    internal class Program
    {
        public static readonly double TARIF_ADULTE = 4.7;
        public static readonly double TARIF_REDUIT = 3.6;
        public static readonly double TARIF_MINOT = 0;
        public static readonly double TARIF_PATINS = 3.5;
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------\nCAISSE PATINOIRE\n----------------------------------------\nAge ?");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Location Patins ? (O/N)");
            String patin = Console.ReadLine();
            double prixE = TARIF_ADULTE;
            double prixL = 0;
            if (age < 5)
            {
                prixE = TARIF_MINOT;
            }
            else if (age <= 25 || age > 65)
            {
                prixE = TARIF_REDUIT;
                
            }
            if (patin == "O")
            {
                prixL += TARIF_PATINS;
            }
            Console.WriteLine("----------------------------------------\nPrix entrée : " + prixE + "\nPrix location : " + prixL + "\nPrix total : " + (prixE+prixL));


        }
    }
}