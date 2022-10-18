using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class o3consultingsocietes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banque",
                columns: table => new
                {
                    BanqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCompte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banque", x => x.BanqueId);
                });

            migrationBuilder.CreateTable(
                name: "BanqueStructure",
                columns: table => new
                {
                    BanqueStructureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Champ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longueur = table.Column<int>(type: "int", nullable: true),
                    TypeChamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanqueStructure", x => x.BanqueStructureId);
                });

            migrationBuilder.CreateTable(
                name: "CategComptable",
                columns: table => new
                {
                    CategComptableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategComptable", x => x.CategComptableId);
                });

            migrationBuilder.CreateTable(
                name: "CategHotel",
                columns: table => new
                {
                    CategHotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategHotel", x => x.CategHotelId);
                });

            migrationBuilder.CreateTable(
                name: "CategTarifaire",
                columns: table => new
                {
                    CategTarifaireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategTarifaire", x => x.CategTarifaireId);
                });

            migrationBuilder.CreateTable(
                name: "Civilite",
                columns: table => new
                {
                    CiviliteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Civilite", x => x.CiviliteId);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypetiersId = table.Column<int>(type: "int", nullable: true),
                    PaysId = table.Column<int>(type: "int", nullable: true),
                    CiviliteId = table.Column<int>(type: "int", nullable: true),
                    BanqueId = table.Column<int>(type: "int", nullable: true),
                    DeviseId = table.Column<int>(type: "int", nullable: true),
                    CategorieId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Taxable = table.Column<bool>(type: "bit", nullable: true),
                    TypeClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Societe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodePostal = table.Column<int>(type: "int", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Siren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbPer = table.Column<int>(type: "int", nullable: true),
                    GroupeId = table.Column<int>(type: "int", nullable: true),
                    Justificatif = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Compte",
                columns: table => new
                {
                    CompteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sens = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Auxiliaire = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compte", x => x.CompteId);
                });

            migrationBuilder.CreateTable(
                name: "Compteur",
                columns: table => new
                {
                    CompteurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefixe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suffixe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Separateur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbSuffixe = table.Column<int>(type: "int", nullable: true),
                    Table = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compteur", x => x.CompteurId);
                });

            migrationBuilder.CreateTable(
                name: "Delai",
                columns: table => new
                {
                    DelaiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deconexion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnArrive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnDepart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Resa = table.Column<int>(type: "int", nullable: true),
                    Modifie = table.Column<int>(type: "int", nullable: true),
                    Annule = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delai", x => x.DelaiId);
                });

            migrationBuilder.CreateTable(
                name: "Departement",
                columns: table => new
                {
                    DepartementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departement", x => x.DepartementId);
                });

            migrationBuilder.CreateTable(
                name: "Devise",
                columns: table => new
                {
                    DeviseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devise", x => x.DeviseId);
                });

            migrationBuilder.CreateTable(
                name: "Domaine",
                columns: table => new
                {
                    DomaineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domaine", x => x.DomaineId);
                });

            migrationBuilder.CreateTable(
                name: "FichierResa",
                columns: table => new
                {
                    FichierResaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fichier = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichierResa", x => x.FichierResaId);
                });

            migrationBuilder.CreateTable(
                name: "FormeJuridique",
                columns: table => new
                {
                    FormeJuridiqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormeJuridique", x => x.FormeJuridiqueId);
                });

            migrationBuilder.CreateTable(
                name: "Frais",
                columns: table => new
                {
                    FraisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FraisAnnule = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FraisModif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AppliAnnule = table.Column<bool>(type: "bit", nullable: true),
                    AppliModif = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frais", x => x.FraisId);
                });

            migrationBuilder.CreateTable(
                name: "Metier",
                columns: table => new
                {
                    MetierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metier", x => x.MetierId);
                });

            migrationBuilder.CreateTable(
                name: "Outillage",
                columns: table => new
                {
                    OutillageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outillage", x => x.OutillageId);
                });

            migrationBuilder.CreateTable(
                name: "PaiementMode",
                columns: table => new
                {
                    PaiementModeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaiementMode", x => x.PaiementModeId);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    PaysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code2car = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code3car = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeChiffre = table.Column<int>(type: "int", nullable: true),
                    LibelleFR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibelleENG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuseauhoraire = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.PaysId);
                });

            migrationBuilder.CreateTable(
                name: "PlanningConsult",
                columns: table => new
                {
                    PlanningConsultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodeAvant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodeApres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanningConsult", x => x.PlanningConsultId);
                });

            migrationBuilder.CreateTable(
                name: "ProduitComposant",
                columns: table => new
                {
                    ProduitComposantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitComposantParentId = table.Column<int>(type: "int", nullable: true),
                    ProduitComposantFilsId = table.Column<int>(type: "int", nullable: true),
                    QteFils = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitComposant", x => x.ProduitComposantId);
                });

            migrationBuilder.CreateTable(
                name: "ReservationMotif",
                columns: table => new
                {
                    ReservationMotifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeModif = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationMotif", x => x.ReservationMotifId);
                });

            migrationBuilder.CreateTable(
                name: "Statut",
                columns: table => new
                {
                    StatutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadLibelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statut", x => x.StatutId);
                });

            migrationBuilder.CreateTable(
                name: "TaxeListe",
                columns: table => new
                {
                    TaxeListeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeTaxe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expression = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valeur = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxeListe", x => x.TaxeListeId);
                });

            migrationBuilder.CreateTable(
                name: "TypeObjet",
                columns: table => new
                {
                    TypeObjetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeObjet", x => x.TypeObjetId);
                });

            migrationBuilder.CreateTable(
                name: "Typetiers",
                columns: table => new
                {
                    TypetiersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typetiers", x => x.TypetiersId);
                });

            migrationBuilder.CreateTable(
                name: "Unite",
                columns: table => new
                {
                    UniteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unite", x => x.UniteId);
                });

            migrationBuilder.CreateTable(
                name: "Identite",
                columns: table => new
                {
                    IdentiteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CliendId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identite", x => x.IdentiteId);
                    table.ForeignKey(
                        name: "FK_Identite_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "CategFacturation",
                columns: table => new
                {
                    CategFacturationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompteurId = table.Column<int>(type: "int", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbExemplaire = table.Column<int>(type: "int", nullable: true),
                    MiseEnPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Periodicite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeFact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategFacturation", x => x.CategFacturationId);
                    table.ForeignKey(
                        name: "FK_CategFacturation_Compteur_CompteurId",
                        column: x => x.CompteurId,
                        principalTable: "Compteur",
                        principalColumn: "CompteurId");
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartementId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_Departement_DepartementId",
                        column: x => x.DepartementId,
                        principalTable: "Departement",
                        principalColumn: "DepartementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CotationDevise",
                columns: table => new
                {
                    CotationDeviseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviseId = table.Column<int>(type: "int", nullable: false),
                    DeviseIdRep = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    REPORTING = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ETABLISSEMENT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VENTE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ACHAT = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotationDevise", x => x.CotationDeviseId);
                    table.ForeignKey(
                        name: "FK_CotationDevise_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "DeviseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TenuCptDevise",
                columns: table => new
                {
                    TenuCptDeviseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviseId = table.Column<int>(type: "int", nullable: false),
                    HOTEL = table.Column<int>(type: "int", nullable: true),
                    RESTO = table.Column<int>(type: "int", nullable: true),
                    LOGISTIC = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenuCptDevise", x => x.TenuCptDeviseId);
                    table.ForeignKey(
                        name: "FK_TenuCptDevise_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "DeviseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomaineId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieId);
                    table.ForeignKey(
                        name: "FK_Categorie_Domaine_DomaineId",
                        column: x => x.DomaineId,
                        principalTable: "Domaine",
                        principalColumn: "DomaineId");
                });

            migrationBuilder.CreateTable(
                name: "Famille",
                columns: table => new
                {
                    FamilleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    DomaineId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentLibelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famille", x => x.FamilleId);
                    table.ForeignKey(
                        name: "FK_Famille_Domaine_DomaineId",
                        column: x => x.DomaineId,
                        principalTable: "Domaine",
                        principalColumn: "DomaineId");
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomaineId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOption = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.OptionId);
                    table.ForeignKey(
                        name: "FK_Option_Domaine_DomaineId",
                        column: x => x.DomaineId,
                        principalTable: "Domaine",
                        principalColumn: "DomaineId");
                });

            migrationBuilder.CreateTable(
                name: "Utilise",
                columns: table => new
                {
                    UtiliseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutillageId = table.Column<int>(type: "int", nullable: true),
                    DomaineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilise", x => x.UtiliseId);
                    table.ForeignKey(
                        name: "FK_Utilise_Domaine_DomaineId",
                        column: x => x.DomaineId,
                        principalTable: "Domaine",
                        principalColumn: "DomaineId");
                    table.ForeignKey(
                        name: "FK_Utilise_Outillage_OutillageId",
                        column: x => x.OutillageId,
                        principalTable: "Outillage",
                        principalColumn: "OutillageId");
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    FournisseurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviseId = table.Column<int>(type: "int", nullable: true),
                    PaiementModeId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodeDePaiement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelaiLivraison = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FraisLivraison = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.FournisseurId);
                    table.ForeignKey(
                        name: "FK_Fournisseur_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "DeviseId");
                    table.ForeignKey(
                        name: "FK_Fournisseur_PaiementMode_PaiementModeId",
                        column: x => x.PaiementModeId,
                        principalTable: "PaiementMode",
                        principalColumn: "PaiementModeId");
                });

            migrationBuilder.CreateTable(
                name: "Societe",
                columns: table => new
                {
                    SocieteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaysId = table.Column<int>(type: "int", nullable: false),
                    FormeJuridiqueId = table.Column<int>(type: "int", nullable: false),
                    CategHotelId = table.Column<int>(type: "int", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capital = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressCompl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionCode = table.Column<int>(type: "int", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ChampLibre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampLibre2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampLibre3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societe", x => x.SocieteId);
                    table.ForeignKey(
                        name: "FK_Societe_CategHotel_CategHotelId",
                        column: x => x.CategHotelId,
                        principalTable: "CategHotel",
                        principalColumn: "CategHotelId");
                    table.ForeignKey(
                        name: "FK_Societe_FormeJuridique_FormeJuridiqueId",
                        column: x => x.FormeJuridiqueId,
                        principalTable: "FormeJuridique",
                        principalColumn: "FormeJuridiqueId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Societe_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "PaysId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objet",
                columns: table => new
                {
                    ObjetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomaineId = table.Column<int>(type: "int", nullable: true),
                    TypeObjetId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacite = table.Column<int>(type: "int", nullable: true),
                    PlanningLoad = table.Column<bool>(type: "bit", nullable: true),
                    EnMaintenance = table.Column<byte>(type: "tinyint", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objet", x => x.ObjetId);
                    table.ForeignKey(
                        name: "FK_Objet_Domaine_DomaineId",
                        column: x => x.DomaineId,
                        principalTable: "Domaine",
                        principalColumn: "DomaineId");
                    table.ForeignKey(
                        name: "FK_Objet_TypeObjet_TypeObjetId",
                        column: x => x.TypeObjetId,
                        principalTable: "TypeObjet",
                        principalColumn: "TypeObjetId");
                });

            migrationBuilder.CreateTable(
                name: "Professionnel",
                columns: table => new
                {
                    ProfessionnelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Societe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Siren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaysId = table.Column<int>(type: "int", nullable: true),
                    TypetiersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionnel", x => x.ProfessionnelId);
                    table.ForeignKey(
                        name: "FK_Professionnel_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "PaysId");
                    table.ForeignKey(
                        name: "FK_Professionnel_Typetiers_TypetiersId",
                        column: x => x.TypetiersId,
                        principalTable: "Typetiers",
                        principalColumn: "TypetiersId");
                });

            migrationBuilder.CreateTable(
                name: "Collaborateur",
                columns: table => new
                {
                    CollaborateurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    DepartementId = table.Column<int>(type: "int", nullable: true),
                    MetierId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateur", x => x.CollaborateurId);
                    table.ForeignKey(
                        name: "FK_Collaborateur_Metier_MetierId",
                        column: x => x.MetierId,
                        principalTable: "Metier",
                        principalColumn: "MetierId");
                    table.ForeignKey(
                        name: "FK_Collaborateur_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId");
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilleId = table.Column<int>(type: "int", nullable: true),
                    CategorieId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeProduit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadSite = table.Column<bool>(type: "bit", nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fichier1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fichier2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fichier3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadPlanning = table.Column<bool>(type: "bit", nullable: true),
                    Nombre = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.ProduitId);
                    table.ForeignKey(
                        name: "FK_Produit_Categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorie",
                        principalColumn: "CategorieId");
                });

            migrationBuilder.CreateTable(
                name: "OptionList",
                columns: table => new
                {
                    OptionListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionList", x => x.OptionListId);
                    table.ForeignKey(
                        name: "FK_OptionList_Option_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Option",
                        principalColumn: "OptionId");
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiviliteId = table.Column<int>(type: "int", nullable: true),
                    SocieteId = table.Column<int>(type: "int", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fonction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contact_Civilite_CiviliteId",
                        column: x => x.CiviliteId,
                        principalTable: "Civilite",
                        principalColumn: "CiviliteId");
                    table.ForeignKey(
                        name: "FK_Contact_Societe_SocieteId",
                        column: x => x.SocieteId,
                        principalTable: "Societe",
                        principalColumn: "SocieteId");
                });

            migrationBuilder.CreateTable(
                name: "Maintenance",
                columns: table => new
                {
                    MaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjetId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance", x => x.MaintenanceId);
                    table.ForeignKey(
                        name: "FK_Maintenance_Objet_ObjetId",
                        column: x => x.ObjetId,
                        principalTable: "Objet",
                        principalColumn: "ObjetId");
                });

            migrationBuilder.CreateTable(
                name: "ObjetProduit",
                columns: table => new
                {
                    ObjetProduitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjetId = table.Column<int>(type: "int", nullable: true),
                    ProduitId = table.Column<int>(type: "int", nullable: true),
                    NbProduit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetProduit", x => x.ObjetProduitId);
                    table.ForeignKey(
                        name: "FK_ObjetProduit_Objet_ObjetId",
                        column: x => x.ObjetId,
                        principalTable: "Objet",
                        principalColumn: "ObjetId");
                });

            migrationBuilder.CreateTable(
                name: "OptionsObjets",
                columns: table => new
                {
                    OptionsObjetsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjetId = table.Column<int>(type: "int", nullable: true),
                    OptionId = table.Column<int>(type: "int", nullable: true),
                    Valeur = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionsObjets", x => x.OptionsObjetsId);
                    table.ForeignKey(
                        name: "FK_OptionsObjets_Objet_ObjetId",
                        column: x => x.ObjetId,
                        principalTable: "Objet",
                        principalColumn: "ObjetId");
                    table.ForeignKey(
                        name: "FK_OptionsObjets_Option_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Option",
                        principalColumn: "OptionId");
                });

            migrationBuilder.CreateTable(
                name: "ClientTarif",
                columns: table => new
                {
                    ClientTarifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTarif", x => x.ClientTarifId);
                    table.ForeignKey(
                        name: "FK_ClientTarif_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientTarif_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdCatTarifaire",
                columns: table => new
                {
                    ProdCatTarifaireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    DeviseId = table.Column<int>(type: "int", nullable: true),
                    CategTarifaireId = table.Column<int>(type: "int", nullable: true),
                    Tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdCatTarifaire", x => x.ProdCatTarifaireId);
                    table.ForeignKey(
                        name: "FK_ProdCatTarifaire_CategTarifaire_CategTarifaireId",
                        column: x => x.CategTarifaireId,
                        principalTable: "CategTarifaire",
                        principalColumn: "CategTarifaireId");
                    table.ForeignKey(
                        name: "FK_ProdCatTarifaire_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "DeviseId");
                    table.ForeignKey(
                        name: "FK_ProdCatTarifaire_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProduitTarif",
                columns: table => new
                {
                    ProduitTarifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    DeviseId = table.Column<int>(type: "int", nullable: false),
                    Tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Somme = table.Column<bool>(type: "bit", nullable: true),
                    Taxable = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitTarif", x => x.ProduitTarifId);
                    table.ForeignKey(
                        name: "FK_ProduitTarif_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "DeviseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProduitTarif_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromoTarif",
                columns: table => new
                {
                    PromoTarifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    DeviseId = table.Column<int>(type: "int", nullable: false),
                    Tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoTarif", x => x.PromoTarifId);
                    table.ForeignKey(
                        name: "FK_PromoTarif_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "DeviseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromoTarif_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(type: "int", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    ModepayementId = table.Column<int>(type: "int", nullable: true),
                    NumRes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quantite = table.Column<int>(type: "int", nullable: true),
                    NombrePax = table.Column<int>(type: "int", nullable: true),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etat = table.Column<int>(type: "int", nullable: true),
                    ObjetId = table.Column<int>(type: "int", nullable: true),
                    PaiementModeId = table.Column<int>(type: "int", nullable: true),
                    StatutId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_Reservation_PaiementMode_PaiementModeId",
                        column: x => x.PaiementModeId,
                        principalTable: "PaiementMode",
                        principalColumn: "PaiementModeId");
                    table.ForeignKey(
                        name: "FK_Reservation_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId");
                    table.ForeignKey(
                        name: "FK_Reservation_Statut_StatutId",
                        column: x => x.StatutId,
                        principalTable: "Statut",
                        principalColumn: "StatutId");
                });

            migrationBuilder.CreateTable(
                name: "TypetiersTarif",
                columns: table => new
                {
                    TypetiersTarifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypetiersId = table.Column<int>(type: "int", nullable: false),
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    DeviseId = table.Column<int>(type: "int", nullable: false),
                    Tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypetiersTarif", x => x.TypetiersTarifId);
                    table.ForeignKey(
                        name: "FK_TypetiersTarif_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "DeviseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypetiersTarif_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypetiersTarif_Typetiers_TypetiersId",
                        column: x => x.TypetiersId,
                        principalTable: "Typetiers",
                        principalColumn: "TypetiersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategHotel",
                columns: new[] { "CategHotelId", "Libelle" },
                values: new object[,]
                {
                    { 1, "1 étoile" },
                    { 2, "2 étoiles" },
                    { 3, "3 étoiles" },
                    { 4, "4 étoiles" },
                    { 5, "5 étoiles" }
                });

            migrationBuilder.InsertData(
                table: "Civilite",
                columns: new[] { "CiviliteId", "Code", "Libelle" },
                values: new object[,]
                {
                    { 1, "M", "Monsieur" },
                    { 2, "Mme", "Madame" },
                    { 3, "Mlle", "Mademoiselle" },
                    { 4, "Mx", "Neutre" }
                });

            migrationBuilder.InsertData(
                table: "FormeJuridique",
                columns: new[] { "FormeJuridiqueId", "Code", "Libelle" },
                values: new object[,]
                {
                    { 101, "EI", "Entreprise Individuelle" },
                    { 102, "SARL", "Société à Responsabilité Limitée" },
                    { 103, "SA", "Société Anonyme" },
                    { 104, "SNC", "Société en Nom Collectif" },
                    { 105, "SCS", "Société en Commandite Simple" },
                    { 106, "GIE", "Groupement d'Intérêt Economique" },
                    { 107, "SDET", "Société de Droit Etranger" }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Code2car", "Code3car", "CodeChiffre", "Fuseauhoraire", "LibelleENG", "LibelleFR" },
                values: new object[,]
                {
                    { 1, "AW", "ABW", 533, null, "ARUBA", "ARUBA" },
                    { 2, "AF", "AFG", 4, null, "AFGHANISTAN", "AFGHANISTAN" },
                    { 3, "AO", "AGO", 24, null, "ANGOLA", "ANGOLA" },
                    { 4, "AI", "AIA", 660, null, "ANGUILLA", "ANGUILLA" },
                    { 5, "AL", "ALB", 8, null, "ALBANIE", "ALBANIE" },
                    { 6, "AD", "AND", 20, null, "ANDORRES", "ANDORRES" },
                    { 7, "AN", "ANT", 530, null, "NETHERLANDS ANTILLES", "NETHERLANDS ANTILLES" },
                    { 8, "AE", "ARE", 784, null, "EMIRATS ARABES UNIS", "EMIRATS ARABES UNIS" },
                    { 9, "AR", "ARG", 32, null, "ARGENTINE", "ARGENTINE" },
                    { 10, "AM", "ARM", 51, null, "ARMENIE", "ARMENIA" },
                    { 11, "AS", "ASM", 16, null, "AMERICAN SAMOA", "AMERICAN SAMOA" },
                    { 12, "AQ", "ATA", 10, null, "ANTARCTIC", "ANTARCTICA" },
                    { 13, "TF", "ATF", 260, null, "FRENCH SOUTHERN TERRITORIES", "FRENCH SOUTHERN TERRITORIES" },
                    { 14, "AG", "ATG", 32, null, "ANTIGUA AND BARBUDA", "ANTIGUA" },
                    { 15, "AU", "AUS", 36, null, "AUSTRALIA", "AUSTRALIE" },
                    { 16, "AT", "AUT", 40, null, "AUSTRIA", "AUTRICHE" },
                    { 17, "AZ", "AZE", 31, null, "AZERBAIJAN", "AZERBAIJAN" },
                    { 18, "BI", "BDI", 108, null, "BURUNDI", "BURUNDI" },
                    { 19, "BE", "BEL", 32, null, "BELGIUM", "BELGIQUE" },
                    { 20, "BJ", "BEN", 204, null, "BENIN", "BENIN" },
                    { 21, "BF", "BFA", 854, null, "BURKINA FASO", "BURKINA FASO" },
                    { 22, "BD", "BGD", 50, null, "BENGLADESH", "BENGLADESH" },
                    { 23, "BG", "BGR", 100, null, "BULGARIE", "BULGARIE" },
                    { 24, "BH", "BHR", 48, null, "BAHRAIN", "BAHRAIN" },
                    { 25, "BS", "BHS", 44, null, "BAHAMAS", "BAHAMAS" },
                    { 26, "BA", "BIH", 70, null, "BOSNIA AND HERZEGOWINA", "BOSNIE HERZEGOVINE" }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Code2car", "Code3car", "CodeChiffre", "Fuseauhoraire", "LibelleENG", "LibelleFR" },
                values: new object[,]
                {
                    { 27, "BY", "BLR", 112, null, "BELARUS", "BELARUS" },
                    { 28, "BZ", "BLZ", 84, null, "BELIZE", "BELIZE" },
                    { 29, "BM", "BMU", 60, null, "BERMUDA", "BERMUDES" },
                    { 30, "BO", "BOL", 68, null, "BOLIVIA", "BOLIVIE" },
                    { 31, "BR", "BRA", 76, null, "BRAZIL", "BRESIL" },
                    { 32, "BB", "BRB", 52, null, "BARBADOS", "BARBADES" },
                    { 33, "BN", "BRN", 96, null, "BRUNEI DARUSSALAM", "BRUNEI DARUSSALAM" },
                    { 34, "BT", "BTN", 64, null, "BHUTAN", "BHUTAN" },
                    { 35, "BV", "BVT", 74, null, "BOUVET ISLAND", "BOUVET ISLAND" },
                    { 36, "BW", "BWA", 72, null, "BOTSWANA", "BOTSWANA" },
                    { 37, "CF", "CAF", 140, null, "CENTRAL AFRICAN REPUBLIC", "CENTRAFRIQUE" },
                    { 38, "CA", "CAN", 124, null, "CANADA", "CANADA" },
                    { 39, "CC", "CCK", 166, null, "COCOS (KEELING) ISLANDS", "BRECOCOS (KEELING) ISLANDSSIL" },
                    { 40, "CH", "CHE", 756, null, "SWITZERLAND", "SUISSE" },
                    { 41, "CL", "CHL", 152, null, "CHILE", "CHILI" },
                    { 42, "CN", "CHN", 156, null, "CHINA", "CHINE" },
                    { 43, "CI", "CIV", 384, null, "COTE D''IVOIRE", "COTE D''IVOIRE" },
                    { 44, "CM", "CMR", 120, null, "CAMEROON", "CAMEROUN" },
                    { 45, "CD", "COD", 180, null, "CONGO, Democratic Republic of (was Zaire)", "CONGO (Zaire)" },
                    { 46, "CG", "COG", 178, null, "CONGO, People''s Republic of", "CONGO" },
                    { 47, "CK", "COK", 184, null, "COOK ISLANDS", "COOK ISLANDS" },
                    { 48, "CO", "COL", 170, null, "COLOMBIA", "COLOMBIE" },
                    { 49, "KM", "COM", 174, null, "COMOROS", "COMORES" },
                    { 50, "CV", "CPV", 132, null, "CAPE VERDE", "CAP VERT" },
                    { 51, "CR", "CRI", 188, null, "COSTA RICA", "COSTA RICA" },
                    { 52, "CU", "CUB", 192, null, "CUBA", "CUBA" },
                    { 53, "CX", "CXR", 162, null, "CHRISTMAS ISLAND", "CHRISTMAS ISLAND" },
                    { 54, "KY", "CYM", 136, null, "CAYMAN ISLANDS", "CAYMAN ISLANDS" },
                    { 55, "CY", "CYP", 196, null, "CYPRUS", "CHYPRE" },
                    { 56, "CZ", "CZE", 203, null, "CZECH REPUBLIC", "CZECH REPUBLIC" },
                    { 57, "DE", "DEU", 276, null, "GERMANY", "ALLEMAGNE" },
                    { 58, "DJ", "DJI", 262, null, "DJIBOUTI", "DJIBOUTI" },
                    { 59, "DM", "DMA", 212, null, "DOMINICA", "DOMINICA" },
                    { 60, "DK", "DNK", 208, null, "DENMARK", "DANEMARK" },
                    { 61, "DO", "DOM", 214, null, "DOMINICAN REPUBLIC", "DOMINICAN REPUBLIC" },
                    { 62, "DZ", "DZA", 12, null, "ALGERIA", "ALGERIE" },
                    { 63, "EC", "ECU", 218, null, "ECUADOR", "EQUATEUR" },
                    { 64, "EG", "EGY", 818, null, "EGYPT", "EGYPTE" },
                    { 65, "ER", "ERI", 232, null, "ERITREA", "ERYTHREE" },
                    { 66, "EH", "ESH", 732, null, "WESTERN SAHARA", "SAHARA OCCIDENTAL" },
                    { 67, "ES", "ESP", 724, null, "SPAIN", "ESPAGNE" },
                    { 68, "EE", "EST", 233, null, "ESTONIA", "ETHIOPIE" }
                });

            migrationBuilder.InsertData(
                table: "Pays",
                columns: new[] { "PaysId", "Code2car", "Code3car", "CodeChiffre", "Fuseauhoraire", "LibelleENG", "LibelleFR" },
                values: new object[,]
                {
                    { 69, "ET", "ETH", 231, null, "ETHIOPIA", "CAPVERT" },
                    { 70, "FI", "FIN", 246, null, "FINLAND", "FINLANDE" },
                    { 71, "FJ", "FJI", 242, null, "FIJI", "FIDJI" },
                    { 72, "FK", "FLK", 238, null, "FALKLAND ISLANDS (MALVINAS)", "FALKLAND ISLANDS (MALVINAS)" },
                    { 73, "FR", "FRA", 250, null, "FRANCE", "FRANCE" },
                    { 74, "FO", "FRO", 234, null, "FAROE ISLANDS", "FAROE ISLANDS" },
                    { 75, "FM", "FSM", 583, null, "MICRONESIA, FEDERATED STATES OF", "MICRONESIA, FEDERATED STATES OF" },
                    { 76, "FX", "FXX", 249, null, "FRANCE, METROPOLITAN", "FRANCE, METROPOLITAN" },
                    { 77, "GA", "GAB", 266, null, "GABON", "GABON" },
                    { 78, "GB", "GBR", 826, null, "UNITED KINGDOM", "ROYAUME UNI" },
                    { 79, "GE", "GEO", 268, null, "GEORGIA", "GEORGIE" },
                    { 80, "GH", "GHA", 288, null, "GHANA", "GHANA" },
                    { 81, "GI", "GIB", 292, null, "GIBRALTAR", "GIBRALTAR" },
                    { 82, "GN", "GIN", 324, null, "GUINEA", "GUINEE CONAKRY" },
                    { 83, "GP", "GLP", 312, null, "GUADELOUPE", "GUADELOUPE" },
                    { 84, "GM", "GMB", 270, null, "GAMBIA", "GAMBIE" },
                    { 85, "GW", "GNB", 624, null, "GUINEA-BISSAU", "GUINEE-BISSAU" },
                    { 86, "GQ", "GNQ", 226, null, "EQUATORIAL GUINEA", "GUINEE EQUATORIALE" },
                    { 87, "GR", "GRC", 300, null, "GREECE", "GRECE" },
                    { 88, "GD", "GRD", 308, null, "GRENADA", "GRENADE" },
                    { 89, "GL", "GRL", 304, null, "GREENLAND", "GREENLAND" },
                    { 90, "GT", "GTM", 320, null, "GUATEMALA", "GUATEMALA" },
                    { 91, "GF", "GUF", 254, null, "FRENCH GUIANA", "GUYANE FRANCAISE" },
                    { 92, "GU", "GUM", 316, null, "GUAM", "GUAM" },
                    { 93, "GY", "GUY", 328, null, "GUYANA", "GUYANE" },
                    { 94, "HK", "HKG", 344, null, "HONG KONG", "HONG KONG" },
                    { 95, "HM", "HMD", 334, null, "HEARD AND MC DONALD ISLANDS", "HEARD AND MC DONALD ISLANDS" },
                    { 96, "HN", "HND", 340, null, "HONDURAS", "HONDURAS" },
                    { 97, "HR", "HRV", 191, null, "CROATIA (local name: Hrvatska)", "CROATIE" },
                    { 98, "HT", "HTI", 332, null, "HAITI", "HAITI" },
                    { 99, "HU", "HUN", 348, null, "HUNGARY", "HONGRIE" },
                    { 100, "ID", "IDN", 360, null, "INDONESIA", "INDONESIE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategFacturation_CompteurId",
                table: "CategFacturation",
                column: "CompteurId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_DomaineId",
                table: "Categorie",
                column: "DomaineId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTarif_ClientId",
                table: "ClientTarif",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientTarif_ProduitId",
                table: "ClientTarif",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateur_MetierId",
                table: "Collaborateur",
                column: "MetierId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateur_ServiceId",
                table: "Collaborateur",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CiviliteId",
                table: "Contact",
                column: "CiviliteId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_SocieteId",
                table: "Contact",
                column: "SocieteId");

            migrationBuilder.CreateIndex(
                name: "IX_CotationDevise_DeviseId",
                table: "CotationDevise",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_Famille_DomaineId",
                table: "Famille",
                column: "DomaineId");

            migrationBuilder.CreateIndex(
                name: "IX_Fournisseur_DeviseId",
                table: "Fournisseur",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_Fournisseur_PaiementModeId",
                table: "Fournisseur",
                column: "PaiementModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Identite_ClientId",
                table: "Identite",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_ObjetId",
                table: "Maintenance",
                column: "ObjetId");

            migrationBuilder.CreateIndex(
                name: "IX_Objet_DomaineId",
                table: "Objet",
                column: "DomaineId");

            migrationBuilder.CreateIndex(
                name: "IX_Objet_TypeObjetId",
                table: "Objet",
                column: "TypeObjetId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetProduit_ObjetId",
                table: "ObjetProduit",
                column: "ObjetId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_DomaineId",
                table: "Option",
                column: "DomaineId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionList_OptionId",
                table: "OptionList",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionsObjets_ObjetId",
                table: "OptionsObjets",
                column: "ObjetId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionsObjets_OptionId",
                table: "OptionsObjets",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdCatTarifaire_CategTarifaireId",
                table: "ProdCatTarifaire",
                column: "CategTarifaireId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdCatTarifaire_DeviseId",
                table: "ProdCatTarifaire",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdCatTarifaire_ProduitId",
                table: "ProdCatTarifaire",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_CategorieId",
                table: "Produit",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduitTarif_DeviseId",
                table: "ProduitTarif",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduitTarif_ProduitId",
                table: "ProduitTarif",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Professionnel_PaysId",
                table: "Professionnel",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Professionnel_TypetiersId",
                table: "Professionnel",
                column: "TypetiersId");

            migrationBuilder.CreateIndex(
                name: "IX_PromoTarif_DeviseId",
                table: "PromoTarif",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_PromoTarif_ProduitId",
                table: "PromoTarif",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ClientId",
                table: "Reservation",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PaiementModeId",
                table: "Reservation",
                column: "PaiementModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ProduitId",
                table: "Reservation",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_StatutId",
                table: "Reservation",
                column: "StatutId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_DepartementId",
                table: "Service",
                column: "DepartementId");

            migrationBuilder.CreateIndex(
                name: "IX_Societe_CategHotelId",
                table: "Societe",
                column: "CategHotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Societe_FormeJuridiqueId",
                table: "Societe",
                column: "FormeJuridiqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Societe_PaysId",
                table: "Societe",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_TenuCptDevise_DeviseId",
                table: "TenuCptDevise",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_TypetiersTarif_DeviseId",
                table: "TypetiersTarif",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_TypetiersTarif_ProduitId",
                table: "TypetiersTarif",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_TypetiersTarif_TypetiersId",
                table: "TypetiersTarif",
                column: "TypetiersId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilise_DomaineId",
                table: "Utilise",
                column: "DomaineId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilise_OutillageId",
                table: "Utilise",
                column: "OutillageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banque");

            migrationBuilder.DropTable(
                name: "BanqueStructure");

            migrationBuilder.DropTable(
                name: "CategComptable");

            migrationBuilder.DropTable(
                name: "CategFacturation");

            migrationBuilder.DropTable(
                name: "ClientTarif");

            migrationBuilder.DropTable(
                name: "Collaborateur");

            migrationBuilder.DropTable(
                name: "Compte");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "CotationDevise");

            migrationBuilder.DropTable(
                name: "Delai");

            migrationBuilder.DropTable(
                name: "Famille");

            migrationBuilder.DropTable(
                name: "FichierResa");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "Frais");

            migrationBuilder.DropTable(
                name: "Identite");

            migrationBuilder.DropTable(
                name: "Maintenance");

            migrationBuilder.DropTable(
                name: "ObjetProduit");

            migrationBuilder.DropTable(
                name: "OptionList");

            migrationBuilder.DropTable(
                name: "OptionsObjets");

            migrationBuilder.DropTable(
                name: "PlanningConsult");

            migrationBuilder.DropTable(
                name: "ProdCatTarifaire");

            migrationBuilder.DropTable(
                name: "ProduitComposant");

            migrationBuilder.DropTable(
                name: "ProduitTarif");

            migrationBuilder.DropTable(
                name: "Professionnel");

            migrationBuilder.DropTable(
                name: "PromoTarif");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "ReservationMotif");

            migrationBuilder.DropTable(
                name: "TaxeListe");

            migrationBuilder.DropTable(
                name: "TenuCptDevise");

            migrationBuilder.DropTable(
                name: "TypetiersTarif");

            migrationBuilder.DropTable(
                name: "Unite");

            migrationBuilder.DropTable(
                name: "Utilise");

            migrationBuilder.DropTable(
                name: "Compteur");

            migrationBuilder.DropTable(
                name: "Metier");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Civilite");

            migrationBuilder.DropTable(
                name: "Societe");

            migrationBuilder.DropTable(
                name: "Objet");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "CategTarifaire");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "PaiementMode");

            migrationBuilder.DropTable(
                name: "Statut");

            migrationBuilder.DropTable(
                name: "Devise");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Typetiers");

            migrationBuilder.DropTable(
                name: "Outillage");

            migrationBuilder.DropTable(
                name: "Departement");

            migrationBuilder.DropTable(
                name: "CategHotel");

            migrationBuilder.DropTable(
                name: "FormeJuridique");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "TypeObjet");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Domaine");
        }
    }
}
