namespace Domain.Entites
{
    public class Professionnel
    {
        public int ProfessionnelId { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Societe { get; set; }
        public string Pass { get; set; }
        public string Stat { get; set; }
        public string NIF { get; set; }
        public string Siren { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public int? PaysId { get; set; }
        public int? TypetiersId { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual Typetiers Typetiers { get; set; }
    }
}
