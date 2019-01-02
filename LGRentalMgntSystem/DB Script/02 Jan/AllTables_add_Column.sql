
GO
 -- 1 -- 
 -- VehicleType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='VehicleType' AND COLUMN_NAME='nVechicleTypeID' ) BEGIN 		ALTER TABLE VehicleType		ADD nVechicleTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='VehicleType' AND COLUMN_NAME='sVehicleTypeName' ) BEGIN 		ALTER TABLE VehicleType		ADD sVehicleTypeName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='VehicleType' AND COLUMN_NAME='sVehicleTypeCode' ) BEGIN 		ALTER TABLE VehicleType		ADD sVehicleTypeCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='VehicleType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE VehicleType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='VehicleType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE VehicleType		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 2 -- 
 -- PartyType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='PartyType' AND COLUMN_NAME='nPartyTypeID' ) BEGIN 		ALTER TABLE PartyType		ADD nPartyTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='PartyType' AND COLUMN_NAME='sPartyTypeName' ) BEGIN 		ALTER TABLE PartyType		ADD sPartyTypeName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='PartyType' AND COLUMN_NAME='sPartyTypeCode' ) BEGIN 		ALTER TABLE PartyType		ADD sPartyTypeCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='PartyType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE PartyType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='PartyType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE PartyType		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 3 -- 
 -- MaterialType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='MaterialType' AND COLUMN_NAME='nMaterialTypeID' ) BEGIN 		ALTER TABLE MaterialType		ADD nMaterialTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='MaterialType' AND COLUMN_NAME='sMaterialTypeName' ) BEGIN 		ALTER TABLE MaterialType		ADD sMaterialTypeName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='MaterialType' AND COLUMN_NAME='sMaterialTypeCode' ) BEGIN 		ALTER TABLE MaterialType		ADD sMaterialTypeCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='MaterialType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE MaterialType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='MaterialType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE MaterialType		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 4 -- 
 -- Designation -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='Designation' AND COLUMN_NAME='nDesignationID' ) BEGIN 		ALTER TABLE Designation		ADD nDesignationID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='Designation' AND COLUMN_NAME='sDesignationName' ) BEGIN 		ALTER TABLE Designation		ADD sDesignationName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='Designation' AND COLUMN_NAME='bIsAllowAccess' ) BEGIN 		ALTER TABLE Designation		ADD bIsAllowAccess bit  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='Designation' AND COLUMN_NAME='bIsAllowSignatory' ) BEGIN 		ALTER TABLE Designation		ADD bIsAllowSignatory bit  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='Designation' AND COLUMN_NAME='sDesignationCode' ) BEGIN 		ALTER TABLE Designation		ADD sDesignationCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='Designation' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE Designation		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='Designation' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE Designation		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 5 -- 
 -- CompanyType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='CompanyType' AND COLUMN_NAME='nCompanyTypeID' ) BEGIN 		ALTER TABLE CompanyType		ADD nCompanyTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='CompanyType' AND COLUMN_NAME='sCompanyTypeName' ) BEGIN 		ALTER TABLE CompanyType		ADD sCompanyTypeName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='CompanyType' AND COLUMN_NAME='sCompanyTypeCode' ) BEGIN 		ALTER TABLE CompanyType		ADD sCompanyTypeCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='CompanyType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE CompanyType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='CompanyType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE CompanyType		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 6 -- 
 -- AssetMainType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetMainType' AND COLUMN_NAME='nAssetMainTypeID' ) BEGIN 		ALTER TABLE AssetMainType		ADD nAssetMainTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetMainType' AND COLUMN_NAME='sAssetType' ) BEGIN 		ALTER TABLE AssetMainType		ADD sAssetType varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetMainType' AND COLUMN_NAME='sAssetCode' ) BEGIN 		ALTER TABLE AssetMainType		ADD sAssetCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetMainType' AND COLUMN_NAME='bIsSystemDefined' ) BEGIN 		ALTER TABLE AssetMainType		ADD bIsSystemDefined bit  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetMainType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE AssetMainType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetMainType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE AssetMainType		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 7 -- 
 -- AssetType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetType' AND COLUMN_NAME='nAssetTypeID' ) BEGIN 		ALTER TABLE AssetType		ADD nAssetTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetType' AND COLUMN_NAME='sAssetTypeName' ) BEGIN 		ALTER TABLE AssetType		ADD sAssetTypeName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetType' AND COLUMN_NAME='nAssetMainTypeID' ) BEGIN 		ALTER TABLE AssetType		ADD nAssetMainTypeID numeric(18,0)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetType' AND COLUMN_NAME='sAssetTypeCode' ) BEGIN 		ALTER TABLE AssetType		ADD sAssetTypeCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE AssetType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE AssetType		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 8 -- 
 -- AssetTypeOne -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetTypeOne' AND COLUMN_NAME='nAssetTypeOneID' ) BEGIN 		ALTER TABLE AssetTypeOne		ADD nAssetTypeOneID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetTypeOne' AND COLUMN_NAME='sAssetTypeOneName' ) BEGIN 		ALTER TABLE AssetTypeOne		ADD sAssetTypeOneName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetTypeOne' AND COLUMN_NAME='nAssetMainTypeID' ) BEGIN 		ALTER TABLE AssetTypeOne		ADD nAssetMainTypeID numeric(18,0)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetTypeOne' AND COLUMN_NAME='sAssetTypeOneCode' ) BEGIN 		ALTER TABLE AssetTypeOne		ADD sAssetTypeOneCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetTypeOne' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE AssetTypeOne		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='AssetTypeOne' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE AssetTypeOne		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 9 -- 
 -- ColourType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='ColourType' AND COLUMN_NAME='nColourTypeID' ) BEGIN 		ALTER TABLE ColourType		ADD nColourTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='ColourType' AND COLUMN_NAME='sColourTypeName' ) BEGIN 		ALTER TABLE ColourType		ADD sColourTypeName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='ColourType' AND COLUMN_NAME='sColourTypeCode' ) BEGIN 		ALTER TABLE ColourType		ADD sColourTypeCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='ColourType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE ColourType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='ColourType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE ColourType		ADD dtModifiedDate datetime  NULL  END  



GO
 -- 10 -- 
 -- DensityType -- 

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='DensityType' AND COLUMN_NAME='nDensityTypeID' ) BEGIN 		ALTER TABLE DensityType		ADD nDensityTypeID numeric(18,0)  NOT NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='DensityType' AND COLUMN_NAME='sDensityTypeName' ) BEGIN 		ALTER TABLE DensityType		ADD sDensityTypeName varchar(100)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='DensityType' AND COLUMN_NAME='sDensityTypeCode' ) BEGIN 		ALTER TABLE DensityType		ADD sDensityTypeCode varchar(10)  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='DensityType' AND COLUMN_NAME='dtCreatedDate' ) BEGIN 		ALTER TABLE DensityType		ADD dtCreatedDate datetime  NULL  END  

GO
 IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME='DensityType' AND COLUMN_NAME='dtModifiedDate' ) BEGIN 		ALTER TABLE DensityType		ADD dtModifiedDate datetime  NULL  END  


