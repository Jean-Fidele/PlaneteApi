namespace Domain.Entites.Produits
{
    public class ProduitComposant
    {
        public int ProduitComposantId { get; set; }
        public int? ProduitComposantParentId { get; set; }
        public int? ProduitComposantFilsId { get; set; }
        public int? QteFils { get; set; }
    }
}
