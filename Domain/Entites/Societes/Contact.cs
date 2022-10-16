namespace Domain.Entites.Societes
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int? CiviliteId { get; set; }
        public int? PaysId { get; set; }
        public int? SocieteId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Fonction { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public virtual Civilite Civilite { get; set; }
        public virtual Societe Societe { get; set; }
        public virtual Pays Pays { get; set; }
    }
}
