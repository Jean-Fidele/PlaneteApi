namespace Domain.Entites
{
    using System.Collections.Generic;

    public class Objet
    {
        public Objet()
        {
            Maintenance = new HashSet<Maintenance>();
            OptionsObjets = new HashSet<OptionsObjets>();
            ObjetProduits = new HashSet<ObjetProduit>();
        }

        public int ObjetId { get; set; }
        public int? DomaineId { get; set; }
        public int? TypeObjetId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public int? Capacite { get; set; }
        public bool? PlanningLoad { get; set; }
        public byte EnMaintenance { get; set; }
        public string Statut { get; set; }
        public virtual Domaine Domaine { get; set; }
        public virtual ICollection<Maintenance> Maintenance { get; set; }
        public virtual ICollection<OptionsObjets> OptionsObjets { get; set; }
        public virtual TypeObjet TypeObjet { get; set; }
        public virtual ICollection<ObjetProduit> ObjetProduits { get; set; }
    }
}
