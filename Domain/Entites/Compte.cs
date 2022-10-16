namespace Domain.Entites
{
    public class Compte
    {
        public int CompteId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Sens { get; set; }
        public bool? Auxiliaire { get; set; }
    }
}
