namespace Domain.Entites.Produits
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CategTarifaire
    {
        public CategTarifaire()
        {
            ProdCatTarifaires = new HashSet<ProdCatTarifaire>();
        }
        public int CategTarifaireId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<ProdCatTarifaire> ProdCatTarifaires { get; set; }
    }
}
