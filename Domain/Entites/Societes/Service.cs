namespace Domain.Entites.Societes
{
    public class Service
    {
        public int ServiceId { get; set; }
        public int DepartementId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public virtual Departement Departement { get; set; }
    }
}
