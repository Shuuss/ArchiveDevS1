namespace Exo2_Piscine
{
    internal class Program
    {
        public static readonly double ABONNEMENT_ADULTE_S = 85;
        public static readonly double ABONNEMENT_REDUIT_S = 63.8;
        public static readonly double ABONNEMENT_ADULTE_A = 155.8;
        public static readonly double ABONNEMENT_REDUIT_A = 116.9;
        public static readonly double ENTREE_ADULTE = 4.8;
        public static readonly double ENTREE_REDUIT = 3.6;
        public static readonly double REDUCTION = 0.1;
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------\nCAISSE PISCINE\n----------------------------------------\nAbonnement ou Entrée (A/E) ?");
            string option= Console.ReadLine();
            if (option!="A" && option!="E")
            {
                throw new ArgumentException("Erreur de Saisie");
            }
            Console.WriteLine("----------------------------------------\nAge ?");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            if (option == "A")
            {
                Console.WriteLine("Type abonnement : Annuel ou Semestriel (A/S) ?");
                string typeAbonnement = Console.ReadLine();
                Console.WriteLine("----------------------------------------\nPrix de l'abonnement : " + CalculePrixAbonnement(typeAbonnement, age) + " euro(s)");
            }
            else
            {
                Console.WriteLine("Carte de réduction (O/N) ?");
                string carteReduc = Console.ReadLine();
                if (carteReduc != "O" && carteReduc != "N")
                {
                    throw new ArgumentException("Erreur de Saisie");
                }
                Console.WriteLine("----------------------------------------\nPrix de l'entrée : " + CalculePrixEntree(carteReduc=="O", age) + " euro(s)");
            }


        }
        public static double CalculePrixAbonnement(String typeAbonnement, int age)
        {
            if ((typeAbonnement != "A" && typeAbonnement != "S") || age <= 0)
            {
                throw new ArgumentException("Erreur de Saisie");
            }
            double prix;
            if (typeAbonnement == "S")
            {
                if (age <= 25 || age > 65)
                {
                    prix = ABONNEMENT_REDUIT_S;
                }
                else
                {
                    prix = ABONNEMENT_ADULTE_S;
                }
            }
            else
            {
                if (age <= 25 || age > 65)
                {
                    prix = ABONNEMENT_REDUIT_A;
                }
                else
                {
                    prix = ABONNEMENT_ADULTE_A;
                }
            }
            return prix;
        }
        public static double CalculePrixEntree(bool carteEntree,int age)
        {
            if (age <= 0)
            {
                throw new ArgumentException("erreur de saisie");
            }
            double prix = 4.8;
            if (age <= 25 || age > 65)
            {
                prix = 3.6;
            }
            if (carteEntree)
            {
                prix -= prix * REDUCTION;
            }
            return prix;
        }
    }
}