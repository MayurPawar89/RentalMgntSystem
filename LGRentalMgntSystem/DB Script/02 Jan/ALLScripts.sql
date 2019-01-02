
GO
 -- 1 -- 
 -- lgsp_Get_AllMastersData -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_Get_AllMastersData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_Get_AllMastersData]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[lgsp_Get_AllMastersData]
-- Add the parameters for the stored procedure here
     @nMasterType NUMERIC(18 , 0)
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
                   ROW_NUMBER() OVER(
                   ORDER BY 
                   [sCompanyTypeName]) [RowNo]
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
                           ROW_NUMBER() OVER(
                           ORDER BY 
                           [sMaterialTypeName]) [RowNo]
                         , [MAT].[nMaterialTypeID] AS [TypeID]
                         , 0 AS [nAssetMainTypeID]
                         , [MAT].[sMaterialTypeName] AS [TypeName]
                         , '' AS [AssetType]
                         , 0 AS [AllowAccess]
                         , 0 AS [AllowSignatory]
                         , 0 AS [SystemDefined]
                         , [MAT].[sMaterialTypeCode] AS [TypeCode]
                         , [MAT].[dtCreatedDate] AS [CreatedOn]
                         , [MAT].[dtModifiedDate] [ModifiedOn]
                         , 0 AS [IsUsed]
                        FROM 
                             [dbo].[MaterialType] AS [MAT];
                END;
                ELSE
                    BEGIN
                        IF @nMasterType = 2
                            BEGIN
                                SELECT 
                                   ROW_NUMBER() OVER(
                                   ORDER BY 
                                   [sDesignationName]) [RowNo]
                                 , [DES].[nDesignationID] AS [TypeID]
                                 , 0 AS [nAssetMainTypeID]
                                 , [DES].[sDesignationName] AS [TypeName]
                                 , '' AS [AssetType]
                                 , ISNULL([DES].[bIsAllowAccess] , 0) AS [AllowAccess]
                                 , ISNULL([DES].[bIsAllowSignatory] , 0) AS [AllowSignatory]
                                 , 0 AS [SystemDefined]
                                 , [DES].[sDesignationCode] AS [TypeCode]
                                 , [DES].[dtCreatedDate] AS [CreatedOn]
                                 , [DES].[dtModifiedDate] [ModifiedOn]
                                 , 0 AS [IsUsed]
                                FROM 
                                     [dbo].[Designation] AS [DES];
                        END;
                        ELSE
                            BEGIN
                                IF @nMasterType = 3
          BEGIN
                                        SELECT 
                                           ROW_NUMBER() OVER(
                                           ORDER BY 
                                           [sAssetTypeName]) [RowNo]
                                         , [ASS].[nAssetTypeID] AS [TypeID]
                                         , [AMT].[nAssetMainTypeID] AS [nAssetMainTypeID]
                                         , [ASS].[sAssetTypeName] AS [TypeName]
                                         , [AMT].[sAssetType] AS [AssetType]
                                         , 0 AS [AllowAccess]
                                         , 0 AS [AllowSignatory]
                                         , 0 AS [SystemDefined]
                                         , [ASS].[sAssetTypeCode] AS [TypeCode]
                                         , [ASS].[dtCreatedDate] AS [CreatedOn]
                                         , [ASS].[dtModifiedDate] [ModifiedOn]
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
                                                   ROW_NUMBER() OVER(
                                                   ORDER BY 
                                                   [sAssetTypeOneName]) [RowNo]
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
                                                           ROW_NUMBER() OVER(
                                                           ORDER BY 
                                                           [sPartyTypeName]) [RowNo]
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
                                                                   ROW_NUMBER() OVER(
                                                                   ORDER BY 
                                                                   [sVehicleTypeName]) [RowNo]
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
                                                                           ROW_NUMBER() OVER(
                                                                           ORDER BY 
                                                                           [sColourTypeName]) [RowNo]
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
                                                                                   ROW_NUMBER() OVER(
                                                                                   ORDER BY 
                                                                                   [sDensityTypeName]) [RowNo]
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
                                                                                           ROW_NUMBER() OVER(
                                                                                           ORDER BY 
                                                                                           [sAssetType]) [RowNo]
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

GO
 -- 2 -- 
 -- lgsp_INUP_Masters -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_Masters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_Masters]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_Masters] 
-- Add the parameters for the stored procedure here
     @nMasterID         NUMERIC(18 , 0)
   , @sMasterName       VARCHAR(100)
   , @sMasterCode       VARCHAR(100)    = ''
   , @nMasterMainID     NUMERIC(18 , 0)
   , @nMasterType       INT
   , @bIsAllowAccess    BIT
   , @bIsAllowSignatory BIT
   , @nReturnID         INT OUTPUT
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
                     @nMasterID , 
                     @sMasterName , 
                     @sMasterCode;
        END;
        ELSE
            BEGIN
                IF @nMasterType = 1
                    BEGIN
                        EXEC @nReturnID = [lgsp_INUP_MaterialType] 
                             @nMasterID , 
                             @sMasterName , 
                             @sMasterCode;
                END;
                ELSE
                    BEGIN
                        IF @nMasterType = 2
                            BEGIN
                                EXEC @nReturnID = [lgsp_INUP_Designation] 
                                     @nMasterID , 
                                     @sMasterName , 
                                     @sMasterCode , 
                                     @bIsAllowAccess , 
                                     @bIsAllowSignatory;
                        END;
                        ELSE
                            BEGIN
                                IF @nMasterType = 3
                                    BEGIN
                                        EXEC @nReturnID = [lgsp_INUP_AssetType] 
                                             @nMasterID , 
                                             @sMasterName , 
                                             @sMasterCode , 
                                             @nMasterMainID;
                                END;
                                ELSE
                                    BEGIN
                                        IF @nMasterType = 4
                                            BEGIN
                                                EXEC @nReturnID = [lgsp_INUP_AssetTypeOne] 
                                                     @nMasterID , 
                                                     @sMasterName , 
                                                     @nMasterMainID,
													 @sMasterCode;
                                        END;
                                        ELSE
                                            BEGIN
                                                IF @nMasterType = 5
                                                    BEGIN
                                                        EXEC @nReturnID = [lgsp_INUP_PartyType] 
                                                             @nMasterID , 
                                                             @sMasterName , 
                                                             @sMasterCode;
                                                END;
                                                ELSE
                                                    BEGIN
 IF @nMasterType = 6
                                                            BEGIN
                                                                EXEC @nReturnID = [lgsp_INUP_VehicleType] 
                                                                     @nMasterID , 
                                                                     @sMasterName,
																	 @sMasterCode;
                                                        END;
                                                        ELSE
                                                            BEGIN
                                                                IF @nMasterType = 7
                                                                    BEGIN
                                                                        EXEC @nReturnID = [lgsp_INUP_ColourType] 
                                                                             @nMasterID , 
                                                                             @sMasterName , 
                                                                             @sMasterCode;
                                                                END;
                                                                ELSE
                                                                    BEGIN
                                                                        IF @nMasterType = 8
                                                                            BEGIN
                                                                                EXEC @nReturnID = [lgsp_INUP_DensityType] 
                                                                                     @nMasterID , 
                                                                                     @sMasterName , 
                                                                                     @sMasterCode;
                                                                        END;
                                                                        ELSE
                                                                            BEGIN
                                                                                IF @nMasterType = 9
                                                                                    BEGIN
                                                                                        EXEC @nReturnID = [lgsp_INUP_AssetMainType] 
                                                                                             @nMasterID , 
                                                                                             @sMasterName , 
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
        SELECT 
           @nReturnID;
    END;

GO
 -- 3 -- 
 -- lgsp_INUP_ColourType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_ColourType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_ColourType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_ColourType] 
-- Add the parameters for the stored procedure here
     @nColourTypeID   NUMERIC(18 , 0)
   , @sColourTypeName VARCHAR(100)
   , @sColourTypeCode VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nColourTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[ColourType] AS [COL]
                        WHERE [COL].[sColourTypeCode] = @sColourTypeCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[ColourType]
                            (
                               [nColourTypeID]
                             , [sColourTypeName]
                             , [sColourTypeCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nColourTypeID - numeric
                               , @sColourTypeName -- sColourTypeName - varchar
                               , @sColourTypeCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[ColourType]
                      SET 
                          [dbo].[ColourType].[sColourTypeName] = @sColourTypeName , -- varchar
                          [dbo].[ColourType].[sColourTypeCode] = @sColourTypeCode , 
                          [dbo].[ColourType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[ColourType].[nColourTypeID] = @nColourTypeID;
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
 -- 4 -- 
 -- lgsp_INUP_DensityType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_DensityType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_DensityType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_DensityType] 
-- Add the parameters for the stored procedure here
     @nDensityTypeID   NUMERIC(18 , 0)
   , @sDensityTypeName VARCHAR(100)
   , @sDensityTypeCode VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nDensityTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[DensityType] AS [DEN]
                        WHERE [DEN].[sDensityTypeCode] = @sDensityTypeCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[DensityType]
                            (
                               [nDensityTypeID]
                             , [sDensityTypeName]
                             , [sDensityTypeCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nDensityTypeID - numeric
                               , @sDensityTypeName -- sDensityTypeName - varchar
                               , @sDensityTypeCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[ColourType]
                      SET 
                          [dbo].[ColourType].[sColourTypeName] = @sDensityTypeName , -- varchar
                          [dbo].[ColourType].[sColourTypeCode] = @sDensityTypeCode , 
                          [dbo].[ColourType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[ColourType].[nColourTypeID] = @nDensityTypeID;
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
 -- 5 -- 
 -- lgsp_INUP_AssetMainType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_AssetMainType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_AssetMainType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_AssetMainType]
-- Add the parameters for the stored procedure here
     @nAssetMainTypeID NUMERIC(18 , 0)
   , @sAssetName       VARCHAR(100)
   , @sAssetCode       VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nAssetMainTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[AssetMainType] AS [ASS]
                        WHERE [ASS].[sAssetCode] = @sAssetCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[AssetMainType]
                            (
                               [nAssetMainTypeID]
                             , [sAssetType]
                             , [sAssetCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nAssetMainTypeID - numeric
                               , @sAssetName -- sAssetType - varchar
                               , @sAssetCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[AssetMainType]
                      SET 
                          [dbo].[AssetMainType].[sAssetType] = @sAssetName , -- varchar
                          [dbo].[AssetMainType].[sAssetCode] = @sAssetCode , 
                          [dbo].[AssetMainType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[AssetMainType].[nAssetMainTypeID] = @nAssetMainTypeID;
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
 -- 6 -- 
 -- lgsp_INUP_AssetTypeOne -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_AssetTypeOne]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_AssetTypeOne]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_AssetTypeOne] 
-- Add the parameters for the stored procedure here
     @nAssetTypeOneID   NUMERIC(18 , 0)
   , @sAssetTypeOneName VARCHAR(100)
   , @nAssetMainTypeID  NUMERIC(18 , 0)
   , @sAssetTypeOneCode VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nAssetTypeOneID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[AssetTypeOne] AS [ASS]
                        WHERE [ASS].[sAssetTypeOneCode] = @sAssetTypeOneCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[AssetTypeOne]
                            (
                               [nAssetTypeOneID]
                             , [sAssetTypeOneName]
                             , [nAssetMainTypeID]
                             , [sAssetTypeOneCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nAssetTypeOneID - numeric
                               , @sAssetTypeOneName -- sAssetTypeOneName - varchar
                               , @nAssetMainTypeID -- nAssetMainTypeID - numeric
                               , @sAssetTypeOneCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[AssetTypeOne]
                      SET 
                          [dbo].[AssetTypeOne].[sAssetTypeOneName] = @sAssetTypeOneName , -- varchar
                          [dbo].[AssetTypeOne].[nAssetMainTypeID] = @nAssetMainTypeID , -- numeric
                          [dbo].[AssetTypeOne].[sAssetTypeOneCode] = @sAssetTypeOneCode , 
                          [dbo].[AssetTypeOne].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[AssetTypeOne].[nAssetTypeOneID] = @nAssetTypeOneID;
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
 -- 7 -- 
 -- lgsp_INUP_PartyType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_PartyType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_PartyType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_PartyType] 
-- Add the parameters for the stored procedure here
     @nPartyTypeID   NUMERIC(18 , 0)
   , @sPartyTypeName VARCHAR(100)
   , @sPartyTypeCode VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nPartyTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[PartyType] AS [PAR]
                        WHERE [PAR].[sPartyTypeCode] = @sPartyTypeCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[PartyType]
                            (
                               [nPartyTypeID]
                             , [sPartyTypeName]
                             , [sPartyTypeCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nPartyTypeID - numeric
                               , @sPartyTypeName -- sPartyTypeName - varchar
                               , @sPartyTypeCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[PartyType]
                      SET 
                          [dbo].[PartyType].[sPartyTypeName] = @sPartyTypeName , -- varchar
                          [dbo].[PartyType].[sPartyTypeCode] = @sPartyTypeCode , 
                          [dbo].[PartyType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[PartyType].[nPartyTypeID] = @nPartyTypeID;
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
 -- 8 -- 
 -- lgsp_INUP_VehicleType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_VehicleType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_VehicleType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_VehicleType] 
-- Add the parameters for the stored procedure here
     @nVehicleTypeID   NUMERIC(18 , 0)
   , @sVehicleTypeName VARCHAR(100)
   , @sVehicleTypeCode VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nVehicleTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[VehicleType] AS [VEH]
                        WHERE [veh].[sVehicleTypeCode] = @sVehicleTypeCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[VehicleType]
                            (
                               [nVechicleTypeID]
                             , [sVehicleTypeName]
                             , [sVehicleTypeCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nVechicleTypeID - numeric
                               , @sVehicleTypeName -- sVehicleTypeName - varchar
                               , @sVehicleTypeCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[VehicleType]
                      SET 
                          [dbo].[VehicleType].[sVehicleTypeName] = @sVehicleTypeName , -- varchar
                          [dbo].[VehicleType].[sVehicleTypeCode] = @sVehicleTypeCode , 
                          [dbo].[VehicleType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[VehicleType].[nVechicleTypeID] = @nVehicleTypeID;
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
 -- 9 -- 
 -- lgsp_INUP_AssetType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_AssetType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_AssetType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_AssetType] 
-- Add the parameters for the stored procedure here
     @nAssetTypeID     NUMERIC(18 , 0)
   , @sAssetTypeName   VARCHAR(100)
   , @sAssetTypeCode   VARCHAR(10)
   , @nAssetMainTypeID NUMERIC(18 , 0)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nAssetTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[AssetType] AS [ASS]
                        WHERE [ASS].[sAssetTypeCode] = @sAssetTypeCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[AssetType]
                            (
                               [nAssetTypeID]
                             , [sAssetTypeName]
                             , [nAssetMainTypeID]
                             , [sAssetTypeCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nAssetTypeID - numeric
                               , @sAssetTypeName -- sAssetTypeName - varchar
                               , @nAssetMainTypeID -- nAssetMainTypeID - numeric
                               , @sAssetTypeCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[AssetType]
                      SET 
                          [dbo].[AssetType].[sAssetTypeName] = @sAssetTypeName , -- varchar
                          [dbo].[AssetType].[nAssetMainTypeID] = @nAssetMainTypeID , -- numeric
                          [dbo].[AssetType].[sAssetTypeCode] = @sAssetTypeCode , 
                          [dbo].[AssetType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[AssetType].[nAssetTypeID] = @nAssetTypeID;
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
 -- 10 -- 
 -- lgsp_INUP_Designation -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_Designation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_Designation]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_Designation] 
-- Add the parameters for the stored procedure here
     @nDesignationID    NUMERIC(18 , 0)
   , @sDesigantionName  VARCHAR(100)
   , @sDesignationCode  VARCHAR(10)
   , @bIsAllowAccess    BIT
   , @bIsAllowSignatory BIT
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nDesignationID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [Designation] [DES]
                        WHERE [DES].[sDesignationCode] = @sDesignationCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[Designation]
                            (
                               [nDesignationID]
                             , [sDesignationName]
                             , [bIsAllowAccess]
                             , [bIsAllowSignatory]
                             , [sDesignationCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nDesigmationID - numeric
                               , @sDesigantionName -- sDesignationName - varchar
                               , @bIsAllowAccess
                               , @bIsAllowSignatory
                               , @sDesignationCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[Designation]
                      SET 
                          [dbo].[Designation].[sDesignationName] = @sDesigantionName , -- varchar
                          [dbo].[Designation].[bIsAllowAccess] = @bIsAllowAccess , 
                          [dbo].[Designation].[bIsAllowSignatory] = @bIsAllowSignatory , 
                          [dbo].[Designation].[sDesignationCode] = @sDesignationCode , 
                          [dbo].[Designation].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[Designation].[nDesignationID] = @nDesignationID;
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
 -- 11 -- 
 -- lgsp_INUP_MaterialType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_MaterialType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_MaterialType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_MaterialType] 
-- Add the parameters for the stored procedure here
     @nMaterialTypeID   NUMERIC(18 , 0)
   , @sMaterialTypeName VARCHAR(100)
   , @sMaterialTypeCode VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nMaterialTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[MaterialType] AS [MAT]
                        WHERE [MAT].[sMaterialTypeCode] = @sMaterialTypeCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[MaterialType]
                            (
                               [nMaterialTypeID]
                             , [sMaterialTypeName]
                             , [sMaterialTypeCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nCompanyTypeID - numeric
                               , @sMaterialTypeName -- sCompanyTypeName - varchar
                               , @sMaterialTypeCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[MaterialType]
                      SET 
                          [dbo].[MaterialType].[sMaterialTypeName] = @sMaterialTypeName , -- varchar
                          [dbo].[MaterialType].[sMaterialTypeCode] = @sMaterialTypeCode , 
                          [dbo].[MaterialType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[MaterialType].[nMaterialTypeID] = @nMaterialTypeID;
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
 -- 12 -- 
 -- lgsp_INUP_CompanyType -- 

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lgsp_INUP_CompanyType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[lgsp_INUP_CompanyType]

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[lgsp_INUP_CompanyType] 
-- Add the parameters for the stored procedure here
     @nCompanyTypeID   NUMERIC(18 , 0)
   , @sCompanyTypeName VARCHAR(100)
   , @sCompanyTypeCode VARCHAR(10)
AS
    BEGIN
        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE 
               @result INT = 0;
        -- Insert statements for procedure here
        BEGIN TRY
            BEGIN TRANSACTION;
            IF @nCompanyTypeID = 0
                BEGIN
                    IF EXISTS
                    (
                        SELECT 
                           1
                        FROM 
                             [dbo].[CompanyType] AS [COM]
                        WHERE [com].[sCompanyTypeCode] = @sCompanyTypeCode
                    )
                        BEGIN
                            SET @result = 2;
                    END;
                    IF @result = 0
                        BEGIN
                            INSERT INTO [dbo].[CompanyType]
                            (
                               [nCompanyTypeID]
                             , [sCompanyTypeName]
                             , [sCompanyTypeCode]
                             , [dtCreatedDate]
                             , [dtModifiedDate]
                            )
                            VALUES
                            (
                                 [dbo].[GetUniqueID_V2]() -- nCompanyTypeID - numeric
                               , @sCompanyTypeName -- sCompanyTypeName - varchar
                               , @sCompanyTypeCode
                               , GETDATE() -- dtCreatedDate - datetime
                               , GETDATE() -- dtModifiedDate - datetime
                            );
                            SET @result = 1;
                    END;
            END;
            ELSE
                BEGIN
                    UPDATE [dbo].[CompanyType]
                      SET 
                          [dbo].[CompanyType].[sCompanyTypeName] = @sCompanyTypeName , -- varchar
                          [dbo].[CompanyType].[sCompanyTypeCode] = @sCompanyTypeCode , 
                          [dbo].[CompanyType].[dtModifiedDate] = GETDATE() -- datetime
                    WHERE 
                       [dbo].[CompanyType].[nCompanyTypeID] = @nCompanyTypeID;
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
