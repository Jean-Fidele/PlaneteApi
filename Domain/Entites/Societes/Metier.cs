namespace Domain.Entites.Societes
{
    using System.Collections.Generic;

    public class Metier
    {
        public Metier()
        {
            Collaborateurs = new HashSet<Collaborateur>();
        }

        public int MetierId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Collaborateur> Collaborateurs { get; set; }
    }
}
