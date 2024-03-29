USE [IdentityDbMvc]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 1/18/2023 9:57:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Gender] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address], [DateOfBirth], [FullName], [Gender]) VALUES (N'1e3d58f1-3a2c-4c3a-a3e7-f2533d60d854', N'recep', N'RECEP', N'recep@yesil.com', N'RECEP@YESIL.COM', 0, N'AQAAAAEAACcQAAAAEJUharce/5YrCO++fVRiveezxJNY69GhqKNzhx29+gZX4T6pfDIn/MhAmb/LnEEQqA==', N'KRDOA3OABAUEIREP6RQRBVV2FDNOYB3R', N'e7e7b78c-6e5a-4cb7-ac6a-6a6477b43a73', NULL, 0, 0, NULL, 1, 0, N'ist', CAST(N'1991-01-01T00:00:00.0000000' AS DateTime2), N'recepo', N'Erkek')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address], [DateOfBirth], [FullName], [Gender]) VALUES (N'3784df9c-328c-4ff5-931d-ff5ba94710e7', N'patika', N'PATIKA', N'pt@dev.com', N'PT@DEV.COM', 1, N'AQAAAAEAACcQAAAAELpslGIYA4VNUVBsCe0Qiwiiu7GiTuo3OyMlSOQYCrDtwHNVY1h8DGIqA4v3zpSnkQ==', N'HNPJWPGIVQ3L4ZJS4YAT34RZFGQ342XU', N'a415fa56-247f-44b5-a8a0-9adb6ccce214', NULL, 0, 0, NULL, 1, 0, N'istanvul', CAST(N'1991-01-01T00:00:00.0000000' AS DateTime2), N'PAtika dev', N'Male')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address], [DateOfBirth], [FullName], [Gender]) VALUES (N'57df6ed8-be72-43c3-b26e-3aeca56427e8', N'recap', N'RECAP', N'recepysl@gmail.com', N'RECEPYSL@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAECjoLTVmR5XvLjtoQIzNI/JXe+nXkko5/jcjKzmdfMiXCiYNJ9cLsrzzw8XIsvE77Q==', N'XSDR4TBYBLWG57OK3GPILY6P755JFSH5', N'8df02d09-fc33-436b-877a-19b363eed7e6', NULL, 0, 0, NULL, 1, 0, N'Konya', CAST(N'1993-04-12T00:00:00.0000000' AS DateTime2), N'recep patika', N'Male')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address], [DateOfBirth], [FullName], [Gender]) VALUES (N'd0f3dd3d-d54b-4aba-a5f0-94b90aa8b25d', N'deny', N'DENY', N'deny@hotmail.com', N'DENY@HOTMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGsg/aejBQirDFh6sgQJFJplUOrLyWkT28Mg810l8vMENs5g3wdy1JCXBzNNJPAbOQ==', N'HQ3VMZC2U5KWPB2E4RFFL6CAUGCIZECD', N'2cb37a6d-3652-407e-bd88-af84cede269e', NULL, 0, 0, NULL, 1, 0, N'Deny DA', CAST(N'1981-01-05T00:00:00.0000000' AS DateTime2), N'deny sellen', N'Male')
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [DateOfBirth]
GO
