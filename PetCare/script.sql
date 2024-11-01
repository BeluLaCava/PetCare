USE [master]
GO
/****** Object:  Database [PetCare]    Script Date: 1/11/2024 14:06:56 ******/
CREATE DATABASE [PetCareIndividual]
 
GO
ALTER DATABASE [PetCareIndividual] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PetCareIndividual].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PetCareIndividual] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PetCareIndividual] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PetCareIndividual] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PetCareIndividual] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PetCareIndividual] SET ARITHABORT OFF 
GO
ALTER DATABASE [PetCareIndividual] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PetCareIndividual] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PetCareIndividual] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PetCareIndividual] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PetCareIndividual] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PetCareIndividual] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PetCareIndividual] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PetCareIndividual] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PetCareIndividual] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PetCareIndividual] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PetCareIndividual] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PetCareIndividual] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PetCareIndividual] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PetCareIndividual] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PetCareIndividual] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PetCareIndividual] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PetCareIndividual] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PetCareIndividual] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PetCareIndividual] SET  MULTI_USER 
GO
ALTER DATABASE [PetCareIndividual] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PetCareIndividual] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PetCareIndividual] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PetCareIndividual] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PetCareIndividual] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PetCareIndividual] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PetCareIndividual] SET QUERY_STORE = OFF
GO
USE [PetCareIndividual]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 1/11/2024 14:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[veterinario_id] [int] NULL,
	[mascota_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 1/11/2024 14:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[direccion] [varchar](150) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[email] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Clientes__3214EC276B828A84] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 1/11/2024 14:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[ID_EMPLEADO] [int] IDENTITY(1,1) NOT NULL,
	[APELLIDO] [varchar](50) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[DNI] [varchar](50) NOT NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[CONTRASENIA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[ID_EMPLEADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 1/11/2024 14:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[total] [decimal](10, 2) NOT NULL,
	[cliente_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascotas]    Script Date: 1/11/2024 14:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascotas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[especie] [varchar](50) NOT NULL,
	[raza] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[cliente_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 1/11/2024 14:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](255) NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veterinarios]    Script Date: 1/11/2024 14:06:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veterinarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[especialidad] [varchar](100) NOT NULL,
	[horario_trabajo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (1, N'Rosales', N'Misiones 123', N'1231231231', N'rosales@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (4, N'Martinez', N'Posadas 123', N'1154564567', N'Martinez@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (6, N'Garcia', N'Huergo 23', N'1154561235', N'garcia@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (7, N'Perez', N'Avellaneda 786', N'1141594234', N'perez@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (8, N'Pereira', N'Husares 1234', N'1151641234', N'pereira@gmail.com')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([ID_EMPLEADO], [APELLIDO], [NOMBRE], [DNI], [EMAIL], [CONTRASENIA]) VALUES (1, N'Ramirez', N'Esteban', N'40123123', N'ramirez@gmail.com', N'123')
INSERT [dbo].[Empleado] ([ID_EMPLEADO], [APELLIDO], [NOMBRE], [DNI], [EMAIL], [CONTRASENIA]) VALUES (2, N'Lopez', N'Florencia', N'12123123', N'flor@gmail.com', N'1234')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD FOREIGN KEY([mascota_id])
REFERENCES [dbo].[Mascotas] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD FOREIGN KEY([veterinario_id])
REFERENCES [dbo].[Veterinarios] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK__Facturas__client__48CFD27E] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[Clientes] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK__Facturas__client__48CFD27E]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [FK__Mascotas__client__3E52440B] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[Clientes] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [FK__Mascotas__client__3E52440B]
GO
USE [master]
GO
ALTER DATABASE [PetCareIndividual] SET  READ_WRITE 
GO
