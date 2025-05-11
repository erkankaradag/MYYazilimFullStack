using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityChatMail.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderMail",
                table: "Messages",
                newName: "SenderEmail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderEmail",
                table: "Messages",
                newName: "SenderMail");
        }
    }
}
