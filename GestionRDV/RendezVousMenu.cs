using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Common;
using Microsoft.Extensions.DependencyInjection;
using Services;


namespace GestionRDV
{
    public class RendezVousMenu
    {
      
        public RendezVousMenu()
        {
            
        }
        /// <summary>
        /// List d'objets RendezVous pour stocker les rendez-vous
        /// </summary>
        public static List<RendezVous> RendezVousList { get; set; } = new List<RendezVous>();

        public static void Menu()
        {
            var serviceProvider = new ServiceCollection().AddSingleton<IRendezVousManagement, RendezVousManagement>().BuildServiceProvider();
            var _rendezVousManagement = serviceProvider.GetService<IRendezVousManagement>();
            /// Menu principal pour gérer les rendez-vous
            Console.WriteLine("Bienvenue dans le gestionnaire de rendez-vous");
            while (true)
            {
                Console.WriteLine("1. Ajouter un rendez-vous");
                Console.WriteLine("2. Afficher les rendez-vous");
                Console.WriteLine("3. Mettre à jour un rendez-vous");
                Console.WriteLine("4. Supprimer un rendez-vous");
                Console.WriteLine("5. Quitter");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        /// Demmande des informations du rendez-vous à ajouter et appel de la méthode AjouterRendezVous avec les attributs du rendez-vous
                        Console.WriteLine("Ajouter les informations du rendez-vous à poser");
                        Console.WriteLine("Entrer l'ID du rendez-vous *Obligatoire*");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer la date du rendez-vous (exemple : 05)");
                        string date = Console.ReadLine();
                        Console.WriteLine("Entrer le mois du rendez-vous (exemple : 01 pour janvier");
                        string month = Console.ReadLine();
                        Console.WriteLine("Entrer l'heure du rendez-vous (Format 00:00");
                        string hour = Console.ReadLine();
                        Console.WriteLine("Entrer le nom du rendez-vous");
                        string name = Console.ReadLine();
                        Console.WriteLine("Entrer la description du rendez-vous");
                        string description = Console.ReadLine();
                        RendezVous rendezVous = new RendezVous()
                        {
                            Id = id,
                            DateDay = date,
                            DateMonth = month,
                            Hour = hour,
                            Name = name,
                            Description = description
                        };

                        _rendezVousManagement.AjouterRendezVous(rendezVous);
                        break;
                    case 2:
                        Console.Clear();
                        /// Appel de la méthode AfficherRendezVous
                        Console.WriteLine("Liste des rendez-vous");
                        _rendezVousManagement.AfficherRendezVous();
                        break;
                    case 3:
                        Console.Clear();
                        /// Appel pour mettre à jour un rendez-vous
                        Console.WriteLine("Mettre à jour un rendez-vous");
                        Console.WriteLine("Entrer l'ID du rendez-vous à mettre à jour");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le nom du rendez-vous");
                        string nameToUpdate = Console.ReadLine();
                        Console.WriteLine("Entrer la description du rendez-vous");
                        string descriptionToUpdate = Console.ReadLine();
                        Console.WriteLine("Entrer la date du rendez-vous (exemple : 05)");
                        string dateToUpdate = Console.ReadLine();
                        Console.WriteLine("Entrer le mois du rendez-vous (exemple : 01 pour janvier");
                        string monthToUpdate = Console.ReadLine();
                        Console.WriteLine("Entrer l'heure du rendez-vous (Format 00:00");
                        string hourToUpdate = Console.ReadLine();
                        /// Transformation des données récupérées en objet RendezVous et appel de la méthode MettreAJourRendezVous
                        RendezVous rendezVousToUpdate = new RendezVous()
                        {
                            Id = idToUpdate,
                            Name = nameToUpdate,
                            Description = descriptionToUpdate,
                            DateDay = dateToUpdate,
                            DateMonth = monthToUpdate,
                            Hour = hourToUpdate
                        };
                        _rendezVousManagement.MettreAJourRendezVous(rendezVousToUpdate);
                        break;

                    case 4:
                        Console.Clear();
                        /// Demmande de l'ID du rendez-vous à supprimer et appel de la méthode SupprimerRendezVous avec l'attribut de l'ID du rendez-vous
                        Console.WriteLine("Entrez l'ID du rendez-vous à supprimer");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());
                        RendezVous rendezVoustoDelete = _rendezVousManagement.RendezVousList.FirstOrDefault(r => r.Id == idToDelete);
                        if (rendezVoustoDelete != null)
                        {
                            _rendezVousManagement.SupprimerRendezVous(rendezVoustoDelete);
                            Console.WriteLine("Rendez-vous supprimé avec succès");
                        }
                        else
                        {
                            Console.WriteLine("Rendez-vous non trouvé");
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }
            }
        }
    }
}
