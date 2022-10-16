namespace Domain.Entites.Objets
{
    using System.Collections.Generic;

    public class Option
    {
        public Option()
        {
            OptionLists = new HashSet<OptionList>();
            OptionsObjets = new HashSet<OptionsObjets>();
        }

        public int OptionobjetId { get; set; }
        public int? DomaineId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string TypeOption { get; set; }
        public virtual Domaine Domaine { get; set; }
        public virtual ICollection<OptionList> OptionLists { get; set; }
        public virtual ICollection<OptionsObjets> OptionsObjets { get; set; }
    }
}
