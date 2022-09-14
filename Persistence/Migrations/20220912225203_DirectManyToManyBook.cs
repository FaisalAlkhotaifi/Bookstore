using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class DirectManyToManyBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BS205_Book_Bookstore");

            migrationBuilder.CreateTable(
                name: "BS205_BookBookstore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BookstoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BS205_BookBookstore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BS205_BookBookstore_BS201_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "BS201_Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BS205_BookBookstore_BS203_Bookstore_BookstoreId",
                        column: x => x.BookstoreId,
                        principalTable: "BS203_Bookstore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BS205_BookBookstore_BookId",
                table: "BS205_BookBookstore",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BS205_BookBookstore_BookstoreId",
                table: "BS205_BookBookstore",
                column: "BookstoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BS205_BookBookstore");

            migrationBuilder.CreateTable(
                name: "BS205_Book_Bookstore",
                columns: table => new
                {
                    BS201_Book_Id = table.Column<int>(type: "int", nullable: false),
                    BS203_Bookstore_Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BS205_Book_Bookstore", x => new { x.BS201_Book_Id, x.BS203_Bookstore_Id });
                    table.ForeignKey(
                        name: "FK_BS205_Book_Bookstore_BS201_Book_BS201_Book_Id",
                        column: x => x.BS201_Book_Id,
                        principalTable: "BS201_Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BS205_Book_Bookstore_BS203_Bookstore_BS203_Bookstore_Id",
                        column: x => x.BS203_Bookstore_Id,
                        principalTable: "BS203_Bookstore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BS205_Book_Bookstore_BS203_Bookstore_Id",
                table: "BS205_Book_Bookstore",
                column: "BS203_Bookstore_Id");
        }
    }
}
