using Domain.Entites.Societes.Config;

namespace Domain.Entites.Societes
{
    public class CategFacturation
    {
        public int CategFacturationId { get; set; }
        public int? CompteurId { get; set; }
        public string Libelle { get; set; }
        public int? NbExemplaire { get; set; }
        public string MiseEnPage { get; set; }
        public string Periodicite { get; set; }
        public string CodeFact { get; set; }
        public virtual Compteur Compteur { get; set; }
    }
}
