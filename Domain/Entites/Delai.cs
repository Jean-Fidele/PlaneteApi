namespace Domain.Entites
{
    public class Delai
    {
        public int DelaiId { get; set; }
        public string Deconexion { get; set; }
        public string EnArrive { get; set; }
        public string EnDepart { get; set; }
        public bool? Active { get; set; }
        public int? Resa { get; set; }
        public int? Modifie { get; set; }
        public int? Annule { get; set; }
    }
}
