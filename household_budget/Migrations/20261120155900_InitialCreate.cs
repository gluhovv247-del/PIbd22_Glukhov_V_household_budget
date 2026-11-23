using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace household_budget.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "family",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    surname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_family", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "operation_categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operation_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "budget_forecasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    projected_income = table.Column<decimal>(type: "numeric", nullable: false),
                    projected_expense = table.Column<decimal>(type: "numeric", nullable: false),
                    family_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_budget_forecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_budget_forecasts_family_family_id",
                        column: x => x.family_id,
                        principalTable: "family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    family_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                    table.CheckConstraint("CK_Budget_EndDate_After_StartDate", "\"end_date\" > \"start_date\"");
                    table.ForeignKey(
                        name: "FK_Budgets_family_family_id",
                        column: x => x.family_id,
                        principalTable: "family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "family_members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FamilyId = table.Column<int>(type: "integer", nullable: false),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_family_members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_family_members_family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "budget_reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    total_income = table.Column<decimal>(type: "numeric", nullable: false),
                    total_expense = table.Column<decimal>(type: "numeric", nullable: false),
                    planned_income = table.Column<decimal>(type: "numeric", nullable: false),
                    planned_expense = table.Column<decimal>(type: "numeric", nullable: false),
                    create_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BudgetId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_budget_reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_budget_reports_Budgets_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "budget_items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    planned_amount = table.Column<decimal>(type: "numeric", nullable: false),
                    budget_id = table.Column<int>(type: "integer", nullable: false),
                    operation_category_id = table.Column<int>(type: "integer", nullable: false),
                    family_member_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_budget_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_budget_items_Budgets_budget_id",
                        column: x => x.budget_id,
                        principalTable: "Budgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_budget_items_family_members_family_member_id",
                        column: x => x.family_member_id,
                        principalTable: "family_members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_budget_items_operation_categories_operation_category_id",
                        column: x => x.operation_category_id,
                        principalTable: "operation_categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OperationCategoryId = table.Column<int>(type: "integer", nullable: false),
                    importance = table.Column<int>(type: "integer", nullable: false),
                    FamilyMemberId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_operations_family_members_FamilyMemberId",
                        column: x => x.FamilyMemberId,
                        principalTable: "family_members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_operations_operation_categories_OperationCategoryId",
                        column: x => x.OperationCategoryId,
                        principalTable: "operation_categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_budget_forecasts_family_id",
                table: "budget_forecasts",
                column: "family_id");

            migrationBuilder.CreateIndex(
                name: "IX_budget_items_budget_id",
                table: "budget_items",
                column: "budget_id");

            migrationBuilder.CreateIndex(
                name: "IX_budget_items_family_member_id",
                table: "budget_items",
                column: "family_member_id");

            migrationBuilder.CreateIndex(
                name: "IX_budget_items_operation_category_id",
                table: "budget_items",
                column: "operation_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_budget_reports_BudgetId",
                table: "budget_reports",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_family_id",
                table: "Budgets",
                column: "family_id");

            migrationBuilder.CreateIndex(
                name: "IX_family_members_FamilyId",
                table: "family_members",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_operations_FamilyMemberId",
                table: "operations",
                column: "FamilyMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_operations_OperationCategoryId",
                table: "operations",
                column: "OperationCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "budget_forecasts");

            migrationBuilder.DropTable(
                name: "budget_items");

            migrationBuilder.DropTable(
                name: "budget_reports");

            migrationBuilder.DropTable(
                name: "operations");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "family_members");

            migrationBuilder.DropTable(
                name: "operation_categories");

            migrationBuilder.DropTable(
                name: "family");
        }
    }
}
