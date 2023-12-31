USE [College1en]
GO
/****** Object:  Table [dbo].[Programs]    Script Date: 2/12/2023 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Programs](
	[ProgId] [varchar](5) NOT NULL,
	[ProgName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Programs] PRIMARY KEY CLUSTERED 
(
	[ProgId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 2/12/2023 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CId] [varchar](7) NOT NULL,
	[CName] [varchar](50) NOT NULL,
	[ProgId] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 2/12/2023 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StId] [varchar](10) NOT NULL,
	[StName] [varchar](50) NOT NULL,
	[ProgId] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollments]    Script Date: 2/12/2023 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollments](
	[StId] [varchar](10) NOT NULL,
	[CId] [varchar](7) NOT NULL,
	[FinalGrade] [int] NULL,
 CONSTRAINT [PK_Enrollments] PRIMARY KEY CLUSTERED 
(
	[StId] ASC,
	[CId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[EnrollmentView]    Script Date: 2/12/2023 23:43:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[EnrollmentView] AS
SELECT DISTINCT
    s.StId,
    s.StName,
    c.CId,
    c.CName,
    e.FinalGrade,
    p.ProgId,
    p.ProgName
FROM
    Enrollments AS e
JOIN Students AS s ON e.StId = s.StId
JOIN Courses AS c ON e.CId = c.CId
JOIN Programs AS p ON c.ProgId = p.ProgId;
GO
INSERT [dbo].[Courses] ([CId], [CName], [ProgId]) VALUES (N'CAS2-AS', N'Information System', N'P420P')
INSERT [dbo].[Courses] ([CId], [CName], [ProgId]) VALUES (N'CAT2-AS', N'Object Oriented Programming', N'P420X')
INSERT [dbo].[Courses] ([CId], [CName], [ProgId]) VALUES (N'CFDT-AS', N'Front Desk Techniques', N'P430A')
INSERT [dbo].[Courses] ([CId], [CName], [ProgId]) VALUES (N'CLS3-AS', N'Scripting Language', N'P420P')
INSERT [dbo].[Courses] ([CId], [CName], [ProgId]) VALUES (N'CMATH-1', N'Math', N'P420P')
INSERT [dbo].[Courses] ([CId], [CName], [ProgId]) VALUES (N'CSM2-AS', N'Supply Management', N'P430A')
GO
INSERT [dbo].[Enrollments] ([StId], [CId], [FinalGrade]) VALUES (N'S202211072', N'CAS2-AS', 58)
INSERT [dbo].[Enrollments] ([StId], [CId], [FinalGrade]) VALUES (N'S202211072', N'CAT2-AS', 87)
INSERT [dbo].[Enrollments] ([StId], [CId], [FinalGrade]) VALUES (N'S202211072', N'CMATH-1', 100)
INSERT [dbo].[Enrollments] ([StId], [CId], [FinalGrade]) VALUES (N'S202244444', N'CFDT-AS', 66)
GO
INSERT [dbo].[Programs] ([ProgId], [ProgName]) VALUES (N'P420P', N'DEC in Computer Science - Programming')
INSERT [dbo].[Programs] ([ProgId], [ProgName]) VALUES (N'P420X', N'DEC in Computer Science - Video Game Programming')
INSERT [dbo].[Programs] ([ProgId], [ProgName]) VALUES (N'P430A', N'DEC in Hotel Management Technique')
INSERT [dbo].[Programs] ([ProgId], [ProgName]) VALUES (N'P440T', N'DEC in Tourism')
GO
INSERT [dbo].[Students] ([StId], [StName], [ProgId]) VALUES (N'S202211072', N'Sergio', N'P420P')
INSERT [dbo].[Students] ([StId], [StName], [ProgId]) VALUES (N'S202211111', N'Mohammad', N'P420P')
INSERT [dbo].[Students] ([StId], [StName], [ProgId]) VALUES (N'S202222222', N'Javier', N'P420X')
INSERT [dbo].[Students] ([StId], [StName], [ProgId]) VALUES (N'S202233333', N'Marilena', N'P420P')
INSERT [dbo].[Students] ([StId], [StName], [ProgId]) VALUES (N'S202244444', N'Quan', N'P430A')
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Programs] FOREIGN KEY([ProgId])
REFERENCES [dbo].[Programs] ([ProgId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Programs]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Courses] FOREIGN KEY([CId])
REFERENCES [dbo].[Courses] ([CId])
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Courses]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Students] FOREIGN KEY([StId])
REFERENCES [dbo].[Students] ([StId])
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Programs] FOREIGN KEY([ProgId])
REFERENCES [dbo].[Programs] ([ProgId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Programs]
GO
