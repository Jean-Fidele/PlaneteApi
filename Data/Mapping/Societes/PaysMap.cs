﻿using Domain.Entites.Societes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Societes
{
    public class PaysMap : IEntityTypeConfiguration<Pays>
    {
        public void Configure(EntityTypeBuilder<Pays> builder)
        {
            builder.ToTable("Pays");
            builder.HasKey(x => x.PaysId);
            builder.HasData(
                new Pays { PaysId = 1, Code2car = "AW", Code3car = "ABW", CodeChiffre = 533, Fuseauhoraire = null, LibelleENG= "ARUBA", LibelleFR = "ARUBA" },
                new Pays { PaysId = 2, Code2car = "AF", Code3car = "AFG", CodeChiffre = 4, Fuseauhoraire = null, LibelleENG = "AFGHANISTAN", LibelleFR = "AFGHANISTAN" },
                new Pays { PaysId = 3, Code2car = "AO", Code3car = "AGO", CodeChiffre = 24, Fuseauhoraire = null, LibelleENG = "ANGOLA", LibelleFR = "ANGOLA" },
                new Pays { PaysId = 4, Code2car = "AI", Code3car = "AIA", CodeChiffre = 660, Fuseauhoraire = null, LibelleENG = "ANGUILLA", LibelleFR = "ANGUILLA" },
                new Pays { PaysId = 5, Code2car = "AL", Code3car = "ALB", CodeChiffre = 8, Fuseauhoraire = null, LibelleENG = "ALBANIE", LibelleFR = "ALBANIE" },
                new Pays { PaysId = 6, Code2car = "AD", Code3car = "AND", CodeChiffre = 20, Fuseauhoraire = null, LibelleENG = "ANDORRES", LibelleFR = "ANDORRES" },
                new Pays { PaysId = 7, Code2car = "AN", Code3car = "ANT", CodeChiffre = 530, Fuseauhoraire = null, LibelleENG = "NETHERLANDS ANTILLES", LibelleFR = "NETHERLANDS ANTILLES" },
                new Pays { PaysId = 8, Code2car = "AE", Code3car = "ARE", CodeChiffre = 784, Fuseauhoraire = null, LibelleENG = "EMIRATS ARABES UNIS", LibelleFR = "EMIRATS ARABES UNIS" },
                new Pays { PaysId = 9, Code2car = "AR", Code3car = "ARG", CodeChiffre = 32, Fuseauhoraire = null, LibelleENG = "ARGENTINE", LibelleFR = "ARGENTINE" },
                new Pays { PaysId = 10, Code2car = "AM", Code3car = "ARM", CodeChiffre = 51, Fuseauhoraire = null, LibelleENG = "ARMENIE", LibelleFR = "ARMENIA" },
                new Pays { PaysId = 11, Code2car = "AS", Code3car = "ASM", CodeChiffre = 16, Fuseauhoraire = null, LibelleENG = "AMERICAN SAMOA", LibelleFR = "AMERICAN SAMOA" },
                new Pays { PaysId = 12, Code2car = "AQ", Code3car = "ATA", CodeChiffre = 10, Fuseauhoraire = null, LibelleENG = "ANTARCTIC", LibelleFR = "ANTARCTICA" },
                new Pays { PaysId = 13, Code2car = "TF", Code3car = "ATF", CodeChiffre = 260, Fuseauhoraire = null, LibelleENG = "FRENCH SOUTHERN TERRITORIES", LibelleFR = "FRENCH SOUTHERN TERRITORIES" },
                new Pays { PaysId = 14, Code2car = "AG", Code3car = "ATG", CodeChiffre = 32, Fuseauhoraire = null, LibelleENG = "ANTIGUA AND BARBUDA", LibelleFR = "ANTIGUA" },
                new Pays { PaysId = 15, Code2car = "AU", Code3car = "AUS", CodeChiffre = 36, Fuseauhoraire = null, LibelleENG = "AUSTRALIA", LibelleFR = "AUSTRALIE" },
                new Pays { PaysId = 16, Code2car = "AT", Code3car = "AUT", CodeChiffre = 40, Fuseauhoraire = null, LibelleENG = "AUSTRIA", LibelleFR = "AUTRICHE" },
                new Pays { PaysId = 17, Code2car = "AZ", Code3car = "AZE", CodeChiffre = 31, Fuseauhoraire = null, LibelleENG = "AZERBAIJAN", LibelleFR = "AZERBAIJAN" },
                new Pays { PaysId = 18, Code2car = "BI", Code3car = "BDI", CodeChiffre = 108, Fuseauhoraire = null, LibelleENG = "BURUNDI", LibelleFR = "BURUNDI" },
                new Pays { PaysId = 19, Code2car = "BE", Code3car = "BEL", CodeChiffre = 32, Fuseauhoraire = null, LibelleENG = "BELGIUM", LibelleFR = "BELGIQUE" },
                new Pays { PaysId = 20, Code2car = "BJ", Code3car = "BEN", CodeChiffre = 204, Fuseauhoraire = null, LibelleENG = "BENIN", LibelleFR = "BENIN" },
                new Pays { PaysId = 21, Code2car = "BF", Code3car = "BFA", CodeChiffre = 854, Fuseauhoraire = null, LibelleENG = "BURKINA FASO", LibelleFR = "BURKINA FASO" },
                new Pays { PaysId = 22, Code2car = "BD", Code3car = "BGD", CodeChiffre = 50, Fuseauhoraire = null, LibelleENG = "BENGLADESH", LibelleFR = "BENGLADESH" },
                new Pays { PaysId = 23, Code2car = "BG", Code3car = "BGR", CodeChiffre = 100, Fuseauhoraire = null, LibelleENG = "BULGARIE", LibelleFR = "BULGARIE" },
                new Pays { PaysId = 24, Code2car = "BH", Code3car = "BHR", CodeChiffre = 48, Fuseauhoraire = null, LibelleENG = "BAHRAIN", LibelleFR = "BAHRAIN" },
                new Pays { PaysId = 25, Code2car = "BS", Code3car = "BHS", CodeChiffre = 44, Fuseauhoraire = null, LibelleENG = "BAHAMAS", LibelleFR = "BAHAMAS" },
                new Pays { PaysId = 26, Code2car = "BA", Code3car = "BIH", CodeChiffre = 70, Fuseauhoraire = null, LibelleENG = "BOSNIA AND HERZEGOWINA", LibelleFR = "BOSNIE HERZEGOVINE" },
                new Pays { PaysId = 27, Code2car = "BY", Code3car = "BLR", CodeChiffre = 112, Fuseauhoraire = null, LibelleENG = "BELARUS", LibelleFR = "BELARUS" },
                new Pays { PaysId = 28, Code2car = "BZ", Code3car = "BLZ", CodeChiffre = 84, Fuseauhoraire = null, LibelleENG = "BELIZE", LibelleFR = "BELIZE" },
                new Pays { PaysId = 29, Code2car = "BM", Code3car = "BMU", CodeChiffre = 60, Fuseauhoraire = null, LibelleENG = "BERMUDA", LibelleFR = "BERMUDES" },
                new Pays { PaysId = 30, Code2car = "BO", Code3car = "BOL", CodeChiffre = 68, Fuseauhoraire = null, LibelleENG = "BOLIVIA", LibelleFR = "BOLIVIE" },
                new Pays { PaysId = 31, Code2car = "BR", Code3car = "BRA", CodeChiffre = 76, Fuseauhoraire = null, LibelleENG = "BRAZIL", LibelleFR = "BRESIL" },
                new Pays { PaysId = 32, Code2car = "BB", Code3car = "BRB", CodeChiffre = 52, Fuseauhoraire = null, LibelleENG = "BARBADOS", LibelleFR = "BARBADES" },
                new Pays { PaysId = 33, Code2car = "BN", Code3car = "BRN", CodeChiffre = 96, Fuseauhoraire = null, LibelleENG = "BRUNEI DARUSSALAM", LibelleFR = "BRUNEI DARUSSALAM" },
                new Pays { PaysId = 34, Code2car = "BT", Code3car = "BTN", CodeChiffre = 64, Fuseauhoraire = null, LibelleENG = "BHUTAN", LibelleFR = "BHUTAN" },
                new Pays { PaysId = 35, Code2car = "BV", Code3car = "BVT", CodeChiffre = 74, Fuseauhoraire = null, LibelleENG = "BOUVET ISLAND", LibelleFR = "BOUVET ISLAND" },
                new Pays { PaysId = 36, Code2car = "BW", Code3car = "BWA", CodeChiffre = 72, Fuseauhoraire = null, LibelleENG = "BOTSWANA", LibelleFR = "BOTSWANA" },
                new Pays { PaysId = 37, Code2car = "CF", Code3car = "CAF", CodeChiffre = 140, Fuseauhoraire = null, LibelleENG = "CENTRAL AFRICAN REPUBLIC", LibelleFR = "CENTRAFRIQUE" },
                new Pays { PaysId = 38, Code2car = "CA", Code3car = "CAN", CodeChiffre = 124, Fuseauhoraire = null, LibelleENG = "CANADA", LibelleFR = "CANADA" },
                new Pays { PaysId = 39, Code2car = "CC", Code3car = "CCK", CodeChiffre = 166, Fuseauhoraire = null, LibelleENG = "COCOS (KEELING) ISLANDS", LibelleFR = "BRECOCOS (KEELING) ISLANDSSIL" },
                new Pays { PaysId = 40, Code2car = "CH", Code3car = "CHE", CodeChiffre = 756, Fuseauhoraire = null, LibelleENG = "SWITZERLAND", LibelleFR = "SUISSE" },
                new Pays { PaysId = 41, Code2car = "CL", Code3car = "CHL", CodeChiffre = 152, Fuseauhoraire = null, LibelleENG = "CHILE", LibelleFR = "CHILI" },
                new Pays { PaysId = 42, Code2car = "CN", Code3car = "CHN", CodeChiffre = 156, Fuseauhoraire = null, LibelleENG = "CHINA", LibelleFR = "CHINE" },
                new Pays { PaysId = 43, Code2car = "CI", Code3car = "CIV", CodeChiffre = 384, Fuseauhoraire = null, LibelleENG = "COTE D''IVOIRE", LibelleFR = "COTE D''IVOIRE" },
                new Pays { PaysId = 44, Code2car = "CM", Code3car = "CMR", CodeChiffre = 120, Fuseauhoraire = null, LibelleENG = "CAMEROON", LibelleFR = "CAMEROUN" },
                new Pays { PaysId = 45, Code2car = "CD", Code3car = "COD", CodeChiffre = 180, Fuseauhoraire = null, LibelleENG = "CONGO, Democratic Republic of (was Zaire)", LibelleFR = "CONGO (Zaire)" },
                new Pays { PaysId = 46, Code2car = "CG", Code3car = "COG", CodeChiffre = 178, Fuseauhoraire = null, LibelleENG = "CONGO, People''s Republic of", LibelleFR = "CONGO" },
                new Pays { PaysId = 47, Code2car = "CK", Code3car = "COK", CodeChiffre = 184, Fuseauhoraire = null, LibelleENG = "COOK ISLANDS", LibelleFR = "COOK ISLANDS" },
                new Pays { PaysId = 48, Code2car = "CO", Code3car = "COL", CodeChiffre = 170, Fuseauhoraire = null, LibelleENG = "COLOMBIA", LibelleFR = "COLOMBIE" },
                new Pays { PaysId = 49, Code2car = "KM", Code3car = "COM", CodeChiffre = 174, Fuseauhoraire = null, LibelleENG = "COMOROS", LibelleFR = "COMORES" },
                new Pays { PaysId = 50, Code2car = "CV", Code3car = "CPV", CodeChiffre = 132, Fuseauhoraire = null, LibelleENG = "CAPE VERDE", LibelleFR = "CAP VERT" },
                new Pays { PaysId = 51, Code2car = "CR", Code3car = "CRI", CodeChiffre = 188, Fuseauhoraire = null, LibelleENG = "COSTA RICA", LibelleFR = "COSTA RICA" }
                new Pays { PaysId = 52, Code2car = "CU", Code3car = "CUB", CodeChiffre = 192, Fuseauhoraire = null, LibelleENG = "CUBA", LibelleFR = "CUBA" },
                new Pays { PaysId = 53, Code2car = "CX", Code3car = "CXR", CodeChiffre = 162, Fuseauhoraire = null, LibelleENG = "CHRISTMAS ISLAND", LibelleFR = "CHRISTMAS ISLAND" },
                new Pays { PaysId = 54, Code2car = "KY", Code3car = "CYM", CodeChiffre = 136, Fuseauhoraire = null, LibelleENG = "CAYMAN ISLANDS", LibelleFR = "CAYMAN ISLANDS" },
                new Pays { PaysId = 55, Code2car = "CY", Code3car = "CYP", CodeChiffre = 196, Fuseauhoraire = null, LibelleENG = "CYPRUS", LibelleFR = "CHYPRE" },
                new Pays { PaysId = 56, Code2car = "CZ", Code3car = "CZE", CodeChiffre = 203, Fuseauhoraire = null, LibelleENG = "CZECH REPUBLIC", LibelleFR = "CZECH REPUBLIC" },
                new Pays { PaysId = 57, Code2car = "DE", Code3car = "DEU", CodeChiffre = 276, Fuseauhoraire = null, LibelleENG = "GERMANY", LibelleFR = "ALLEMAGNE" },
                new Pays { PaysId = 58, Code2car = "DJ", Code3car = "DJI", CodeChiffre = 262, Fuseauhoraire = null, LibelleENG = "DJIBOUTI", LibelleFR = "DJIBOUTI" },
                new Pays { PaysId = 59, Code2car = "DM", Code3car = "DMA", CodeChiffre = 212, Fuseauhoraire = null, LibelleENG = "DOMINICA", LibelleFR = "DOMINICA" },
                new Pays { PaysId = 60, Code2car = "DK", Code3car = "DNK", CodeChiffre = 208, Fuseauhoraire = null, LibelleENG = "DENMARK", LibelleFR = "DANEMARK" },
                new Pays { PaysId = 61, Code2car = "DO", Code3car = "DOM", CodeChiffre = 214, Fuseauhoraire = null, LibelleENG = "DOMINICAN REPUBLIC", LibelleFR = "DOMINICAN REPUBLIC" },
                new Pays { PaysId = 62, Code2car = "DZ", Code3car = "DZA", CodeChiffre = 12, Fuseauhoraire = null, LibelleENG = "ALGERIA", LibelleFR = "ALGERIE" },
                new Pays { PaysId = 63, Code2car = "EC", Code3car = "ECU", CodeChiffre = 218, Fuseauhoraire = null, LibelleENG = "ECUADOR", LibelleFR = "EQUATEUR" },
                new Pays { PaysId = 64, Code2car = "EG", Code3car = "EGY", CodeChiffre = 818, Fuseauhoraire = null, LibelleENG = "EGYPT", LibelleFR = "EGYPTE" },
                new Pays { PaysId = 65, Code2car = "ER", Code3car = "ERI", CodeChiffre = 232, Fuseauhoraire = null, LibelleENG = "ERITREA", LibelleFR = "ERYTHREE" },
                new Pays { PaysId = 66, Code2car = "EH", Code3car = "ESH", CodeChiffre = 732, Fuseauhoraire = null, LibelleENG = "WESTERN SAHARA", LibelleFR = "SAHARA OCCIDENTAL" },
                new Pays { PaysId = 67, Code2car = "ES", Code3car = "ESP", CodeChiffre = 724, Fuseauhoraire = null, LibelleENG = "SPAIN", LibelleFR = "ESPAGNE" },
                new Pays { PaysId = 68, Code2car = "EE", Code3car = "EST", CodeChiffre = 233, Fuseauhoraire = null, LibelleENG = "ESTONIA", LibelleFR = "ETHIOPIE" },
                new Pays { PaysId = 69, Code2car = "ET", Code3car = "ETH", CodeChiffre = 231, Fuseauhoraire = null, LibelleENG = "ETHIOPIA", LibelleFR = "CAPVERT" },
                new Pays { PaysId = 70, Code2car = "FI", Code3car = "FIN", CodeChiffre = 246, Fuseauhoraire = null, LibelleENG = "FINLAND", LibelleFR = "FINLANDE" },
                new Pays { PaysId = 71, Code2car = "FJ", Code3car = "FJI", CodeChiffre = 242, Fuseauhoraire = null, LibelleENG = "FIJI", LibelleFR = "FIDJI" },
                new Pays { PaysId = 72, Code2car = "FK", Code3car = "FLK", CodeChiffre = 238, Fuseauhoraire = null, LibelleENG = "FALKLAND ISLANDS (MALVINAS)", LibelleFR = "FALKLAND ISLANDS (MALVINAS)" },
                new Pays { PaysId = 73, Code2car = "FR", Code3car = "FRA", CodeChiffre = 250, Fuseauhoraire = null, LibelleENG = "FRANCE", LibelleFR = "FRANCE" },
                new Pays { PaysId = 74, Code2car = "FO", Code3car = "FRO", CodeChiffre = 234, Fuseauhoraire = null, LibelleENG = "FAROE ISLANDS", LibelleFR = "FAROE ISLANDS" },
                new Pays { PaysId = 75, Code2car = "FM", Code3car = "FSM", CodeChiffre = 583, Fuseauhoraire = null, LibelleENG = "MICRONESIA, FEDERATED STATES OF", LibelleFR = "MICRONESIA, FEDERATED STATES OF" },
                new Pays { PaysId = 76, Code2car = "FX", Code3car = "FXX", CodeChiffre = 249, Fuseauhoraire = null, LibelleENG = "FRANCE, METROPOLITAN", LibelleFR = "FRANCE, METROPOLITAN" },
                new Pays { PaysId = 77, Code2car = "GA", Code3car = "GAB", CodeChiffre = 266, Fuseauhoraire = null, LibelleENG = "GABON", LibelleFR = "GABON" },
                new Pays { PaysId = 78, Code2car = "GB", Code3car = "GBR", CodeChiffre = 826, Fuseauhoraire = null, LibelleENG = "UNITED KINGDOM", LibelleFR = "ROYAUME UNI" },
                new Pays { PaysId = 79, Code2car = "GE", Code3car = "GEO", CodeChiffre = 268, Fuseauhoraire = null, LibelleENG = "GEORGIA", LibelleFR = "GEORGIE" },
                new Pays { PaysId = 80, Code2car = "GH", Code3car = "GHA", CodeChiffre = 288, Fuseauhoraire = null, LibelleENG = "GHANA", LibelleFR = "GHANA" },
                new Pays { PaysId = 81, Code2car = "GI", Code3car = "GIB", CodeChiffre = 292, Fuseauhoraire = null, LibelleENG = "GIBRALTAR", LibelleFR = "GIBRALTAR" },
                new Pays { PaysId = 82, Code2car = "GN", Code3car = "GIN", CodeChiffre = 324, Fuseauhoraire = null, LibelleENG = "GUINEA", LibelleFR = "GUINEE CONAKRY" },
                new Pays { PaysId = 83, Code2car = "GP", Code3car = "GLP", CodeChiffre = 312, Fuseauhoraire = null, LibelleENG = "GUADELOUPE", LibelleFR = "GUADELOUPE" },
                new Pays { PaysId = 84, Code2car = "GM", Code3car = "GMB", CodeChiffre = 270, Fuseauhoraire = null, LibelleENG = "GAMBIA", LibelleFR = "GAMBIE" },
                new Pays { PaysId = 85, Code2car = "GW", Code3car = "GNB", CodeChiffre = 624, Fuseauhoraire = null, LibelleENG = "GUINEA-BISSAU", LibelleFR = "GUINEE-BISSAU" },
                new Pays { PaysId = 86, Code2car = "GQ", Code3car = "GNQ", CodeChiffre = 226, Fuseauhoraire = null, LibelleENG = "EQUATORIAL GUINEA", LibelleFR = "GUINEE EQUATORIALE" },
                new Pays { PaysId = 87, Code2car = "GR", Code3car = "GRC", CodeChiffre = 300, Fuseauhoraire = null, LibelleENG = "GREECE", LibelleFR = "GRECE" },
                new Pays { PaysId = 88, Code2car = "GD", Code3car = "GRD", CodeChiffre = 308, Fuseauhoraire = null, LibelleENG = "GRENADA", LibelleFR = "GRENADE" },
                new Pays { PaysId = 89, Code2car = "GL", Code3car = "GRL", CodeChiffre = 304, Fuseauhoraire = null, LibelleENG = "GREENLAND", LibelleFR = "GREENLAND" },
                new Pays { PaysId = 90, Code2car = "GT", Code3car = "GTM", CodeChiffre = 320, Fuseauhoraire = null, LibelleENG = "GUATEMALA", LibelleFR = "GUATEMALA" },
                new Pays { PaysId = 91, Code2car = "GF", Code3car = "GUF", CodeChiffre = 254, Fuseauhoraire = null, LibelleENG = "FRENCH GUIANA", LibelleFR = "GUYANE FRANCAISE" },
                new Pays { PaysId = 92, Code2car = "GU", Code3car = "GUM", CodeChiffre = 316, Fuseauhoraire = null, LibelleENG = "GUAM", LibelleFR = "GUAM" },
                new Pays { PaysId = 93, Code2car = "GY", Code3car = "GUY", CodeChiffre = 328, Fuseauhoraire = null, LibelleENG = "GUYANA", LibelleFR = "GUYANE" },
                new Pays { PaysId = 94, Code2car = "HK", Code3car = "HKG", CodeChiffre = 344, Fuseauhoraire = null, LibelleENG = "HONG KONG", LibelleFR = "HONG KONG" },
                new Pays { PaysId = 95, Code2car = "HM", Code3car = "HMD", CodeChiffre = 334, Fuseauhoraire = null, LibelleENG = "HEARD AND MC DONALD ISLANDS", LibelleFR = "HEARD AND MC DONALD ISLANDS" },
                new Pays { PaysId = 96, Code2car = "HN", Code3car = "HND", CodeChiffre = 340, Fuseauhoraire = null, LibelleENG = "HONDURAS", LibelleFR = "HONDURAS" },
                new Pays { PaysId = 97, Code2car = "HR", Code3car = "HRV", CodeChiffre = 191, Fuseauhoraire = null, LibelleENG = "CROATIA (local name: Hrvatska)", LibelleFR = "CROATIE" },
                new Pays { PaysId = 98, Code2car = "HT", Code3car = "HTI", CodeChiffre = 332, Fuseauhoraire = null, LibelleENG = "HAITI", LibelleFR = "HAITI" },
                new Pays { PaysId = 99, Code2car = "HU", Code3car = "HUN", CodeChiffre = 348, Fuseauhoraire = null, LibelleENG = "HUNGARY", LibelleFR = "HONGRIE" },
                new Pays { PaysId = 100, Code2car = "ID", Code3car = "IDN", CodeChiffre = 360, Fuseauhoraire = null, LibelleENG = "INDONESIA", LibelleFR = "INDONESIE" }
            );
        }
    }
}
