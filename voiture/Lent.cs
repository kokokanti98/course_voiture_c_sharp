using course_voiture.operation_publique;
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
    class Lent : Voiture
    {
        /// <summary>
        /// constructeur
        /// </summary>
        /// <parametre name="p_couleur"></le couleur de la voiture>
        public Lent(string p_couleur)
        {
            Console.WriteLine("Votre voiture lent a ete cree elle est de couleur {0}", p_couleur);
        }
        /// <summary>
        /// fonction pour le parcours du terrain
        /// </summary>
        /// <parametre name="p_terrain_course"></objet terrain creer c est le terrain a parcourir>
        /// <parametre name="p_vitesse_moyenne"></la vitesse moyenne>
        protected override internal void parcours_terrain(Terrain p_terrain_course , int p_vitesse_moyenne)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (p_terrain_course.distance > 0)
            {
                bool boost = false;
                p_vitesse_moyenne = 14;
                p_vitesse_moyenne = Boost_vitesse(100, boost, p_vitesse_moyenne);
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
        /// fonction pour le boost de vitesse
        /// </summary>
        /// <parametre name="max_chance"></chance maximale quand j ai appele j y ai mis 100 pour 100%>
        /// <parametre name="p_boost"></variable boolean pour verifier si boost est activer>
        /// <parametre name="vitesse"></variable de la vitesse_moyenne qui change d apres les condition de boost>
        /// <returns></returns>
        internal static int Boost_vitesse(int max_chance, bool p_boost , int vitesse)
        {
            Random rnd = new Random();
            int chance = rnd.Next(max_chance + 1);
            //car 1,13 donne un nb de 1 a 12 et si 52 ce sera de 0 a 51
            //on va supposer que max_chance et egale a 100 pour random value entre 0 et 100
            //si le nombre est entre 0 et 60 alors la piece de voiture est casse pour 60%
            if (0 <= chance && chance <= 30 && p_boost == false)
            {
                p_boost = Ok_vitesse(p_boost);
                Console.WriteLine(p_boost);
                if (true)
                {
                    vitesse = 33;
                }
                else if (false)
                {
                    vitesse = 14;
                }
                else
                {
                    Console.WriteLine("ni l un ni l autre");
                }
            }
            return vitesse;
        }
        /// <summary>
        /// fonciton qui retourn un boolean pour savoir si la vitesse apres sera active(1 des conditions d activation)
        /// </summary>
        /// <param name="p_boost"></variable boolean pour le boost de vitesse>
        /// <returns></returns>
        protected static bool Ok_vitesse(bool p_boost)
        {

            Stopwatch time_boost = new Stopwatch();
            //debut d'un timer pour compter les 3 secondes
            time_boost.Start();
            TimeSpan ts = time_boost.Elapsed;
            //Ici on va commencer le melange de mot pour VITESSE
            string mot = "VITESSE";
            //j ai creer 4 mot_melange different car ca renvoie le meme mot melange a chq fois suivi d'un switch pour l'application
            string mot_melange = Operation.mot_melange(mot);
            string mot_melange1 = Operation.mot_melange(mot_melange);
            string mot_melange2 = Operation.mot_melange(mot_melange1);
            string mot_melange3 = Operation.mot_melange(mot_melange2);
            string mot_melange4 = Operation.mot_melange(mot_melange3);
            Random rnd = new Random();
            int chance = rnd.Next(4);
            //car 1,13 donne un nb de 1 a 12 et si 52 ce sera de 0 a 51
            //on va supposer que max_chance et egale a 100 pour random value entre 0 et 100
            //si le nombre est entre 0 et 60 alors la piece de voiture est casse pour 60%
            
            switch (chance)
            {
                 
                case 0:
                    //Ici s'arrete le mot avec un variable string qu 'on recoit du mot_melangee avec le mot VITESSE melange
                    Console.WriteLine("Bravo entrez {0}  dans les 3 secondes qui suivent pour" +
                        "avoir un booste de vitesse :", mot_melange);
                    string votreVariable = Operation.enregistrer_variable_string();
                    Console.WriteLine(time_boost.ElapsedMilliseconds);
                    if (time_boost.ElapsedMilliseconds <= 3000 && votreVariable == mot_melange)
                    {
                        p_boost = true;
                        Console.WriteLine(mot_melange);

                    }
                    else
                    {
                        p_boost = false;
                        Console.WriteLine(mot_melange);

                    }
                    break;
                case 1:
                    //Ici s'arrete le mot avec un variable string qu 'on recoit du mot_melangee avec le mot VITESSE melange
                    Console.WriteLine("Bravo entrez {0}  dans les 3 secondes qui suivent pour" +
                        "avoir un booste de vitesse :", mot_melange1);
                    string votreVariable1 = Operation.enregistrer_variable_string();
                    Console.WriteLine(time_boost.ElapsedMilliseconds);
                    if (time_boost.ElapsedMilliseconds <= 3000 && votreVariable1 == mot_melange1)
                    {
                        p_boost = true;
                        Console.WriteLine(mot_melange1);

                    }
                    else
                    {
                        p_boost = false;
                        Console.WriteLine(mot_melange1);

                    }
                    break;
                case 2:
                    //Ici s'arrete le mot avec un variable string qu 'on recoit du mot_melangee avec le mot VITESSE melange
                    Console.WriteLine("Bravo entrez {0}  dans les 3 secondes qui suivent pour" +
                        "avoir un booste de vitesse :", mot_melange2);
                    string votreVariable2 = Operation.enregistrer_variable_string();
                    Console.WriteLine(time_boost.ElapsedMilliseconds);
                    if (time_boost.ElapsedMilliseconds <= 3000 && votreVariable2 == mot_melange2)
                    {
                        p_boost = true;
                        Console.WriteLine(mot_melange2);

                    }
                    else
                    {
                        p_boost = false;
                        Console.WriteLine(mot_melange2);

                    }
                    break;
                case 3:
                    //Ici s'arrete le mot avec un variable string qu 'on recoit du mot_melangee avec le mot VITESSE melange
                    Console.WriteLine("Bravo entrez {0}  dans les 3 secondes qui suivent pour" +
                        "avoir un booste de vitesse :", mot_melange3);
                    string votreVariable3 = Operation.enregistrer_variable_string();
                    Console.WriteLine(time_boost.ElapsedMilliseconds);
                    if (time_boost.ElapsedMilliseconds <= 3000 && votreVariable3 == mot_melange3)
                    {
                        p_boost = true;
                        Console.WriteLine(mot_melange3);

                    }
                    else
                    {
                        p_boost = false;
                        Console.WriteLine(mot_melange3);

                    }
                    break;
                case 4:
                    //Ici s'arrete le mot avec un variable string qu 'on recoit du mot_melangee avec le mot VITESSE melange
                    Console.WriteLine("Bravo entrez {0}  dans les 3 secondes qui suivent pour" +
                        "avoir un booste de vitesse :", mot_melange4);
                    string votreVariable4 = Operation.enregistrer_variable_string();
                    Console.WriteLine(time_boost.ElapsedMilliseconds);
                    if (time_boost.ElapsedMilliseconds <= 3000 && votreVariable4 == mot_melange4)
                    {
                        p_boost = true;
                        Console.WriteLine(mot_melange4);

                    }
                    else
                    {
                        p_boost = false;
                        Console.WriteLine(mot_melange4);

                    }
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }

            //arret du timer
            time_boost.Stop();
            mot_melange=null;
            return p_boost;
        }
    }
}
