namespace Domain.Entites.Objets
{
    using System.Collections.Generic;

    public class TypeObjet
    {
        public TypeObjet()
        {
            Objet = new HashSet<Objet>();
        }
        public int TypeObjetId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Objet> Objet { get; set; }
    }
}
