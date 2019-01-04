
GO
 -- 1 -- 
 -- MakeMaster -- 

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MakeMaster]') AND type in (N'U'))
CREATE TABLE [dbo].[MakeMaster](
[nMakeID] [numeric] (18, 0) NOT NULL ,
[sMakeName] [varchar] (100) NULL ,
[sMakeCode] [varchar] (10) NULL ,
[dtCreatedDate] [datetime] NULL ,
[dtModifiedDate] [datetime] NULL
) ON [PRIMARY]


