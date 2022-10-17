using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CiviliteId = table.Column<int>(type: "int", nullable: true),
                    PaysId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Contact_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "PaysId");
                    table.ForeignKey(
                        name: "FK_Contact_Societe_SocieteId",
                        column: x => x.SocieteId,
                        principalTable: "Societe",
                        principalColumn: "SocieteId");
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
                    { 9, "AR", "ARG", 32, null, "ARGENTINE", "ARGENTINE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategFacturation_CompteurId",
                table: "CategFacturation",
                column: "CompteurId");

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
                name: "IX_Contact_PaysId",
                table: "Contact",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_SocieteId",
                table: "Contact",
                column: "SocieteId");

            migrationBuilder.CreateIndex(
                name: "IX_Professionnel_PaysId",
                table: "Professionnel",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Professionnel_TypetiersId",
                table: "Professionnel",
                column: "TypetiersId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategComptable");

            migrationBuilder.DropTable(
                name: "CategFacturation");

            migrationBuilder.DropTable(
                name: "Collaborateur");

            migrationBuilder.DropTable(
                name: "Compte");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Professionnel");

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
                name: "Typetiers");

            migrationBuilder.DropTable(
                name: "Departement");

            migrationBuilder.DropTable(
                name: "CategHotel");

            migrationBuilder.DropTable(
                name: "FormeJuridique");

            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
