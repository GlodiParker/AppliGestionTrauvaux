USE [bdTravauxISIPA]
GO
/****** Object:  Table [dbo].[Etudiant]    Script Date: 10/16/2022 17:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Etudiant](
	[Matricule] [varchar](10) NOT NULL,
	[Nom] [varchar](20) NULL,
	[Prenom] [varchar](20) NULL,
	[Telephone] [varchar](20) NULL,
	[Departement] [varchar](20) NULL,
	[Section] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Matricule] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Encadreur]    Script Date: 10/16/2022 17:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Encadreur](
	[CodeEnc] [varchar](10) NOT NULL,
	[Nom] [varchar](100) NULL,
	[Prenom] [varchar](20) NULL,
	[Grade] [varchar](20) NULL,
	[Telephone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeEnc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 10/16/2022 17:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[Login_] [varchar](50) NOT NULL,
	[PassWord_] [varchar](20) NULL,
	[Photo] [varchar](200) NULL,
	[Droit] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Login_] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TravauxAcad]    Script Date: 10/16/2022 17:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TravauxAcad](
	[CodeTravail] [varchar](10) NOT NULL,
	[Intitule] [varchar](100) NULL,
	[Domaine] [varchar](20) NULL,
	[AnneeAcad] [varchar](20) NULL,
	[Etudiant] [varchar](10) NULL,
	[Encadreur] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodeTravail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_TravauxAcad_Encadreur]    Script Date: 10/16/2022 17:35:40 ******/
ALTER TABLE [dbo].[TravauxAcad]  WITH CHECK ADD  CONSTRAINT [FK_TravauxAcad_Encadreur] FOREIGN KEY([Encadreur])
REFERENCES [dbo].[Encadreur] ([CodeEnc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TravauxAcad] CHECK CONSTRAINT [FK_TravauxAcad_Encadreur]
GO
/****** Object:  ForeignKey [FK_TravauxAcad_Etudiant]    Script Date: 10/16/2022 17:35:40 ******/
ALTER TABLE [dbo].[TravauxAcad]  WITH CHECK ADD  CONSTRAINT [FK_TravauxAcad_Etudiant] FOREIGN KEY([Etudiant])
REFERENCES [dbo].[Etudiant] ([Matricule])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TravauxAcad] CHECK CONSTRAINT [FK_TravauxAcad_Etudiant]
GO
