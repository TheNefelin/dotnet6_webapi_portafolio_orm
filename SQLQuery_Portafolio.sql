DROP TABLE __EFMigrationsHistory
DROP TABLE pf_link_grp
DROP TABLE pf_link
DROP TABLE pf_language
DROP TABLE pf_technology
DROP TABLE pf_project
DROP TABLE pf_project_list
DROP TABLE pf_pro_prol

SELECT * FROM __EFMigrationsHistory
SELECT * FROM pf_link_grp
SELECT * FROM pf_link
SELECT * FROM pf_language
SELECT * FROM pf_technology
SELECT * FROM pf_project
SELECT * FROM pf_project_list
SELECT * FROM pf_pro_prol

-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------

SET IDENTITY_INSERT [dbo].[pf_link_grp] ON
GO

INSERT INTO pf_link_grp
	(id, nombre, estado)
VALUES
	(1, 'Framework', 1),
	(2, 'Learning', 1),
	(3, 'Hosting', 1),
	(4, 'Images', 1),
	(5, 'Tools', 1),
	(6, 'IA', 1),
	(7, 'Agile', 1),
	(8, 'My Links', 1)
GO

SET IDENTITY_INSERT [dbo].[pf_link_grp] OFF
GO

INSERT INTO pf_link
	(nombre, url_link, estado, id_link_grp)
VALUES
	('Strapi', 'https://strapi.io/', 1, 1),
	('Mui', 'https://mui.com/', 1, 1),
	('Tailwindcss', 'https://tailwindcss.com/', 1, 1),
	('DaisyUI', 'https://daisyui.com/', 1, 1),
	('NextJS', 'https://nextjs.org/', 1, 1),
	('NextUI', 'https://nextui.org/', 1, 1),
	('NextAuth', 'https://next-auth.js.org/', 1, 1),
	('FastAPI', 'https://fastapi.tiangolo.com/', 1, 1),
	('Tremor', 'https://www.tremor.so/', 1, 1),
	('Heroicons', 'https://heroicons.com/', 1, 1),

	('CodeDex', 'https://www.codedex.io/', 1, 2),
	('W3Schools', 'https://www.w3schools.com/', 1, 2),
	('Scrimba', 'https://scrimba.com/', 1, 2),
	('Animate', 'https://animate.style/', 1, 2),
	('YouTube CodelyTV', 'https://www.youtube.com/@CodelyTV/', 1, 2),
	('Lucid Chart', 'https://www.lucidchart.com/', 1, 2),
	('Uiverse', 'https://uiverse.io/all/', 1, 2),
	('DevDocs', 'https://devdocs.io/', 1, 2),
	('WebDev', 'https://web.dev/', 1, 2),

	('Railway', 'https://railway.app/', 1, 3),
	('Netlify', 'https://www.netlify.com/', 1, 3),
	('Vercel', 'https://vercel.com/', 1, 3),
	('FreeAspHosting', 'https://freeasphosting.net/', 1, 3),
	('InfinityFree', 'https://www.infinityfree.net/', 1, 3),
	('Azure DevObs', 'https://dev.azure.com/', 1, 3),
	('DigitalOcean', 'https://www.digitalocean.com/', 1, 3),
	('Linode', 'https://www.linode.com/es/', 1, 3),
	('DonWeb', 'https://donweb.com/es-cl/', 1, 3),
	('Heroku', 'https://www.heroku.com/', 1, 3),

	('PixaBay', 'https://pixabay.com/', 1, 4),
	('FreePik', 'https://www.freepik.com/', 1, 4),
	('UnSplash', 'https://unsplash.com/', 1, 4),
	('FreeSVG', 'https://freesvg.org/', 1, 4),
	('SocialSVG', 'https://www.svgrepo.com/collection/social-and-company-colored-logo-icons/', 1, 4),
	('Convert to Icon', 'https://convertio.co/es/', 1, 4),
	('SoftIcons', 'https://www.softicons.com/', 1, 4),

	('PlayCode', 'https://playcode.io/', 1, 5),
	('GitHub', 'https://github.com/TheNefelin/', 1, 5),
	('LinkedIn', 'https://www.linkedin.com/in/nefelin/', 1, 5),
	('Figma', 'https://www.figma.com/', 1, 5),
	('CodePen', 'https://codepen.io/', 1, 5),
	('Canva', 'https://www.canva.com/', 1, 5),
	('Songsterr', 'https://www.songsterr.com/', 1, 5),
	('Mixamo', 'https://www.mixamo.com/#/', 1, 5),
	('PublicAPI', 'https://publicapi.dev/', 1, 5),
	('LabCenter', 'https://www.labcenter.com/', 1, 5),
	('Oklch', 'https://oklch.com/', 1, 5),
	('Excalidraw', 'https://excalidraw.com/', 1, 5),

	('Google Bard', 'https://bard.google.com/', 1, 6),
	('ChatGPT', 'https://chat.openai.com/', 1, 6),
	('Claude 2', 'https://claude.ai/', 1, 6),
	('LiterallyAnything', 'https://www.literallyanything.io/', 1, 6),
	('BlackBox', 'https://www.useblackbox.io/', 1, 6),
	('AgentGPT', 'https://agentgpt.reworkd.ai/es/', 1, 6),
	('ElevenLabs', 'https://beta.elevenlabs.io/', 1, 6),
	('Podcast', 'https://podcast.adobe.com/enhance/', 1, 6),
	('Leonardo', 'https://leonardo.ai/', 1, 6),

	('Jira', 'https://www.atlassian.com/es/software/jira/', 1, 7),
	('Trello', 'https://trello.com/es/', 1, 7),
	('ClickUp', 'https://clickup.com/', 1, 7),
	('Asana', 'https://asana.com/es/', 1, 7),

	('Mi Insignia', 'https://www.acreditta.com/credential/63c99def-c48d-4495-aab5-00a3158d10a0/', 1, 8),
	('Get Onbrd', 'https://www.getonbrd.com/misempleos/', 1, 8),
	('Maps', 'https://geekflare.com/es/geocoding-maps-api-solution/', 1, 8)
GO

SET IDENTITY_INSERT [dbo].[pf_project] ON
GO

INSERT INTO pf_project
	(id, nombre, url_img, orden)
VALUES
	(1, 'Tecno Chile', '03-tecno-chile.jpg', 1),
	(2, 'Web Components v1.0', '04-web-components-v1.jpg', 2),
	(3, 'Kartax v1.0', '01-kartax-v1.jpg', 3),
	(4, 'Portafolio V1.0', '02-portafolio-v1.jpg', 4),
	(5, 'Game El Cubo v2.0', '05-el-cubo-v2.jpg', 5),
	(6, 'Transbank POS Integration v1.0', '06-transbank-pos.png', 6),
	(7, 'Arduino DHT Temperature Monitoring by Network', '07-DHT.png', 7),
	(8, 'Kartax v2.0', '08-kartax-v2.png', 8),
	(9, 'Portafolio v2.0', '09-portafolio-v2.png', 9),
	(10, 'Kartax v3.0 (Developing...)', '10-kartax-v3.png', 10),
	(11, 'Guides for Games', '11-guides-for-games.png', 11)

SET IDENTITY_INSERT [dbo].[pf_project] OFF
GO

SET IDENTITY_INSERT [dbo].[pf_project_list] ON
GO

INSERT INTO pf_project_list
	(id, nombre, url_deploy, url_repo)
VALUES
	(1, 'Tecno Chile v1.0 app', 'https://tecnochile.netlify.app', 'https://github.com/TheNefelin/td_trabajo_grupal_03'),
	(2, 'Tecno Chile v1.0 api', 'https://slifer.bsite.net/index.html', 'https://github.com/TheNefelin/td_api.NetCore6'),
	(3, 'Components v1.0 app', 'https://nefelin-components.netlify.app', 'https://github.com/TheNefelin/my-web-components'),
	(4, 'Kartax v1.0 app', 'https://kartax.netlify.app', 'https://github.com/TheNefelin/kartax-ant'),
	(5, 'Portafolio app', 'https://nefelin-portafolio.netlify.app', 'https://github.com/TheNefelin/portafolio-site'),
	(6, 'Portafolio api', 'https://bsite.net/metalflap/index.html', 'https://github.com/TheNefelin/portafolio_api.NETCore6'),
	(7, 'El Cubo v2.0', 'https://drive.google.com/drive/folders/1qttZk_iN8fHYVjHqI6_VLS4nyT4fTkyu?usp=drive_link', null),
	(8, 'Transbank POS v1', null, 'https://github.com/TheNefelin/Transbank-POS-v1'),
	(9, 'Arduino DHT Monitoring', null, 'https://github.com/TheNefelin/DHT/tree/master/DHT'),
	(10, 'Kartax v2.0 app', 'https://kartax-express-production.up.railway.app', 'https://github.com/TheNefelin/kartax-express'),
	(11, 'Kartax v2.0 api', 'https://kartax-api-production.up.railway.app', 'https://github.com/TheNefelin/kartax-api'),
	(12, 'Portafolio v2.0', 'http://www.francisco-dev.cl', 'https://github.com/TheNefelin/portafolio-next13'),
	(13, 'Kartax v3.0 app', 'https://kartax-next13.vercel.app', null),
	(14, 'Kartax v3.0 api', 'https://kartax-api-py.vercel.app/docs', null),
	(15, 'Guia app', 'https://guias-juegos-next13-ts.vercel.app', 'https://github.com/TheNefelin/guias-juegos-next13-ts'),
	(16, 'Guia api', 'https://bsite.net/metalflap/index.html', 'https://github.com/TheNefelin/portafolio_api.NETCore6'),
	(17, 'SQL Server', null, 'https://github.com/TheNefelin/SQLServer')

SET IDENTITY_INSERT [dbo].[pf_project_list] OFF
GO

-------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------
