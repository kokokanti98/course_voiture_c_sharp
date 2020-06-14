using course_voiture.operation_publique;
using course_voiture.terrain;
using course_voiture.userinterface;
using course_voiture.voiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_voiture
{
    class Program
    {
        //100km/h->33m/s
        //100km/h->28m/s
        //50km/h->14m/s
        static void Main(string[] args)
        {
            bool choix;//variable booleen pour le choix de voiture

            Terrain mario_map = new Terrain(); //creation du terrain à parcourir

            Userinterface.displayinfo("Choisissez votre type de voiture(lent->0 ou rapide->1)");

            choix = Operation.enregistrer_variable_bool();//enregistrement du choix

            Userinterface.displayinfo("Entrez maintenant la couleur choisie");

            string couleur = Operation.enregistrer_variable_string();// la enregistrement de 
            //la variable string couleur qui est la couleur de la voiture

            if (choix == true)
            {
                Rapide ma_voiture = new Rapide(couleur);  //creation de la classe fille voiture rapide
                ma_voiture.parcours_terrain(mario_map,28); //parcours du terrain
            }
            else
            {
                Lent ma_voiture = new Lent(couleur); //creation de la classe fille voiture lente
                ma_voiture.parcours_terrain(mario_map,14); //parcours du terrain
            }
            //liberer la variable couleur
            couleur = null;
            Console.ReadLine();
        }
    }
}
