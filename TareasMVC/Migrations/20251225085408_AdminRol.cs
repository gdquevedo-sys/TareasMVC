using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF NOT EXISTS(Select Id from AspNetRoles where Id = 'ed7b3a43-c734-436e-be8f-bedcb27d3738')
                BEGIN
	            INSERT AspNetRoles (Id, [Name], [NormalizedName])
	            VALUES ('ed7b3a43-c734-436e-be8f-bedcb27d3738','admin','ADMIN')
                END
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = 'ed7b3a43-c734-436e-be8f-bedcb27d3738'");
        }
    }
}
