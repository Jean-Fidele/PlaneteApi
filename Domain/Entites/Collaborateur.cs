namespace Domain.Entites
{
    public class Collaborateur
    {
        public int CollaborateurId { get; set; }
        public int? ServiceId { get; set; }
        public int? DepartementId { get; set; }
        public int? MetierId { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Adresse { get; set; }
        public virtual Metier Metier { get; set; }
        public virtual Service Service { get; set; }
    }
}
