
GO
 -- 1 -- 
 -- lgsp_Get_AssetMasterData_ByMainType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_Get_AssetMasterData_ByMainType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_Get_AssetMasterData_ByMainType]

GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  


CREATE PROCEDURE [dbo].[lgsp_Get_AssetMasterData_ByMainType]  
-- Add the parameters for the stored procedure here  
      @nAssetType NUMERIC(18, 0)
AS
     BEGIN  
         -- SET NOCOUNT ON added to prevent extra result sets from  
         -- interfering with SELECT statements.  
         SET NOCOUNT ON;  
  
         -- Insert statements for procedure here  
         IF @nAssetType = 0
             BEGIN
                 SELECT
                        [ASS].[nAssetMainTypeID] AS [ID]
                      , [ASS].[sAssetType] AS [Code]
                 FROM
                      [dbo].[AssetMainType] AS [ASS] WITH (NOLOCK);
                 SELECT
                        [COM].[nCompanyID] AS [ID]
                      , [COM].[sCompanyCode]+'-'+[COM].[sCompanyName] AS [Code]
                 FROM
                      [dbo].[CompanyMaster] AS [COM] WITH (NOLOCK);
                 SELECT
                        [MAT].[nMaterialTypeID] AS [ID]
                      , CASE
                            WHEN ISNULL([MAT].[sMaterialTypeCode], '') = ''
                            THEN [MAT].[sMaterialTypeName]
                            ELSE [MAT].[sMaterialTypeCode]+'-'+[MAT].[sMaterialTypeName]
                        END AS [Code]
                 FROM
                      [dbo].[MaterialType] AS [MAT] WITH (NOLOCK);
                 SELECT
                        [COL].[nColourTypeID] AS [ID]
                      , CASE
                            WHEN ISNULL([COL].[sColourTypeCode], '') = ''
                            THEN [COL].[sColourTypeName]
                            ELSE [COL].[sColourTypeCode]+'-'+[COL].[sColourTypeName]
                        END AS [Code]
                 FROM
                      [dbo].[ColourType] AS [COL] WITH (NOLOCK);
                 SELECT
                        [DEN].[nDensityTypeID] AS [ID]
                      , CASE
                            WHEN ISNULL([DEN].[sDensityTypeCode], '') = ''
                            THEN [DEN].[sDensityTypeName]
                            ELSE [DEN].[sDensityTypeCode]+'-'+[DEN].[sDensityTypeName]
                        END AS [Code]
                 FROM
                      [dbo].[DensityType] AS [DEN] WITH (NOLOCK);
                 SELECT
                        [PAR].[nPartyID] AS [ID]
                      , [PAR].[sPartyCode]+'-'+[PAR].[sPartyName] AS [Code]
                 FROM
                      [dbo].[PartyMaster] AS [PAR]
                 WHERE [PAR].[nPartyType] =
                 (
                  SELECT
                         [PAR].[nPartyTypeID]
                  FROM
                       [dbo].[PartyType] AS [PAR] WITH (NOLOCK)
                  WHERE LOWER([PAR].[sPartyTypeName]) = 'vendor'
                       );
             END;
         ELSE
             BEGIN
                 SELECT
                        [ASS].[nAssetTypeID] AS [ID]
                      , CASE
                            WHEN ISNULL([ASS].[sAssetTypeCode], '') = ''
                            THEN [ASS].[sAssetTypeName]
                            ELSE [ASS].[sAssetTypeCode]+'-'+[ASS].[sAssetTypeName]
                        END AS [Code]
                 FROM
                      [dbo].[AssetType] AS [ASS]
                 WHERE [ASS].[nAssetMainTypeID] = @nAssetType;
                 SELECT
                        [ASS].[nAssetTypeOneID] AS [ID]
                      , CASE
                            WHEN ISNULL([ASS].[sAssetTypeOneCode], '') = ''
                            THEN [ASS].[sAssetTypeOneName]
                            ELSE [ASS].[sAssetTypeOneCode]+'-'+[ASS].[sAssetTypeOneName]
                        END AS [Code]
                 FROM
                      [dbo].[AssetTypeOne] AS [ASS]
                 WHERE [ASS].[nAssetMainTypeID] = @nAssetType;  
                 --SELECT   
                 --   REPLICATE('0' , 3 - LEN(ISNULL(MAX([AC].[nSequenceNo]) + 1 , 1))) + CAST(ISNULL(MAX([AC].[nSequenceNo]) + 1 , 1) AS VARCHAR) AS [SequenceNo]  
                 --FROM   
                 --     [dbo].[AssetCode] AS [AC]  
                 --     INNER JOIN [dbo].[AssetMaster] AS [AM] ON [AC].[nAssetID] = [AM].[nAssetID]  
                 --WHERE [AM].[nAssetMainTypeID] = @nAssetType;  
             END;
     END;

GO
 -- 2 -- 
 -- lgsp_INUP_MakeMaster -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_MakeMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_MakeMaster]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


CREATE PROCEDURE [lgsp_INUP_MakeMaster] 
-- Add the parameters for the stored procedure here
       @nMakeID   NUMERIC(18, 0),
       @sMakeName VARCHAR(100),
       @sMakeCode VARCHAR(10)
AS
     BEGIN
         -- SET NOCOUNT ON added to prevent extra result sets from
         -- interfering with SELECT statements.
         SET NOCOUNT ON;

         -- Insert statements for procedure here
         DECLARE
                @result INT = 0;  
         -- Insert statements for procedure here  
         BEGIN TRY
             BEGIN TRANSACTION;
             IF @nMakeID = 0
                 BEGIN
                     IF EXISTS
                     (
                      SELECT
                             1
                      FROM
                           [dbo].[MakeMaster] AS [mm]
                      WHERE [Mm].[sMakeCode] = @sMakeCode
                               )
                         BEGIN
                             SET @result = 2;
                         END;
                     IF @result = 0
                         BEGIN
                             INSERT INTO [dbo].[MakeMaster]
                             (
                                    [nMakeID]
                                  , [sMakeName]
                                  , [sMakeCode]
                                  , [dtCreatedDate]
                                  , [dtModifiedDate]
                             )
                             VALUES
                             (
                                    [dbo].[GetUniqueID_V2](), -- nMakeID - numeric
                                    @sMakeName, -- sMakeName - varchar
                                    @sMakeCode, -- sMakeCode - varchar
                                    getDate(), -- dtCreatedDate - datetime
                                    getDate() -- dtModifiedDate - datetime
                             );
                             SET @result = 1;
                         END;
                 END;
             ELSE
                 BEGIN
                     UPDATE [dbo].[MakeMaster]
                       SET
                           [dbo].[MakeMaster].[sMakeName] = @sMakeName, -- varchar
                           [dbo].[MakeMaster].[sMakeCode] = @sMakeCode, -- varchar
                           [dbo].[MakeMaster].[dtModifiedDate] = GETDATE() -- datetime
                     WHERE
                           [dbo].[MakeMaster].[nMakeID] = @nMakeID;
                     SET @result = 1;
                 END;
             COMMIT TRANSACTION;
         END TRY
         BEGIN CATCH  
  
/*   
  SELECT  
   ERROR_NUMBER() AS ErrorNumber,  
   ERROR_SEVERITY() AS ErrorSeverity,  
   ERROR_STATE() AS ErrorState,  
   ERROR_PROCEDURE() AS ErrorProcedure,  
   ERROR_LINE() AS ErrorLine,  
   ERROR_MESSAGE() AS ErrorMessage  
 */

             SET @result = -1;
         END CATCH;
         RETURN @result;
     END;


GO
 -- 3 -- 
 -- lgsp_INUP_Masters -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_Masters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_Masters]

GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  


CREATE PROCEDURE [dbo].[lgsp_INUP_Masters]   
-- Add the parameters for the stored procedure here  
      @nMasterID         NUMERIC(18, 0),
      @sMasterName       VARCHAR(100),
      @sMasterCode       VARCHAR(100)   = '',
      @nMasterMainID     NUMERIC(18, 0),
      @nMasterType       INT,
      @bIsAllowAccess    BIT,
      @bIsAllowSignatory BIT,
      @nReturnID         INT OUTPUT
AS
     BEGIN  
         -- SET NOCOUNT ON added to prevent extra result sets from  
         -- interfering with SELECT statements.  
         SET NOCOUNT ON;  
  
         -- Insert statements for procedure here  
         --CompanyType = 0,  
         --MaterialType = 1,  
         --Designation = 2,  
         --AssetType = 3,  
         --AssetType1 = 4,  
         --PartyType = 5,  
         --VehicleType = 6,  
         --ColourType = 7,  
         --DensityType = 8,  
         --AssetMasterType=9  

         IF @nMasterType = 0
             BEGIN
                 EXEC @nReturnID = [lgsp_INUP_CompanyType]
                      @nMasterID,
                      @sMasterName,
                      @sMasterCode;
             END;
         ELSE
             BEGIN
                 IF @nMasterType = 1
                     BEGIN
                         EXEC @nReturnID = [lgsp_INUP_MaterialType]
                              @nMasterID,
                              @sMasterName,
                              @sMasterCode;
                     END;
                 ELSE
                     BEGIN
                         IF @nMasterType = 2
                             BEGIN
                                 EXEC @nReturnID = [lgsp_INUP_Designation]
                                      @nMasterID,
                                      @sMasterName,
                                      @sMasterCode,
                                      @bIsAllowAccess,
                                      @bIsAllowSignatory;
                             END;
                         ELSE
                             BEGIN
                                 IF @nMasterType = 3
                                     BEGIN
                                         EXEC @nReturnID = [lgsp_INUP_AssetType]
                                              @nMasterID,
                                              @sMasterName,
                                              @sMasterCode,
                                              @nMasterMainID;
                                     END;
                                 ELSE
                                     BEGIN
                                         IF @nMasterType = 4
                                             BEGIN
                                                 EXEC @nReturnID = [lgsp_INUP_AssetTypeOne]
                                                      @nMasterID,
                                                      @sMasterName,
                                                      @nMasterMainID,
                                                      @sMasterCode;
                                             END;
                                         ELSE
                                             BEGIN
                                                 IF @nMasterType = 5
                                                     BEGIN
                                                         EXEC @nReturnID = [lgsp_INUP_PartyType]
                                                              @nMasterID,
                                                              @sMasterName,
                                                              @sMasterCode;
                                                     END;
                                         ELSE
                                                     BEGIN
                                                         IF @nMasterType = 6
                                                             BEGIN
                                                                 EXEC @nReturnID = [lgsp_INUP_VehicleType]
                                                                      @nMasterID,
                                                                      @sMasterName,
                                                                      @sMasterCode;
                                                             END;
                                                         ELSE
                                                             BEGIN
                                                                 IF @nMasterType = 7
                                                                     BEGIN
                                                                         EXEC @nReturnID = [lgsp_INUP_ColourType]
                                                                              @nMasterID,
                                                                              @sMasterName,
                                                                              @sMasterCode;
                                                                     END;
                                                                 ELSE
                                                                     BEGIN
                                                                         IF @nMasterType = 8
                                                                             BEGIN
                                                                                 EXEC @nReturnID = [lgsp_INUP_DensityType]
                                                                                      @nMasterID,
                                                                                      @sMasterName,
                                                                                      @sMasterCode;
                                                                             END;
                                                                         ELSE
                                                                             BEGIN
                                                                                 IF @nMasterType = 9
                                                                                     BEGIN
                                                                                         EXEC @nReturnID = [lgsp_INUP_AssetMainType]
                                                                                              @nMasterID,
                                                                                              @sMasterName,
                                                                                              @sMasterCode;
                                                                                     END;
                                                                                 ELSE
                                                                                     BEGIN
                                                                                         IF @nMasterType = 10
                                                                                             BEGIN
                                                                                                 EXEC @nReturnID = [lgsp_INUP_MakeMaster]
                                                                                                      @nMasterID,
                                                                                                      @sMasterName,
                                            @sMasterCode;
                                                                                             END;
                                                                                     END;
                                                                             END;
                                                                     END;
                                                             END;
                                                     END;
                                             END;
                                     END;
                             END;
                     END;
             END;
         SELECT
                @nReturnID;
     END;  


GO
 -- 4 -- 
 -- lgsp_Get_AllMastersData -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_Get_AllMastersData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_Get_AllMastersData]

GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  


CREATE PROCEDURE [dbo].[lgsp_Get_AllMastersData]  
-- Add the parameters for the stored procedure here  
       @nMasterType NUMERIC(18, 0)
AS
     BEGIN  
         -- SET NOCOUNT ON added to prevent extra result sets from  
         -- interfering with SELECT statements.  
         SET NOCOUNT ON;  
         -- Insert statements for procedure here  
         --CompanyType = 0,  
         --MaterialType = 1,  
         --Designation = 2,  
         --AssetType = 3,  
         --AssetType1 = 4,  
         --PartyType = 5,  
         --VehicleType = 6,  
         --ColourType = 7,  
         --DensityType = 8,  
         --AssetMasterType=9  
         IF @nMasterType = 0
             BEGIN
                 SELECT
                        ROW_NUMBER() OVER(ORDER BY [sCompanyTypeName]) AS [RowNo]
                      , [COM].[nCompanyTypeID] AS [TypeID]
                      , 0 AS [nAssetMainTypeID]
                      , [COM].[sCompanyTypeName] AS [TypeName]
                      , '' AS [AssetType]
                      , 0 AS [AllowAccess]
                      , 0 AS [AllowSignatory]
                      , 0 AS [SystemDefined]
                      , [COM].[sCompanyTypeCode] AS [TypeCode]
                      , [COM].[dtCreatedDate] AS [CreatedOn]
                      , [COM].[dtModifiedDate] AS [ModifiedOn]
                      , 0 AS [IsUsed]
                 FROM
                      [dbo].[CompanyType] AS [COM];
             END;
         ELSE
             BEGIN
                 IF @nMasterType = 1
                     BEGIN
                         SELECT
                                ROW_NUMBER() OVER(ORDER BY [sMaterialTypeName]) AS [RowNo]
                              , [MAT].[nMaterialTypeID] AS [TypeID]
                              , 0 AS [nAssetMainTypeID]
                              , [MAT].[sMaterialTypeName] AS [TypeName]
                              , '' AS [AssetType]
                              , 0 AS [AllowAccess]
                              , 0 AS [AllowSignatory]
                              , 0 AS [SystemDefined]
                              , [MAT].[sMaterialTypeCode] AS [TypeCode]
                              , [MAT].[dtCreatedDate] AS [CreatedOn]
                              , [MAT].[dtModifiedDate] AS [ModifiedOn]
                              , 0 AS [IsUsed]
                         FROM
                              [dbo].[MaterialType] AS [MAT];
                     END;
                 ELSE
                     BEGIN
                         IF @nMasterType = 2
                             BEGIN
                                 SELECT
                                        ROW_NUMBER() OVER(ORDER BY [sDesignationName]) AS [RowNo]
                                      , [DES].[nDesignationID] AS [TypeID]
                                      , 0 AS [nAssetMainTypeID]
                                      , [DES].[sDesignationName] AS [TypeName]
                                      , '' AS [AssetType]
                                      , ISNULL([DES].[bIsAllowAccess], 0) AS [AllowAccess]
                                      , ISNULL([DES].[bIsAllowSignatory], 0) AS [AllowSignatory]
                                      , 0 AS [SystemDefined]
                                      , [DES].[sDesignationCode] AS [TypeCode]
                                      , [DES].[dtCreatedDate] AS [CreatedOn]
                                      , [DES].[dtModifiedDate] AS [ModifiedOn]
                                      , 0 AS [IsUsed]
                                 FROM
                                      [dbo].[Designation] AS [DES];
                             END;
                         ELSE
                             BEGIN
                                 IF @nMasterType = 3
                                     BEGIN
                                         SELECT
                                                ROW_NUMBER() OVER(ORDER BY [sAssetTypeName]) AS [RowNo]
                                              , [ASS].[nAssetTypeID] AS [TypeID]
                                              , [AMT].[nAssetMainTypeID] AS [nAssetMainTypeID]
                                              , [ASS].[sAssetTypeName] AS [TypeName]
                                              , [AMT].[sAssetType] AS [AssetType]
                                              , 0 AS [AllowAccess]
                                              , 0 AS [AllowSignatory]
                                              , 0 AS [SystemDefined]
                                              , [ASS].[sAssetTypeCode] AS [TypeCode]
                                              , [ASS].[dtCreatedDate] AS [CreatedOn]
                                              , [ASS].[dtModifiedDate] AS [ModifiedOn]
                                              , 0 AS [IsUsed]
                                         FROM
                                              [dbo].[AssetType] AS [ASS]
                                              INNER JOIN [dbo].[AssetMainType] AS [AMT] ON [ASS].[nAssetMainTypeID] = [AMT].[nAssetMainTypeID];
                                     END;
                                 ELSE
                                     BEGIN
                                         IF @nMasterType = 4
                                             BEGIN
                                                 SELECT
                                                        ROW_NUMBER() OVER(ORDER BY [sAssetTypeOneName]) AS [RowNo]
                                                      , [ASS].[nAssetTypeOneID] AS [TypeID]
                                                      , [AMT].[nAssetMainTypeID] AS [nAssetMainTypeID]
                                                      , [ASS].[sAssetTypeOneName] AS [TypeName]
                                                      , [AMT].[sAssetType] AS [AssetType]
                                                      , 0 AS [AllowAccess]
                                                      , 0 AS [AllowSignatory]
                                                      , 0 AS [SystemDefined]
                                                      , [ASS].[sAssetTypeOneCode] AS [TypeCode]
                                                      , [ASS].[dtCreatedDate] AS [CreatedOn]
                                                      , [ASS].[dtModifiedDate] AS [ModifiedOn]
                                                      , 0 AS [IsUsed]
                                                 FROM
                                                      [dbo].[AssetTypeOne] AS [ASS]
                                                      INNER JOIN [dbo].[AssetMainType] AS [AMT] ON [ASS].[nAssetMainTypeID] = [AMT].[nAssetMainTypeID];
                                             END;
                                         ELSE
                                             BEGIN
                                                 IF @nMasterType = 5
                                                     BEGIN
                                                         SELECT
                                                                ROW_NUMBER() OVER(ORDER BY [sPartyTypeName]) AS [RowNo]
                                                              , [PAR].[nPartyTypeID] AS [TypeID]
                                                              , 0 AS [nAssetMainTypeID]
                                                              , [PAR].[sPartyTypeName] AS [TypeName]
                                                              , '' AS [AssetType]
                 , 0 AS [AllowAccess]
                                                              , 0 AS [AllowSignatory]
                                                              , 0 AS [SystemDefined]
                                                              , [PAR].[sPartyTypeCode] AS [TypeCode]
                                                              , [PAR].[dtCreatedDate] AS [CreatedOn]
                                                              , [PAR].[dtModifiedDate] AS [ModifiedOn]
                                                              , 0 AS [IsUsed]
                                                         FROM
                                                              [dbo].[PartyType] AS [PAR];
                                                     END;
                                                 ELSE
                                                     BEGIN
                                                         IF @nMasterType = 6
                                                             BEGIN
                                                                 SELECT
                                                                        ROW_NUMBER() OVER(ORDER BY [sVehicleTypeName]) AS [RowNo]
                                                                      , [VEH].[nVechicleTypeID] AS [TypeID]
                                                                      , 0 AS [nAssetMainTypeID]
                                                                      , [VEH].[sVehicleTypeName] AS [TypeName]
                                                                      , '' AS [AssetType]
                                                                      , 0 AS [AllowAccess]
                                                                      , 0 AS [AllowSignatory]
                                                                      , 0 AS [SystemDefined]
                                                                      , [VEH].[sVehicleTypeCode] AS [TypeCode]
                                                                      , [VEH].[dtCreatedDate] AS [CreatedOn]
                                                                      , [VEH].[dtModifiedDate] AS [ModifiedOn]
                                                                      , 0 AS [IsUsed]
                                                                 FROM
                                                                      [dbo].[VehicleType] AS [VEH];
                                                             END;
                                                         ELSE
                                                             BEGIN
                                                                 IF @nMasterType = 7
                                                                     BEGIN
                                                                         SELECT
                                                                                ROW_NUMBER() OVER(ORDER BY [sColourTypeName]) AS [RowNo]
                                                                              , [COL].[nColourTypeID] AS [TypeID]
                                                                              , 0 AS [nAssetMainTypeID]
                                                                              , [COL].[sColourTypeName] AS [TypeName]
                                                                              , '' AS [AssetType]
                                                                              , 0 AS [AllowAccess]
                                                                              , 0 AS [AllowSignatory]
                                                                              , 0 AS [SystemDefined]
                                                                              , [COL].[sColourTypeCode] AS [TypeCode]
                                                                              , [COL].[dtCreatedDate] AS [CreatedOn]
                                                                              , [COL].[dtModifiedDate] AS [ModifiedOn]
                                                                              , 0 AS [IsUsed]
                                                                         FROM
                                                                              [dbo].[ColourType] AS [COL];
                                                                     END;
                                                                 ELSE
                                                                     BEGIN
                                                                         IF @nMasterType = 8
                                                                             BEGIN
                                                                                 SELECT
                                                                                        ROW_NUMBER() OVER(ORDER BY [sDensityTypeName]) AS [RowNo]
                                                                                      , [DEN].[nDensityTypeID] AS [TypeID]
                                                                                      , 0 AS [nAssetMainTypeID]
                                                                                      , [DEN].[sDensityTypeName] AS [TypeName]
                                                                                      , '' AS [AssetType]
                                                                                      , 0 AS [AllowAccess]
                                                                                      , 0 AS [AllowSignatory]
                                                                                      , 0 AS [SystemDefined]
                                                                                      , [DEN].[sDensityTypeCode] AS [TypeCode]
                                                                                      , [DEN].[dtCreatedDate] AS [CreatedOn]
                                                                                      , [DEN].[dtModifiedDate] AS [ModifiedOn]
                                                                                      , 0 AS [IsUsed]
                                                                                 FROM
                                                                                      [dbo].[DensityType] AS [DEN];
                                                                             END;
                                                                         ELSE
                                                                             BEGIN
                                                                                 IF @nMasterType = 9
                                                                                     BEGIN
                                                                                         SELECT
                                                                                                ROW_NUMBER() OVER(ORDER BY [sAssetType]) AS [RowNo]
                                                                                              , [ASS].[nAssetMainTypeID] AS [TypeID]
                                                                                              , 0 AS [nAssetMainTypeID]
                                                                                              , [ASS].[sAssetType] AS [TypeName]
                                                                                              , '' AS [AssetType]
                                                                                              , 0 AS [AllowAccess]
                                           , 0 AS [AllowSignatory]
                                                                                              , [ASS].[bIsSystemDefined] AS [SystemDefined]
                                                                                              , [ASS].[sAssetCode] AS [TypeCode]
                                                                                              , [ASS].[dtCreatedDate] AS [CreatedOn]
                                                                                              , [ASS].[dtModifiedDate] AS [ModifiedOn]
                                                                                              , CASE
                                                                                                    WHEN
                                                                                         (
                                                                                          SELECT
                                                                                                 COUNT(*)
                                                                                          FROM
                                                                                               [dbo].[AssetType] AS [ASS2]
                                                                                          WHERE [ASS2].[nAssetMainTypeID] = [ASS].[nAssetMainTypeID]
                                                                                                         ) > 0
                                                                                                    THEN 1
                                                                                                    WHEN
                                                                                         (
                                                                                          SELECT
                                                                                                 COUNT(*)
                                                                                          FROM
                                                                                               [dbo].[AssetTypeOne] AS [ASS2]
                                                                                          WHERE [ASS2].[nAssetMainTypeID] = [ASS].[nAssetMainTypeID]
                                                                                                         ) > 0
                                                                                                    THEN 1
                                                                                                    ELSE 0
                                                                                                END AS [IsUsed]
                                                                                         FROM
                                                                                              [dbo].[AssetMainType] AS [ASS];
                                                                                     END;
                                                                                 ELSE
                                                                                     BEGIN
                                                                                         IF @nMasterType = 10
                                                                                             BEGIN
                                                                                                 SELECT
                                                                                                        ROW_NUMBER() OVER(ORDER BY [sMakeName]) AS [RowNo]
                                                                                                      , [mm].[nMakeID] AS [TypeID]
                                                                                                      , 0 AS [nAssetMainTypeID]
                                                                                                      , [mm].[sMakeName] AS [TypeName]
                                                                                                      , '' AS [AssetType]
                                                                                                      , 0 AS [AllowAccess]
                                                                                                      , 0 AS [AllowSignatory]
                                                                                                      , 0 AS [SystemDefined]
                                                                                                      , [mm].[sMakeCode] AS [TypeCode]
                                                                                                      , [mm].[dtCreatedDate] AS [CreatedOn]
                                                                                                      , [mm].[dtModifiedDate] AS [ModifiedOn]
                                                                                                      , 0 AS [IsUsed]
                                                                                                 FROM
                                                                                                      [dbo].[MakeMaster] AS [mm];
                                                                                             END;
                                                                                     END;
                                                                             END;
                                                                     END;
                                                             END;
                                                     END;
                                             END;
                                     END;
                             END;
                     END;
             END;
     END;  

