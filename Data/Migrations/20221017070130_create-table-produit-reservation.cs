using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class createtableproduitreservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientTarif");

            migrationBuilder.DropTable(
                name: "Delai");

            migrationBuilder.DropTable(
                name: "FichierResa");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "Identite");

            migrationBuilder.DropTable(
                name: "PlanningConsult");

            migrationBuilder.DropTable(
                name: "ProdCatTarifaire");

            migrationBuilder.DropTable(
                name: "ProduitComposant");

            migrationBuilder.DropTable(
                name: "ProduitTarif");

            migrationBuilder.DropTable(
                name: "PromoTarif");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "ReservationMotif");

            migrationBuilder.DropTable(
                name: "TypetiersTarif");

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
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Domaine");
        }
    }
}
