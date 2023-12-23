using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoryDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDB", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CompanyDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    CacRegNumber = table.Column<string>(type: "longtext", nullable: true),
                    Logo = table.Column<string>(type: "longtext", nullable: true),
                    CompanyEmail = table.Column<string>(type: "longtext", nullable: true),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDB", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleDB", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Password = table.Column<string>(type: "longtext", nullable: true),
                    UserName = table.Column<string>(type: "longtext", nullable: true),
                    WalletBalance = table.Column<double>(type: "double", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDB", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    TagNumber = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerDB_UserDB_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ManagerDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    CompanyId = table.Column<string>(type: "varchar(255)", nullable: true),
                    StaffNumber = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerDB_CompanyDB_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyDB",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ManagerDB_UserDB_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProfileDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: true),
                    LastName = table.Column<string>(type: "longtext", nullable: true),
                    Image = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileDB_UserDB_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoleDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoleDB_RoleDB_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleDB",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoleDB_UserDB_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WalletDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    NewBalance = table.Column<double>(type: "double", nullable: false),
                    Balance = table.Column<double>(type: "double", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletDB_UserDB_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CartDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    CustomerId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "longtext", nullable: true),
                    MakePayment = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDB_CustomerDB_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    CartId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OrderRefNumber = table.Column<string>(type: "longtext", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDB_CartDB_CartId",
                        column: x => x.CartId,
                        principalTable: "CartDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    CategoryId = table.Column<string>(type: "varchar(255)", nullable: true),
                    CompanyId = table.Column<string>(type: "varchar(255)", nullable: true),
                    QuantityTaken = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<string>(type: "varchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDB_CartDB_CartId",
                        column: x => x.CartId,
                        principalTable: "CartDB",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductDB_CategoryDB_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryDB",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductDB_CompanyDB_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductCartDB",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(255)", nullable: true),
                    CartId = table.Column<string>(type: "varchar(255)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCartDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCartDB_CartDB_CartId",
                        column: x => x.CartId,
                        principalTable: "CartDB",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductCartDB_ProductDB_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductDB",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CartDB_CustomerId",
                table: "CartDB",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDB_UserId",
                table: "CustomerDB",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerDB_CompanyId",
                table: "ManagerDB",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ManagerDB_UserId",
                table: "ManagerDB",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDB_CartId",
                table: "OrderDB",
                column: "CartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCartDB_CartId",
                table: "ProductCartDB",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCartDB_ProductId",
                table: "ProductCartDB",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDB_CartId",
                table: "ProductDB",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDB_CategoryId",
                table: "ProductDB",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDB_CompanyId",
                table: "ProductDB",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileDB_UserId",
                table: "ProfileDB",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleDB_RoleId",
                table: "UserRoleDB",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleDB_UserId",
                table: "UserRoleDB",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletDB_UserId",
                table: "WalletDB",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManagerDB");

            migrationBuilder.DropTable(
                name: "OrderDB");

            migrationBuilder.DropTable(
                name: "ProductCartDB");

            migrationBuilder.DropTable(
                name: "ProfileDB");

            migrationBuilder.DropTable(
                name: "UserRoleDB");

            migrationBuilder.DropTable(
                name: "WalletDB");

            migrationBuilder.DropTable(
                name: "ProductDB");

            migrationBuilder.DropTable(
                name: "RoleDB");

            migrationBuilder.DropTable(
                name: "CartDB");

            migrationBuilder.DropTable(
                name: "CategoryDB");

            migrationBuilder.DropTable(
                name: "CompanyDB");

            migrationBuilder.DropTable(
                name: "CustomerDB");

            migrationBuilder.DropTable(
                name: "UserDB");
        }
    }
}
