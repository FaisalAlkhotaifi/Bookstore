using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BS202_Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BS202_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BS204_Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BS204_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BS401_BookCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BS401_BookCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BS203_Bookstore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BS204_Customer_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BS203_Bookstore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BS203_Bookstore_BS204_Customer_BS204_Customer_Id",
                        column: x => x.BS204_Customer_Id,
                        principalTable: "BS204_Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "BS201_Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BS401_BookCategory_Id = table.Column<int>(type: "int", nullable: false),
                    BS202_Author_Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BS201_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BS201_Book_BS202_Author_BS202_Author_Id",
                        column: x => x.BS202_Author_Id,
                        principalTable: "BS202_Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BS201_Book_BS401_BookCategory_BS401_BookCategory_Id",
                        column: x => x.BS401_BookCategory_Id,
                        principalTable: "BS401_BookCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BS205_Book_Bookstore",
                columns: table => new
                {
                    BS201_Book_Id = table.Column<int>(type: "int", nullable: false),
                    BS203_Bookstore_Id = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "IX_BS201_Book_BS202_Author_Id",
                table: "BS201_Book",
                column: "BS202_Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BS201_Book_BS401_BookCategory_Id",
                table: "BS201_Book",
                column: "BS401_BookCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BS201_Book_PublishDate",
                table: "BS201_Book",
                column: "PublishDate");

            migrationBuilder.CreateIndex(
                name: "IX_BS201_Book_Title",
                table: "BS201_Book",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_BS203_Bookstore_BS204_Customer_Id",
                table: "BS203_Bookstore",
                column: "BS204_Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BS205_Book_Bookstore_BS203_Bookstore_Id",
                table: "BS205_Book_Bookstore",
                column: "BS203_Bookstore_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BS205_Book_Bookstore");

            migrationBuilder.DropTable(
                name: "BS201_Book");

            migrationBuilder.DropTable(
                name: "BS203_Bookstore");

            migrationBuilder.DropTable(
                name: "BS202_Author");

            migrationBuilder.DropTable(
                name: "BS401_BookCategory");

            migrationBuilder.DropTable(
                name: "BS204_Customer");
        }
    }
}
