namespace Domain.Entites
{
    public class Chambre
    {
        public int ChambreId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public int? EtageId { get; set; }
        public virtual Etage Etage { get; set; }
    }
}
