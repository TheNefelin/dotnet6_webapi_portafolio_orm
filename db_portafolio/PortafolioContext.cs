using Microsoft.EntityFrameworkCore;

namespace db_portafolio
{
    public class PortafolioContext : DbContext
    {
        public PortafolioContext(DbContextOptions<PortafolioContext> options)
            : base(options)
        {
            
        }

        public DbSet<PF_Link_Grp> PF_Link_Grp { get; set; }
        public DbSet<PF_Link> PF_Link { get; set; }
        public DbSet<PF_Youtube> PF_Youtube { get; set; }
        public DbSet<PF_Project> PF_Project { get; set; }
        public DbSet<PF_Source> PF_Source { get; set; }
        public DbSet<PF_Pro_Sour> PF_Pro_Sour { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Links ---------------------------------------------------------------------
            modelBuilder.Entity<PF_Link_Grp>()
                .ToTable("pf_link_grp")
                .HasKey(e => e.id);

            modelBuilder.Entity<PF_Link>()
                .ToTable("pf_link")
                .HasKey(e => e.id);

            modelBuilder.Entity<PF_Link>()
                .HasOne(e => e.LinkGrp) 
                .WithMany(e => e.Links)  
                .HasForeignKey(e => e.id_link_grp);

            // Youtube -------------------------------------------------------------------
            modelBuilder.Entity<PF_Youtube>()
                .ToTable("pf_youtube")
                .HasKey(e => e.id);

            // Projects ------------------------------------------------------------------
            modelBuilder.Entity<PF_Project>()
                .ToTable("pf_project")
                .HasKey(e => e.id);

            modelBuilder.Entity<PF_Source>()
                .ToTable("pf_source")
                .HasKey(e => e.id);

            modelBuilder.Entity<PF_Pro_Sour>()
                .ToTable("pf_pro_sour")
                .HasKey(e => new { e.id_project, e.id_source });

            modelBuilder.Entity<PF_Pro_Sour>()
                .HasOne(e => e.Project)
                .WithMany(e => e.ProjectSources)
                .HasForeignKey(e => e.id_project)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PF_Pro_Sour>()
                .HasOne(e => e.Source)
                .WithMany(e => e.ProjectSources)
                .HasForeignKey(e => e.id_source)
                .OnDelete(DeleteBehavior.Restrict);

            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            int id = 0;
            int order = 0;

            modelBuilder.Entity<PF_Link_Grp>().HasData(
                new PF_Link_Grp { id = 1, nombre = "Framework", estado = true },
                new PF_Link_Grp { id = 2, nombre = "Learning", estado = true },
                new PF_Link_Grp { id = 3, nombre = "Hosting", estado = true },
                new PF_Link_Grp { id = 4, nombre = "Images", estado = true },
                new PF_Link_Grp { id = 5, nombre = "Tools", estado = true },
                new PF_Link_Grp { id = 6, nombre = "IA", estado = true },
                new PF_Link_Grp { id = 7, nombre = "Agile", estado = true },
                new PF_Link_Grp { id = 8, nombre = "My Links", estado = true }
            );

            modelBuilder.Entity<PF_Link>().HasData(
                new PF_Link { id = ++id, nombre = "Strapi", url_link = "https://strapi.io", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "Mui", url_link = "https://mui.com", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "Tailwindcss", url_link = "https://tailwindcss.com", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "DaisyUI", url_link = "https://daisyui.com", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "NextJS", url_link = "https://nextjs.org", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "NextUI", url_link = "https://nextui.org", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "NextAuth", url_link = "https://next-auth.js.org", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "FastAPI", url_link = "https://fastapi.tiangolo.com", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "Tremor", url_link = "https://www.tremor.so", estado = true, id_link_grp = 1 },
                new PF_Link { id = ++id, nombre = "Heroicons", url_link = "https://heroicons.com", estado = true, id_link_grp = 1 },

                new PF_Link { id = ++id, nombre = "CodeDex", url_link = "https://www.w3schools.com", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "w3schools", url_link = "https://www.w3schools.com", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "Scrimba", url_link = "https://scrimba.com", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "Animate", url_link = "https://animate.style", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "CodelyTV", url_link = "https://www.youtube.com/@CodelyTV", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "LucidChart", url_link = "https://www.lucidchart.com", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "Uiverse", url_link = "https://uiverse.io/all", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "DevDocs", url_link = "https://devdocs.io", estado = true, id_link_grp = 2 },
                new PF_Link { id = ++id, nombre = "WebDev", url_link = "https://web.dev", estado = true, id_link_grp = 2 },

                new PF_Link { id = ++id, nombre = "Railway", url_link = "https://railway.app", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "Netlify", url_link = "https://www.netlify.com", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "Vercel", url_link = "https://vercel.com", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "FreeAspHosting", url_link = "https://freeasphosting.net", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "InfinityFree", url_link = "https://www.infinityfree.net", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "AzureDevObs", url_link = "https://dev.azure.com", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "DigitalOcean", url_link = "https://www.digitalocean.com", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "Linode", url_link = "https://www.linode.com/es", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "DonWeb", url_link = "https://donweb.com/es-cl", estado = true, id_link_grp = 3 },
                new PF_Link { id = ++id, nombre = "Heroku", url_link = "https://www.heroku.com", estado = true, id_link_grp = 3 },

                new PF_Link { id = ++id, nombre = "PixaBay", url_link = "https://pixabay.com", estado = true, id_link_grp = 4 },
                new PF_Link { id = ++id, nombre = "FreePik", url_link = "https://www.freepik.com", estado = true, id_link_grp = 4 },
                new PF_Link { id = ++id, nombre = "UnSplash", url_link = "https://unsplash.com", estado = true, id_link_grp = 4 },
                new PF_Link { id = ++id, nombre = "FreeSVG", url_link = "https://freesvg.org", estado = true, id_link_grp = 4 },
                new PF_Link { id = ++id, nombre = "SocialSVG", url_link = "https://www.svgrepo.com/collection/social-and-company-colored-logo-icons", estado = true, id_link_grp = 4 },
                new PF_Link { id = ++id, nombre = "ConvertToIcon", url_link = "https://convertio.co/es", estado = true, id_link_grp = 4 },
                new PF_Link { id = ++id, nombre = "SoftIcons", url_link = "https://www.softicons.com", estado = true, id_link_grp = 4 },

                new PF_Link { id = ++id, nombre = "PlayCode", url_link = "https://playcode.io", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "GitHub", url_link = "https://github.com/TheNefelin", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "LinkedIn", url_link = "https://www.linkedin.com/in/nefelin", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "Figma", url_link = "https://www.figma.com", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "CodePen", url_link = "https://codepen.io", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "Canva", url_link = "https://www.canva.com", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "Songsterr", url_link = "https://www.songsterr.com", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "Mixamo", url_link = "https://www.mixamo.com/#", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "PublicAPI", url_link = "https://publicapi.dev", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "LabCenter", url_link = "https://www.labcenter.com", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "Oklch", url_link = "https://oklch.com", estado = true, id_link_grp = 5 },
                new PF_Link { id = ++id, nombre = "Excalidraw", url_link = "https://excalidraw.com", estado = true, id_link_grp = 5 },

                new PF_Link { id = ++id, nombre = "GoogleBard", url_link = "https://bard.google.com", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "ChatGPT", url_link = "https://chat.openai.com", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "Claude2", url_link = "https://claude.ai", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "LiterallyAnything", url_link = "https://www.literallyanything.io", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "BlackBox", url_link = "https://www.useblackbox.io", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "AgentGPT", url_link = "https://agentgpt.reworkd.ai/es", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "ElevenLabs", url_link = "https://beta.elevenlabs.io", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "Podcast", url_link = "https://podcast.adobe.com/enhance", estado = true, id_link_grp = 6 },
                new PF_Link { id = ++id, nombre = "Leonardo", url_link = "https://leonardo.ai", estado = true, id_link_grp = 6 },

                new PF_Link { id = ++id, nombre = "Jira", url_link = "https://www.atlassian.com/es/software/jira", estado = true, id_link_grp = 7 },
                new PF_Link { id = ++id, nombre = "Trello", url_link = "https://trello.com/es", estado = true, id_link_grp = 7 },
                new PF_Link { id = ++id, nombre = "ClickUp", url_link = "https://clickup.com", estado = true, id_link_grp = 7 },
                new PF_Link { id = ++id, nombre = "Asana", url_link = "https://asana.com/es", estado = true, id_link_grp = 7 },

                new PF_Link { id = ++id, nombre = "MiInsignia", url_link = "https://www.acreditta.com/credential/63c99def-c48d-4495-aab5-00a3158d10a0", estado = true, id_link_grp = 8 },
                new PF_Link { id = ++id, nombre = "GetOnbrd", url_link = "https://www.getonbrd.com/misempleos", estado = true, id_link_grp = 8 },
                new PF_Link { id = ++id, nombre = "Maps", url_link = "https://geekflare.com/es/geocoding-maps-api-solution", estado = true, id_link_grp = 8 }
            );

            modelBuilder.Entity<PF_Youtube>().HasData(
                new PF_Youtube { id = 1, nombre = "Jam-Covid", video_id = "0WsjRYgZMzs" },
                new PF_Youtube { id = 2, nombre = "Sky Lagoon", video_id = "qUYQzlj_580" },
                new PF_Youtube { id = 3, nombre = "Valhalla", video_id = "ktCw2CfWeTA" },
                new PF_Youtube { id = 4, nombre = "Yu-Gi-Oh", video_id = "2q9liMSxOcE" },
                new PF_Youtube { id = 5, nombre = "Monster Hunter", video_id = "yPKbPUM9RRc" },
                new PF_Youtube { id = 6, nombre = "Final Fantasy XV", video_id = "3JlJ2fsOQnU" }
            );

            order = 0;

            modelBuilder.Entity<PF_Project>().HasData(
                new PF_Project { id = 1, nombre = "Tecno Chile", url_img = "03-tecno-chile.jpg", orden = ++order },
                new PF_Project { id = 2, nombre = "Web Components v1.0", url_img = "04-web-components-v1.jpg", orden = ++order },
                new PF_Project { id = 3, nombre = "Kartax v1.0", url_img = "01-kartax-v1.jpg", orden = ++order },
                new PF_Project { id = 4, nombre = "Portafolio V1.0", url_img = "02-portafolio-v1.jpg", orden = ++order },
                new PF_Project { id = 5, nombre = "Game El Cubo v2.0", url_img = "05-el-cubo-v2.jpg", orden = ++order },
                new PF_Project { id = 6, nombre = "Transbank POS Integration v1.0", url_img = "06-transbank-pos.png", orden = ++order },
                new PF_Project { id = 7, nombre = "Arduino DHT Temperature Monitoring by Network", url_img = "07-DHT.png", orden = ++order },
                new PF_Project { id = 8, nombre = "Kartax v2.0", url_img = "08-kartax-v2.png", orden = ++order },
                new PF_Project { id = 9, nombre = "Portafolio v2.0", url_img = "09-portafolio-v2.png", orden = ++order },
                new PF_Project { id = 10, nombre = "Kartax v3.0 (Developing...)", url_img = "10-kartax-v3.png", orden = ++order },
                new PF_Project { id = 11, nombre = "Guides for games", url_img = "11-guides-for-games.png", orden = ++order }
            );

            modelBuilder.Entity<PF_Source>().HasData(
                new PF_Source { id = 1, nombre = "Tecno Chile v1.0 app", url_deploy = "https://tecnochile.netlify.app", url_repo = "https://github.com/TheNefelin/td_trabajo_grupal_03" },
                new PF_Source { id = 2, nombre = "Slifer api", url_deploy = "https://slifer.bsite.net/index.html", url_repo = "https://github.com/TheNefelin/td_api.NetCore6" },
                new PF_Source { id = 3, nombre = "Components v1.0 app", url_deploy = "https://nefelin-components.netlify.app", url_repo = "https://github.com/TheNefelin/my-web-components" },
                new PF_Source { id = 4, nombre = "Kartax v1.0 app", url_deploy = "https://kartax.netlify.app", url_repo = "https://github.com/TheNefelin/kartax-ant" },
                new PF_Source { id = 5, nombre = "Portafolio app", url_deploy = "https://nefelin-portafolio.netlify.app", url_repo = "https://github.com/TheNefelin/portafolio-site" },
                new PF_Source { id = 6, nombre = "Metalflap api", url_deploy = "https://bsite.net/metalflap/index.html", url_repo = "https://github.com/TheNefelin/portafolio_api.NETCore6" },
                new PF_Source { id = 7, nombre = "Download Link app", url_deploy = "https://drive.google.com/drive/folders/1qttZk_iN8fHYVjHqI6_VLS4nyT4fTkyu?usp=drive_link", url_repo = null },
                new PF_Source { id = 8, nombre = "Transbank POS v1.0 app", url_deploy = null, url_repo = "https://github.com/TheNefelin/Transbank-POS-v1" },
                new PF_Source { id = 9, nombre = "Arduino DHT Monitoring", url_deploy = null, url_repo = "https://github.com/TheNefelin/DHT/tree/master/DHT" },
                new PF_Source { id = 10, nombre = "Kartax v2.0 app", url_deploy = "https://kartax-express-production.up.railway.app/", url_repo = "https://github.com/TheNefelin/kartax-express" },
                new PF_Source { id = 11, nombre = "Kartax v2.0 api", url_deploy = "https://kartax-api-production.up.railway.app", url_repo = "https://github.com/TheNefelin/kartax-api" },
                new PF_Source { id = 12, nombre = "Portafolio v2.0 app", url_deploy = "http://www.francisco-dev.cl", url_repo = "https://github.com/TheNefelin/portafolio-next13" },
                new PF_Source { id = 13, nombre = "Kartax v3.0 app", url_deploy = "https://kartax-next13.vercel.app/", url_repo = null },
                new PF_Source { id = 14, nombre = "Guia v1.0 app", url_deploy = "https://guias-juegos-next13-ts.vercel.app", url_repo = "https://github.com/TheNefelin/guias-juegos-next13-ts" },
                new PF_Source { id = 15, nombre = "SQL Server", url_deploy = null, url_repo = "https://github.com/TheNefelin/SQLServer" }
            );

            modelBuilder.Entity<PF_Pro_Sour>().HasData(
                new PF_Pro_Sour { id_project = 1, id_source = 1 },
                new PF_Pro_Sour { id_project = 1, id_source = 2 },
                new PF_Pro_Sour { id_project = 2, id_source = 3 }
            );

        }

    }
}