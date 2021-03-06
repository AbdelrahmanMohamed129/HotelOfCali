USE [master]
GO
/****** Object:  Database [Hotel_Project]    Script Date: 1/5/2022 9:58:59 PM ******/
CREATE DATABASE [Hotel_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel_Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hotel_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hotel_Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hotel_Project] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel_Project] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel_Project] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hotel_Project] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel_Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel_Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hotel_Project] SET QUERY_STORE = OFF
GO
USE [Hotel_Project]
GO
/****** Object:  Table [dbo].[Attend]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attend](
	[USSN] [int] NOT NULL,
	[EventNO] [int] NOT NULL,
 CONSTRAINT [PK_Attend] PRIMARY KEY CLUSTERED 
(
	[USSN] ASC,
	[EventNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillNO] [int] NOT NULL,
	[EventCost] [int] NULL,
	[RoomCost] [int] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companion]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companion](
	[FName] [varchar](50) NOT NULL,
	[Minit] [varchar](1) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[USSN] [int] NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Relationship] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Companion] PRIMARY KEY CLUSTERED 
(
	[FName] ASC,
	[Minit] ASC,
	[LName] ASC,
	[USSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dependents]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dependents](
	[FName] [varchar](50) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[ESSN] [int] NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[Relationship] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Dependents] PRIMARY KEY CLUSTERED 
(
	[FName] ASC,
	[LName] ASC,
	[ESSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[FName] [varchar](50) NOT NULL,
	[Minit] [varchar](5) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[SSN] [int] NOT NULL,
	[RoleID] [varchar](10) NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[MobileNO] [varchar](50) NOT NULL,
	[SuperSSN] [int] NULL,
	[Salary] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[EventNO] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[EventCost] [int] NOT NULL,
	[Description] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[EventNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginAccount]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginAccount](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LoginAccount] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organize]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organize](
	[ESSN] [int] NOT NULL,
	[EventNO] [int] NOT NULL,
 CONSTRAINT [PK_Organize] PRIMARY KEY CLUSTERED 
(
	[ESSN] ASC,
	[EventNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ReservationNO] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[USSN] [int] NULL,
	[RoomNO] [int] NOT NULL,
	[BillNO] [int] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ReservationNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [varchar](10) NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[Description] [varchar](max) NULL,
	[DefaultSalary] [int] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomNO] [int] NOT NULL,
	[RoomType] [int] NOT NULL,
	[Occupancy] [int] NOT NULL,
	[Cleaned] [varchar](1) NOT NULL,
	[ESSN] [int] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomType](
	[RoomTypeID] [int] NOT NULL,
	[RoomType] [varchar](15) NOT NULL,
	[RoomView] [varchar](15) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_RoomType] PRIMARY KEY CLUSTERED 
(
	[RoomTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 1/5/2022 9:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[FName] [varchar](50) NOT NULL,
	[Minit] [varchar](1) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[SSN] [int] NOT NULL,
	[Gender] [varchar](1) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[MobileNO] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'David', N'M', N'Bryan', 12222, N'RecMGR', N'M', CAST(N'1955-12-08' AS Date), N'638 Voss, Houston, TX', N'14844493857', 12345, 100000, N'EMP_David')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Mark', N'F', N'Jerry', 12345, N'CEO', N'M', CAST(N'1965-09-11' AS Date), N'731 Fondren, Houston, TX', N'14844493863', NULL, 250000, N'EMP_Mark')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'John', N'L', N'Tom', 13333, N'HouMGR', N'M', CAST(N'1937-11-10' AS Date), N'3321,Castle, Spring, TX', N'14844493500', 12345, 22000, N'EMP_John')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Sofia', N'Z', N'Labib', 14444, N'OrgMGR', N'F', CAST(N'1979-03-29' AS Date), N'975 Fire Oak, Humble, TX', N'15852135945', 12345, 45000, N'EMP_Sofia')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Maria', N'F', N'Habib', 15555, N'RecEMP', N'F', CAST(N'1972-07-31' AS Date), N'980 Dallas, Houston, TX', N'15852135888', 12222, 10000, N'EMP_Maria')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Jack', N'S', N'Peter', 16666, N'RecEMP', N'M', CAST(N'1972-07-11' AS Date), N'523 Rice, Houston, T', N'158521357231', 12222, 11000, N'EMP_Jack')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Alice', N'M', N'Alex', 17777, N'OrgEMP', N'F', CAST(N'1965-09-08' AS Date), N'291 Rice, Bellaire, TX', N'15811223945', 14444, 7500, N'EMP_Alice')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Nancy', N'K', N'David', 18888, N'OrgEMP', N'F', CAST(N'1985-03-29' AS Date), N'975 Fire Oak, Ohio, TX', N'14822293863', 14444, 7500, N'EMP_Nancy')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Mansour', N'M', N'Ibrahim', 19999, N'HouEMP', N'M', CAST(N'1957-05-10' AS Date), N'3321,Castle, Summer, TX', N'14844421863', 13333, 2500, N'EMP_Mansour')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'James', N'Z', N'Lebron', 20000, N'HouEMP', N'M', CAST(N'1969-07-04' AS Date), N'5631 Rice, Alaska, T', N'15852132345', 13333, 2000, N'EMP_James')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Kevin', N'A', N'Green', 21111, N'HouEMP', N'M', CAST(N'1967-03-11' AS Date), N'451 Dallas, Houston, TX', N'15898765945', 13333, 2000, N'EMP_Kevin')
INSERT [dbo].[Employee] ([FName], [Minit], [LName], [SSN], [RoleID], [Gender], [BirthDate], [Address], [MobileNO], [SuperSSN], [Salary], [UserName]) VALUES (N'Adam', N'J', N'Bran', 22222, N'HouEMP', N'M', CAST(N'1975-12-31' AS Date), N'975 Fire Oak, California, TX', N'15823137785', 13333, 2200, N'EMP_Adam')
GO
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Adam', N'adam123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Alice', N'alice123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_David', N'david123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Jack', N'jack123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_James', N'james123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_John', N'john123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Kevin', N'kevin123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Mansour', N'mansour123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Maria', N'maria123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Mark', N'mark123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Nancy', N'nancy123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'EMP_Sofia', N'sofia123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'USER_Anna', N'anna123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'USER_Carol', N'carol123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'USER_Daniel', N'daniel123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'USER_Jerry', N'jerry123')
INSERT [dbo].[LoginAccount] ([UserName], [Password]) VALUES (N'USER_Roy', N'roy123')
GO
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description], [DefaultSalary]) VALUES (N'CEO', N'Head Manager', N'Controls everything in the system', 200000)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description], [DefaultSalary]) VALUES (N'HouEMP', N'HouseKeeping', N'Responsible for cleaning rooms', 2000)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description], [DefaultSalary]) VALUES (N'HouMGR', N'House keeping Manager', N'Controls all the house keeping employees', 20000)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description], [DefaultSalary]) VALUES (N'OrgEMP', N'Organizer', N'Responsible for organizing events', 7500)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description], [DefaultSalary]) VALUES (N'OrgMGR', N'Organizers Manager', N'Controls all Organizers', 40000)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description], [DefaultSalary]) VALUES (N'RecEMP', N'Receptionist', N'Responsible for reserving and checking up the rooms', 10000)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description], [DefaultSalary]) VALUES (N'RecMGR', N'Receptionist Manager', N'Contols all the reception employees', 100000)
GO
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (1, N'Single', N'City', N'A single bedroom with city view', 1000)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (2, N'Single', N'Pool', N'A single bedroom with pool view', 1500)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (3, N'Double', N'Pool', N'A double bedroom with a pool view', 2500)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (4, N'Double', N'Sea', N'A double bedroom with sea view', 3000)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (5, N'Double', N'Mountain', N'A double bedroom with a mountain view', 3000)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (6, N'King', N'Pool', N'A room with king bed and a pool view', 4000)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (7, N'King', N'Sea', N'A room with a king bed and a sea view', 4500)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (8, N'King', N'Mountain', N'A room with king bed and a mountain view', 5000)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (9, N'Suite', N'Sea', N'A room with one or more bedrooms and a separate living space with sea view', 6000)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (10, N'Suite', N'Mountain', N'A room with one or more bedrooms and a separate living space with mountain view', 6500)
INSERT [dbo].[RoomType] ([RoomTypeID], [RoomType], [RoomView], [Description], [Price]) VALUES (11, N'Super Suite', N'Sea', N'A super suite has more than one bedroom and a living space with a strong emphasis on grand in-room decoration, high-quality amenities and supplies, and tailor-made services with sea view', 50000)
GO
ALTER TABLE [dbo].[Attend]  WITH CHECK ADD  CONSTRAINT [FK_Attend_Events] FOREIGN KEY([EventNO])
REFERENCES [dbo].[Events] ([EventNO])
GO
ALTER TABLE [dbo].[Attend] CHECK CONSTRAINT [FK_Attend_Events]
GO
ALTER TABLE [dbo].[Attend]  WITH CHECK ADD  CONSTRAINT [FK_Attend_User] FOREIGN KEY([USSN])
REFERENCES [dbo].[User] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attend] CHECK CONSTRAINT [FK_Attend_User]
GO
ALTER TABLE [dbo].[Companion]  WITH CHECK ADD  CONSTRAINT [FK_Companion_User] FOREIGN KEY([USSN])
REFERENCES [dbo].[User] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Companion] CHECK CONSTRAINT [FK_Companion_User]
GO
ALTER TABLE [dbo].[Dependents]  WITH CHECK ADD  CONSTRAINT [FK_Dependents_Employee] FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dependents] CHECK CONSTRAINT [FK_Dependents_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Employee] FOREIGN KEY([SuperSSN])
REFERENCES [dbo].[Employee] ([SSN])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_LoginAccount] FOREIGN KEY([UserName])
REFERENCES [dbo].[LoginAccount] ([UserName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_LoginAccount]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Roles]
GO
ALTER TABLE [dbo].[Organize]  WITH CHECK ADD  CONSTRAINT [FK_Organize_Employee] FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organize] CHECK CONSTRAINT [FK_Organize_Employee]
GO
ALTER TABLE [dbo].[Organize]  WITH CHECK ADD  CONSTRAINT [FK_Organize_Events] FOREIGN KEY([EventNO])
REFERENCES [dbo].[Events] ([EventNO])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organize] CHECK CONSTRAINT [FK_Organize_Events]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Room] FOREIGN KEY([RoomNO])
REFERENCES [dbo].[Room] ([RoomNO])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Room]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_User] FOREIGN KEY([USSN])
REFERENCES [dbo].[User] ([SSN])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_User]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Employee] FOREIGN KEY([ESSN])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Employee]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_RoomType] FOREIGN KEY([RoomType])
REFERENCES [dbo].[RoomType] ([RoomTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_RoomType]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_LoginAccount] FOREIGN KEY([UserName])
REFERENCES [dbo].[LoginAccount] ([UserName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_LoginAccount]
GO
USE [master]
GO
ALTER DATABASE [Hotel_Project] SET  READ_WRITE 
GO
