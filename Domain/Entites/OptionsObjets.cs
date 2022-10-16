namespace Domain.Entites
{
    public class OptionsObjets
    {
        public int OID_RELATION { get; set; }
        public int? ObjetId { get; set; }
        public int? OptionId { get; set; }
        public string Valeur { get; set; }
        public virtual Objet Objet { get; set; }
        public virtual Option Option { get; set; }
    }
}
