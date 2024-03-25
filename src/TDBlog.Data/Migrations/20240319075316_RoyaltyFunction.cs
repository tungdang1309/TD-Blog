using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TDBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoyaltyFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToSatatus",
                table: "PostActibityLogs",
                newName: "ToStatus");

            migrationBuilder.AddColumn<double>(
                name: "RoyaltyAmountPerPost",
                table: "AppUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromUserName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FromUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToUserName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropColumn(
                name: "RoyaltyAmountPerPost",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "ToStatus",
                table: "PostActibityLogs",
                newName: "ToSatatus");
        }
    }
}
