namespace Domain.Entites
{
    public class ConfigMail
    {
        public int ConfigMailId { get; set; }
        public string Serveur { get; set; }
        public string Expediteur { get; set; }
        public int Port { get; set; }
        public string Utilisateur { get; set; }
        public string Password { get; set; }
        public bool? EstEnvoye { get; set; }
    }
}
