namespace Domain.Entites.Frais
{
    public class TaxeListe
    {
        public int TaxeListeId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string TypeTaxe { get; set; }
        public string Expression { get; set; }
        public string Compte { get; set; }
        public decimal? Valeur { get; set; }
    }
}
