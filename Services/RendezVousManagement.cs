using Business;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Services
{   
    /// <summary>
    /// Classe pour gérer la gestion des rendez-vous
    /// </summary>
    public class RendezVousManagement : IRendezVousManagement
    {
      
        public RendezVousManagement()
        {
        }
        /// <summary>
        /// Liste des objets RendezVous
        /// </summary>
        public List<RendezVous> RendezVousList { get; set; } = new List<RendezVous>();
        /// <summary>
        /// Méthode pour ajouter un rendez-vous à la liste
        /// </summary>
        /// <param name="rendezVous">
        /// Prend en paramètre RendezVous qui doit avoir les attributs de RendezVous</param>
        public void AjouterRendezVous(RendezVous rendezVous)
        {
            if (ExistRendezVous(rendezVous.Id))
            { 
                RendezVousList.Add(rendezVous); 
                Console.WriteLine("Rendez-vous ajouté avec succès");
            }
            else
            {
                Console.WriteLine("Un rendez-vous avec cet ID existe déja");
            }
        }
        /// <summary>
        /// Méthode pour afficher les rendez-vous déja ajoutés
        /// </summary>
        public void AfficherRendezVous()
        {
            foreach (RendezVous rendezVous in RendezVousList)
            {
                Console.WriteLine("Information du rendez-vous");
                Console.WriteLine("ID: " + rendezVous.Id);
                Console.WriteLine("Date: " + rendezVous.DateDay);
                Console.WriteLine("Mois: " + rendezVous.DateMonth);
                Console.WriteLine("Heure: " + rendezVous.Hour);
                Console.WriteLine("Nom: " + rendezVous.Name);
                Console.WriteLine("Description: " + rendezVous.Description);
            }
        }
        /// <summary>
        /// Méthode pour mettre a jour les rendez-vous déja ajoutés
        /// </summary>
        /// <param name="rendezVous"></param>
        /// <returns></returns>
        public string MettreAJourRendezVous(RendezVous rendezVous)
        {
            var rendezVousToUpdate = RendezVousList.Find(x => x.Id == rendezVous.Id);
            if (rendezVousToUpdate == null)
            {
                return "Rendez-vous non trouvé";
            }
            rendezVousToUpdate.Name = rendezVous.Name;
            rendezVousToUpdate.Description = rendezVous.Description;
            rendezVousToUpdate.DateDay = rendezVous.DateDay;
            rendezVousToUpdate.DateMonth = rendezVous.DateMonth;
            rendezVousToUpdate.Hour = rendezVous.Hour;
            return "Rendez-vous mis à jour avec succès" + rendezVousToUpdate.Name;
        }
        /// <summary>
        /// Méthode pour supprimer un rendez-vous de la liste
        /// </summary>
        /// <param name="rendezVous"></param>
        public void SupprimerRendezVous(Common.RendezVous rendezVous)
        {
            RendezVousList.Remove(rendezVous);
        }
        /// <summary>
        /// Méthode pour vérifier si un rendez-vous existe déja avec cet ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ExistRendezVous(int id)
        {
            var existRendezVous = RendezVousList.Find(x => x.Id != id);
            if (existRendezVous == null)
            {
                return true;
            }
            return false;
        }

        string IRendezVousManagement.AjouterRendezVous(RendezVous rendezVous)
        {
            throw new NotImplementedException();
        }
    }
}
