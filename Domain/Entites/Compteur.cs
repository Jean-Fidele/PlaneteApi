namespace Domain.Entites
{
    using System.Collections.Generic;

    public class Compteur
    {
        public Compteur()
        {
            CategFacturations = new HashSet<CategFacturation>();
        }
        public int CompteurId { get; set; }
        public string Code { get; set; }
        public string Prefixe { get; set; }
        public string Suffixe { get; set; }
        public string Separateur { get; set; }
        public string Libelle { get; set; }
        public int? NbSuffixe { get; set; }
        public string Table { get; set; }
        public virtual ICollection<CategFacturation> CategFacturations { get; set; }
    }
}
