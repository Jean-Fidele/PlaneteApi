namespace Domain.Entites
{
    using System.Collections.Generic;

    public class Produit
    {
        public Produit()
        {
            ProdCatTarifaire = new HashSet<ProdCatTarifaire>();
            PromoTarif = new HashSet<PromoTarif>();
            ClientTarif = new HashSet<ClientTarif>();
            TypetiersTarif = new HashSet<TypetiersTarif>();
            Reservation = new HashSet<Reservation>();
            ProduitTarif = new HashSet<ProduitTarif>();
        }
        public int ProduitId { get; set; }
        public int? FamilleId { get; set; }
        public int? CategorieId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string TypeProduit { get; set; }
        public bool? LoadSite { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Fichier1 { get; set; }
        public string Fichier2 { get; set; }
        public string Fichier3 { get; set; }
        public bool? LoadPlanning { get; set; }
        public int? Nombre { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual ICollection<ProdCatTarifaire> ProdCatTarifaire { get; set; }
        public virtual ICollection<PromoTarif> PromoTarif { get; set; }
        public virtual ICollection<ClientTarif> ClientTarif { get; set; }
        public virtual ICollection<TypetiersTarif> TypetiersTarif { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<ProduitTarif> ProduitTarif { get; set; }
    }
}
