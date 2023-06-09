USE [master]
GO
/****** Object:  Database [SX]    Script Date: 22/03/2023 02:38:52 ******/
CREATE DATABASE [SX]
GO
ALTER DATABASE [SX] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SX].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SX] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SX] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SX] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SX] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SX] SET ARITHABORT OFF 
GO
ALTER DATABASE [SX] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SX] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SX] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SX] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SX] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SX] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SX] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SX] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SX] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SX] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SX] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SX] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SX] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SX] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SX] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SX] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SX] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SX] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SX] SET  MULTI_USER 
GO
ALTER DATABASE [SX] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SX] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SX] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SX] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SX] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SX] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SX] SET QUERY_STORE = OFF
GO
USE [SX]
GO
/****** Object:  Table [dbo].[tblColaborador]    Script Date: 22/03/2023 02:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblColaborador](
	[idColaborador] [int] IDENTITY(1,1) NOT NULL,
	[idEmpresa] [int] NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[cpf] [varchar](11) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[telefone] [varchar](11) NOT NULL,
	[endereco] [varchar](max) NOT NULL,
 CONSTRAINT [PK_colaborador] PRIMARY KEY CLUSTERED 
(
	[idColaborador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpresa]    Script Date: 22/03/2023 02:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmpresa](
	[idEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[cnpj] [varchar](14) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[telefone] [varchar](11) NOT NULL,
	[endereco] [varchar](max) NOT NULL,
 CONSTRAINT [PK_empresa] PRIMARY KEY CLUSTERED 
(
	[idEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblColaborador]  WITH CHECK ADD  CONSTRAINT [FK_colaborador_empresa_idEmpresa] FOREIGN KEY([idEmpresa])
REFERENCES [dbo].[tblEmpresa] ([idEmpresa])
GO
ALTER TABLE [dbo].[tblColaborador] CHECK CONSTRAINT [FK_colaborador_empresa_idEmpresa]
GO
USE [master]
GO
ALTER DATABASE [SX] SET  READ_WRITE 
GO
