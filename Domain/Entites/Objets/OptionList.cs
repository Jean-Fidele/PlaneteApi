namespace Domain.Entites.Objets
{
    public class OptionList
    {
        public int OptionListId { get; set; }
        public int? OptionId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual Option Option { get; set; }
    }
}
