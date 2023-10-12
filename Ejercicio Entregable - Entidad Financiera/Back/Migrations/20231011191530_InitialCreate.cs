using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "CuentasBancarias",
                columns: table => new
                {
                    NumeroCuenta = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: true),
                    Titular_CuentaIdCliente = table.Column<int>(type: "int", nullable: true),
                    NombreTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasBancarias", x => x.NumeroCuenta);
                    table.ForeignKey(
                        name: "FK_CuentasBancarias_Clientes_Titular_CuentaIdCliente",
                        column: x => x.Titular_CuentaIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                });

            migrationBuilder.CreateTable(
                name: "TarjetasDeCredito",
                columns: table => new
                {
                    NumeroTarjeta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LimiteCredito = table.Column<double>(type: "float", nullable: true),
                    Saldo = table.Column<double>(type: "float", nullable: true),
                    MontoDeuda = table.Column<double>(type: "float", nullable: true),
                    TitularIdCliente = table.Column<int>(type: "int", nullable: true),
                    NombreTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarjetasDeCredito", x => x.NumeroTarjeta);
                    table.ForeignKey(
                        name: "FK_TarjetasDeCredito_Clientes_TitularIdCliente",
                        column: x => x.TitularIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuentasBancarias_Titular_CuentaIdCliente",
                table: "CuentasBancarias",
                column: "Titular_CuentaIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_TarjetasDeCredito_TitularIdCliente",
                table: "TarjetasDeCredito",
                column: "TitularIdCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentasBancarias");

            migrationBuilder.DropTable(
                name: "TarjetasDeCredito");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
