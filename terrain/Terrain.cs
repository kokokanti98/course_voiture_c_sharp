using course_voiture.operation_publique;
using course_voiture.userinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_voiture.terrain
{
    class Terrain
    {
 
        public int distance;// la distance a parcourir qui sera en metre
        /// <summary>
        /// contructeur de la classe terrain
        /// </summary>
        public Terrain()
        {
            Userinterface.displayinfo("Bonjour MR/MME nous allons tout d abord creer votre terrain");
            Userinterface.displayinfo("Entrez la distance voulue en metre:");
            distance = Operation.enregistrer_variable_int();
        }
    }
}
