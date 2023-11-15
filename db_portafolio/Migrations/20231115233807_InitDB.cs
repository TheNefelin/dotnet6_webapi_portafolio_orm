using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace db_portafolio.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "pf_source",
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
                    table.PrimaryKey("PK_pf_source", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pf_youtube",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    video_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_youtube", x => x.id);
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
                name: "pf_pro_sour",
                columns: table => new
                {
                    id_project = table.Column<int>(type: "int", nullable: false),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pf_pro_sour", x => new { x.id_project, x.id_source });
                    table.ForeignKey(
                        name: "FK_pf_pro_sour_pf_project_id_project",
                        column: x => x.id_project,
                        principalTable: "pf_project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pf_pro_sour_pf_source_id_source",
                        column: x => x.id_source,
                        principalTable: "pf_source",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "pf_link_grp",
                columns: new[] { "id", "estado", "nombre" },
                values: new object[,]
                {
                    { 1, true, "Framework" },
                    { 2, true, "Learning" },
                    { 3, true, "Hosting" },
                    { 4, true, "Images" },
                    { 5, true, "Tools" },
                    { 6, true, "IA" },
                    { 7, true, "Agile" },
                    { 8, true, "My Links" }
                });

            migrationBuilder.InsertData(
                table: "pf_project",
                columns: new[] { "id", "nombre", "orden", "url_img" },
                values: new object[,]
                {
                    { 1, "Tecno Chile", 1, "03-tecno-chile.jpg" },
                    { 2, "Web Components v1.0", 2, "04-web-components-v1.jpg" },
                    { 3, "Kartax v1.0", 3, "01-kartax-v1.jpg" },
                    { 4, "Portafolio V1.0", 4, "02-portafolio-v1.jpg" },
                    { 5, "Game El Cubo v2.0", 5, "05-el-cubo-v2.jpg" },
                    { 6, "Transbank POS Integration v1.0", 6, "06-transbank-pos.png" },
                    { 7, "Arduino DHT Temperature Monitoring by Network", 7, "07-DHT.png" },
                    { 8, "Kartax v2.0", 8, "08-kartax-v2.png" },
                    { 9, "Portafolio v2.0", 9, "09-portafolio-v2.png" },
                    { 10, "Kartax v3.0 (Developing...)", 10, "10-kartax-v3.png" },
                    { 11, "Guides for games", 11, "11-guides-for-games.png" }
                });

            migrationBuilder.InsertData(
                table: "pf_source",
                columns: new[] { "id", "nombre", "url_deploy", "url_repo" },
                values: new object[,]
                {
                    { 1, "Tecno Chile v1.0 app", "https://tecnochile.netlify.app", "https://github.com/TheNefelin/td_trabajo_grupal_03" },
                    { 2, "Slifer api", "https://slifer.bsite.net/index.html", "https://github.com/TheNefelin/td_api.NetCore6" },
                    { 3, "Components v1.0 app", "https://nefelin-components.netlify.app", "https://github.com/TheNefelin/my-web-components" },
                    { 4, "Kartax v1.0 app", "https://kartax.netlify.app", "https://github.com/TheNefelin/kartax-ant" },
                    { 5, "Portafolio app", "https://nefelin-portafolio.netlify.app", "https://github.com/TheNefelin/portafolio-site" },
                    { 6, "Metalflap api", "https://bsite.net/metalflap/index.html", "https://github.com/TheNefelin/portafolio_api.NETCore6" },
                    { 7, "Download Link app", "https://drive.google.com/drive/folders/1qttZk_iN8fHYVjHqI6_VLS4nyT4fTkyu?usp=drive_link", null },
                    { 8, "Transbank POS v1.0 app", null, "https://github.com/TheNefelin/Transbank-POS-v1" },
                    { 9, "Arduino DHT Monitoring", null, "https://github.com/TheNefelin/DHT/tree/master/DHT" },
                    { 10, "Kartax v2.0 app", "https://kartax-express-production.up.railway.app/", "https://github.com/TheNefelin/kartax-express" },
                    { 11, "Kartax v2.0 api", "https://kartax-api-production.up.railway.app", "https://github.com/TheNefelin/kartax-api" },
                    { 12, "Portafolio v2.0 app", "http://www.francisco-dev.cl", "https://github.com/TheNefelin/portafolio-next13" },
                    { 13, "Kartax v3.0 app", "https://kartax-next13.vercel.app/", null },
                    { 14, "Guia v1.0 app", "https://guias-juegos-next13-ts.vercel.app", "https://github.com/TheNefelin/guias-juegos-next13-ts" },
                    { 15, "SQL Server", null, "https://github.com/TheNefelin/SQLServer" }
                });

            migrationBuilder.InsertData(
                table: "pf_youtube",
                columns: new[] { "id", "nombre", "video_id" },
                values: new object[,]
                {
                    { 1, "Jam-Covid", "0WsjRYgZMzs" },
                    { 2, "Sky Lagoon", "qUYQzlj_580" },
                    { 3, "Valhalla", "ktCw2CfWeTA" },
                    { 4, "Yu-Gi-Oh", "2q9liMSxOcE" },
                    { 5, "Monster Hunter", "yPKbPUM9RRc" },
                    { 6, "Final Fantasy XV", "3JlJ2fsOQnU" }
                });

            migrationBuilder.InsertData(
                table: "pf_link",
                columns: new[] { "id", "estado", "id_link_grp", "nombre", "url_link" },
                values: new object[,]
                {
                    { 1, true, 1, "Strapi", "https://strapi.io" },
                    { 2, true, 1, "Mui", "https://mui.com" },
                    { 3, true, 1, "Tailwindcss", "https://tailwindcss.com" },
                    { 4, true, 1, "DaisyUI", "https://daisyui.com" },
                    { 5, true, 1, "NextJS", "https://nextjs.org" },
                    { 6, true, 1, "NextUI", "https://nextui.org" },
                    { 7, true, 1, "NextAuth", "https://next-auth.js.org" },
                    { 8, true, 1, "FastAPI", "https://fastapi.tiangolo.com" },
                    { 9, true, 1, "Tremor", "https://www.tremor.so" },
                    { 10, true, 1, "Heroicons", "https://heroicons.com" },
                    { 11, true, 2, "CodeDex", "https://www.w3schools.com" },
                    { 12, true, 2, "w3schools", "https://www.w3schools.com" },
                    { 13, true, 2, "Scrimba", "https://scrimba.com" },
                    { 14, true, 2, "Animate", "https://animate.style" },
                    { 15, true, 2, "CodelyTV", "https://www.youtube.com/@CodelyTV" },
                    { 16, true, 2, "LucidChart", "https://www.lucidchart.com" },
                    { 17, true, 2, "Uiverse", "https://uiverse.io/all" },
                    { 18, true, 2, "DevDocs", "https://devdocs.io" },
                    { 19, true, 2, "WebDev", "https://web.dev" },
                    { 20, true, 3, "Railway", "https://railway.app" },
                    { 21, true, 3, "Netlify", "https://www.netlify.com" },
                    { 22, true, 3, "Vercel", "https://vercel.com" },
                    { 23, true, 3, "FreeAspHosting", "https://freeasphosting.net" },
                    { 24, true, 3, "InfinityFree", "https://www.infinityfree.net" },
                    { 25, true, 3, "AzureDevObs", "https://dev.azure.com" },
                    { 26, true, 3, "DigitalOcean", "https://www.digitalocean.com" },
                    { 27, true, 3, "Linode", "https://www.linode.com/es" },
                    { 28, true, 3, "DonWeb", "https://donweb.com/es-cl" },
                    { 29, true, 3, "Heroku", "https://www.heroku.com" },
                    { 30, true, 4, "PixaBay", "https://pixabay.com" },
                    { 31, true, 4, "FreePik", "https://www.freepik.com" },
                    { 32, true, 4, "UnSplash", "https://unsplash.com" },
                    { 33, true, 4, "FreeSVG", "https://freesvg.org" },
                    { 34, true, 4, "SocialSVG", "https://www.svgrepo.com/collection/social-and-company-colored-logo-icons" },
                    { 35, true, 4, "ConvertToIcon", "https://convertio.co/es" },
                    { 36, true, 4, "SoftIcons", "https://www.softicons.com" },
                    { 37, true, 5, "PlayCode", "https://playcode.io" },
                    { 38, true, 5, "GitHub", "https://github.com/TheNefelin" },
                    { 39, true, 5, "LinkedIn", "https://www.linkedin.com/in/nefelin" },
                    { 40, true, 5, "Figma", "https://www.figma.com" },
                    { 41, true, 5, "CodePen", "https://codepen.io" },
                    { 42, true, 5, "Canva", "https://www.canva.com" },
                    { 43, true, 5, "Songsterr", "https://www.songsterr.com" },
                    { 44, true, 5, "Mixamo", "https://www.mixamo.com/#" },
                    { 45, true, 5, "PublicAPI", "https://publicapi.dev" },
                    { 46, true, 5, "LabCenter", "https://www.labcenter.com" },
                    { 47, true, 5, "Oklch", "https://oklch.com" },
                    { 48, true, 5, "Excalidraw", "https://excalidraw.com" },
                    { 49, true, 6, "GoogleBard", "https://bard.google.com" },
                    { 50, true, 6, "ChatGPT", "https://chat.openai.com" },
                    { 51, true, 6, "Claude2", "https://claude.ai" },
                    { 52, true, 6, "LiterallyAnything", "https://www.literallyanything.io" },
                    { 53, true, 6, "BlackBox", "https://www.useblackbox.io" },
                    { 54, true, 6, "AgentGPT", "https://agentgpt.reworkd.ai/es" },
                    { 55, true, 6, "ElevenLabs", "https://beta.elevenlabs.io" },
                    { 56, true, 6, "Podcast", "https://podcast.adobe.com/enhance" },
                    { 57, true, 6, "Leonardo", "https://leonardo.ai" },
                    { 58, true, 7, "Jira", "https://www.atlassian.com/es/software/jira" },
                    { 59, true, 7, "Trello", "https://trello.com/es" },
                    { 60, true, 7, "ClickUp", "https://clickup.com" },
                    { 61, true, 7, "Asana", "https://asana.com/es" },
                    { 62, true, 8, "MiInsignia", "https://www.acreditta.com/credential/63c99def-c48d-4495-aab5-00a3158d10a0" },
                    { 63, true, 8, "GetOnbrd", "https://www.getonbrd.com/misempleos" },
                    { 64, true, 8, "Maps", "https://geekflare.com/es/geocoding-maps-api-solution" }
                });

            migrationBuilder.InsertData(
                table: "pf_pro_sour",
                columns: new[] { "id_project", "id_source" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_pf_link_id_link_grp",
                table: "pf_link",
                column: "id_link_grp");

            migrationBuilder.CreateIndex(
                name: "IX_pf_pro_sour_id_source",
                table: "pf_pro_sour",
                column: "id_source");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pf_link");

            migrationBuilder.DropTable(
                name: "pf_pro_sour");

            migrationBuilder.DropTable(
                name: "pf_youtube");

            migrationBuilder.DropTable(
                name: "pf_link_grp");

            migrationBuilder.DropTable(
                name: "pf_project");

            migrationBuilder.DropTable(
                name: "pf_source");
        }
    }
}
