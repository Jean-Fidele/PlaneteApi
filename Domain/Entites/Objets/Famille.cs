namespace Domain.Entites.Objets
{
    public class Famille
    {
        public int FamilleId { get; set; }
        public int? ParentId { get; set; }
        public int? DomaineId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string ParentLibelle { get; set; }
        public virtual Domaine Domaine { get; set; }
    }
}
