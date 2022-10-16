namespace Domain.Entites
{
    public class ObjetProduit
    {
        public int ObjetProduitId { get; set; }
        public int? ObjetId { get; set; }
        public int? ProduitId { get; set; }
        public int NbProduit { get; set; }
        public virtual Objet Objet { get; set; }
    }
}
