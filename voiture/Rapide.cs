using course_voiture.terrain;
using course_voiture.userinterface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace course_voiture.voiture
{
    class Rapide : Voiture
    {
        /// <summary>
        /// constructeur
        /// </summary>
        /// <parametre name="p_couleur"></le couleur de la voiture>
        public Rapide(string p_couleur)
        {
            Console.WriteLine("Votre voiture rapide a ete cree elle est de couleur {0}", p_couleur);
        }
        /// <summary>
        /// fonction pour le parcours du terrain
        /// </summary>
        /// <parametre name="p_terrain_course"></objet terrain creer c est le terrain a parcourir>
        /// <parametre name="p_vitesse_moyenne"></la vitesse moyenne>
        protected override internal void parcours_terrain(Terrain p_terrain_course, int p_vitesse_moyenne)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            p_vitesse_moyenne = 28;
            while (p_terrain_course.distance > 0)
            {
                bool detruit = false;
                string partie_voiture = "";
                Reparation(100,detruit, partie_voiture);
                p_terrain_course.distance = p_terrain_course.distance - p_vitesse_moyenne;
                Console.WriteLine("Vitesse moyenne : {0}", p_vitesse_moyenne);
                Console.WriteLine("Distance restante: {0}", p_terrain_course.distance);
                Thread.Sleep(1000);
            }
            timer.Stop();
            // Format par defaut du Stopwatch.
            TimeSpan ts = timer.Elapsed;
            // Changement de format de heure,minute seconde.
            string elapsedTime = String.Format("{0:00} heures:{1:00} minutes:{2:00} secondes.{3:00} millisecondes",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Fin de la course votre temps de course est:");
            Console.WriteLine(elapsedTime);
        }
        /// <summary>
        /// fonction pour la reparation
        /// </summary>
        /// <param name="max_chance"></chance maximale>
        /// <param name="detruit"></un variable boolean si une partie de la voiture est casse ou pas>
        /// <param name="p_variable"></la variable qu'on va retrourner avec la fonction Variable_string>
        internal static void Reparation(int max_chance, bool detruit, string p_variable)
        {
            Random rnd = new Random();
            //car 1,13 donne un nb de 1 a 12 et si 52 ce sera de 0 a 51
            //on va supposer que max_chance et egale a 100 pour random value entre 0 et 100

            //si le nombre est entre 0 et 60 alors la piece de voiture est casse pour 60% 
            foreach (var value in Enum.GetValues(typeof(partie_voiture)))
            {
                //variable de chance maximale
                int chance = rnd.Next(max_chance + 1);
                //condition if avec la chance de panne d'une partie de la voiture
                if (0 <= chance && chance <= 60 && detruit == false)
                {
                    Console.WriteLine("Pas de chance votre piece {0} est detruit",
                        ((partie_voiture)value)
                    );
                    detruit = true;
                    //appel du fonction pour commencer la reparation
                    if (detruit == true)
                    {
                        Console.WriteLine("Veuillez entrez {0} pour poursuivre la course",
                            ((partie_voiture)value));
                        string votreVariable = Console.ReadLine();
                        p_variable = Variable_string(p_variable, (int)value);
                        //verification si la valeur entree est le meme et reentre si ce n'est pas le cas
                        while (votreVariable != p_variable)
                        {
                            Console.WriteLine("Erreur!! Veuillez entrez {0} pour poursuivre la course",
                                 ((partie_voiture)value));
                            votreVariable = Console.ReadLine();
                        }
                    }
                    //Operation_construction(i, p_key1, p_key2, p_dico1, p_dico2, detruit, p_pareil_chg, p_presence);
                    break;
                }
                else
                {
                    detruit = false;
                }
            }
        }
        //j'ai fait cette fonction pour l enum utilise afin de faire la comparaison dans la fonction reparation elle retourne un string
        /// <summary>
        /// fonction qui retourne un string à l 'aide de l'enum de la partie_voirture qui sera utile dans la condition de reparation
        /// </summary>
        /// <param name="p_voiture"></ le string retourner>
        /// <param name="p_value"></une cle enum de la voiture>
        /// <returns></returns>
        protected static string Variable_string(string p_voiture, int p_value){
            switch (p_value)
            {
                case 0:
                    p_voiture = "pneu_avant_droit";
                    Console.WriteLine(p_voiture);
                    break;
                case 1:
                    p_voiture = "pneu_avant_gauche";
                    Console.WriteLine(p_voiture);
                    break;
                case 2:
                    p_voiture = "pneu_derriere_droit";
                    Console.WriteLine(p_voiture);
                    break;
                case 3:
                    p_voiture = "pneu_derriere_gauche";
                    Console.WriteLine(p_voiture);
                    break;
                case 4:
                    p_voiture = "frein_principale";
                    Console.WriteLine(p_voiture);
                    break;
                case 5:
                    p_voiture = "frein_main";
                    Console.WriteLine(p_voiture);
                    break;
                case 6:
                    p_voiture = "moteur";
                    Console.WriteLine(p_voiture);
                    break;
                case 7:
                    p_voiture = "volant";
                    Console.WriteLine(p_voiture);
                    break;
                default:
                    p_voiture = "Default case";
                    Console.WriteLine(p_voiture);
                    break;
            }
            return p_voiture;
        }
    }
}
