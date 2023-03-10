USE [master]
GO
/****** Object:  Database [BANCO]    Script Date: 04/18/2016 11:41:21 ******/
CREATE DATABASE [BANCO] ON  PRIMARY 
( NAME = N'BANCO', FILENAME = N'C:\BD\BANCO.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BANCO_log', FILENAME = N'C:\BD\BANCO_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BANCO] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BANCO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BANCO] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BANCO] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BANCO] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BANCO] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BANCO] SET ARITHABORT OFF
GO
ALTER DATABASE [BANCO] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [BANCO] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BANCO] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BANCO] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BANCO] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BANCO] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BANCO] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BANCO] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BANCO] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BANCO] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BANCO] SET  DISABLE_BROKER
GO
ALTER DATABASE [BANCO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BANCO] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BANCO] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BANCO] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BANCO] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BANCO] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BANCO] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BANCO] SET  READ_WRITE
GO
ALTER DATABASE [BANCO] SET RECOVERY SIMPLE
GO
ALTER DATABASE [BANCO] SET  MULTI_USER
GO
ALTER DATABASE [BANCO] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BANCO] SET DB_CHAINING OFF
GO
USE [BANCO]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 04/18/2016 11:41:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[CLI_COD] [int] IDENTITY(1,1) NOT NULL,
	[CLI_NOME] [varchar](50) NULL,
	[CLI_TELEFONE] [varchar](15) NULL,
	[CLI_NASC] [date] NULL,
	[CLI_SALARIO] [numeric](9, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[CLI_COD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONTA]    Script Date: 04/18/2016 11:41:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTA](
	[CONTA_NUMERO] [int] IDENTITY(1,1) NOT NULL,
	[CONTA_ABERTURA] [date] NOT NULL,
	[CONTA_FECHAMENTO] [date] NULL,
	[CONTA_CLIENTE] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CONTA_NUMERO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Conta-Cliente]    Script Date: 04/18/2016 11:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Conta-Cliente]
AS
SELECT     dbo.Cliente.CLI_SALARIO, dbo.Cliente.CLI_COD, dbo.Cliente.CLI_NOME, dbo.CONTA.CONTA_NUMERO, dbo.CONTA.CONTA_FECHAMENTO, 
                      dbo.CONTA.CONTA_ABERTURA, dbo.CONTA.CONTA_CLIENTE
FROM         dbo.Cliente INNER JOIN
                      dbo.CONTA ON dbo.Cliente.CLI_COD = dbo.CONTA.CONTA_CLIENTE
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 32
               Left = 59
               Bottom = 198
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CONTA"
            Begin Extent = 
               Top = 15
               Left = 375
               Bottom = 184
               Right = 573
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Conta-Cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Conta-Cliente'
GO
/****** Object:  Table [dbo].[Movimentacao]    Script Date: 04/18/2016 11:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movimentacao](
	[MOV_NUMERO] [int] IDENTITY(1,1) NOT NULL,
	[MOV_DESCRICAO] [varchar](50) NULL,
	[MOV_TIPO] [char](1) NOT NULL,
	[MOV_CONTA] [int] NOT NULL,
	[MOV_VALOR] [numeric](9, 2) NOT NULL,
	[MOV_DATA] [date] NULL,
 CONSTRAINT [PK_Movimentacao] PRIMARY KEY CLUSTERED 
(
	[MOV_NUMERO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[MOv_Saque_Depo]    Script Date: 04/18/2016 11:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MOv_Saque_Depo]
(
	@MOV_DESCRICAO varchar(50),
	@MOV_TIPO char(1),
	@MOV_CONTA int,
	@MOV_VALOR numeric(9, 2),
	@MOV_DATA date
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Movimentacao] ([MOV_DESCRICAO], [MOV_TIPO], [MOV_CONTA], [MOV_VALOR], [MOV_DATA]) VALUES (@MOV_DESCRICAO, @MOV_TIPO, @MOV_CONTA, @MOV_VALOR, @MOV_DATA);
	
SELECT MOV_NUMERO, MOV_DESCRICAO, MOV_TIPO, MOV_CONTA, MOV_VALOR, MOV_DATA FROM Movimentacao WHERE (MOV_NUMERO = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[Iserrir_mov_saque_depo]    Script Date: 04/18/2016 11:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Iserrir_mov_saque_depo]
(
	@MOV_DESCRICAO varchar(50),
	@MOV_TIPO char(1),
	@MOV_CONTA int,
	@MOV_VALOR numeric(9, 2),
	@MOV_DATA date
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Movimentacao] ([MOV_DESCRICAO], [MOV_TIPO], [MOV_CONTA], [MOV_VALOR], [MOV_DATA]) VALUES (@MOV_DESCRICAO, @MOV_TIPO, @MOV_CONTA, @MOV_VALOR, @MOV_DATA);
GO
/****** Object:  StoredProcedure [dbo].[InserirMovimentacao]    Script Date: 04/18/2016 11:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirMovimentacao]
(
	@MOV_DESCRICAO varchar(50),
	@MOV_TIPO char(1),
	@MOV_CONTA int,
	@MOV_VALOR numeric(9, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Movimentacao] ([MOV_DESCRICAO], [MOV_TIPO], [MOV_CONTA], [MOV_VALOR]) VALUES (@MOV_DESCRICAO, @MOV_TIPO, @MOV_CONTA, @MOV_VALOR);
GO
/****** Object:  View [dbo].[Exibição_extrato Geral]    Script Date: 04/18/2016 11:41:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Exibição_extrato Geral]
AS
SELECT     dbo.Cliente.CLI_COD, dbo.Cliente.CLI_NOME, dbo.CONTA.CONTA_NUMERO, dbo.Movimentacao.MOV_NUMERO, dbo.Movimentacao.MOV_DESCRICAO, 
                      dbo.Movimentacao.MOV_TIPO, dbo.Movimentacao.MOV_CONTA, dbo.Movimentacao.MOV_VALOR, dbo.Movimentacao.MOV_DATA
FROM         dbo.Cliente INNER JOIN
                      dbo.CONTA ON dbo.Cliente.CLI_COD = dbo.CONTA.CONTA_CLIENTE INNER JOIN
                      dbo.Movimentacao ON dbo.CONTA.CONTA_NUMERO = dbo.Movimentacao.MOV_CONTA
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 12
               Left = 17
               Bottom = 131
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CONTA"
            Begin Extent = 
               Top = 12
               Left = 351
               Bottom = 131
               Right = 549
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Movimentacao"
            Begin Extent = 
               Top = 101
               Left = 640
               Bottom = 255
               Right = 830
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Exibição_extrato Geral'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Exibição_extrato Geral'
GO
/****** Object:  ForeignKey [FK__CONTA__CONTA_CLI__08EA5793]    Script Date: 04/18/2016 11:41:22 ******/
ALTER TABLE [dbo].[CONTA]  WITH CHECK ADD FOREIGN KEY([CONTA_CLIENTE])
REFERENCES [dbo].[Cliente] ([CLI_COD])
GO
/****** Object:  ForeignKey [FK__Movimenta__MOV_C__09DE7BCC]    Script Date: 04/18/2016 11:41:23 ******/
ALTER TABLE [dbo].[Movimentacao]  WITH CHECK ADD FOREIGN KEY([MOV_CONTA])
REFERENCES [dbo].[CONTA] ([CONTA_NUMERO])
GO
