using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AjusteArchivosAdjuntos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_archivoAdjuntos_Tareas_TareaId",
                table: "archivoAdjuntos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_archivoAdjuntos",
                table: "archivoAdjuntos");

            migrationBuilder.RenameTable(
                name: "archivoAdjuntos",
                newName: "ArchivosAdjuntos");

            migrationBuilder.RenameIndex(
                name: "IX_archivoAdjuntos_TareaId",
                table: "ArchivosAdjuntos",
                newName: "IX_ArchivosAdjuntos_TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArchivosAdjuntos",
                table: "ArchivosAdjuntos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArchivosAdjuntos_Tareas_TareaId",
                table: "ArchivosAdjuntos",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArchivosAdjuntos_Tareas_TareaId",
                table: "ArchivosAdjuntos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArchivosAdjuntos",
                table: "ArchivosAdjuntos");

            migrationBuilder.RenameTable(
                name: "ArchivosAdjuntos",
                newName: "archivoAdjuntos");

            migrationBuilder.RenameIndex(
                name: "IX_ArchivosAdjuntos_TareaId",
                table: "archivoAdjuntos",
                newName: "IX_archivoAdjuntos_TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_archivoAdjuntos",
                table: "archivoAdjuntos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_archivoAdjuntos_Tareas_TareaId",
                table: "archivoAdjuntos",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
