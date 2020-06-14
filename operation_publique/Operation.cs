using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_voiture.operation_publique
{
    class Operation
    {
        /// <summary>
        /// fonction pour entrer une vlaeur dans un variable string
        /// </summary>
        /// <returns></returns>
        public static string enregistrer_variable_string()
        {
            string votreVariable = Console.ReadLine(); // Pour variable string
            //Console.WriteLine(votreVariable); // afficher la variable entree
            //verification si la valeur entree est bien un string
            while (!(votreVariable is string))
            {
                Console.WriteLine("Erreur vous devez entrez une valeur string");
                votreVariable = Console.ReadLine(); // Pour variable string
            }
            //retourne une variable string 
            return votreVariable;
        }

        /// <summary>
        /// fonction pour entrer une vlaeur dans un variable int
        /// </summary>
        /// <returns></returns>
        public static int enregistrer_variable_int()
        {
            int votreVariable = int.Parse(Console.ReadLine()); // Pour variable int
            //verification si la valeur entree est bien un integer
            while (!(votreVariable is int))
            {
                Console.WriteLine("Erreur vous devez entrez une valeur integer");
                votreVariable = int.Parse(Console.ReadLine()); // Pour variable int
            }
            //Console.WriteLine(votreVariable); // afficher la variable entree
            //retourne une variable integer 
            return votreVariable;
        }

        /// <summary>
        /// fonction pour entrer une vlaeur dans un variable booleen
        /// </summary>
        /// <returns></returns>
        public static bool enregistrer_variable_bool()
        {
            int votreVariable = int.Parse(Console.ReadLine()); // prendre un variable int
            //verification si la valeur entree est bien un 0 ou integer
            while (!(votreVariable is int))
            {
                Console.WriteLine("Erreur vous devez entrez une " +
                    "valeur integer(0 pour faux->non et autre valeur pour vrai->oui:");
                votreVariable = int.Parse(Console.ReadLine()); // Pour variable int
            }
            //Console.WriteLine(votreVariable); // afficher la variable entree
            //transforme la variable integer en booleen
            bool variable = Convert.ToBoolean(votreVariable);//transforme en boolean ex 1 en true
            //retourne la variable booleen
            return variable;

        }

        /// <summary>
        /// fonction pour le melange de mot
        /// </summary>
        /// <param name="word"></le mot a melange qui est en format string>
        /// <returns></returns>
        public static string mot_melange(string word)
        {
            char[] chars = new char[word.Length];
            Random rand = new Random(10000);
            int index = 0;
            while (word.Length > 0)
            { // Prend un nombre aléatoire compris entre 0 et la longueur du mot.
                int next = rand.Next(0, word.Length - 1); //Prend le personnage de la position aléatoire 
                                                          //Ajout notre charactere en un variable tableau array
                chars[index] = word[next];                // Supprimer le charactere du variable word. 
                word = word.Substring(0, next) + word.Substring(next + 1);
                ++index;
            }
            //retourne le charactere melange en variable string;
            return new String(chars);
        }

    }
}
