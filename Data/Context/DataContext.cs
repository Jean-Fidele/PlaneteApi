using Data.Mapping.Produits;
using Data.Mapping.Reservations;
using Data.Mapping.Societes;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /* SOCIETES */
            builder.ApplyConfiguration(new CategComptableMap());
            builder.ApplyConfiguration(new CategFacturationMap());
            builder.ApplyConfiguration(new CategHotelMap());
            builder.ApplyConfiguration(new CiviliteMap());
            builder.ApplyConfiguration(new CollaborateurMap());
            builder.ApplyConfiguration(new CompteMap());
            builder.ApplyConfiguration(new ContactMap());
            builder.ApplyConfiguration(new DepartementMap());
            builder.ApplyConfiguration(new FormeJuridiqueMap());
            builder.ApplyConfiguration(new MetierMap());
            builder.ApplyConfiguration(new PaysMap());
            builder.ApplyConfiguration(new ProfessionnelMap());
            builder.ApplyConfiguration(new ServiceMap());
            builder.ApplyConfiguration(new SocieteMap());

            /* RESERVATIONS */
            builder.ApplyConfiguration(new ClientMap());
            builder.ApplyConfiguration(new DelaiMap());
            builder.ApplyConfiguration(new FichierResaMap());
            builder.ApplyConfiguration(new FournisseurMap());
            builder.ApplyConfiguration(new IdentiteMap());
            builder.ApplyConfiguration(new PaiementModeMap());
            builder.ApplyConfiguration(new PlanningConsultMap());
            builder.ApplyConfiguration(new ReservationMap());
            builder.ApplyConfiguration(new ReservationMotifMap());
            builder.ApplyConfiguration(new StatutMap());

            /* PRODUITS */
            builder.ApplyConfiguration(new CategorieMap());
            builder.ApplyConfiguration(new CategTarifaireMap());
            builder.ApplyConfiguration(new ClientTarifMap());
            builder.ApplyConfiguration(new ProdCatTarifaireMap());
            builder.ApplyConfiguration(new ProduitComposantMap());
            builder.ApplyConfiguration(new ProduitMap());
            builder.ApplyConfiguration(new ProduitTarifMap());
            builder.ApplyConfiguration(new PromoTarifMap());
            builder.ApplyConfiguration(new TypetiersMap());
            builder.ApplyConfiguration(new TypetiersTarifMap());
            base.OnModelCreating(builder);
        }
    }
}
