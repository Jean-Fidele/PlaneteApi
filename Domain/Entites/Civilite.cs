namespace Domain.Entites
{
    using System.Collections.Generic;

    public class Civilite
    {
        public Civilite()
        {
            Contacts = new HashSet<Contact>();
        }
        public int CiviliteId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
