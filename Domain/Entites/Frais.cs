namespace Domain.Entites
{
    public class Frais
    {
        public int FraisId { get; set; }
        public decimal? FraisAnnule { get; set; }
        public decimal? FraisModif { get; set; }
        public bool? AppliAnnule { get; set; }
        public bool? AppliModif { get; set; }
    }
}
