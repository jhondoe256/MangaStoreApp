using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangaHut.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedStoreMangaDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreManga_Mangas_MangaId",
                table: "StoreManga");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreManga_Stores_StoreId",
                table: "StoreManga");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreManga",
                table: "StoreManga");

            migrationBuilder.RenameTable(
                name: "StoreManga",
                newName: "StoreMangas");

            migrationBuilder.RenameIndex(
                name: "IX_StoreManga_StoreId",
                table: "StoreMangas",
                newName: "IX_StoreMangas_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreManga_MangaId",
                table: "StoreMangas",
                newName: "IX_StoreMangas_MangaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreMangas",
                table: "StoreMangas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreMangas_Mangas_MangaId",
                table: "StoreMangas",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreMangas_Stores_StoreId",
                table: "StoreMangas",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreMangas_Mangas_MangaId",
                table: "StoreMangas");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreMangas_Stores_StoreId",
                table: "StoreMangas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreMangas",
                table: "StoreMangas");

            migrationBuilder.RenameTable(
                name: "StoreMangas",
                newName: "StoreManga");

            migrationBuilder.RenameIndex(
                name: "IX_StoreMangas_StoreId",
                table: "StoreManga",
                newName: "IX_StoreManga_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreMangas_MangaId",
                table: "StoreManga",
                newName: "IX_StoreManga_MangaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreManga",
                table: "StoreManga",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreManga_Mangas_MangaId",
                table: "StoreManga",
                column: "MangaId",
                principalTable: "Mangas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreManga_Stores_StoreId",
                table: "StoreManga",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
