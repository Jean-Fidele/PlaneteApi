namespace Domain.Entites.Objets
{
    using System.Collections.Generic;

    public class Outillage
    {
        public Outillage()
        {
            Utilises = new HashSet<Utilise>();
        }
        public int OutillageId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Utilise> Utilises { get; set; }
    }
}
