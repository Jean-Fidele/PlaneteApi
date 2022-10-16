namespace Domain.Entites
{
    using System.Collections.Generic;

    public class Categorie
    {
        public Categorie()
        {
            Produits = new HashSet<Produit>();
        }
        public int CategorieId { get; set; }
        public int? DomaineId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual Domaine Domaine { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
