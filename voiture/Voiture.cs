using course_voiture.terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_voiture.voiture
{
    abstract class Voiture
    {
        /// <summary>
        /// constructeur de la class abstraite mere voiture
        /// </summary>
        protected Voiture()
        {

        }
        /// <summary>
        /// les partie de la voiture
        /// </summary>
        //les parties de la voiture
        protected enum partie_voiture
        {
            pneu_avant_droit,
            pneu_avant_gauche,
            pneu_derriere_droit,
            pneu_derriere_gauche,
            frein_principale,
            frein_main,
            moteur,
            volant
        }
        protected abstract internal void parcours_terrain(Terrain p_terrain_course ,int p_vitesse);
    }
}
