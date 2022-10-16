namespace Domain.Entites
{
    using System.Collections.Generic;

    public class FormeJuridique
    {
        public FormeJuridique()
        {
            Societes = new HashSet<Societe>();
        }
        public int FormeJuridiqueId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Societe> Societes { get; set; }
    }
}
