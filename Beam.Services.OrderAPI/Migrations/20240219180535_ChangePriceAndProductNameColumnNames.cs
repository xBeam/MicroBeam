using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beam.Services.OrderAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangePriceAndProductNameColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "OrderDetails",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderDetails",
                newName: "ProductPrice");
        }
    }
}
