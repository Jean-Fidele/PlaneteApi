namespace Domain.Entites.Objets
{
    using System.ComponentModel.DataAnnotations;

    public class Domaine
    {
        public int DomaineId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
    }
}
