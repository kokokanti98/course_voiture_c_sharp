using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_voiture.userinterface
{
    class Userinterface
    {
        /// <summary>
        /// constructeur de la classe Userinterface
        /// </summary>
        public Userinterface()
        {
        }
        /// <summary>
        /// fonction pour afficher un texte au joueur
        /// </summary>
        /// <parametre name="texte"></le texte a afficher>
        public static void displayinfo(params string[] texte)
        {


            foreach (string i in texte)
            {
                System.Console.Write("{0}", i);//affiche avec {0} espacement sur meme ligne
            }
            Console.WriteLine();
            //Console.ReadLine();
        }
    }
}
