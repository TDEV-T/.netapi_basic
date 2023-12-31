-- CREATE DATABASE MyWorldDB
-- GO

-- USE MyWorldDB
-- GO

-- CREATE TABLE [dbo].[Gadgets](
--     [Id] [int] IDENTITY(1,1) NOT NULL,
--     [ProductName] [varchar](max) NULL,
--     [Brand] [varchar](max) NULL,
--     [Cost] [decimal](18,0) NOT NULL,
--     [ImageName] [varchar](1024) NULL,
--     [Type] [varchar](128) NULL,
--     [CreatedDate] [datetime] NULL,
--     [ModifiedDate] [datetime] NULL,
--     PRIMARY KEY CLUSTERED
--     (
--         [Id] ASC
--     )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS = ON,ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]   
-- )ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
-- GO


USE MyWorldDB
GO

CREATE TABLE [dbo].[Users](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Username] [varchar](max) NOT NULL,
    [Password] [varchar](max) NOT NULL,
    [Email] [varchar](max) NOT NULL,
    [Status] [varchar](max) NULL,
    [CreatedDate] [datetime] NULL,
    [ModifiedDate] [datetime] NULL,
    PRIMARY KEY CLUSTERED
    (
        [Id] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF,IGNORE_DUP_KEY=OFF,ALLOW_ROW_LOCKS = ON,ALLOW_PAGE_LOCKS=ON) ON [PRIMARY]   
)ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO