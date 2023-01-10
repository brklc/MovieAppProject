using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieProject.Entity.Migrations
{
    /// <inheritdoc />
    public partial class initTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adult = table.Column<bool>(type: "bit", nullable: false),
                    Backdroppath = table.Column<string>(name: "Backdrop_path", type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<int>(type: "int", nullable: false),
                    Homepage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imdbid = table.Column<string>(name: "Imdb_id", type: "nvarchar(max)", nullable: false),
                    Originallanguage = table.Column<string>(name: "Original_language", type: "nvarchar(max)", nullable: false),
                    Originaltitle = table.Column<string>(name: "Original_title", type: "nvarchar(max)", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Popularity = table.Column<double>(type: "float", nullable: false),
                    Posterpath = table.Column<string>(name: "Poster_path", type: "nvarchar(max)", nullable: false),
                    Releasedate = table.Column<string>(name: "Release_date", type: "nvarchar(max)", nullable: false),
                    Revenue = table.Column<int>(type: "int", nullable: false),
                    Runtime = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tagline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<bool>(type: "bit", nullable: false),
                    Voteaverage = table.Column<double>(name: "Vote_average", type: "float", nullable: false),
                    Votecount = table.Column<int>(name: "Vote_count", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BelongsToCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posterpath = table.Column<string>(name: "Poster_path", type: "nvarchar(max)", nullable: false),
                    Backdroppath = table.Column<string>(name: "Backdrop_path", type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BelongsToCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BelongsToCollections_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logopath = table.Column<string>(name: "Logo_path", type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origincountry = table.Column<string>(name: "Origin_country", type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionCompanies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionCountries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iso31661 = table.Column<string>(name: "Iso_3166_1", type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionCountries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionCountries_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpokenLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Englishname = table.Column<string>(name: "English_name", type: "nvarchar(max)", nullable: false),
                    Iso6391 = table.Column<string>(name: "Iso_639_1", type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpokenLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spoken_languages_Movie",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BelongsToCollections_MovieId",
                table: "BelongsToCollections",
                column: "MovieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieId",
                table: "Genres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionCompanies_MovieId",
                table: "ProductionCompanies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionCountries_MovieId",
                table: "ProductionCountries",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_SpokenLanguages_MovieId",
                table: "SpokenLanguages",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BelongsToCollections");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "ProductionCompanies");

            migrationBuilder.DropTable(
                name: "ProductionCountries");

            migrationBuilder.DropTable(
                name: "SpokenLanguages");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
