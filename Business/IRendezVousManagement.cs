using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;



namespace Business
{
    /// <summary>
    /// Interface pour les méthodes Rendez-vous
    /// </summary>
    public interface IRendezVousManagement 
    {
        public List<RendezVous> RendezVousList { get; set; }
        /// <summary>
        /// Méthode ajouter un rendez-vous à la liste de rendez-vous de Rendez-Vous Management
        /// </summary>
        /// <param name="rendezVous"></param>
        /// <returns></returns>
        public string AjouterRendezVous(RendezVous rendezVous);
        /// <summary>
        /// Méthode pour afficher les rendez-vous déja ajoutés, provient de RendezVousManagement
        /// </summary>
        public void AfficherRendezVous();
        /// <summary>
        /// Méthode pour mettre a jour les rendez-vous déja ajoutés, provient de RendezVousManagement
        /// </summary>
        /// <param name="rendezVous"></param>
        /// <returns></returns>
        public string MettreAJourRendezVous(RendezVous rendezVous);
        /// <summary>
        /// Méthode pour supprimer un rendez-vous de la liste de rendez-vous de Rendez-Vous Management
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ExistRendezVous(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void SupprimerRendezVous(Common.RendezVous rendezVous);
        
            
    }
}
