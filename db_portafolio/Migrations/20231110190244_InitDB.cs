using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace db_portafolio.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pf_language",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    url_img = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_language", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pf_link_grp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_link_grp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pf_project",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    url_img = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    orden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_project", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pf_project_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    url_deploy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    url_repo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_project_list", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pf_technology",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    url_img = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_technology", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pf_link",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    url_link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    id_link_grp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_link", x => x.id);
                    table.ForeignKey(
                        name: "FK_pf_link_pf_link_grp_id_link_grp",
                        column: x => x.id_link_grp,
                        principalTable: "pf_link_grp",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_pro_lang",
                columns: table => new
                {
                    id_project = table.Column<int>(type: "int", nullable: false),
                    id_language = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_pro_lang", x => new { x.id_project, x.id_language });
                    table.ForeignKey(
                        name: "FK_pf_pro_lang_pf_language_id_language",
                        column: x => x.id_language,
                        principalTable: "pf_language",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_pro_lang_pf_project_id_project",
                        column: x => x.id_project,
                        principalTable: "pf_project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_pro_prol",
                columns: table => new
                {
                    id_project = table.Column<int>(type: "int", nullable: false),
                    id_project_list = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_pro_prol", x => new { x.id_project, x.id_project_list });
                    table.ForeignKey(
                        name: "FK_pf_pro_prol_pf_project_id_project",
                        column: x => x.id_project,
                        principalTable: "pf_project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_pro_prol_pf_project_list_id_project_list",
                        column: x => x.id_project_list,
                        principalTable: "pf_project_list",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pf_pro_tech",
                columns: table => new
                {
                    id_project = table.Column<int>(type: "int", nullable: false),
                    id_technology = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_pro_tech", x => new { x.id_project, x.id_technology });
                    table.ForeignKey(
                        name: "FK_pf_pro_tech_pf_project_id_project",
                        column: x => x.id_project,
                        principalTable: "pf_project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pf_pro_tech_pf_technology_id_technology",
                        column: x => x.id_technology,
                        principalTable: "pf_technology",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pf_link_id_link_grp",
                table: "pf_link",
                column: "id_link_grp");

            migrationBuilder.CreateIndex(
                name: "IX_pf_pro_lang_id_language",
                table: "pf_pro_lang",
                column: "id_language");

            migrationBuilder.CreateIndex(
                name: "IX_pf_pro_prol_id_project_list",
                table: "pf_pro_prol",
                column: "id_project_list");

            migrationBuilder.CreateIndex(
                name: "IX_pf_pro_tech_id_technology",
                table: "pf_pro_tech",
                column: "id_technology");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pf_link");

            migrationBuilder.DropTable(
                name: "pf_pro_lang");

            migrationBuilder.DropTable(
                name: "pf_pro_prol");

            migrationBuilder.DropTable(
                name: "pf_pro_tech");

            migrationBuilder.DropTable(
                name: "pf_link_grp");

            migrationBuilder.DropTable(
                name: "pf_language");

            migrationBuilder.DropTable(
                name: "pf_project_list");

            migrationBuilder.DropTable(
                name: "pf_project");

            migrationBuilder.DropTable(
                name: "pf_technology");
        }
    }
}
