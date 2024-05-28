using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace loginwebapijwt.Migrations
{
    /// <inheritdoc />
    public partial class CreateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "name", "password", "role" },
                values: new object[,]
                {
                    { 1, "admin@devatila.com.br", "Admin Dev Atila", "$2a$11$Z28yNgN3.dTIvRCR3ZCXPuHX.E/LmIgt0gBQu5uk8yMj.Gx3/4Lmm", 0 },
                    { 2, "cliente@devatila.com.br", "Cliente Sicreno do Tal", "$2a$11$Iq8aHyT8M8m382NgxMauIOjy8b9uyQHl7rb10QZN05wr5V185Me/C", 1 },
                    { 3, "funcionario@devatila.com.br", "Usuario Funcionario de Tal", "$2a$11$x1W5HtIVJ0gg7TdIbwD0euoqXIkstqkQFrzuvc0eUDdbUeM0opJSa", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
