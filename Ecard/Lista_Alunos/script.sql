USE [2019ECard]
GO
/****** Object:  User [2019ECard]    Script Date: 14/08/2019 11:02:56 ******/
CREATE USER [2019ECard] FOR LOGIN [2019ECard] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [2019ECard]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[senha] [varchar](60) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bairro]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bairro](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](90) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudante]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudante](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[senha] [varchar](60) NOT NULL,
	[status] [varchar](100) NOT NULL,
	[carteira_foto] [varchar](100) NOT NULL,
	[carteira_saldo] [numeric](10, 2) NOT NULL,
	[carteira_numero] [int] NOT NULL,
	[carteira_validade] [date] NOT NULL,
	[instituicao_id] [int] NOT NULL,
	[administrador_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instituicao]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instituicao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[cnpj] [varchar](18) NOT NULL,
	[codigo_inep] [varchar](60) NOT NULL,
	[senha] [varchar](60) NOT NULL,
	[endereco_numero] [varchar](10) NOT NULL,
	[endereco_logradouro] [varchar](150) NOT NULL,
	[endereco_cep] [varchar](9) NOT NULL,
	[endereco_bairro] [varchar](100) NOT NULL,
	[endereco_municipio] [varchar](100) NOT NULL,
	[administrador_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lista_Anual_Alunos]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_Anual_Alunos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ano] [int] NOT NULL,
	[caminho_arquivo] [varchar](200) NOT NULL,
	[processada] [bit] NOT NULL,
	[instituicao_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ponto_Recarga]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ponto_Recarga](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome_ponto] [varchar](200) NOT NULL,
	[endereco_numero] [varchar](10) NOT NULL,
	[endereco_logradouro] [varchar](150) NOT NULL,
	[endereco_cep] [varchar](9) NOT NULL,
	[endereco_bairro] [varchar](100) NOT NULL,
	[endereco_municipio] [varchar](100) NOT NULL,
	[administrador_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ponto_Referencia]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ponto_Referencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[rotas_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recarga]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recarga](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data_recarga] [date] NOT NULL,
	[valor] [numeric](10, 2) NOT NULL,
	[estudante_id] [int] NOT NULL,
	[ponto_recarga_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rota]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rota](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[administrador_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rotas_Bairro]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rotas_Bairro](
	[rotas_id] [int] NOT NULL,
	[bairro_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefone_Instituicao]    Script Date: 14/08/2019 11:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefone_Instituicao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [varchar](20) NOT NULL,
	[instituicao_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Estudante]  WITH CHECK ADD FOREIGN KEY([administrador_id])
REFERENCES [dbo].[Administrador] ([id])
GO
ALTER TABLE [dbo].[Estudante]  WITH CHECK ADD FOREIGN KEY([instituicao_id])
REFERENCES [dbo].[Instituicao] ([id])
GO
ALTER TABLE [dbo].[Instituicao]  WITH CHECK ADD FOREIGN KEY([administrador_id])
REFERENCES [dbo].[Administrador] ([id])
GO
ALTER TABLE [dbo].[Lista_Anual_Alunos]  WITH CHECK ADD FOREIGN KEY([instituicao_id])
REFERENCES [dbo].[Instituicao] ([id])
GO
ALTER TABLE [dbo].[Ponto_Recarga]  WITH CHECK ADD FOREIGN KEY([administrador_id])
REFERENCES [dbo].[Administrador] ([id])
GO
ALTER TABLE [dbo].[Ponto_Referencia]  WITH CHECK ADD FOREIGN KEY([rotas_id])
REFERENCES [dbo].[Rota] ([id])
GO
ALTER TABLE [dbo].[Recarga]  WITH CHECK ADD FOREIGN KEY([estudante_id])
REFERENCES [dbo].[Estudante] ([id])
GO
ALTER TABLE [dbo].[Recarga]  WITH CHECK ADD FOREIGN KEY([ponto_recarga_id])
REFERENCES [dbo].[Ponto_Recarga] ([id])
GO
ALTER TABLE [dbo].[Rota]  WITH CHECK ADD FOREIGN KEY([administrador_id])
REFERENCES [dbo].[Administrador] ([id])
GO
ALTER TABLE [dbo].[Rotas_Bairro]  WITH CHECK ADD FOREIGN KEY([bairro_id])
REFERENCES [dbo].[Bairro] ([id])
GO
ALTER TABLE [dbo].[Rotas_Bairro]  WITH CHECK ADD FOREIGN KEY([rotas_id])
REFERENCES [dbo].[Rota] ([id])
GO
ALTER TABLE [dbo].[Telefone_Instituicao]  WITH CHECK ADD FOREIGN KEY([instituicao_id])
REFERENCES [dbo].[Instituicao] ([id])
GO
