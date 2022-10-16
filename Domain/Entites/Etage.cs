namespace Domain.Entites
{
    using System.Collections.Generic;

    public class Etage
    {
        public Etage()
        {
            Chambre = new HashSet<Chambre>();
        }

        public int EtageId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Chambre> Chambre { get; set; }
    }
}
