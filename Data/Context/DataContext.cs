using Data.Mapping;
using Data.Mapping.Banques;
using Data.Mapping.Devises;
using Data.Mapping.Frais;
using Data.Mapping.Objets;
using Data.Mapping.Produits;
using Data.Mapping.Reservations;
using Data.Mapping.Societes;
using Microsoft.EntityFrameworkCore;
using DomaineMap = Data.Mapping.Objets.DomaineMap;

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

            /* Objets*/
            builder.ApplyConfiguration(new DomaineMap());
            builder.ApplyConfiguration(new FamilleMap());
            builder.ApplyConfiguration(new MaintenanceMap());
            builder.ApplyConfiguration(new ObjetMap());
            builder.ApplyConfiguration(new ObjetProduitMap());
            builder.ApplyConfiguration(new OptionListMap());
            builder.ApplyConfiguration(new OptionMap());
            builder.ApplyConfiguration(new OptionsObjetsMap());
            builder.ApplyConfiguration(new OutillageMap());
            builder.ApplyConfiguration(new TypeobjetMap());
            builder.ApplyConfiguration(new UtiliseMap());

            /* Frais */
            builder.ApplyConfiguration(new FraisMap());
            builder.ApplyConfiguration(new TaxeListeMap());

            /* Devise */
            builder.ApplyConfiguration(new CotationDeviseMap());
            builder.ApplyConfiguration(new DeviseMap());
            builder.ApplyConfiguration(new TenuCptDeviseMap());
            builder.ApplyConfiguration(new UniteMap());

            /* Banque */
            builder.ApplyConfiguration(new BanqueMap());
            builder.ApplyConfiguration(new BanqueStructureMap());

            base.OnModelCreating(builder);
        }
    }
}
