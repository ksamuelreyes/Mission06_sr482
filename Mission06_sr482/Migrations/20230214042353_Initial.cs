using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_sr482.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "Guillermo Del Toro", false, "", "", "PG-13", "Pacific Rim", 2013 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sci-Fi", "Christopher Nolan", false, "", "", "PG-13", "Interstellar", 2014 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action", "Ryan Coogler", false, "", "", "PG-13", "Black Panther", 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
