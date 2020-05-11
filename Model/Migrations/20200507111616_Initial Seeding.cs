using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class InitialSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campussen",
                columns: new[] { "CampusId", "Gemeente", "Huisnummer", "CampusNaam", "Postcode", "Straat" },
                values: new object[,]
                {
                    { 1, "Antwerpen", "22", "Andros", "2018", "Somersstraat" },
                    { 2, "Dendermonde", "17", "Delos", "9200", "Oude Vest" },
                    { 3, "Genk", "37", "Gavdos", "3600", "Europalaan" },
                    { 4, "Heverlee", "2", "Hydra", "3001", "Interleuvenlaan" },
                    { 5, "Wevelgem", "10", "Ikaria", "8560", "Vlamingstraat" },
                    { 6, "Oostende", "4", "Oinouses", "8400", "Archimedesstraat" }
                });

            migrationBuilder.InsertData(
                table: "Landen",
                columns: new[] { "LandCode", "Naam" },
                values: new object[,]
                {
                    { "BE", "België" },
                    { "NL", "Nederland" },
                    { "DE", "Duitsland" },
                    { "FR", "Frankrijk" },
                    { "IT", "Italië" },
                    { "LU", "Luxemburg" }
                });

            migrationBuilder.InsertData(
                table: "Docenten",
                columns: new[] { "DocentId", "CampusId", "Familienaam", "HeeftRijbewijs", "InDienst", "LandCode", "Voornaam", "Maandwedde" },
                values: new object[,]
                {
                    { 5, 1, "Adriaensens", true, new DateTime(2019, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jan", 2100m },
                    { 21, 5, "Baert", false, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dirk", 1000m },
                    { 16, 5, "Anseeuw", null, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Urbain", 1500m },
                    { 12, 5, "Aerts", false, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stefan", 1500m },
                    { 11, 5, "Aerts", true, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", 2000m },
                    { 295, 4, "Vervaecke", false, new DateTime(2019, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julien", 1400m },
                    { 291, 4, "Verschueren", true, new DateTime(2019, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adolf", 1400m },
                    { 274, 4, "Van Impe", false, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucien", 1400m },
                    { 270, 4, "Van Hauwaert", true, new DateTime(2019, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cyrille", 1400m },
                    { 253, 4, "Tchmil", false, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andrei", 1400m },
                    { 249, 4, "Storme", true, new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucien", 1400m },
                    { 232, 4, "Salmon", false, new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Félicien", 1400m },
                    { 228, 4, "Roesems", true, new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bert", 1400m },
                    { 211, 4, "Louis", false, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Victor", 1400m },
                    { 207, 4, "Ollivier", true, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Valère", 1400m },
                    { 190, 4, "Mollin", false, new DateTime(2019, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maurice", 1400m },
                    { 32, 5, "Bauwens", true, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arsène", 2000m },
                    { 186, 4, "Meuleman", true, new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maurice", 1400m },
                    { 33, 5, "Bauwens", false, new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Henri", 1500m },
                    { 42, 5, "Belvaux", false, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean", 1000m },
                    { 121, 5, "Desplenter", null, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1500m },
                    { 117, 5, "Dernies", false, new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michel", 1500m },
                    { 116, 5, "Derijcke", true, new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Germain", 2000m },
                    { 105, 5, "Deloor", false, new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gustaaf", 1000m },
                    { 100, 5, "Decraeye", null, new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1500m },
                    { 96, 5, "De Bruyne", false, new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fred", 1500m },
                    { 95, 5, "Danneels", true, new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gustave", 2000m },
                    { 84, 5, "Capiot", false, new DateTime(2019, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johan", 1000m },
                    { 79, 5, "Bruylandts", null, new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dave", 1500m },
                    { 75, 5, "Brosteaux", false, new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1500m },
                    { 74, 5, "Brichard", true, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emile", 2000m },
                    { 63, 5, "Boonen", false, new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tom", 1000m },
                    { 58, 5, "Boekaerts", null, new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alfons", 1500m },
                    { 54, 5, "Blockx", false, new DateTime(2019, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 1500m },
                    { 53, 5, "Blavier", true, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 2000m },
                    { 37, 5, "Beeckman", null, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Koen", 1500m },
                    { 169, 4, "Lurquin", false, new DateTime(2019, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "André", 1400m },
                    { 165, 4, "Leman", true, new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eric", 1400m },
                    { 148, 4, "Hardiquest", false, new DateTime(2019, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Louis", 1400m },
                    { 280, 3, "Van Santvliet", false, new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", 1300m },
                    { 276, 3, "Van Linden", true, new DateTime(2019, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rik", 1300m },
                    { 269, 3, "Van Geneugden", null, new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Martin", 1900m },
                    { 265, 3, "Vanden Meerschaut", false, new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Odiel", 1900m },
                    { 259, 3, "Van Avermaet", false, new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Greg", 1300m },
                    { 255, 3, "Thys", true, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Philippe", 1300m },
                    { 248, 3, "Sterckx", null, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ernest", 1900m },
                    { 244, 3, "Sercu", false, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Patrick", 1900m },
                    { 238, 3, "Schotte", false, new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Briek", 1300m },
                    { 234, 3, "Scheers", true, new DateTime(2019, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 1300m },
                    { 227, 3, "Ritserveldt", null, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 1900m },
                    { 223, 3, "Rebry", false, new DateTime(2019, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gaston", 1900m },
                    { 217, 3, "Planckaert", false, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 1300m },
                    { 213, 3, "Pirmez", true, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Théodore", 1300m },
                    { 206, 3, "Oellibrandt", null, new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Petrus", 1900m },
                    { 286, 3, "Verbrugghe", false, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rik", 1900m },
                    { 290, 3, "Vermaut", null, new DateTime(2019, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stive", 1900m },
                    { 297, 3, "Vlaemynck", true, new DateTime(2019, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucien", 1300m },
                    { 301, 3, "Walschot", false, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "René", 1300m },
                    { 144, 4, "Grysolle", false, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sylvain", 1400m },
                    { 127, 4, "De Wolf", null, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alfons", 1400m },
                    { 123, 4, "De Vlaeminck", false, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eric", 1400m },
                    { 106, 4, "Deltour", null, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hubert", 1400m },
                    { 102, 4, "De Jonghe", false, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 1400m },
                    { 85, 4, "Cerami", null, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pino", 1400m },
                    { 81, 4, "Buysse", false, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lucien", 1400m },
                    { 126, 5, "Dewaele", false, new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maurice", 1000m },
                    { 64, 4, "Boons", null, new DateTime(2019, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jozef", 1400m },
                    { 43, 4, "Benoit", null, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adelin", 1400m },
                    { 39, 4, "Beeckman", false, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Theophile", 1400m },
                    { 22, 4, "Baert", null, new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hubert", 1400m },
                    { 18, 4, "Arlet", false, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jacques", 1400m },
                    { 4, 4, "Adam", null, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "François", 1700m },
                    { 1, 4, "Abbeloos", null, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 1400m },
                    { 307, 3, "Wauters", false, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marc", 1900m },
                    { 60, 4, "Bogaert", false, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jan", 1400m },
                    { 137, 5, "Farazijn", true, new DateTime(2019, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", 2000m },
                    { 138, 5, "Frison", false, new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Herman", 1500m },
                    { 142, 5, "Godefroot", null, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Walter", 1500m },
                    { 157, 6, "Javaux", false, new DateTime(2019, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Benjamin", 1600m },
                    { 153, 6, "Impanis", true, new DateTime(2019, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Raymond", 1600m },
                    { 140, 6, "Gielen", true, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 1600m },
                    { 136, 6, "Emonds", null, new DateTime(2019, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nico", 1600m },
                    { 132, 6, "Driessens", false, new DateTime(2019, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lomme", 1600m },
                    { 119, 6, "Desimpelaere", true, new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maurice", 1600m },
                    { 115, 6, "Derboven", null, new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 1600m },
                    { 111, 6, "Demuysere", false, new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jef", 1600m },
                    { 98, 6, "De Clerq", true, new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hans", 1600m },
                    { 94, 6, "Daems", null, new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emile", 1600m },
                    { 90, 6, "Corbusier", false, new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yvan", 1600m },
                    { 77, 6, "Bruyère", true, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Marie", 1600m },
                    { 73, 6, "Brankart", null, new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean", 1600m },
                    { 69, 6, "Bracke", false, new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ferdinand", 1600m },
                    { 56, 6, "Bocklandt", true, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 1600m },
                    { 161, 6, "Keteleer", null, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Désiré", 1600m },
                    { 174, 6, "Maes", true, new DateTime(2019, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Romain", 1600m },
                    { 178, 6, "Martin", false, new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jacques", 1600m },
                    { 182, 6, "Meirhaeghe", null, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Filip", 1600m },
                    { 300, 6, "Wallays", true, new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luc", 1600m },
                    { 287, 6, "Verdyck", null, new DateTime(2019, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auguste", 1600m },
                    { 283, 6, "Van Steenbergen", false, new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rik", 1600m },
                    { 279, 6, "Van Petegem", true, new DateTime(2019, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", 1600m },
                    { 266, 6, "Vanderaerden", null, new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eric", 1600m },
                    { 262, 6, "Van Daele", false, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Léon", 1600m },
                    { 258, 6, "Troonbeeckx", true, new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lode", 1600m },
                    { 52, 6, "Billiet", null, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hector", 1600m },
                    { 245, 6, "de Smet", null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Andy", 1600m },
                    { 237, 6, "Scherens", true, new DateTime(2019, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jef", 1600m },
                    { 224, 6, "Renders", null, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jens", 1600m },
                    { 220, 6, "Proost", false, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Louis", 1600m },
                    { 216, 6, "Planckaert", true, new DateTime(2019, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Walter", 1600m },
                    { 203, 6, "Nuyens", null, new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nick", 1600m },
                    { 199, 6, "Nelissen", false, new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wilfried", 1600m },
                    { 195, 6, "Mottard", true, new DateTime(2019, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alfred", 1600m },
                    { 241, 6, "Sellier", false, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Félix", 1600m },
                    { 202, 3, "Nulens", false, new DateTime(2019, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Guy", 1900m },
                    { 48, 6, "Beths", false, new DateTime(2019, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 1600m },
                    { 31, 6, "Baumans", null, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auguste", 1600m },
                    { 222, 5, "Ramon", true, new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 1500m },
                    { 221, 5, "Protin", null, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", 2000m },
                    { 210, 5, "Petitjean", true, new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Luc", 1000m },
                    { 205, 5, "Ockers", false, new DateTime(2019, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stan", 1500m },
                    { 201, 5, "Noyelle", true, new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "André", 1500m },
                    { 200, 5, "Neuville", null, new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "François", 2000m },
                    { 189, 5, "Molenaers", true, new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yvo", 1000m },
                    { 184, 5, "Merckx", false, new DateTime(2019, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eddy", 1500m },
                    { 180, 5, "Mathieu", true, new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Florent", 1500m },
                    { 179, 5, "père", null, new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emile", 2000m },
                    { 168, 5, "Lowie", true, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jules", 1000m },
                    { 163, 5, "Lambot", false, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Firmin", 1500m },
                    { 159, 5, "Kemplaire", true, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Francis", 1500m },
                    { 158, 5, "Kaers", null, new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Karel", 2000m },
                    { 147, 5, "Hamerlinck", true, new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alfred", 1000m },
                    { 226, 5, "Rijckaert", false, new DateTime(2019, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 1500m },
                    { 231, 5, "Rosseel", true, new DateTime(2019, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "André", 1000m },
                    { 242, 5, "Sels", null, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Edward", 2000m },
                    { 243, 5, "Sercu", true, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 1500m },
                    { 27, 6, "Baguet", false, new DateTime(2019, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Serge", 1600m },
                    { 14, 6, "Allard", true, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Henri", 1600m },
                    { 10, 6, "Aerts", null, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mario", 1600m },
                    { 6, 6, "Adriaensens", false, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "René", 1600m },
                    { 306, 5, "Weylandt", true, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wouter", 1500m },
                    { 305, 5, "Wesemael", null, new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wilfried", 2000m },
                    { 294, 5, "Vervaecke", true, new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Félicien", 1000m },
                    { 35, 6, "Beckaert", true, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 1600m },
                    { 289, 5, "Vermandel", false, new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "René", 1500m },
                    { 284, 5, "Van Tongerloo", null, new DateTime(2019, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Guillaume", 2000m },
                    { 273, 5, "Van Hooydonck", true, new DateTime(2019, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Edwig", 1000m },
                    { 268, 5, "Van Genechten", false, new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Richard", 1500m },
                    { 264, 5, "Vandenbroucke", true, new DateTime(2019, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frank", 1500m },
                    { 263, 5, "Van Den Born", null, new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", 2000m }
                });

            migrationBuilder.InsertData(
                table: "Docenten",
                columns: new[] { "DocentId", "CampusId", "Familienaam", "HeeftRijbewijs", "InDienst", "LandCode", "Voornaam", "Maandwedde" },
                values: new object[,]
                {
                    { 252, 5, "Targez", true, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arthur", 1000m },
                    { 247, 5, "Steels", false, new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tom", 1500m },
                    { 285, 5, "Vantyghem", true, new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Noël", 1500m },
                    { 304, 6, "Wellens", false, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bart", 1600m },
                    { 196, 3, "Mottart", false, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ernest", 1300m },
                    { 185, 3, "Messelis", null, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "André", 1900m },
                    { 288, 1, "Verhaert", true, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jozef", 1100m },
                    { 281, 1, "Van Schil", null, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Victor", 1700m },
                    { 278, 1, "Vannitsen", null, new DateTime(2019, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 2100m },
                    { 277, 1, "Van Looy", false, new DateTime(2019, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rik", 1700m },
                    { 267, 1, "Van de Wouwer", true, new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kurt", 1100m },
                    { 260, 1, "Van Bruaene", null, new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Armand", 1700m },
                    { 257, 1, "Tommies", null, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Léon", 2100m },
                    { 256, 1, "Tiberghien", false, new DateTime(2019, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hector", 1700m },
                    { 246, 1, "Somers", true, new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 1100m },
                    { 239, 1, "Schoubben", null, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 1700m },
                    { 236, 1, "Scherens", null, new DateTime(2019, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 2100m },
                    { 235, 1, "Schepers", false, new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alfons", 1700m },
                    { 225, 1, "Reybrouck", true, new DateTime(2019, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Guido", 1100m },
                    { 218, 1, "Pollentier", null, new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michel", 1700m },
                    { 215, 1, "Planckaert", null, new DateTime(2019, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jo", 2100m },
                    { 298, 1, "Vlaeyen", false, new DateTime(2019, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "André", 1700m },
                    { 214, 1, "Planckaert", false, new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eddy", 1700m },
                    { 299, 1, "Vliegen", null, new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean", 2100m },
                    { 309, 1, "Wouters", true, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jozef", 1100m },
                    { 82, 2, "Brandt", null, new DateTime(2019, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Christophe", 1800m },
                    { 72, 2, "Brands", false, new DateTime(2019, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 1200m },
                    { 65, 2, "Borra", true, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gabriel", 1800m },
                    { 62, 2, "Bonduel", true, new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 2200m },
                    { 61, 2, "Bogaerts", null, new DateTime(2019, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean", 1800m },
                    { 51, 2, "Billiet", false, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 1200m },
                    { 44, 2, "Benoit", true, new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auguste", 1800m },
                    { 41, 2, "Beirnaert", true, new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 2200m },
                    { 40, 2, "Beheyt", null, new DateTime(2019, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Benoni", 1800m },
                    { 30, 2, "Barras", false, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1200m },
                    { 23, 2, "Baert", true, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Pierre", 1800m },
                    { 20, 2, "Baens", true, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 2200m },
                    { 19, 2, "Arras", null, new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wim", 1800m },
                    { 9, 2, "Aerts", false, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean", 1200m },
                    { 2, 2, "Abelshausen", true, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 1800m },
                    { 302, 1, "Wampers", null, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Marie", 1700m },
                    { 204, 1, "Nys", true, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sven", 1100m },
                    { 197, 1, "Mottiat", null, new DateTime(2019, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Louis", 1700m },
                    { 194, 1, "Moreels", null, new DateTime(2019, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sammie", 2100m },
                    { 88, 1, "Clerckx", null, new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Karel", 1700m },
                    { 78, 1, "Bruyere", false, new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 1100m },
                    { 71, 1, "Braekevelt", true, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Omer", 1700m },
                    { 68, 1, "Boumon", true, new DateTime(2019, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 2100m },
                    { 67, 1, "Boucquet", null, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Walter", 1700m },
                    { 57, 1, "Bodart", false, new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emile", 1100m },
                    { 50, 1, "Beyssens", true, new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Herman", 1700m },
                    { 47, 1, "Berton", true, new DateTime(2019, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 2100m },
                    { 46, 1, "Berckmans", null, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Pierre", 1700m },
                    { 36, 1, "Beckaert", false, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 1100m },
                    { 29, 1, "Barbé", true, new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Koen", 1700m },
                    { 26, 1, "Baguet", true, new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 2100m },
                    { 25, 1, "Baeyens", null, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jan", 1700m },
                    { 15, 1, "Anciaux", false, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Albert", 1100m },
                    { 8, 1, "Aerts", true, new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emile", 1700m },
                    { 89, 1, "Close", true, new DateTime(2019, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alex", 2100m },
                    { 92, 1, "Cretskens", true, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wilfried", 1700m },
                    { 99, 1, "Decock", false, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 1100m },
                    { 109, 1, "De Mulder", null, new DateTime(2019, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 1700m },
                    { 193, 1, "Monty", false, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 1700m },
                    { 183, 1, "Merckx", true, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Axel", 1100m },
                    { 176, 1, "Marchand", null, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 1700m },
                    { 173, 1, "Maertens", null, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Freddy", 2100m },
                    { 172, 1, "Maelbrancke", false, new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "André", 1700m },
                    { 162, 1, "Kint", true, new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 1100m },
                    { 155, 1, "In''t", null, new DateTime(2019, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Willy", 1700m },
                    { 83, 2, "Callens", true, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Norbert", 2200m },
                    { 152, 1, "Hulsmans", null, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kevin", 2100m },
                    { 141, 1, "Gijssels", false, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Romain", 1100m },
                    { 134, 1, "Dupont", true, new DateTime(2019, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 1700m },
                    { 131, 1, "Dictus", true, new DateTime(2019, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 2100m },
                    { 130, 1, "Dierckxsens", null, new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ludo", 1700m },
                    { 120, 1, "Desmet", false, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gilbert", 1100m },
                    { 113, 1, "Depoorter", true, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Richard", 1700m },
                    { 110, 1, "De Muynck", true, new DateTime(2019, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johan", 2100m },
                    { 151, 1, "Hoevenaers", false, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 1700m },
                    { 86, 2, "Christiaens", true, new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1800m },
                    { 93, 2, "Criquielion", false, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Claude", 1200m },
                    { 103, 2, "Delbecque", null, new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Julien", 1800m },
                    { 76, 3, "Bruneau", null, new DateTime(2019, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emile", 1900m },
                    { 70, 3, "Braeckeveldt", null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adolphe", 1300m },
                    { 66, 3, "Bosmans", false, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 1300m },
                    { 59, 3, "Bogaert", true, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cesar", 1900m },
                    { 55, 3, "Blomme", null, new DateTime(2019, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maurice", 1900m },
                    { 49, 3, "Beyens", null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "René", 1300m },
                    { 45, 3, "Berben", false, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jef", 1300m },
                    { 38, 3, "Beeckman", true, new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kamiel", 1900m },
                    { 34, 3, "Bayens", null, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jules", 1900m },
                    { 28, 3, "Balducq", null, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gérard", 1300m },
                    { 24, 3, "Baeyens", false, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Armand", 1300m },
                    { 17, 3, "Antheunis", true, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Etienne", 1900m },
                    { 13, 3, "Alexander", null, new DateTime(2019, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "François", 1900m },
                    { 7, 3, "Aerenhouts", null, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 1300m },
                    { 3, 3, "Achten", false, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Joseph", 1300m },
                    { 80, 3, "Bruyneel", true, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johan", 1900m },
                    { 87, 3, "Claes", false, new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1300m },
                    { 91, 3, "Couvreur", null, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hilaire", 1300m },
                    { 97, 3, "Decabooter", null, new DateTime(2019, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arthur", 1900m },
                    { 181, 3, "Mattan", false, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nico", 1900m },
                    { 175, 3, "Maes", false, new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sylvère", 1300m },
                    { 171, 3, "Machiels", true, new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pierrot", 1300m },
                    { 164, 3, "Lambrecht", null, new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 1900m },
                    { 160, 3, "Kerckhove", false, new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Norbert", 1900m },
                    { 154, 3, "In''t", false, new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", 1300m },
                    { 150, 3, "Hendrikx", true, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 1300m },
                    { 303, 2, "Wancour", true, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Robert", 1200m },
                    { 143, 3, "Govaerts", true, new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dries", 1900m },
                    { 133, 3, "Drioul", null, new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gustave", 1300m },
                    { 129, 3, "D''Hooghe", false, new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Michel", 1300m },
                    { 122, 3, "Despontin", true, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Léon", 1900m },
                    { 118, 3, "Deruyter", null, new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Charles", 1900m },
                    { 112, 3, "Depoorter", null, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jules", 1300m },
                    { 108, 3, "Demeyer", false, new DateTime(2019, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marc", 1300m },
                    { 101, 3, "Defraeye", true, new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Odiel", 1900m },
                    { 139, 3, "Garnier", null, new DateTime(2019, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Henri", 1900m },
                    { 192, 3, "Monséré", true, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean-Pierre", 1300m },
                    { 296, 2, "Vissers", null, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Edward", 1800m },
                    { 292, 2, "Verschueren", false, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Constant", 1800m },
                    { 177, 2, "Martens", true, new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "René", 1200m },
                    { 170, 2, "Rik", null, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Henri", 1800m },
                    { 167, 2, "Liboton", null, new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roland", 2200m },
                    { 166, 2, "Leroy", false, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Camille", 1800m },
                    { 156, 2, "Janssens", true, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcel", 1200m },
                    { 149, 2, "Hardy", null, new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emile", 1800m },
                    { 146, 2, "Haghedooren", null, new DateTime(2019, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", 2200m },
                    { 145, 2, "Gyselinck", true, new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 1800m },
                    { 135, 2, "Eeckhout", false, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Niko", 1200m },
                    { 128, 2, "Dhaenens", true, new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rudy", 1800m },
                    { 125, 2, "Devolder", true, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stijn", 2200m },
                    { 124, 2, "De Vlaeminck", null, new DateTime(2019, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 1800m },
                    { 114, 2, "Depredomme", false, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Prosper", 1200m },
                    { 107, 2, "Deman", true, new DateTime(2019, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Paul", 1800m },
                    { 104, 2, "Deloor", true, new DateTime(2019, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alfons", 2200m },
                    { 187, 2, "Meulenberg", false, new DateTime(2019, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eloi", 1800m },
                    { 188, 2, "Mintjens", null, new DateTime(2019, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Frans", 2200m },
                    { 191, 2, "Mommerency", null, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Arthur", 1800m },
                    { 198, 2, "Museeuw", true, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johan", 1200m },
                    { 282, 2, "van Springel", true, new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Herman", 1200m },
                    { 275, 2, "Van Kerkhove", null, new DateTime(2019, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Henri", 1800m },
                    { 272, 2, "Van Hevel", null, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jules", 2200m },
                    { 271, 2, "Van Herzele", false, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maurice", 1800m },
                    { 261, 2, "Vanconingsloo", true, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1200m },
                    { 254, 2, "Thoma", null, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emmanuel", 1800m },
                    { 251, 2, "Swerts", null, new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roger", 2200m },
                    { 293, 2, "Verstrepen", null, new DateTime(2019, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Johan", 2200m },
                    { 250, 2, "Stubbe", false, new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tom", 1800m }
                });

            migrationBuilder.InsertData(
                table: "Docenten",
                columns: new[] { "DocentId", "CampusId", "Familienaam", "HeeftRijbewijs", "InDienst", "LandCode", "Voornaam", "Maandwedde" },
                values: new object[,]
                {
                    { 233, 2, "Schaeken", null, new DateTime(2019, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Léopold", 1800m },
                    { 230, 2, "Ronsse", null, new DateTime(2019, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 2200m },
                    { 229, 2, "Rolus", false, new DateTime(2019, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Louis", 1800m },
                    { 219, 2, "Poncelet", true, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Léon", 1200m },
                    { 212, 2, "Pintens", null, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Georges", 1800m },
                    { 209, 2, "Peeters", null, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Edward", 2200m },
                    { 208, 2, "Peelman", false, new DateTime(2019, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eddy", 1800m },
                    { 240, 2, "Scieur", true, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Léon", 1200m },
                    { 308, 6, "Willems", null, new DateTime(2019, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Daniel", 1600m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "LandCode",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "LandCode",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "LandCode",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "LandCode",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "LandCode",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "LandCode",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 6);
        }
    }
}
