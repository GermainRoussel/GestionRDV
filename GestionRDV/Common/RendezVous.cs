using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRDV.Common
{
    /// <summary>
    /// Classe RendezVous qui contient les attributs d'un rendez-vous
    /// </summary>
    public class RendezVous
    {
        /// <summary>
        /// Attribut ID qui est l'identifiant du rendez-vous
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Attribut DateDay qui est le jour de date du rendez-vous
        /// </summary>
        public string DateDay { get; set; }
        /// <summary>
        /// Attribut DateMonth qui est le mois du rendez-vous
        /// </summary>
        public string DateMonth { get; set; }
        /// <summary>
        /// Attribut Hour qui est l'heure du rendez-vous
        /// </summary>

        public string Hour { get; set; }
        /// <summary>
        /// Attribut Name qui est le nom donné au rendez-vous
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Attribut Description qui est la description du rendez-vous
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructeur vide de la classe RendezVous
        /// </summary>
        public RendezVous()
        {

        }

    }
}
