USE [GTSDb]
GO
/****** Object:  Table [dbo].[datThesis]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datThesis](
	[ThesisID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NULL,
	[Summary] [nvarchar](max) NULL,
	[AuthorID] [int] NULL,
	[Year] [smallint] NULL,
	[TTypeID] [tinyint] NULL,
	[UniversityID] [smallint] NULL,
	[InstituteID] [tinyint] NULL,
	[PageCount] [smallint] NULL,
	[LanguageID] [tinyint] NULL,
	[DeliveryDT] [nvarchar](8) NULL,
	[AdvisorID] [smallint] NULL,
	[PAdvisorID] [smallint] NULL,
 CONSTRAINT [PK_datThesis] PRIMARY KEY CLUSTERED 
(
	[ThesisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datUser]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datUser](
	[UserID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](10) NOT NULL,
	[UserPassw] [nvarchar](10) NOT NULL,
	[UserType] [char](1) NULL,
 CONSTRAINT [PK_datUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jnkThesisKeyword]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jnkThesisKeyword](
	[TKID] [int] IDENTITY(1,1) NOT NULL,
	[ThesisID] [int] NOT NULL,
	[KeywordID] [smallint] NOT NULL,
 CONSTRAINT [PK_jnkThesisKeyword] PRIMARY KEY CLUSTERED 
(
	[TKID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmAdvisor]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmAdvisor](
	[AdvisorID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_prmAdvisor] PRIMARY KEY CLUSTERED 
(
	[AdvisorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmAuthor]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmAuthor](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_prmAuthor] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmInstitute]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmInstitute](
	[InstituteID] [tinyint] IDENTITY(1,1) NOT NULL,
	[UniversityID] [smallint] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_prmInstitute] PRIMARY KEY CLUSTERED 
(
	[InstituteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmKeyword]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmKeyword](
	[KeywordID] [smallint] IDENTITY(1,1) NOT NULL,
	[KeywordDesc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_prmKeyword] PRIMARY KEY CLUSTERED 
(
	[KeywordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmLanguage]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmLanguage](
	[LanguageID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](20) NULL,
 CONSTRAINT [PK_prmLanguage] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmThesisType]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmThesisType](
	[TTypeID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_prmThesisType] PRIMARY KEY CLUSTERED 
(
	[TTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prmUniversity]    Script Date: 7.01.2024 00:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prmUniversity](
	[UniversityID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_prmUniversity] PRIMARY KEY CLUSTERED 
(
	[UniversityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[datThesis] ON 

INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (1, N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', N'Vestibulum sed magna at nunc commodo placerat. Praesent blandit. Nam nulla.', 1, 2009, 7, 3, 21, 236, 3, N'20121212', 19, 47)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (3, N'Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.', N'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.', 9, 2020, 8, 6, 1, 158, 2, N'20200304', 16, 11)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (4, N'Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum.', N'In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.', 92, 2013, 7, 2, 14, 115, 2, N'20000615', 10, 22)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (5, N'Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis.', N'Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est.', 37, 2022, 7, 2, 18, 61, 1, N'20050611', 10, 33)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (6, N'Integer non velit. Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.', N'Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia.', 2, 2007, 8, 2, 17, 216, 3, N'20030530', 42, 25)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (7, N'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus.', N'Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', 89, 2005, 7, 2, 19, 118, 1, N'20130818', 16, 27)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (8, N'Sed ante. Vivamus tortor.', N'Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.', 71, 2004, 7, 4, 25, 166, 1, N'20010322', 14, 30)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (9, N'Morbi non lectus.', N'Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.', 75, 2013, 7, 4, 28, 107, 3, N'20210107', 39, 26)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (10, N'Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.', N'Nulla suscipit ligula in lacus.', 73, 2009, 8, 1, 5, 88, 3, N'20000119', 24, 16)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (11, N'Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.', N'Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus.', 5, 2009, 8, 5, 12, 142, 2, N'20050505', 41, 3)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (12, N'Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.', N'Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', 85, 2007, 10, 6, 1, 133, 3, N'20131219', 13, 41)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (13, N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', 94, 2000, 9, 6, 2, 70, 1, N'20160520', 19, 20)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (14, N'Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.', N'In est risus, auctor sed, tristique in, tempus sit amet, sem.', 14, 2017, 8, 2, 18, 206, 1, N'20110719', 37, 46)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (15, N'Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien.', N'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.', 79, 2018, 8, 1, 5, 77, 3, N'20100611', 2, 6)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (16, N'Curabitur convallis.', N'Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.', 6, 2000, 7, 1, 8, 101, 1, N'20021205', 7, 8)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (17, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo.', N'In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.', 27, 2008, 9, 2, 17, 105, 2, N'20200714', 50, 49)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (18, N'Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.', N'Etiam vel augue.', 32, 2005, 10, 3, 20, 93, 3, N'20020130', 22, 39)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (19, N'Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.', N'Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.', 98, 2003, 10, 2, 15, 170, 1, N'20030420', 1, 39)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (20, N'Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.', N'Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl. Nunc nisl.', 17, 2020, 8, 1, 7, 206, 2, N'20070808', 25, 29)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (21, N'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.', N'Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.', 94, 2008, 9, 1, 8, 60, 3, N'20140617', 46, 25)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (22, N'Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum.', N'Maecenas pulvinar lobortis est. Phasellus sit amet erat.', 33, 2003, 8, 5, 9, 192, 3, N'20030909', 40, 4)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (23, N'Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.', N'Nullam porttitor lacus at turpis.', 15, 2017, 7, 3, 23, 202, 3, N'20070508', 49, 32)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (24, N'Nulla tellus. In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.', N'Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin interdum mauris non ligula pellentesque ultrices.', 19, 2014, 7, 2, 15, 194, 2, N'20020606', 3, 20)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (25, N'Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.', N'Duis mattis egestas metus.', 67, 2009, 10, 3, 23, 61, 2, N'20100614', 7, 17)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (27, N'Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.', N'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia.', 100, 2014, 10, 4, 26, 177, 3, N'20211115', 24, 43)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (28, N'Ut at dolor quis odio consequat varius. Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.', N'Curabitur at ipsum ac tellus semper interdum.', 40, 2007, 7, 5, 11, 114, 3, N'20080330', 17, 19)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (29, N'Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem. Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.', N'Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.', 88, 2002, 7, 3, 23, 196, 3, N'20020417', 42, 26)
INSERT [dbo].[datThesis] ([ThesisID], [Title], [Summary], [AuthorID], [Year], [TTypeID], [UniversityID], [InstituteID], [PageCount], [LanguageID], [DeliveryDT], [AdvisorID], [PAdvisorID]) VALUES (30, N'In congue. Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.', N'In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum.', 29, 2012, 7, 3, 24, 249, 2, N'20030128', 36, 11)
SET IDENTITY_INSERT [dbo].[datThesis] OFF
GO
SET IDENTITY_INSERT [dbo].[datUser] ON 

INSERT [dbo].[datUser] ([UserID], [UserName], [UserPassw], [UserType]) VALUES (1, N'Admin', N'Q1w2e3', N'A')
INSERT [dbo].[datUser] ([UserID], [UserName], [UserPassw], [UserType]) VALUES (2, N'User', N'Q1w2e3*', N'U')
SET IDENTITY_INSERT [dbo].[datUser] OFF
GO
SET IDENTITY_INSERT [dbo].[prmAdvisor] ON 

INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (1, N'Pippo Ferraretto')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (2, N'Edvard Nehls')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (3, N'Lyndsey Stobbart')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (4, N'Cosmo Queripel')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (5, N'Ulrich Alves')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (6, N'Kerk Staite')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (7, N'Aindrea McCague')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (8, N'Sander Jahnig')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (9, N'Stacy Bendel')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (10, N'Benni Fellman')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (11, N'Stevie Champain')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (12, N'Keelia Sandes')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (13, N'Leonelle Rengger')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (14, N'Brien Bartolomieu')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (15, N'Kala Clohessy')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (16, N'Aindrea Kennagh')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (17, N'Malinda Barr')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (18, N'Shalom O''Cannan')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (19, N'Meta Fever')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (20, N'Nalani McArthur')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (21, N'Worthington Bushby')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (22, N'Graeme Lazonby')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (23, N'Siouxie Gittins')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (24, N'Janeczka Chetwin')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (25, N'Huntley Urwen')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (26, N'Harp Astbery')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (27, N'Johannah Carlet')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (28, N'Ricki Brokenshaw')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (29, N'Odo Alderson')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (30, N'Leeland Hucke')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (31, N'Wenona Skipton')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (32, N'Billy Alelsandrowicz')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (33, N'Ashly Cush')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (34, N'Hartwell Bonwick')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (35, N'North Callcott')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (36, N'Dorene Grasser')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (37, N'Thom Nan Carrow')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (38, N'Dulcia Fernie')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (39, N'Devy Raddenbury')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (40, N'Cosetta Filkov')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (41, N'Lainey Bartot')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (42, N'Kirby Raitie')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (43, N'Tim Folomkin')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (44, N'Serge Simonsson')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (45, N'Minerva Deacock')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (46, N'Katherine Berrick')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (47, N'Ambrosius Stockow')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (48, N'Constantino Holborn')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (49, N'Pearle Whitloe')
INSERT [dbo].[prmAdvisor] ([AdvisorID], [Name]) VALUES (50, N'Susanne De Ruggero')
SET IDENTITY_INSERT [dbo].[prmAdvisor] OFF
GO
SET IDENTITY_INSERT [dbo].[prmAuthor] ON 

INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (1, N'Fletcher West-Frimley')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (2, N'Kristoforo Sixsmith')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (3, N'Gabby Waitland')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (4, N'Olympe Dmytryk')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (5, N'Michaeline Kirsopp')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (6, N'Lemmy Woodson')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (7, N'Neda Jerrolt')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (8, N'Sue Gouldeby')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (9, N'Udell Flewett')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (10, N'Isidro Geelan')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (11, N'Darrelle McComb')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (12, N'Davis Bulford')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (13, N'Gene Galletly')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (14, N'Martita Dowrey')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (15, N'Tam Magne')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (16, N'Sukey Spirritt')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (17, N'Clyde McPhate')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (18, N'Damita Nemchinov')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (19, N'Mitchell Biles')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (20, N'Eveline Victor')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (21, N'Penni Zucker')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (22, N'Katrina Gadsdon')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (23, N'Ted Wloch')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (24, N'Caitrin Puckey')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (25, N'Tiffani Tincombe')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (26, N'Keri Jasik')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (27, N'Munroe Taphouse')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (28, N'Cos Jachtym')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (29, N'Milicent Verner')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (30, N'Rupert Keneforde')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (31, N'Josee Burton')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (32, N'Meggy Dalgliesh')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (33, N'Chuck Summergill')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (34, N'Llywellyn Garmanson')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (35, N'Corbie Tetsall')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (36, N'Jobyna Bome')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (37, N'Harri Rosenthaler')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (38, N'Jaimie Scemp')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (39, N'Harli Antuoni')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (40, N'Shaun Greer')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (41, N'Selena Loveard')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (42, N'Anderea Dulin')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (43, N'Freeman Timmins')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (44, N'Blaine Pullman')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (45, N'Antin Fripps')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (46, N'Jared Roydon')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (47, N'Willamina Petrou')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (48, N'Chanda Whiteside')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (49, N'Talia Barten')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (50, N'Belia Kivits')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (51, N'Edward McArd')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (52, N'Almeria Tilly')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (53, N'Alex Painten')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (54, N'Alexander Herion')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (55, N'Almire Scurman')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (56, N'Bee Spurdon')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (57, N'Liza Doswell')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (58, N'Pearline Coniam')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (59, N'Blondell Etherton')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (60, N'Libbi Bridgestock')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (61, N'Godfree Leindecker')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (62, N'Feodor Chesterfield')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (63, N'Matias Seefeldt')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (64, N'Nickolaus Domesday')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (65, N'Stafford Wickson')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (66, N'Jodi Pitbladdo')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (67, N'Dianemarie Howford')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (68, N'Myrvyn Roth')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (69, N'Meggi Parsonage')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (70, N'Timmy Marrable')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (71, N'Inglis Verna')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (72, N'Sergeant Curzey')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (73, N'Julie Gardiner')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (74, N'Fergus Jarvis')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (75, N'Honey Bartelli')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (76, N'Lou Aujean')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (77, N'Adolph Fane')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (78, N'Chiarra Bilsford')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (79, N'Hyacintha Carey')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (80, N'Adel Chidler')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (81, N'Lillis Wolffers')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (82, N'Ruben Laister')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (83, N'Vanya Ferrierio')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (84, N'Aleen Blondelle')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (85, N'Trefor Gilogly')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (86, N'Guglielma Phipp')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (87, N'Benedikta Hyndman')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (88, N'Doro Moline')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (89, N'Gerardo Giacovetti')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (90, N'Marji Hamor')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (91, N'Christophe Bockmann')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (92, N'Desirae Pimlott')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (93, N'Eduino Blackaby')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (94, N'Edy Kempshall')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (95, N'Cordy Reedie')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (96, N'Jill Crummie')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (97, N'Ora Seefeldt')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (98, N'Lucine Dach')
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (99, N'Klement MacCawley')
GO
INSERT [dbo].[prmAuthor] ([AuthorID], [Name]) VALUES (100, N'Leonie Thresher')
SET IDENTITY_INSERT [dbo].[prmAuthor] OFF
GO
SET IDENTITY_INSERT [dbo].[prmInstitute] ON 

INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (1, 6, N'Institute of Pure and Applied Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (2, 6, N'Institute of Social Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (3, 1, N'Disaster Management Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (4, 1, N'Eurasia Institute of Earth Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (5, 1, N'Informatics Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (6, 1, N'Energy Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (7, 1, N'Graduate School')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (8, 1, N'Aviation Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (9, 5, N'Graduate School of Applied Mathematics')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (10, 5, N'Graduate School of Informatics')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (11, 5, N'Graduate School of Marine Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (12, 5, N'Graduate School of Natural and Applied Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (13, 5, N'Graduate School of Social Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (14, 2, N'Confucius Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (15, 2, N'Social Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (17, 2, N'Kandilli Observatory And Earthquake Research Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (18, 2, N'Institute for Graduate Studies in Science and Engineering')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (19, 2, N'Institute for Data Science & Artificial Intelligence')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (20, 3, N'﻿Aziz Sancar Institute of Experimental Medicine')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (21, 3, N'Institute of Ataturk’s Principles and Reforms')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (22, 3, N'Institute of Graduate Studies In Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (23, 3, N'Institute of Oncology')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (24, 3, N'Institute of Social Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (25, 4, N'Graduate School of Educational Sciences ')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (26, 4, N'Biotechnology Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (27, 4, N'Institute of Health Sciences')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (28, 4, N'Water Management Institute')
INSERT [dbo].[prmInstitute] ([InstituteID], [UniversityID], [Name]) VALUES (29, 4, N'Forensic Sciences Institute')
SET IDENTITY_INSERT [dbo].[prmInstitute] OFF
GO
SET IDENTITY_INSERT [dbo].[prmKeyword] ON 

INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (1, N'Multi-layered')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (2, N'Face to face')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (3, N'Fully-configurable')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (4, N'Multi-tiered')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (5, N'service-desk')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (6, N'solution')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (7, N'Advanced')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (8, N'protocol')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (9, N'installation')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (10, N'database')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (11, N'project')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (12, N'Advanced')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (13, N'Self-enabling')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (14, N'time-frame')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (15, N'asymmetric')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (16, N'Stand-alone')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (17, N'protocol')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (18, N'secondary')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (19, N'Graphical User Interface')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (20, N'maximized')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (21, N'Profound')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (22, N'system-worthy')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (23, N'exuding')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (24, N'optimizing')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (25, N'coherent')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (26, N'Focused')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (27, N'help-desk')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (28, N'Cloned')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (29, N'actuating')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (30, N'open architecture')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (31, N'homogeneous')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (32, N'process improvement')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (33, N'tertiary')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (34, N'core')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (35, N'User-centric')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (36, N'Digitized')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (37, N'instruction set')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (38, N'flexibility')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (39, N'Cross-group')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (40, N'full-range')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (41, N'Mandatory')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (42, N'encryption')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (43, N'complexity')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (44, N'Optimized')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (45, N'Triple-buffered')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (46, N'algorithm')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (47, N'matrices')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (48, N'systemic')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (49, N'Monitored')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (50, N'responsive')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (51, N'matrix')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (52, N'focus group')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (53, N'Horizontal')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (54, N'system-worthy')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (55, N'throughput')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (56, N'motivating')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (57, N'Progressive')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (58, N'methodology')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (59, N'Diverse')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (60, N'Intuitive')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (61, N'Self-enabling')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (62, N'alliance')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (63, N'orchestration')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (64, N'Triple-buffered')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (65, N'archive')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (66, N'leverage')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (67, N'approach')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (68, N'Advanced')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (69, N'empowering')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (70, N'needs-based')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (71, N'Digitized')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (72, N'incremental')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (73, N'policy')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (74, N'analyzing')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (75, N'clear-thinking')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (76, N'Digitized')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (77, N'customer loyalty')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (78, N'homogeneous')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (79, N'holistic')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (80, N'monitoring')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (81, N'Profit-focused')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (82, N'access')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (83, N'alliance')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (84, N'real-time')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (85, N'internet solution')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (86, N'Front-line')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (87, N'Down-sized')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (88, N'Quality-focused')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (89, N'demand-driven')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (90, N'Multi-tiered')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (91, N'Synergized')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (92, N'Stand-alone')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (93, N'Compatible')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (94, N'Operative')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (95, N'Versatile')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (96, N'foreground')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (97, N'disintermediate')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (98, N'De-engineered')
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (99, N'bottom-line')
GO
INSERT [dbo].[prmKeyword] ([KeywordID], [KeywordDesc]) VALUES (100, N'Customizable')
SET IDENTITY_INSERT [dbo].[prmKeyword] OFF
GO
SET IDENTITY_INSERT [dbo].[prmLanguage] ON 

INSERT [dbo].[prmLanguage] ([LanguageID], [Description]) VALUES (1, N'Turkish')
INSERT [dbo].[prmLanguage] ([LanguageID], [Description]) VALUES (2, N'English')
INSERT [dbo].[prmLanguage] ([LanguageID], [Description]) VALUES (3, N'French')
SET IDENTITY_INSERT [dbo].[prmLanguage] OFF
GO
SET IDENTITY_INSERT [dbo].[prmThesisType] ON 

INSERT [dbo].[prmThesisType] ([TTypeID], [Description]) VALUES (7, N'Master')
INSERT [dbo].[prmThesisType] ([TTypeID], [Description]) VALUES (8, N'Doctorate')
INSERT [dbo].[prmThesisType] ([TTypeID], [Description]) VALUES (9, N'Specializaton on Medicine')
INSERT [dbo].[prmThesisType] ([TTypeID], [Description]) VALUES (10, N'Proficiency in Art')
SET IDENTITY_INSERT [dbo].[prmThesisType] OFF
GO
SET IDENTITY_INSERT [dbo].[prmUniversity] ON 

INSERT [dbo].[prmUniversity] ([UniversityID], [Name]) VALUES (1, N'Istanbul Technical University')
INSERT [dbo].[prmUniversity] ([UniversityID], [Name]) VALUES (2, N'Bosphorus University')
INSERT [dbo].[prmUniversity] ([UniversityID], [Name]) VALUES (3, N'Istanbul University')
INSERT [dbo].[prmUniversity] ([UniversityID], [Name]) VALUES (4, N'Ankara University')
INSERT [dbo].[prmUniversity] ([UniversityID], [Name]) VALUES (5, N'Middle East Technical University')
INSERT [dbo].[prmUniversity] ([UniversityID], [Name]) VALUES (6, N'Marmara University')
SET IDENTITY_INSERT [dbo].[prmUniversity] OFF
GO
ALTER TABLE [dbo].[datThesis]  WITH CHECK ADD  CONSTRAINT [FK_datThesis_prmAdvisor] FOREIGN KEY([AdvisorID])
REFERENCES [dbo].[prmAdvisor] ([AdvisorID])
GO
ALTER TABLE [dbo].[datThesis] CHECK CONSTRAINT [FK_datThesis_prmAdvisor]
GO
ALTER TABLE [dbo].[datThesis]  WITH CHECK ADD  CONSTRAINT [FK_datThesis_prmAdvisor1] FOREIGN KEY([PAdvisorID])
REFERENCES [dbo].[prmAdvisor] ([AdvisorID])
GO
ALTER TABLE [dbo].[datThesis] CHECK CONSTRAINT [FK_datThesis_prmAdvisor1]
GO
ALTER TABLE [dbo].[datThesis]  WITH CHECK ADD  CONSTRAINT [FK_datThesis_prmAuthor] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[prmAuthor] ([AuthorID])
GO
ALTER TABLE [dbo].[datThesis] CHECK CONSTRAINT [FK_datThesis_prmAuthor]
GO
ALTER TABLE [dbo].[datThesis]  WITH CHECK ADD  CONSTRAINT [FK_datThesis_prmInstitute] FOREIGN KEY([InstituteID])
REFERENCES [dbo].[prmInstitute] ([InstituteID])
GO
ALTER TABLE [dbo].[datThesis] CHECK CONSTRAINT [FK_datThesis_prmInstitute]
GO
ALTER TABLE [dbo].[datThesis]  WITH CHECK ADD  CONSTRAINT [FK_datThesis_prmLanguage] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[prmLanguage] ([LanguageID])
GO
ALTER TABLE [dbo].[datThesis] CHECK CONSTRAINT [FK_datThesis_prmLanguage]
GO
ALTER TABLE [dbo].[datThesis]  WITH CHECK ADD  CONSTRAINT [FK_datThesis_prmThesisType] FOREIGN KEY([TTypeID])
REFERENCES [dbo].[prmThesisType] ([TTypeID])
GO
ALTER TABLE [dbo].[datThesis] CHECK CONSTRAINT [FK_datThesis_prmThesisType]
GO
ALTER TABLE [dbo].[datThesis]  WITH CHECK ADD  CONSTRAINT [FK_datThesis_prmUniversity1] FOREIGN KEY([UniversityID])
REFERENCES [dbo].[prmUniversity] ([UniversityID])
GO
ALTER TABLE [dbo].[datThesis] CHECK CONSTRAINT [FK_datThesis_prmUniversity1]
GO
ALTER TABLE [dbo].[prmInstitute]  WITH CHECK ADD  CONSTRAINT [FK_prmInstitute_prmUniversity] FOREIGN KEY([UniversityID])
REFERENCES [dbo].[prmUniversity] ([UniversityID])
GO
ALTER TABLE [dbo].[prmInstitute] CHECK CONSTRAINT [FK_prmInstitute_prmUniversity]
GO
