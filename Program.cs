namespace exSem5
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        // Écrire une méthode qui lit la taille d'un utilisateur et dit s'il est petit, moyen, ou grand
        // petit : moins de 1,70m 
        // moyen : de 1,70m à 1,82m
        // grand : plus de 1,82m
        static void ex1()
        {
            double taille = 0.0;

            Console.WriteLine("Entrez votre taille : ");
            double.TryParse(Console.ReadLine(), out taille);

            if (taille < 1.70)
            {
                Console.WriteLine("Petit");
            }
            else if (taille < 1.83)
            {
                Console.WriteLine("Moyen");
            }
            else if (taille > 1.82)
            {
                Console.WriteLine("Grand");
            }
        }

        // Écrire la méthode qui trouve le plus grand de trois nombres entrés à la console
        static void ex2()
        {
            int nb1 = 0; 
            int nb2 = 0;
            int nb3 = 0;

            Console.WriteLine("Entrer 3 nombres");
            int.TryParse(Console.ReadLine(), out nb1);
            int.TryParse(Console.ReadLine(), out nb2);
            int.TryParse(Console.ReadLine(), out nb3);

            if (nb1 > nb2)
            {
                if (nb1 > nb3)
                {
                    Console.WriteLine(nb1 + " est le plus grand");
                }
                else
                {
                    Console.WriteLine(nb3 + " est le plus grand");
                }
            }
            else
            {
                if (nb2 > nb3)
                {
                    Console.WriteLine(nb2 + " est le plus grand");
                }
                else
                {
                    Console.WriteLine(nb3 + " est le plus grand");
                }
            }
        }

        // À partir des angles internes d'un triangle déterminer si le triangle est valide ou non
        // La somme des angles d'un triangle est toujours 180 degrés
        static void ex3()
        {
            int angle1 = 0;
            int angle2 = 0;
            int angle3 = 0;

            Console.WriteLine("Entrer les 3 angles du triangle");

            if ((angle1 + angle2 + angle3) == 180)
            {
                Console.WriteLine("Triangle valide");
            }
            else 
            {
                Console.WriteLine("Pas un triangle");
            }
        }

        // Saisir la longueur des 3 côtés d'un triangle (a, b et c)
        // À partir des informations déterminer si le triangle est
        // Équilatéral : tous les côtés ont la même longueur
        // Isocèle : 2 côtés égaux
        // Scalène : aucun côté n'est égal 
        static void ex4()
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("Entrer la longueur des côtés du triangle");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            if (a == b)
            {
                if (b == c)
                {
                    Console.WriteLine("Équilatéral");
                }
                else
                {
                    Console.WriteLine("Isocèle");
                }
            }
            else
            {
                if (b == c)
                {
                    Console.WriteLine("Isocèle");
                }
                else
                {
                    Console.WriteLine("Scalène");
                }
            }
        }

        // À partir des informations fournies par l'utilisateur calculer la facture du mois pour sa consommation d'électricité
        // Frais d'accès au réseau par jour : 0.42238$
        // Jusqu'à 40kWh par jour pour le total des jours (ex: 30 jours = 1200kWh) : 0.06319$ par kWh
        // kWh supplémentaires : 0.09749$ par kWh
        static void ex5()
        {
            int nombreJours = 0;
            double kWh = 0.0;
            double seuil = 0.0;
            double acces = 0.0;
            double total = 0.0;

            Console.WriteLine("Combien de jours : ");
            int.TryParse(Console.ReadLine(), out nombreJours);

            Console.WriteLine("Combien de kWh : ");
            double.TryParse(Console.ReadLine(), out kWh);

            seuil = nombreJours * 40;
            acces = nombreJours * 0.42238;
            total = total + acces;

            if (kWh < seuil)
            {
                total = total + kWh * 0.06319;
            }
            else 
            {
                total = total + seuil * 0.06319;
                total = total + (kWh - seuil) * 0.09749;
            }
        }

        // Jeux pair ou impair
        // Le premier joueur choisi 0 ou 1
        // Le premier joueur choisi pair ou impair
        // On efface la console
        // Le deuxième joueur choisi 0 ou 1
        // On affiche le gagnant selon la somme des deux nombres
        // Si la sommme correspond au type de résultat choisi par le premier joueur (pair ou impair) il a gagné
        // Sinon le 2ème joueur a gagné
        static void ex6()
        {
            int nbJoueur1 = 0;
            int nbJoueur2 = 0;
            string pairImpair = "pair";

            Console.WriteLine("Joueur 1 choisi 1 ou 0");
            int.TryParse(Console.ReadLine(), out nbJoueur1);

            Console.WriteLine("Joueur 1 choisi pair/impair");
            pairImpair = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Joueur 2 choisi 1 ou 0");
            int.TryParse(Console.ReadLine(), out nbJoueur2);

            Console.Clear();

            if ((nbJoueur1 + nbJoueur2) % 2 == 0)
            {
                if (pairImpair == "pair")
                {
                    Console.WriteLine("Joueur 1 gagne!");
                }
                else
                {
                    Console.WriteLine("Joueur 2 gagne!");
                }
            }
            else
            {
                if (pairImpair == "impair")
                {
                    Console.WriteLine("Joueur 1 gagne!");
                }
                else
                {
                    Console.WriteLine("Joueur 2 gagne!");
                }
            }
        }

        // Pour être admis en médecine il faut 
        // Une cote R au-dessus de 33.0
        // Une note supérieure à 70% en biologie, chimie et mathématiques
        // Une moyenne supérieure à 80% pour les 3 cours précédents
        // Écrire le programme qui détermine si l'utilisateur est éligible
        static void ex7()
        {
            double coteR = 0.0;
            double bio = 0.0;
            double chimie = 0.0;
            double math = 0.0;
            double moyenne = 0.0;
            bool admissible = true;

            Console.WriteLine("Entrer la cote R");
            double.TryParse(Console.ReadLine(), out coteR);

            Console.WriteLine("Entrer la note de biologie");
            double.TryParse(Console.ReadLine(), out bio);

            Console.WriteLine("Entrer la note de chimie");
            double.TryParse(Console.ReadLine(), out chimie);

            Console.WriteLine("Entrer la note de math");
            double.TryParse(Console.ReadLine(), out math);

            moyenne = (bio + chimie + math) / 3;

            if (coteR < 33.0)
            {
                admissible = false;
            }
            else if (moyenne < 80.0)
            {
                admissible = false;
            }
            else
            {
                if (bio < 70.0)
                {
                    admissible = false;
                }
                if (chimie < 70.0)
                {
                    admissible = false;
                }
                if (math < 70.0)
                {
                    admissible = false;
                }
            }

            if (admissible)
            {
                Console.WriteLine("Tu peux aller en médecine");
            }
            else
            {
                Console.WriteLine("Tu devras te contenter d'attendre à l'urgence");
            }
        }
    }
}