USE [master]
GO
/****** Object:  Database [PetCare]    Script Date: 22/11/2024 15:05:34 ******/
CREATE DATABASE [PetCare]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PetCare', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PetCare.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PetCare_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PetCare_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PetCare] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PetCare].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PetCare] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PetCare] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PetCare] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PetCare] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PetCare] SET ARITHABORT OFF 
GO
ALTER DATABASE [PetCare] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PetCare] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PetCare] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PetCare] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PetCare] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PetCare] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PetCare] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PetCare] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PetCare] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PetCare] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PetCare] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PetCare] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PetCare] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PetCare] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PetCare] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PetCare] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PetCare] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PetCare] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PetCare] SET  MULTI_USER 
GO
ALTER DATABASE [PetCare] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PetCare] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PetCare] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PetCare] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PetCare] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PetCare] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PetCare] SET QUERY_STORE = OFF
GO
USE [PetCare]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 22/11/2024 15:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[veterinario_id] [int] NOT NULL,
	[mascota_id] [int] NOT NULL,
 CONSTRAINT [PK__Citas__3214EC2714A31C3C] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/11/2024 15:05:34 ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 22/11/2024 15:05:34 ******/
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
/****** Object:  Table [dbo].[Facturas]    Script Date: 22/11/2024 15:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[total] [decimal](10, 2) NOT NULL,
	[cliente_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK__Facturas__3214EC270851763D] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascotas]    Script Date: 22/11/2024 15:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascotas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[especie] [varchar](50) NOT NULL,
	[raza] [varchar](50) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[cliente_id] [int] NOT NULL,
 CONSTRAINT [PK__Mascotas__3214EC279E51BB00] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 22/11/2024 15:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK__Producto__3214EC27601CBE34] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veterinarios]    Script Date: 22/11/2024 15:05:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veterinarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[especialidad] [varchar](100) NOT NULL,
	[horario_trabajo] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Veterina__3214EC2710E56939] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Citas] ON 

INSERT [dbo].[Citas] ([ID], [fecha], [hora], [veterinario_id], [mascota_id]) VALUES (13, CAST(N'2024-11-28' AS Date), CAST(N'11:47:21.9140000' AS Time), 9, 17)
INSERT [dbo].[Citas] ([ID], [fecha], [hora], [veterinario_id], [mascota_id]) VALUES (21, CAST(N'2024-11-30' AS Date), CAST(N'12:50:55.6550000' AS Time), 10, 15)
INSERT [dbo].[Citas] ([ID], [fecha], [hora], [veterinario_id], [mascota_id]) VALUES (22, CAST(N'2024-11-23' AS Date), CAST(N'14:52:05.9709782' AS Time), 9, 17)
INSERT [dbo].[Citas] ([ID], [fecha], [hora], [veterinario_id], [mascota_id]) VALUES (23, CAST(N'2024-12-07' AS Date), CAST(N'10:52:05.9710000' AS Time), 11, 20)
SET IDENTITY_INSERT [dbo].[Citas] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (1, N'Rosales', N'Misiones 123', N'1231231231', N'rosales@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (4, N'Martinez', N'Posadas 123', N'1154564567', N'Martinez@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (6, N'Garcia', N'Huergo 23', N'1154561235', N'garcia@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (7, N'Perez', N'Avellaneda 786', N'1141594234', N'perez@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (8, N'Gonzalez', N'Husares 1234', N'1151641234', N'pereira@gmail.com')
INSERT [dbo].[Clientes] ([ID], [nombre], [direccion], [telefono], [email]) VALUES (15, N'Peralta', N'San pedro 123', N'1163213214', N'peralta@gmail.com')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([ID_EMPLEADO], [APELLIDO], [NOMBRE], [DNI], [EMAIL], [CONTRASENIA]) VALUES (1, N'Ramirez', N'Esteban', N'40123123', N'ramirez@gmail.com', N'123')
INSERT [dbo].[Empleado] ([ID_EMPLEADO], [APELLIDO], [NOMBRE], [DNI], [EMAIL], [CONTRASENIA]) VALUES (2, N'Lopez', N'Florencia', N'12123123', N'flor@gmail.com', N'1234')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([ID], [fecha], [total], [cliente_id], [producto_id], [cantidad]) VALUES (1, CAST(N'2024-11-21' AS Date), CAST(50000.00 AS Decimal(10, 2)), 4, 4, 5)
INSERT [dbo].[Facturas] ([ID], [fecha], [total], [cliente_id], [producto_id], [cantidad]) VALUES (2, CAST(N'2024-11-22' AS Date), CAST(30000.00 AS Decimal(10, 2)), 1, 7, 3)
INSERT [dbo].[Facturas] ([ID], [fecha], [total], [cliente_id], [producto_id], [cantidad]) VALUES (4, CAST(N'2024-11-22' AS Date), CAST(50000.00 AS Decimal(10, 2)), 7, 6, 10)
INSERT [dbo].[Facturas] ([ID], [fecha], [total], [cliente_id], [producto_id], [cantidad]) VALUES (5, CAST(N'2024-11-22' AS Date), CAST(4000.00 AS Decimal(10, 2)), 1, 3, 2)
SET IDENTITY_INSERT [dbo].[Facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[Mascotas] ON 

INSERT [dbo].[Mascotas] ([ID], [nombre], [especie], [raza], [fecha_nacimiento], [cliente_id]) VALUES (15, N'Firulais', N'Canino', N'Pitbull', CAST(N'2020-06-10' AS Date), 7)
INSERT [dbo].[Mascotas] ([ID], [nombre], [especie], [raza], [fecha_nacimiento], [cliente_id]) VALUES (17, N'Monchi', N'Felino', N'Siames', CAST(N'2024-11-20' AS Date), 4)
INSERT [dbo].[Mascotas] ([ID], [nombre], [especie], [raza], [fecha_nacimiento], [cliente_id]) VALUES (19, N'Bobby', N'Ave', N'Loro', CAST(N'2019-01-08' AS Date), 1)
INSERT [dbo].[Mascotas] ([ID], [nombre], [especie], [raza], [fecha_nacimiento], [cliente_id]) VALUES (20, N'Coqui', N'Canino', N'Pequines', CAST(N'2021-06-15' AS Date), 8)
SET IDENTITY_INSERT [dbo].[Mascotas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [stock]) VALUES (3, N'Juguete', N'Juguete en forma de hueso', CAST(2000.00 AS Decimal(10, 2)), 100)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [stock]) VALUES (4, N'Comida', N'Comida de perro', CAST(10000.00 AS Decimal(10, 2)), 50)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [stock]) VALUES (6, N'Collar', N'Collar con nombre', CAST(5000.00 AS Decimal(10, 2)), 20)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [stock]) VALUES (7, N'Hueso plastico', N'Hueso de jueguete', CAST(10000.00 AS Decimal(10, 2)), 50)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [stock]) VALUES (9, N'Bolso', N'Bolso para gatos', CAST(25000.00 AS Decimal(10, 2)), 10)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [stock]) VALUES (10, N'Pipeta', N'Pipeta anti pulgas', CAST(2000.00 AS Decimal(10, 2)), 100)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Veterinarios] ON 

INSERT [dbo].[Veterinarios] ([ID], [nombre], [especialidad], [horario_trabajo]) VALUES (9, N'Marcos', N'Radiologo', N'7 a 10')
INSERT [dbo].[Veterinarios] ([ID], [nombre], [especialidad], [horario_trabajo]) VALUES (10, N'Juan', N'Cirujano', N'11 a 16')
INSERT [dbo].[Veterinarios] ([ID], [nombre], [especialidad], [horario_trabajo]) VALUES (11, N'Romina', N'Cardiologia', N'10 a 14')
INSERT [dbo].[Veterinarios] ([ID], [nombre], [especialidad], [horario_trabajo]) VALUES (12, N'Rocio', N'Cardiologia', N'12 a 17')
SET IDENTITY_INSERT [dbo].[Veterinarios] OFF
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK__Citas__mascota_i__440B1D61] FOREIGN KEY([mascota_id])
REFERENCES [dbo].[Mascotas] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK__Citas__mascota_i__440B1D61]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Veterinarios] FOREIGN KEY([veterinario_id])
REFERENCES [dbo].[Veterinarios] ([ID])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Veterinarios]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK__Facturas__client__48CFD27E] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[Clientes] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK__Facturas__client__48CFD27E]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Productos] FOREIGN KEY([producto_id])
REFERENCES [dbo].[Productos] ([ID])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Productos]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [FK__Mascotas__client__3E52440B] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[Clientes] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [FK__Mascotas__client__3E52440B]
GO
USE [master]
GO
ALTER DATABASE [PetCare] SET  READ_WRITE 
GO
