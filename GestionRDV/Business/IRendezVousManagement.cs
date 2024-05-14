using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionRDV.Common;

namespace GestionRDV.Business
{
    public interface IRendezVousManagement
    {
        public string AjouterRendezVous(RendezVous rendezVous);
        public void AfficherRendezVous();
        public string MettreAJourRendezVous(RendezVous rendezVous);
        public bool ExistRendezVous(int id);
        
            
    }
}
