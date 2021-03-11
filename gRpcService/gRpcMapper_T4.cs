using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace gRpcService
{

    public static class MyConverter
    {
        public static void CopyFrom(this DbModel.vStoreWithContacts dest, Model.vStoreWithContacts source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.ContactType      = source.ContactType;
            dest.LastName         = source.LastName;
            dest.FirstName        = source.FirstName;
            dest.EmailPromotion   = source.EmailPromotion;
            dest.MiddleName       = source.MiddleName;
            dest.Suffix           = source.Suffix;
            dest.PhoneNumber      = source.PhoneNumber;
            dest.PhoneNumberType  = source.PhoneNumberType;
            dest.EmailAddress     = source.EmailAddress;
            dest.Title            = source.Title;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vStoreWithContacts dest, DbModel.vStoreWithContacts source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.ContactType      = source.ContactType;
            dest.LastName         = source.LastName;
            dest.FirstName        = source.FirstName;
            dest.EmailPromotion   = source.EmailPromotion;
            dest.MiddleName       = source.MiddleName;
            dest.Suffix           = source.Suffix;
            dest.PhoneNumber      = source.PhoneNumber;
            dest.PhoneNumberType  = source.PhoneNumberType;
            dest.EmailAddress     = source.EmailAddress;
            dest.Title            = source.Title;
        }
        public static void CopyFrom(this DbModel.ScrapReason dest, Model.ScrapReason source)
        {
            dest.ScrapReasonID = (short)source.ScrapReasonID;
            dest.Name          = source.Name;
            dest.ModifiedDate  = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ScrapReason dest, DbModel.ScrapReason source)
        {
            dest.ScrapReasonID = source.ScrapReasonID;
            dest.Name          = source.Name;
            dest.ModifiedDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.vStoreWithAddresses dest, Model.vStoreWithAddresses source)
        {
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.Name              = source.Name;
            dest.AddressType       = source.AddressType;
            dest.AddressLine1      = source.AddressLine1;
            dest.AddressLine2      = source.AddressLine2;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vStoreWithAddresses dest, DbModel.vStoreWithAddresses source)
        {
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.Name              = source.Name;
            dest.AddressType       = source.AddressType;
            dest.AddressLine1      = source.AddressLine1;
            dest.AddressLine2      = source.AddressLine2;
        }
        public static void CopyFrom(this DbModel.vVendorWithContacts dest, Model.vVendorWithContacts source)
        {
            dest.EmailPromotion   = source.EmailPromotion;
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.ContactType      = source.ContactType;
            dest.FirstName        = source.FirstName;
            dest.LastName         = source.LastName;
            dest.Suffix           = source.Suffix;
            dest.PhoneNumber      = source.PhoneNumber;
            dest.PhoneNumberType  = source.PhoneNumberType;
            dest.EmailAddress     = source.EmailAddress;
            dest.MiddleName       = source.MiddleName;
            dest.Title            = source.Title;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vVendorWithContacts dest, DbModel.vVendorWithContacts source)
        {
            dest.EmailPromotion   = source.EmailPromotion;
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.ContactType      = source.ContactType;
            dest.FirstName        = source.FirstName;
            dest.LastName         = source.LastName;
            dest.Suffix           = source.Suffix;
            dest.PhoneNumber      = source.PhoneNumber;
            dest.PhoneNumberType  = source.PhoneNumberType;
            dest.EmailAddress     = source.EmailAddress;
            dest.MiddleName       = source.MiddleName;
            dest.Title            = source.Title;
        }
        public static void CopyFrom(this DbModel.Shift dest, Model.Shift source)
        {
            dest.ShiftID      = (byte)source.ShiftID;
            dest.Name         = source.Name;
            dest.StartTime    = source.StartTime.ToDateTime();
            dest.EndTime      = source.EndTime.ToDateTime();
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.Shift dest, DbModel.Shift source)
        {
            dest.ShiftID      = source.ShiftID;
            dest.Name         = source.Name;
            dest.StartTime    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartTime);
            dest.EndTime      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndTime);
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.vVendorWithAddresses dest, Model.vVendorWithAddresses source)
        {
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.Name              = source.Name;
            dest.AddressType       = source.AddressType;
            dest.AddressLine1      = source.AddressLine1;
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.AddressLine2      = source.AddressLine2;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vVendorWithAddresses dest, DbModel.vVendorWithAddresses source)
        {
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.Name              = source.Name;
            dest.AddressType       = source.AddressType;
            dest.AddressLine1      = source.AddressLine1;
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.AddressLine2      = source.AddressLine2;
        }
        public static void CopyFrom(this DbModel.ProductCategory dest, Model.ProductCategory source)
        {
            dest.ProductCategoryID = source.ProductCategoryID;
            dest.Name              = source.Name;
            dest.Rowguid           =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductCategory dest, DbModel.ProductCategory source)
        {
            dest.ProductCategoryID = source.ProductCategoryID;
            dest.Name              = source.Name;
            dest.Rowguid           =  source.Rowguid.ToString();
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ShipMethod dest, Model.ShipMethod source)
        {
            dest.ShipMethodID = source.ShipMethodID;
            dest.Name         = source.Name;
            dest.ShipBase     = (decimal)source.ShipBase;
            dest.ShipRate     = (decimal)source.ShipRate;
            dest.Rowguid      =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ShipMethod dest, DbModel.ShipMethod source)
        {
            dest.ShipMethodID = source.ShipMethodID;
            dest.Name         = source.Name;
            dest.ShipBase     = (double)source.ShipBase;
            dest.ShipRate     = (double)source.ShipRate;
            dest.Rowguid      =  source.Rowguid.ToString();
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductCostHistory dest, Model.ProductCostHistory source)
        {
            dest.ProductID    = source.ProductID;
            dest.StartDate    = source.StartDate.ToDateTime();
            dest.StandardCost = (decimal)source.StandardCost;
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
            dest.EndDate      = source.EndDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductCostHistory dest, DbModel.ProductCostHistory source)
        {
            dest.ProductID    = source.ProductID;
            dest.StartDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.StandardCost = (double)source.StandardCost;
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.EndDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
        }
        public static void CopyFrom(this DbModel.ProductDescription dest, Model.ProductDescription source)
        {
            dest.ProductDescriptionID = source.ProductDescriptionID;
            dest.Description          = source.Description;
            dest.Rowguid              =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate         = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductDescription dest, DbModel.ProductDescription source)
        {
            dest.ProductDescriptionID = source.ProductDescriptionID;
            dest.Description          = source.Description;
            dest.Rowguid              =  source.Rowguid.ToString();
            dest.ModifiedDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ShoppingCartItem dest, Model.ShoppingCartItem source)
        {
            dest.ShoppingCartItemID = source.ShoppingCartItemID;
            dest.ShoppingCartID     = source.ShoppingCartID;
            dest.Quantity           = source.Quantity;
            dest.ProductID          = source.ProductID;
            dest.DateCreated        = source.DateCreated.ToDateTime();
            dest.ModifiedDate       = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ShoppingCartItem dest, DbModel.ShoppingCartItem source)
        {
            dest.ShoppingCartItemID = source.ShoppingCartItemID;
            dest.ShoppingCartID     = source.ShoppingCartID;
            dest.Quantity           = source.Quantity;
            dest.ProductID          = source.ProductID;
            dest.DateCreated        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.DateCreated);
            dest.ModifiedDate       = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductDocument dest, Model.ProductDocument source)
        {
            dest.ProductID    = source.ProductID;
    // не определен тип данных для столбца 'DocumentNode DocumentNode'
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductDocument dest, DbModel.ProductDocument source)
        {
            dest.ProductID    = source.ProductID;
    // не определен тип данных для столбца 'DocumentNode DocumentNode'
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.DatabaseLog dest, Model.DatabaseLog source)
        {
            dest.TSQL          = source.TSQL;
            dest.XmlEvent      = source.XmlEvent;
            dest.DatabaseLogID = source.DatabaseLogID;
            dest.PostTime      = source.PostTime.ToDateTime();
            dest.DatabaseUser  = source.DatabaseUser;
            dest.Event         = source.Event;
            dest.Schema        = source.Schema;
            dest.Object        = source.Object;
        }
        // ------------------------------
        public static void CopyFrom(this Model.DatabaseLog dest, DbModel.DatabaseLog source)
        {
            dest.TSQL          = source.TSQL;
            dest.XmlEvent      = source.XmlEvent;
            dest.DatabaseLogID = source.DatabaseLogID;
            dest.PostTime      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.PostTime);
            dest.DatabaseUser  = source.DatabaseUser;
            dest.Event         = source.Event;
            dest.Schema        = source.Schema;
            dest.Object        = source.Object;
        }
        public static void CopyFrom(this DbModel.ProductInventory dest, Model.ProductInventory source)
        {
            dest.ProductID    = source.ProductID;
            dest.LocationID   = (short)source.LocationID;
            dest.Shelf        = source.Shelf;
            dest.Bin          = (byte)source.Bin;
            dest.Quantity     = (short)source.Quantity;
            dest.Rowguid      =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductInventory dest, DbModel.ProductInventory source)
        {
            dest.ProductID    = source.ProductID;
            dest.LocationID   = source.LocationID;
            dest.Shelf        = source.Shelf;
            dest.Bin          = source.Bin;
            dest.Quantity     = source.Quantity;
            dest.Rowguid      =  source.Rowguid.ToString();
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.SpecialOffer dest, Model.SpecialOffer source)
        {
            dest.SpecialOfferID = source.SpecialOfferID;
            dest.Description    = source.Description;
            dest.DiscountPct    = (decimal)source.DiscountPct;
            dest.Type           = source.Type;
            dest.Category       = source.Category;
            dest.StartDate      = source.StartDate.ToDateTime();
            dest.EndDate        = source.EndDate.ToDateTime();
            dest.MinQty         = source.MinQty;
            dest.Rowguid        =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate   = source.ModifiedDate.ToDateTime();
            dest.MaxQty         = source.MaxQty;
        }
        // ------------------------------
        public static void CopyFrom(this Model.SpecialOffer dest, DbModel.SpecialOffer source)
        {
            dest.SpecialOfferID = source.SpecialOfferID;
            dest.Description    = source.Description;
            dest.DiscountPct    = (double)source.DiscountPct;
            dest.Type           = source.Type;
            dest.Category       = source.Category;
            dest.StartDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.EndDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
            dest.MinQty         = source.MinQty;
            dest.Rowguid        =  source.Rowguid.ToString();
            dest.ModifiedDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.MaxQty         = source.MaxQty;
        }
        public static void CopyFrom(this DbModel.ErrorLog dest, Model.ErrorLog source)
        {
            dest.ErrorLogID     = source.ErrorLogID;
            dest.ErrorTime      = source.ErrorTime.ToDateTime();
            dest.UserName       = source.UserName;
            dest.ErrorNumber    = source.ErrorNumber;
            dest.ErrorMessage   = source.ErrorMessage;
            dest.ErrorSeverity  = source.ErrorSeverity;
            dest.ErrorState     = source.ErrorState;
            dest.ErrorProcedure = source.ErrorProcedure;
            dest.ErrorLine      = source.ErrorLine;
        }
        // ------------------------------
        public static void CopyFrom(this Model.ErrorLog dest, DbModel.ErrorLog source)
        {
            dest.ErrorLogID     = source.ErrorLogID;
            dest.ErrorTime      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ErrorTime);
            dest.UserName       = source.UserName;
            dest.ErrorNumber    = source.ErrorNumber;
            dest.ErrorMessage   = source.ErrorMessage;
            dest.ErrorSeverity  = source.ErrorSeverity;
            dest.ErrorState     = source.ErrorState;
            dest.ErrorProcedure = source.ErrorProcedure;
            dest.ErrorLine      = source.ErrorLine;
        }
        public static void CopyFrom(this DbModel.ProductListPriceHistory dest, Model.ProductListPriceHistory source)
        {
            dest.ListPrice    = (decimal)source.ListPrice;
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
            dest.ProductID    = source.ProductID;
            dest.StartDate    = source.StartDate.ToDateTime();
            dest.EndDate      = source.EndDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductListPriceHistory dest, DbModel.ProductListPriceHistory source)
        {
            dest.ListPrice    = (double)source.ListPrice;
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.ProductID    = source.ProductID;
            dest.StartDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.EndDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
        }
        public static void CopyFrom(this DbModel.Address dest, Model.Address source)
        {
            dest.AddressID       = source.AddressID;
            dest.AddressLine1    = source.AddressLine1;
            dest.City            = source.City;
            dest.StateProvinceID = source.StateProvinceID;
            dest.PostalCode      = source.PostalCode;
            dest.Rowguid         =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate    = source.ModifiedDate.ToDateTime();
    // не определен тип данных для столбца 'SpatialLocation SpatialLocation'
            dest.AddressLine2    = source.AddressLine2;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Address dest, DbModel.Address source)
        {
            dest.AddressID       = source.AddressID;
            dest.AddressLine1    = source.AddressLine1;
            dest.City            = source.City;
            dest.StateProvinceID = source.StateProvinceID;
            dest.PostalCode      = source.PostalCode;
            dest.Rowguid         =  source.Rowguid.ToString();
            dest.ModifiedDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
    // не определен тип данных для столбца 'SpatialLocation SpatialLocation'
            dest.AddressLine2    = source.AddressLine2;
        }
        public static void CopyFrom(this DbModel.SpecialOfferProduct dest, Model.SpecialOfferProduct source)
        {
            dest.SpecialOfferID = source.SpecialOfferID;
            dest.ProductID      = source.ProductID;
            dest.Rowguid        =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate   = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.SpecialOfferProduct dest, DbModel.SpecialOfferProduct source)
        {
            dest.SpecialOfferID = source.SpecialOfferID;
            dest.ProductID      = source.ProductID;
            dest.Rowguid        =  source.Rowguid.ToString();
            dest.ModifiedDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductModel dest, Model.ProductModel source)
        {
            dest.Rowguid            =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate       = source.ModifiedDate.ToDateTime();
            dest.ProductModelID     = source.ProductModelID;
            dest.Name               = source.Name;
            dest.CatalogDescription = source.CatalogDescription;
            dest.Instructions       = source.Instructions;
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductModel dest, DbModel.ProductModel source)
        {
            dest.Rowguid            =  source.Rowguid.ToString();
            dest.ModifiedDate       = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.ProductModelID     = source.ProductModelID;
            dest.Name               = source.Name;
            dest.CatalogDescription = source.CatalogDescription;
            dest.Instructions       = source.Instructions;
        }
        public static void CopyFrom(this DbModel.AddressType dest, Model.AddressType source)
        {
            dest.AddressTypeID = source.AddressTypeID;
            dest.Name          = source.Name;
            dest.Rowguid       =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate  = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.AddressType dest, DbModel.AddressType source)
        {
            dest.AddressTypeID = source.AddressTypeID;
            dest.Name          = source.Name;
            dest.Rowguid       =  source.Rowguid.ToString();
            dest.ModifiedDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.StateProvince dest, Model.StateProvince source)
        {
            dest.StateProvinceID         = source.StateProvinceID;
            dest.StateProvinceCode       = source.StateProvinceCode;
            dest.CountryRegionCode       = source.CountryRegionCode;
            dest.IsOnlyStateProvinceFlag = source.IsOnlyStateProvinceFlag;
            dest.Name                    = source.Name;
            dest.TerritoryID             = source.TerritoryID;
            dest.Rowguid                 =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate            = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.StateProvince dest, DbModel.StateProvince source)
        {
            dest.StateProvinceID         = source.StateProvinceID;
            dest.StateProvinceCode       = source.StateProvinceCode;
            dest.CountryRegionCode       = source.CountryRegionCode;
            dest.IsOnlyStateProvinceFlag = source.IsOnlyStateProvinceFlag;
            dest.Name                    = source.Name;
            dest.TerritoryID             = source.TerritoryID;
            dest.Rowguid                 =  source.Rowguid.ToString();
            dest.ModifiedDate            = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductModelIllustration dest, Model.ProductModelIllustration source)
        {
            dest.ProductModelID = source.ProductModelID;
            dest.IllustrationID = source.IllustrationID;
            dest.ModifiedDate   = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductModelIllustration dest, DbModel.ProductModelIllustration source)
        {
            dest.ProductModelID = source.ProductModelID;
            dest.IllustrationID = source.IllustrationID;
            dest.ModifiedDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.AWBuildVersion dest, Model.AWBuildVersion source)
        {
            dest.SystemInformationID = (byte)source.SystemInformationID;
            dest.DatabaseVersion     = source.DatabaseVersion;
            dest.VersionDate         = source.VersionDate.ToDateTime();
            dest.ModifiedDate        = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.AWBuildVersion dest, DbModel.AWBuildVersion source)
        {
            dest.SystemInformationID = source.SystemInformationID;
            dest.DatabaseVersion     = source.DatabaseVersion;
            dest.VersionDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.VersionDate);
            dest.ModifiedDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductModelProductDescriptionCulture dest, Model.ProductModelProductDescriptionCulture source)
        {
            dest.ProductModelID       = source.ProductModelID;
            dest.ProductDescriptionID = source.ProductDescriptionID;
            dest.CultureID            = source.CultureID;
            dest.ModifiedDate         = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductModelProductDescriptionCulture dest, DbModel.ProductModelProductDescriptionCulture source)
        {
            dest.ProductModelID       = source.ProductModelID;
            dest.ProductDescriptionID = source.ProductDescriptionID;
            dest.CultureID            = source.CultureID;
            dest.ModifiedDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.BillOfMaterials dest, Model.BillOfMaterials source)
        {
            dest.BillOfMaterialsID = source.BillOfMaterialsID;
            dest.UnitMeasureCode   = source.UnitMeasureCode;
            dest.BOMLevel          = (short)source.BOMLevel;
            dest.PerAssemblyQty    = (decimal)source.PerAssemblyQty;
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
            dest.ComponentID       = source.ComponentID;
            dest.StartDate         = source.StartDate.ToDateTime();
            dest.EndDate           = source.EndDate.ToDateTime();
            dest.ProductAssemblyID = source.ProductAssemblyID;
        }
        // ------------------------------
        public static void CopyFrom(this Model.BillOfMaterials dest, DbModel.BillOfMaterials source)
        {
            dest.BillOfMaterialsID = source.BillOfMaterialsID;
            dest.UnitMeasureCode   = source.UnitMeasureCode;
            dest.BOMLevel          = source.BOMLevel;
            dest.PerAssemblyQty    = (double)source.PerAssemblyQty;
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.ComponentID       = source.ComponentID;
            dest.StartDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.EndDate           = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
            dest.ProductAssemblyID = source.ProductAssemblyID;
        }
        public static void CopyFrom(this DbModel.Store dest, Model.Store source)
        {
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.SalesPersonID    = source.SalesPersonID;
            dest.Demographics     = source.Demographics;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Store dest, DbModel.Store source)
        {
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.SalesPersonID    = source.SalesPersonID;
            dest.Demographics     = source.Demographics;
        }
        public static void CopyFrom(this DbModel.ProductPhoto dest, Model.ProductPhoto source)
        {
            dest.ProductPhotoID         = source.ProductPhotoID;
            dest.ModifiedDate           = source.ModifiedDate.ToDateTime();
            dest.ThumbNailPhoto         = source.ThumbNailPhoto.ToByteArray();
            dest.ThumbnailPhotoFileName = source.ThumbnailPhotoFileName;
            dest.LargePhoto             = source.LargePhoto.ToByteArray();
            dest.LargePhotoFileName     = source.LargePhotoFileName;
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductPhoto dest, DbModel.ProductPhoto source)
        {
            dest.ProductPhotoID         = source.ProductPhotoID;
            dest.ModifiedDate           = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.ThumbNailPhoto         = Google.Protobuf.ByteString.CopyFrom(source.ThumbNailPhoto);
            dest.ThumbnailPhotoFileName = source.ThumbnailPhotoFileName;
            dest.LargePhoto             = Google.Protobuf.ByteString.CopyFrom(source.LargePhoto);
            dest.LargePhotoFileName     = source.LargePhotoFileName;
        }
        public static void CopyFrom(this DbModel.ProductProductPhoto dest, Model.ProductProductPhoto source)
        {
            dest.ProductID      = source.ProductID;
            dest.ProductPhotoID = source.ProductPhotoID;
            dest.Primary        = source.Primary;
            dest.ModifiedDate   = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductProductPhoto dest, DbModel.ProductProductPhoto source)
        {
            dest.ProductID      = source.ProductID;
            dest.ProductPhotoID = source.ProductPhotoID;
            dest.Primary        = source.Primary;
            dest.ModifiedDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.TransactionHistory dest, Model.TransactionHistory source)
        {
            dest.TransactionID        = source.TransactionID;
            dest.ProductID            = source.ProductID;
            dest.ReferenceOrderID     = source.ReferenceOrderID;
            dest.ReferenceOrderLineID = source.ReferenceOrderLineID;
            dest.TransactionDate      = source.TransactionDate.ToDateTime();
            dest.TransactionType      = source.TransactionType;
            dest.Quantity             = source.Quantity;
            dest.ActualCost           = (decimal)source.ActualCost;
            dest.ModifiedDate         = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.TransactionHistory dest, DbModel.TransactionHistory source)
        {
            dest.TransactionID        = source.TransactionID;
            dest.ProductID            = source.ProductID;
            dest.ReferenceOrderID     = source.ReferenceOrderID;
            dest.ReferenceOrderLineID = source.ReferenceOrderLineID;
            dest.TransactionDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.TransactionDate);
            dest.TransactionType      = source.TransactionType;
            dest.Quantity             = source.Quantity;
            dest.ActualCost           = (double)source.ActualCost;
            dest.ModifiedDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductReview dest, Model.ProductReview source)
        {
            dest.ProductReviewID = source.ProductReviewID;
            dest.ProductID       = source.ProductID;
            dest.ReviewerName    = source.ReviewerName;
            dest.ReviewDate      = source.ReviewDate.ToDateTime();
            dest.EmailAddress    = source.EmailAddress;
            dest.Rating          = source.Rating;
            dest.ModifiedDate    = source.ModifiedDate.ToDateTime();
            dest.Comments        = source.Comments;
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductReview dest, DbModel.ProductReview source)
        {
            dest.ProductReviewID = source.ProductReviewID;
            dest.ProductID       = source.ProductID;
            dest.ReviewerName    = source.ReviewerName;
            dest.ReviewDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ReviewDate);
            dest.EmailAddress    = source.EmailAddress;
            dest.Rating          = source.Rating;
            dest.ModifiedDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.Comments        = source.Comments;
        }
        public static void CopyFrom(this DbModel.BusinessEntity dest, Model.BusinessEntity source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.BusinessEntity dest, DbModel.BusinessEntity source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.TransactionHistoryArchive dest, Model.TransactionHistoryArchive source)
        {
            dest.TransactionID        = source.TransactionID;
            dest.ProductID            = source.ProductID;
            dest.ReferenceOrderID     = source.ReferenceOrderID;
            dest.ReferenceOrderLineID = source.ReferenceOrderLineID;
            dest.TransactionDate      = source.TransactionDate.ToDateTime();
            dest.TransactionType      = source.TransactionType;
            dest.Quantity             = source.Quantity;
            dest.ActualCost           = (decimal)source.ActualCost;
            dest.ModifiedDate         = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.TransactionHistoryArchive dest, DbModel.TransactionHistoryArchive source)
        {
            dest.TransactionID        = source.TransactionID;
            dest.ProductID            = source.ProductID;
            dest.ReferenceOrderID     = source.ReferenceOrderID;
            dest.ReferenceOrderLineID = source.ReferenceOrderLineID;
            dest.TransactionDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.TransactionDate);
            dest.TransactionType      = source.TransactionType;
            dest.Quantity             = source.Quantity;
            dest.ActualCost           = (double)source.ActualCost;
            dest.ModifiedDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductSubcategory dest, Model.ProductSubcategory source)
        {
            dest.ProductSubcategoryID = source.ProductSubcategoryID;
            dest.ProductCategoryID    = source.ProductCategoryID;
            dest.Name                 = source.Name;
            dest.Rowguid              =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate         = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductSubcategory dest, DbModel.ProductSubcategory source)
        {
            dest.ProductSubcategoryID = source.ProductSubcategoryID;
            dest.ProductCategoryID    = source.ProductCategoryID;
            dest.Name                 = source.Name;
            dest.Rowguid              =  source.Rowguid.ToString();
            dest.ModifiedDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.BusinessEntityAddress dest, Model.BusinessEntityAddress source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.AddressID        = source.AddressID;
            dest.AddressTypeID    = source.AddressTypeID;
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.BusinessEntityAddress dest, DbModel.BusinessEntityAddress source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.AddressID        = source.AddressID;
            dest.AddressTypeID    = source.AddressTypeID;
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.ProductVendor dest, Model.ProductVendor source)
        {
            dest.MinOrderQty      = source.MinOrderQty;
            dest.MaxOrderQty      = source.MaxOrderQty;
            dest.UnitMeasureCode  = source.UnitMeasureCode;
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
            dest.ProductID        = source.ProductID;
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.AverageLeadTime  = source.AverageLeadTime;
            dest.StandardPrice    = (decimal)source.StandardPrice;
            dest.LastReceiptCost  = (decimal)source.LastReceiptCost;
            dest.LastReceiptDate  = source.LastReceiptDate.ToDateTime();
            dest.OnOrderQty       = source.OnOrderQty;
        }
        // ------------------------------
        public static void CopyFrom(this Model.ProductVendor dest, DbModel.ProductVendor source)
        {
            dest.MinOrderQty      = source.MinOrderQty;
            dest.MaxOrderQty      = source.MaxOrderQty;
            dest.UnitMeasureCode  = source.UnitMeasureCode;
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.ProductID        = source.ProductID;
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.AverageLeadTime  = source.AverageLeadTime;
            dest.StandardPrice    = (double)source.StandardPrice;
            dest.LastReceiptCost  = (double)source.LastReceiptCost;
            dest.LastReceiptDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.LastReceiptDate);
            dest.OnOrderQty       = source.OnOrderQty;
        }
        public static void CopyFrom(this DbModel.BusinessEntityContact dest, Model.BusinessEntityContact source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.PersonID         = source.PersonID;
            dest.ContactTypeID    = source.ContactTypeID;
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.BusinessEntityContact dest, DbModel.BusinessEntityContact source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.PersonID         = source.PersonID;
            dest.ContactTypeID    = source.ContactTypeID;
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.UnitMeasure dest, Model.UnitMeasure source)
        {
            dest.UnitMeasureCode = source.UnitMeasureCode;
            dest.Name            = source.Name;
            dest.ModifiedDate    = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.UnitMeasure dest, DbModel.UnitMeasure source)
        {
            dest.UnitMeasureCode = source.UnitMeasureCode;
            dest.Name            = source.Name;
            dest.ModifiedDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.Vendor dest, Model.Vendor source)
        {
            dest.ModifiedDate            = source.ModifiedDate.ToDateTime();
            dest.BusinessEntityID        = source.BusinessEntityID;
            dest.AccountNumber           = source.AccountNumber;
            dest.Name                    = source.Name;
            dest.CreditRating            = (byte)source.CreditRating;
            dest.PreferredVendorStatus   = source.PreferredVendorStatus;
            dest.ActiveFlag              = source.ActiveFlag;
            dest.PurchasingWebServiceURL = source.PurchasingWebServiceURL;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Vendor dest, DbModel.Vendor source)
        {
            dest.ModifiedDate            = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.BusinessEntityID        = source.BusinessEntityID;
            dest.AccountNumber           = source.AccountNumber;
            dest.Name                    = source.Name;
            dest.CreditRating            = source.CreditRating;
            dest.PreferredVendorStatus   = source.PreferredVendorStatus;
            dest.ActiveFlag              = source.ActiveFlag;
            dest.PurchasingWebServiceURL = source.PurchasingWebServiceURL;
        }
        public static void CopyFrom(this DbModel.ContactType dest, Model.ContactType source)
        {
            dest.ContactTypeID = source.ContactTypeID;
            dest.Name          = source.Name;
            dest.ModifiedDate  = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.ContactType dest, DbModel.ContactType source)
        {
            dest.ContactTypeID = source.ContactTypeID;
            dest.Name          = source.Name;
            dest.ModifiedDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.CountryRegionCurrency dest, Model.CountryRegionCurrency source)
        {
            dest.CountryRegionCode = source.CountryRegionCode;
            dest.CurrencyCode      = source.CurrencyCode;
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.CountryRegionCurrency dest, DbModel.CountryRegionCurrency source)
        {
            dest.CountryRegionCode = source.CountryRegionCode;
            dest.CurrencyCode      = source.CurrencyCode;
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.CountryRegion dest, Model.CountryRegion source)
        {
            dest.CountryRegionCode = source.CountryRegionCode;
            dest.Name              = source.Name;
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.CountryRegion dest, DbModel.CountryRegion source)
        {
            dest.CountryRegionCode = source.CountryRegionCode;
            dest.Name              = source.Name;
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.WorkOrder dest, Model.WorkOrder source)
        {
            dest.DueDate       = source.DueDate.ToDateTime();
            dest.WorkOrderID   = source.WorkOrderID;
            dest.ProductID     = source.ProductID;
            dest.OrderQty      = source.OrderQty;
            dest.StockedQty    = source.StockedQty;
            dest.ScrappedQty   = (short)source.ScrappedQty;
            dest.StartDate     = source.StartDate.ToDateTime();
            dest.ModifiedDate  = source.ModifiedDate.ToDateTime();
            dest.EndDate       = source.EndDate.ToDateTime();
            dest.ScrapReasonID = (short)source.ScrapReasonID;
        }
        // ------------------------------
        public static void CopyFrom(this Model.WorkOrder dest, DbModel.WorkOrder source)
        {
            dest.DueDate       = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.DueDate);
            dest.WorkOrderID   = source.WorkOrderID;
            dest.ProductID     = source.ProductID;
            dest.OrderQty      = source.OrderQty;
            dest.StockedQty    = source.StockedQty;
            dest.ScrappedQty   = source.ScrappedQty;
            dest.StartDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.ModifiedDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.EndDate       = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
            dest.ScrapReasonID = source.ScrapReasonID;
        }
        public static void CopyFrom(this DbModel.PurchaseOrderDetail dest, Model.PurchaseOrderDetail source)
        {
            dest.PurchaseOrderID       = source.PurchaseOrderID;
            dest.PurchaseOrderDetailID = source.PurchaseOrderDetailID;
            dest.DueDate               = source.DueDate.ToDateTime();
            dest.OrderQty              = (short)source.OrderQty;
            dest.ProductID             = source.ProductID;
            dest.UnitPrice             = (decimal)source.UnitPrice;
            dest.LineTotal             = (decimal)source.LineTotal;
            dest.ReceivedQty           = (decimal)source.ReceivedQty;
            dest.RejectedQty           = (decimal)source.RejectedQty;
            dest.StockedQty            = (decimal)source.StockedQty;
            dest.ModifiedDate          = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.PurchaseOrderDetail dest, DbModel.PurchaseOrderDetail source)
        {
            dest.PurchaseOrderID       = source.PurchaseOrderID;
            dest.PurchaseOrderDetailID = source.PurchaseOrderDetailID;
            dest.DueDate               = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.DueDate);
            dest.OrderQty              = source.OrderQty;
            dest.ProductID             = source.ProductID;
            dest.UnitPrice             = (double)source.UnitPrice;
            dest.LineTotal             = (double)source.LineTotal;
            dest.ReceivedQty           = (double)source.ReceivedQty;
            dest.RejectedQty           = (double)source.RejectedQty;
            dest.StockedQty            = (double)source.StockedQty;
            dest.ModifiedDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.CreditCard dest, Model.CreditCard source)
        {
            dest.CreditCardID = source.CreditCardID;
            dest.CardType     = source.CardType;
            dest.CardNumber   = source.CardNumber;
            dest.ExpMonth     = (byte)source.ExpMonth;
            dest.ExpYear      = (short)source.ExpYear;
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.CreditCard dest, DbModel.CreditCard source)
        {
            dest.CreditCardID = source.CreditCardID;
            dest.CardType     = source.CardType;
            dest.CardNumber   = source.CardNumber;
            dest.ExpMonth     = source.ExpMonth;
            dest.ExpYear      = source.ExpYear;
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.Culture dest, Model.Culture source)
        {
            dest.CultureID    = source.CultureID;
            dest.Name         = source.Name;
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.Culture dest, DbModel.Culture source)
        {
            dest.CultureID    = source.CultureID;
            dest.Name         = source.Name;
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.WorkOrderRouting dest, Model.WorkOrderRouting source)
        {
            dest.ModifiedDate       = source.ModifiedDate.ToDateTime();
            dest.WorkOrderID        = source.WorkOrderID;
            dest.ProductID          = source.ProductID;
            dest.OperationSequence  = (short)source.OperationSequence;
            dest.LocationID         = (short)source.LocationID;
            dest.ScheduledStartDate = source.ScheduledStartDate.ToDateTime();
            dest.ScheduledEndDate   = source.ScheduledEndDate.ToDateTime();
            dest.PlannedCost        = (decimal)source.PlannedCost;
            dest.ActualCost         = (decimal)source.ActualCost;
            dest.ActualStartDate    = source.ActualStartDate.ToDateTime();
            dest.ActualEndDate      = source.ActualEndDate.ToDateTime();
            dest.ActualResourceHrs  = (decimal)source.ActualResourceHrs;
        }
        // ------------------------------
        public static void CopyFrom(this Model.WorkOrderRouting dest, DbModel.WorkOrderRouting source)
        {
            dest.ModifiedDate       = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.WorkOrderID        = source.WorkOrderID;
            dest.ProductID          = source.ProductID;
            dest.OperationSequence  = source.OperationSequence;
            dest.LocationID         = source.LocationID;
            dest.ScheduledStartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ScheduledStartDate);
            dest.ScheduledEndDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ScheduledEndDate);
            dest.PlannedCost        = (double)source.PlannedCost;
            dest.ActualCost         = (double)source.ActualCost;
            dest.ActualStartDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ActualStartDate);
            dest.ActualEndDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ActualEndDate);
            dest.ActualResourceHrs  = (double)source.ActualResourceHrs;
        }
        public static void CopyFrom(this DbModel.Currency dest, Model.Currency source)
        {
            dest.CurrencyCode = source.CurrencyCode;
            dest.Name         = source.Name;
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.Currency dest, DbModel.Currency source)
        {
            dest.CurrencyCode = source.CurrencyCode;
            dest.Name         = source.Name;
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.PurchaseOrderHeader dest, Model.PurchaseOrderHeader source)
        {
            dest.SubTotal        = (decimal)source.SubTotal;
            dest.TaxAmt          = (decimal)source.TaxAmt;
            dest.Freight         = (decimal)source.Freight;
            dest.TotalDue        = (decimal)source.TotalDue;
            dest.ModifiedDate    = source.ModifiedDate.ToDateTime();
            dest.PurchaseOrderID = source.PurchaseOrderID;
            dest.RevisionNumber  = (byte)source.RevisionNumber;
            dest.Status          = (byte)source.Status;
            dest.EmployeeID      = source.EmployeeID;
            dest.VendorID        = source.VendorID;
            dest.ShipMethodID    = source.ShipMethodID;
            dest.OrderDate       = source.OrderDate.ToDateTime();
            dest.ShipDate        = source.ShipDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.PurchaseOrderHeader dest, DbModel.PurchaseOrderHeader source)
        {
            dest.SubTotal        = (double)source.SubTotal;
            dest.TaxAmt          = (double)source.TaxAmt;
            dest.Freight         = (double)source.Freight;
            dest.TotalDue        = (double)source.TotalDue;
            dest.ModifiedDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.PurchaseOrderID = source.PurchaseOrderID;
            dest.RevisionNumber  = source.RevisionNumber;
            dest.Status          = source.Status;
            dest.EmployeeID      = source.EmployeeID;
            dest.VendorID        = source.VendorID;
            dest.ShipMethodID    = source.ShipMethodID;
            dest.OrderDate       = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.OrderDate);
            dest.ShipDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ShipDate);
        }
        public static void CopyFrom(this DbModel.CurrencyRate dest, Model.CurrencyRate source)
        {
            dest.CurrencyRateID   = source.CurrencyRateID;
            dest.CurrencyRateDate = source.CurrencyRateDate.ToDateTime();
            dest.FromCurrencyCode = source.FromCurrencyCode;
            dest.ToCurrencyCode   = source.ToCurrencyCode;
            dest.AverageRate      = (decimal)source.AverageRate;
            dest.EndOfDayRate     = (decimal)source.EndOfDayRate;
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.CurrencyRate dest, DbModel.CurrencyRate source)
        {
            dest.CurrencyRateID   = source.CurrencyRateID;
            dest.CurrencyRateDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.CurrencyRateDate);
            dest.FromCurrencyCode = source.FromCurrencyCode;
            dest.ToCurrencyCode   = source.ToCurrencyCode;
            dest.AverageRate      = (double)source.AverageRate;
            dest.EndOfDayRate     = (double)source.EndOfDayRate;
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.Customer dest, Model.Customer source)
        {
            dest.CustomerID    = source.CustomerID;
            dest.AccountNumber = source.AccountNumber;
            dest.Rowguid       =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate  = source.ModifiedDate.ToDateTime();
            dest.PersonID      = source.PersonID;
            dest.StoreID       = source.StoreID;
            dest.TerritoryID   = source.TerritoryID;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Customer dest, DbModel.Customer source)
        {
            dest.CustomerID    = source.CustomerID;
            dest.AccountNumber = source.AccountNumber;
            dest.Rowguid       =  source.Rowguid.ToString();
            dest.ModifiedDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.PersonID      = source.PersonID;
            dest.StoreID       = source.StoreID;
            dest.TerritoryID   = source.TerritoryID;
        }
        public static void CopyFrom(this DbModel.Department dest, Model.Department source)
        {
            dest.DepartmentID = (short)source.DepartmentID;
            dest.Name         = source.Name;
            dest.GroupName    = source.GroupName;
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.Department dest, DbModel.Department source)
        {
            dest.DepartmentID = source.DepartmentID;
            dest.Name         = source.Name;
            dest.GroupName    = source.GroupName;
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.Document dest, Model.Document source)
        {
            dest.Rowguid         =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate    = source.ModifiedDate.ToDateTime();
    // не определен тип данных для столбца 'DocumentNode DocumentNode'
            dest.Title           = source.Title;
            dest.Owner           = source.Owner;
            dest.FolderFlag      = source.FolderFlag;
            dest.FileName        = source.FileName;
            dest.FileExtension   = source.FileExtension;
            dest.Revision        = source.Revision;
            dest.ChangeNumber    = source.ChangeNumber;
            dest.Status          = (byte)source.Status;
            dest.DocumentSummary = source.DocumentSummary;
            dest.DocumentData    = source.DocumentData.ToByteArray();
            dest.DocumentLevel   = (short)source.DocumentLevel;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Document dest, DbModel.Document source)
        {
            dest.Rowguid         =  source.Rowguid.ToString();
            dest.ModifiedDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
    // не определен тип данных для столбца 'DocumentNode DocumentNode'
            dest.Title           = source.Title;
            dest.Owner           = source.Owner;
            dest.FolderFlag      = source.FolderFlag;
            dest.FileName        = source.FileName;
            dest.FileExtension   = source.FileExtension;
            dest.Revision        = source.Revision;
            dest.ChangeNumber    = source.ChangeNumber;
            dest.Status          = source.Status;
            dest.DocumentSummary = source.DocumentSummary;
            dest.DocumentData    = Google.Protobuf.ByteString.CopyFrom(source.DocumentData);
            dest.DocumentLevel   = source.DocumentLevel;
        }
        public static void CopyFrom(this DbModel.SalesOrderDetail dest, Model.SalesOrderDetail source)
        {
            dest.OrderQty              = (short)source.OrderQty;
            dest.ProductID             = source.ProductID;
            dest.SpecialOfferID        = source.SpecialOfferID;
            dest.UnitPrice             = (decimal)source.UnitPrice;
            dest.UnitPriceDiscount     = (decimal)source.UnitPriceDiscount;
            dest.LineTotal             = source.LineTotal;
            dest.Rowguid               =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate          = source.ModifiedDate.ToDateTime();
            dest.SalesOrderID          = source.SalesOrderID;
            dest.SalesOrderDetailID    = source.SalesOrderDetailID;
            dest.CarrierTrackingNumber = source.CarrierTrackingNumber;
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesOrderDetail dest, DbModel.SalesOrderDetail source)
        {
            dest.OrderQty              = source.OrderQty;
            dest.ProductID             = source.ProductID;
            dest.SpecialOfferID        = source.SpecialOfferID;
            dest.UnitPrice             = (double)source.UnitPrice;
            dest.UnitPriceDiscount     = (double)source.UnitPriceDiscount;
            dest.LineTotal             = source.LineTotal;
            dest.Rowguid               =  source.Rowguid.ToString();
            dest.ModifiedDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.SalesOrderID          = source.SalesOrderID;
            dest.SalesOrderDetailID    = source.SalesOrderDetailID;
            dest.CarrierTrackingNumber = source.CarrierTrackingNumber;
        }
        public static void CopyFrom(this DbModel.EmailAddress dest, Model.EmailAddress source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.EmailAddressID   = source.EmailAddressID;
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
            dest.EmailAddressData = source.EmailAddressData;
        }
        // ------------------------------
        public static void CopyFrom(this Model.EmailAddress dest, DbModel.EmailAddress source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.EmailAddressID   = source.EmailAddressID;
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.EmailAddressData = source.EmailAddressData;
        }
        public static void CopyFrom(this DbModel.Employee dest, Model.Employee source)
        {
            dest.JobTitle          = source.JobTitle;
            dest.BirthDate         = source.BirthDate.ToDateTime();
            dest.MaritalStatus     = source.MaritalStatus;
            dest.Gender            = source.Gender;
            dest.HireDate          = source.HireDate.ToDateTime();
            dest.SalariedFlag      = source.SalariedFlag;
            dest.VacationHours     = (short)source.VacationHours;
            dest.SickLeaveHours    = (short)source.SickLeaveHours;
            dest.CurrentFlag       = source.CurrentFlag;
            dest.Rowguid           =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.NationalIDNumber  = source.NationalIDNumber;
            dest.LoginID           = source.LoginID;
    // не определен тип данных для столбца 'OrganizationNode OrganizationNode'
            dest.OrganizationLevel = (short)source.OrganizationLevel;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Employee dest, DbModel.Employee source)
        {
            dest.JobTitle          = source.JobTitle;
            dest.BirthDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.BirthDate);
            dest.MaritalStatus     = source.MaritalStatus;
            dest.Gender            = source.Gender;
            dest.HireDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.HireDate);
            dest.SalariedFlag      = source.SalariedFlag;
            dest.VacationHours     = source.VacationHours;
            dest.SickLeaveHours    = source.SickLeaveHours;
            dest.CurrentFlag       = source.CurrentFlag;
            dest.Rowguid           =  source.Rowguid.ToString();
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.NationalIDNumber  = source.NationalIDNumber;
            dest.LoginID           = source.LoginID;
    // не определен тип данных для столбца 'OrganizationNode OrganizationNode'
            dest.OrganizationLevel = source.OrganizationLevel;
        }
        public static void CopyFrom(this DbModel.SalesOrderHeader dest, Model.SalesOrderHeader source)
        {
            dest.Status                 = (byte)source.Status;
            dest.OnlineOrderFlag        = source.OnlineOrderFlag;
            dest.SalesOrderNumber       = source.SalesOrderNumber;
            dest.SalesOrderID           = source.SalesOrderID;
            dest.RevisionNumber         = (byte)source.RevisionNumber;
            dest.OrderDate              = source.OrderDate.ToDateTime();
            dest.DueDate                = source.DueDate.ToDateTime();
            dest.CustomerID             = source.CustomerID;
            dest.Rowguid                =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate           = source.ModifiedDate.ToDateTime();
            dest.BillToAddressID        = source.BillToAddressID;
            dest.ShipToAddressID        = source.ShipToAddressID;
            dest.ShipMethodID           = source.ShipMethodID;
            dest.SubTotal               = (decimal)source.SubTotal;
            dest.TaxAmt                 = (decimal)source.TaxAmt;
            dest.Freight                = (decimal)source.Freight;
            dest.TotalDue               = (decimal)source.TotalDue;
            dest.Comment                = source.Comment;
            dest.CreditCardID           = source.CreditCardID;
            dest.CreditCardApprovalCode = source.CreditCardApprovalCode;
            dest.CurrencyRateID         = source.CurrencyRateID;
            dest.SalesPersonID          = source.SalesPersonID;
            dest.TerritoryID            = source.TerritoryID;
            dest.ShipDate               = source.ShipDate.ToDateTime();
            dest.PurchaseOrderNumber    = source.PurchaseOrderNumber;
            dest.AccountNumber          = source.AccountNumber;
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesOrderHeader dest, DbModel.SalesOrderHeader source)
        {
            dest.Status                 = source.Status;
            dest.OnlineOrderFlag        = source.OnlineOrderFlag;
            dest.SalesOrderNumber       = source.SalesOrderNumber;
            dest.SalesOrderID           = source.SalesOrderID;
            dest.RevisionNumber         = source.RevisionNumber;
            dest.OrderDate              = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.OrderDate);
            dest.DueDate                = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.DueDate);
            dest.CustomerID             = source.CustomerID;
            dest.Rowguid                =  source.Rowguid.ToString();
            dest.ModifiedDate           = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.BillToAddressID        = source.BillToAddressID;
            dest.ShipToAddressID        = source.ShipToAddressID;
            dest.ShipMethodID           = source.ShipMethodID;
            dest.SubTotal               = (double)source.SubTotal;
            dest.TaxAmt                 = (double)source.TaxAmt;
            dest.Freight                = (double)source.Freight;
            dest.TotalDue               = (double)source.TotalDue;
            dest.Comment                = source.Comment;
            dest.CreditCardID           = source.CreditCardID;
            dest.CreditCardApprovalCode = source.CreditCardApprovalCode;
            dest.CurrencyRateID         = source.CurrencyRateID;
            dest.SalesPersonID          = source.SalesPersonID;
            dest.TerritoryID            = source.TerritoryID;
            dest.ShipDate               = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ShipDate);
            dest.PurchaseOrderNumber    = source.PurchaseOrderNumber;
            dest.AccountNumber          = source.AccountNumber;
        }
        public static void CopyFrom(this DbModel.EmployeeDepartmentHistory dest, Model.EmployeeDepartmentHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.DepartmentID     = (short)source.DepartmentID;
            dest.ShiftID          = (byte)source.ShiftID;
            dest.StartDate        = source.StartDate.ToDateTime();
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
            dest.EndDate          = source.EndDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.EmployeeDepartmentHistory dest, DbModel.EmployeeDepartmentHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.DepartmentID     = source.DepartmentID;
            dest.ShiftID          = source.ShiftID;
            dest.StartDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.EndDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
        }
        public static void CopyFrom(this DbModel.EmployeePayHistory dest, Model.EmployeePayHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.RateChangeDate   = source.RateChangeDate.ToDateTime();
            dest.Rate             = (decimal)source.Rate;
            dest.PayFrequency     = (byte)source.PayFrequency;
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.EmployeePayHistory dest, DbModel.EmployeePayHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.RateChangeDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.RateChangeDate);
            dest.Rate             = (double)source.Rate;
            dest.PayFrequency     = source.PayFrequency;
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.SalesOrderHeaderSalesReason dest, Model.SalesOrderHeaderSalesReason source)
        {
            dest.SalesOrderID  = source.SalesOrderID;
            dest.SalesReasonID = source.SalesReasonID;
            dest.ModifiedDate  = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesOrderHeaderSalesReason dest, DbModel.SalesOrderHeaderSalesReason source)
        {
            dest.SalesOrderID  = source.SalesOrderID;
            dest.SalesReasonID = source.SalesReasonID;
            dest.ModifiedDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.SalesPerson dest, Model.SalesPerson source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Bonus            = (decimal)source.Bonus;
            dest.CommissionPct    = (decimal)source.CommissionPct;
            dest.SalesYTD         = (decimal)source.SalesYTD;
            dest.SalesLastYear    = (decimal)source.SalesLastYear;
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
            dest.TerritoryID      = source.TerritoryID;
            dest.SalesQuota       = (decimal)source.SalesQuota;
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesPerson dest, DbModel.SalesPerson source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Bonus            = (double)source.Bonus;
            dest.CommissionPct    = (double)source.CommissionPct;
            dest.SalesYTD         = (double)source.SalesYTD;
            dest.SalesLastYear    = (double)source.SalesLastYear;
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.TerritoryID      = source.TerritoryID;
            dest.SalesQuota       = (double)source.SalesQuota;
        }
        public static void CopyFrom(this DbModel.Illustration dest, Model.Illustration source)
        {
            dest.IllustrationID = source.IllustrationID;
            dest.ModifiedDate   = source.ModifiedDate.ToDateTime();
            dest.Diagram        = source.Diagram;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Illustration dest, DbModel.Illustration source)
        {
            dest.IllustrationID = source.IllustrationID;
            dest.ModifiedDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.Diagram        = source.Diagram;
        }
        public static void CopyFrom(this DbModel.JobCandidate dest, Model.JobCandidate source)
        {
            dest.JobCandidateID   = source.JobCandidateID;
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Resume           = source.Resume;
        }
        // ------------------------------
        public static void CopyFrom(this Model.JobCandidate dest, DbModel.JobCandidate source)
        {
            dest.JobCandidateID   = source.JobCandidateID;
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Resume           = source.Resume;
        }
        public static void CopyFrom(this DbModel.Location dest, Model.Location source)
        {
            dest.LocationID   = (short)source.LocationID;
            dest.Name         = source.Name;
            dest.CostRate     = (decimal)source.CostRate;
            dest.Availability = (decimal)source.Availability;
            dest.ModifiedDate = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.Location dest, DbModel.Location source)
        {
            dest.LocationID   = source.LocationID;
            dest.Name         = source.Name;
            dest.CostRate     = (double)source.CostRate;
            dest.Availability = (double)source.Availability;
            dest.ModifiedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.Password dest, Model.Password source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.PasswordHash     = source.PasswordHash;
            dest.PasswordSalt     = source.PasswordSalt;
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.Password dest, DbModel.Password source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.PasswordHash     = source.PasswordHash;
            dest.PasswordSalt     = source.PasswordSalt;
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.SalesPersonQuotaHistory dest, Model.SalesPersonQuotaHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.QuotaDate        = source.QuotaDate.ToDateTime();
            dest.SalesQuota       = (decimal)source.SalesQuota;
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesPersonQuotaHistory dest, DbModel.SalesPersonQuotaHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.QuotaDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.QuotaDate);
            dest.SalesQuota       = (double)source.SalesQuota;
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.Person dest, Model.Person source)
        {
            dest.BusinessEntityID      = source.BusinessEntityID;
            dest.PersonType            = source.PersonType;
            dest.NameStyle             = source.NameStyle;
            dest.Rowguid               =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate          = source.ModifiedDate.ToDateTime();
            dest.FirstName             = source.FirstName;
            dest.LastName              = source.LastName;
            dest.EmailPromotion        = source.EmailPromotion;
            dest.AdditionalContactInfo = source.AdditionalContactInfo;
            dest.Demographics          = source.Demographics;
            dest.Suffix                = source.Suffix;
            dest.MiddleName            = source.MiddleName;
            dest.Title                 = source.Title;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Person dest, DbModel.Person source)
        {
            dest.BusinessEntityID      = source.BusinessEntityID;
            dest.PersonType            = source.PersonType;
            dest.NameStyle             = source.NameStyle;
            dest.Rowguid               =  source.Rowguid.ToString();
            dest.ModifiedDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.FirstName             = source.FirstName;
            dest.LastName              = source.LastName;
            dest.EmailPromotion        = source.EmailPromotion;
            dest.AdditionalContactInfo = source.AdditionalContactInfo;
            dest.Demographics          = source.Demographics;
            dest.Suffix                = source.Suffix;
            dest.MiddleName            = source.MiddleName;
            dest.Title                 = source.Title;
        }
        public static void CopyFrom(this DbModel.SalesReason dest, Model.SalesReason source)
        {
            dest.SalesReasonID = source.SalesReasonID;
            dest.Name          = source.Name;
            dest.ReasonType    = source.ReasonType;
            dest.ModifiedDate  = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesReason dest, DbModel.SalesReason source)
        {
            dest.SalesReasonID = source.SalesReasonID;
            dest.Name          = source.Name;
            dest.ReasonType    = source.ReasonType;
            dest.ModifiedDate  = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.SalesTaxRate dest, Model.SalesTaxRate source)
        {
            dest.SalesTaxRateID  = source.SalesTaxRateID;
            dest.StateProvinceID = source.StateProvinceID;
            dest.TaxType         = (byte)source.TaxType;
            dest.TaxRate         = (decimal)source.TaxRate;
            dest.Name            = source.Name;
            dest.Rowguid         =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate    = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesTaxRate dest, DbModel.SalesTaxRate source)
        {
            dest.SalesTaxRateID  = source.SalesTaxRateID;
            dest.StateProvinceID = source.StateProvinceID;
            dest.TaxType         = source.TaxType;
            dest.TaxRate         = (double)source.TaxRate;
            dest.Name            = source.Name;
            dest.Rowguid         =  source.Rowguid.ToString();
            dest.ModifiedDate    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.PersonCreditCard dest, Model.PersonCreditCard source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.CreditCardID     = source.CreditCardID;
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.PersonCreditCard dest, DbModel.PersonCreditCard source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.CreditCardID     = source.CreditCardID;
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.vAdditionalContactInfo dest, Model.vAdditionalContactInfo source)
        {
            dest.BusinessEntityID               = source.BusinessEntityID;
            dest.FirstName                      = source.FirstName;
            dest.Rowguid                        =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate                   = source.ModifiedDate.ToDateTime();
            dest.LastName                       = source.LastName;
            dest.TelephoneNumber                = source.TelephoneNumber;
            dest.TelephoneSpecialInstructions   = source.TelephoneSpecialInstructions;
            dest.Street                         = source.Street;
            dest.City                           = source.City;
            dest.StateProvince                  = source.StateProvince;
            dest.PostalCode                     = source.PostalCode;
            dest.CountryRegion                  = source.CountryRegion;
            dest.HomeAddressSpecialInstructions = source.HomeAddressSpecialInstructions;
            dest.EMailAddress                   = source.EMailAddress;
            dest.EMailSpecialInstructions       = source.EMailSpecialInstructions;
            dest.EMailTelephoneNumber           = source.EMailTelephoneNumber;
            dest.MiddleName                     = source.MiddleName;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vAdditionalContactInfo dest, DbModel.vAdditionalContactInfo source)
        {
            dest.BusinessEntityID               = source.BusinessEntityID;
            dest.FirstName                      = source.FirstName;
            dest.Rowguid                        =  source.Rowguid.ToString();
            dest.ModifiedDate                   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.LastName                       = source.LastName;
            dest.TelephoneNumber                = source.TelephoneNumber;
            dest.TelephoneSpecialInstructions   = source.TelephoneSpecialInstructions;
            dest.Street                         = source.Street;
            dest.City                           = source.City;
            dest.StateProvince                  = source.StateProvince;
            dest.PostalCode                     = source.PostalCode;
            dest.CountryRegion                  = source.CountryRegion;
            dest.HomeAddressSpecialInstructions = source.HomeAddressSpecialInstructions;
            dest.EMailAddress                   = source.EMailAddress;
            dest.EMailSpecialInstructions       = source.EMailSpecialInstructions;
            dest.EMailTelephoneNumber           = source.EMailTelephoneNumber;
            dest.MiddleName                     = source.MiddleName;
        }
        public static void CopyFrom(this DbModel.PersonPhone dest, Model.PersonPhone source)
        {
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.PhoneNumber       = source.PhoneNumber;
            dest.PhoneNumberTypeID = source.PhoneNumberTypeID;
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.PersonPhone dest, DbModel.PersonPhone source)
        {
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.PhoneNumber       = source.PhoneNumber;
            dest.PhoneNumberTypeID = source.PhoneNumberTypeID;
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.vEmployee dest, Model.vEmployee source)
        {
            dest.BusinessEntityID      = source.BusinessEntityID;
            dest.FirstName             = source.FirstName;
            dest.JobTitle              = source.JobTitle;
            dest.City                  = source.City;
            dest.StateProvinceName     = source.StateProvinceName;
            dest.PostalCode            = source.PostalCode;
            dest.CountryRegionName     = source.CountryRegionName;
            dest.LastName              = source.LastName;
            dest.EmailPromotion        = source.EmailPromotion;
            dest.AddressLine1          = source.AddressLine1;
            dest.AddressLine2          = source.AddressLine2;
            dest.Suffix                = source.Suffix;
            dest.AdditionalContactInfo = source.AdditionalContactInfo;
            dest.PhoneNumber           = source.PhoneNumber;
            dest.PhoneNumberType       = source.PhoneNumberType;
            dest.EmailAddress          = source.EmailAddress;
            dest.MiddleName            = source.MiddleName;
            dest.Title                 = source.Title;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vEmployee dest, DbModel.vEmployee source)
        {
            dest.BusinessEntityID      = source.BusinessEntityID;
            dest.FirstName             = source.FirstName;
            dest.JobTitle              = source.JobTitle;
            dest.City                  = source.City;
            dest.StateProvinceName     = source.StateProvinceName;
            dest.PostalCode            = source.PostalCode;
            dest.CountryRegionName     = source.CountryRegionName;
            dest.LastName              = source.LastName;
            dest.EmailPromotion        = source.EmailPromotion;
            dest.AddressLine1          = source.AddressLine1;
            dest.AddressLine2          = source.AddressLine2;
            dest.Suffix                = source.Suffix;
            dest.AdditionalContactInfo = source.AdditionalContactInfo;
            dest.PhoneNumber           = source.PhoneNumber;
            dest.PhoneNumberType       = source.PhoneNumberType;
            dest.EmailAddress          = source.EmailAddress;
            dest.MiddleName            = source.MiddleName;
            dest.Title                 = source.Title;
        }
        public static void CopyFrom(this DbModel.SalesTerritory dest, Model.SalesTerritory source)
        {
            dest.TerritoryID       = source.TerritoryID;
            dest.Name              = source.Name;
            dest.CountryRegionCode = source.CountryRegionCode;
            dest.Group             = source.Group;
            dest.SalesYTD          = (decimal)source.SalesYTD;
            dest.SalesLastYear     = (decimal)source.SalesLastYear;
            dest.CostYTD           = (decimal)source.CostYTD;
            dest.CostLastYear      = (decimal)source.CostLastYear;
            dest.Rowguid           =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesTerritory dest, DbModel.SalesTerritory source)
        {
            dest.TerritoryID       = source.TerritoryID;
            dest.Name              = source.Name;
            dest.CountryRegionCode = source.CountryRegionCode;
            dest.Group             = source.Group;
            dest.SalesYTD          = (double)source.SalesYTD;
            dest.SalesLastYear     = (double)source.SalesLastYear;
            dest.CostYTD           = (double)source.CostYTD;
            dest.CostLastYear      = (double)source.CostLastYear;
            dest.Rowguid           =  source.Rowguid.ToString();
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.vEmployeeDepartment dest, Model.vEmployeeDepartment source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.FirstName        = source.FirstName;
            dest.JobTitle         = source.JobTitle;
            dest.Department       = source.Department;
            dest.GroupName        = source.GroupName;
            dest.StartDate        = source.StartDate.ToDateTime();
            dest.LastName         = source.LastName;
            dest.Suffix           = source.Suffix;
            dest.MiddleName       = source.MiddleName;
            dest.Title            = source.Title;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vEmployeeDepartment dest, DbModel.vEmployeeDepartment source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.FirstName        = source.FirstName;
            dest.JobTitle         = source.JobTitle;
            dest.Department       = source.Department;
            dest.GroupName        = source.GroupName;
            dest.StartDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.LastName         = source.LastName;
            dest.Suffix           = source.Suffix;
            dest.MiddleName       = source.MiddleName;
            dest.Title            = source.Title;
        }
        public static void CopyFrom(this DbModel.PhoneNumberType dest, Model.PhoneNumberType source)
        {
            dest.PhoneNumberTypeID = source.PhoneNumberTypeID;
            dest.Name              = source.Name;
            dest.ModifiedDate      = source.ModifiedDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.PhoneNumberType dest, DbModel.PhoneNumberType source)
        {
            dest.PhoneNumberTypeID = source.PhoneNumberTypeID;
            dest.Name              = source.Name;
            dest.ModifiedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
        }
        public static void CopyFrom(this DbModel.vEmployeeDepartmentHistory dest, Model.vEmployeeDepartmentHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.FirstName        = source.FirstName;
            dest.LastName         = source.LastName;
            dest.Shift            = source.Shift;
            dest.Department       = source.Department;
            dest.GroupName        = source.GroupName;
            dest.StartDate        = source.StartDate.ToDateTime();
            dest.EndDate          = source.EndDate.ToDateTime();
            dest.Suffix           = source.Suffix;
            dest.MiddleName       = source.MiddleName;
            dest.Title            = source.Title;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vEmployeeDepartmentHistory dest, DbModel.vEmployeeDepartmentHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.FirstName        = source.FirstName;
            dest.LastName         = source.LastName;
            dest.Shift            = source.Shift;
            dest.Department       = source.Department;
            dest.GroupName        = source.GroupName;
            dest.StartDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.EndDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
            dest.Suffix           = source.Suffix;
            dest.MiddleName       = source.MiddleName;
            dest.Title            = source.Title;
        }
        public static void CopyFrom(this DbModel.vIndividualCustomer dest, Model.vIndividualCustomer source)
        {
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.LastName          = source.LastName;
            dest.EmailPromotion    = source.EmailPromotion;
            dest.AddressType       = source.AddressType;
            dest.AddressLine1      = source.AddressLine1;
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.FirstName         = source.FirstName;
            dest.MiddleName        = source.MiddleName;
            dest.Demographics      = source.Demographics;
            dest.AddressLine2      = source.AddressLine2;
            dest.Suffix            = source.Suffix;
            dest.PhoneNumber       = source.PhoneNumber;
            dest.PhoneNumberType   = source.PhoneNumberType;
            dest.EmailAddress      = source.EmailAddress;
            dest.Title             = source.Title;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vIndividualCustomer dest, DbModel.vIndividualCustomer source)
        {
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.LastName          = source.LastName;
            dest.EmailPromotion    = source.EmailPromotion;
            dest.AddressType       = source.AddressType;
            dest.AddressLine1      = source.AddressLine1;
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.FirstName         = source.FirstName;
            dest.MiddleName        = source.MiddleName;
            dest.Demographics      = source.Demographics;
            dest.AddressLine2      = source.AddressLine2;
            dest.Suffix            = source.Suffix;
            dest.PhoneNumber       = source.PhoneNumber;
            dest.PhoneNumberType   = source.PhoneNumberType;
            dest.EmailAddress      = source.EmailAddress;
            dest.Title             = source.Title;
        }
        public static void CopyFrom(this DbModel.Product dest, Model.Product source)
        {
            dest.ProductID             = source.ProductID;
            dest.Name                  = source.Name;
            dest.ProductNumber         = source.ProductNumber;
            dest.MakeFlag              = source.MakeFlag;
            dest.FinishedGoodsFlag     = source.FinishedGoodsFlag;
            dest.SafetyStockLevel      = (short)source.SafetyStockLevel;
            dest.ReorderPoint          = (short)source.ReorderPoint;
            dest.StandardCost          = (decimal)source.StandardCost;
            dest.ListPrice             = (decimal)source.ListPrice;
            dest.DaysToManufacture     = source.DaysToManufacture;
            dest.SellStartDate         = source.SellStartDate.ToDateTime();
            dest.Rowguid               =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate          = source.ModifiedDate.ToDateTime();
            dest.SellEndDate           = source.SellEndDate.ToDateTime();
            dest.DiscontinuedDate      = source.DiscontinuedDate.ToDateTime();
            dest.ProductLine           = source.ProductLine;
            dest.Class                 = source.Class;
            dest.Style                 = source.Style;
            dest.ProductSubcategoryID  = source.ProductSubcategoryID;
            dest.ProductModelID        = source.ProductModelID;
            dest.Size                  = source.Size;
            dest.SizeUnitMeasureCode   = source.SizeUnitMeasureCode;
            dest.WeightUnitMeasureCode = source.WeightUnitMeasureCode;
            dest.Weight                = (decimal)source.Weight;
            dest.Color                 = source.Color;
        }
        // ------------------------------
        public static void CopyFrom(this Model.Product dest, DbModel.Product source)
        {
            dest.ProductID             = source.ProductID;
            dest.Name                  = source.Name;
            dest.ProductNumber         = source.ProductNumber;
            dest.MakeFlag              = source.MakeFlag;
            dest.FinishedGoodsFlag     = source.FinishedGoodsFlag;
            dest.SafetyStockLevel      = source.SafetyStockLevel;
            dest.ReorderPoint          = source.ReorderPoint;
            dest.StandardCost          = (double)source.StandardCost;
            dest.ListPrice             = (double)source.ListPrice;
            dest.DaysToManufacture     = source.DaysToManufacture;
            dest.SellStartDate         = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellStartDate);
            dest.Rowguid               =  source.Rowguid.ToString();
            dest.ModifiedDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.SellEndDate           = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellEndDate);
            dest.DiscontinuedDate      = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.DiscontinuedDate);
            dest.ProductLine           = source.ProductLine;
            dest.Class                 = source.Class;
            dest.Style                 = source.Style;
            dest.ProductSubcategoryID  = source.ProductSubcategoryID;
            dest.ProductModelID        = source.ProductModelID;
            dest.Size                  = source.Size;
            dest.SizeUnitMeasureCode   = source.SizeUnitMeasureCode;
            dest.WeightUnitMeasureCode = source.WeightUnitMeasureCode;
            dest.Weight                = (double)source.Weight;
            dest.Color                 = source.Color;
        }
        public static void CopyFrom(this DbModel.vPersonDemographics dest, Model.vPersonDemographics source)
        {
            dest.BusinessEntityID     = source.BusinessEntityID;
            dest.TotalPurchaseYTD     = (decimal)source.TotalPurchaseYTD;
            dest.DateFirstPurchase    = source.DateFirstPurchase.ToDateTime();
            dest.BirthDate            = source.BirthDate.ToDateTime();
            dest.MaritalStatus        = source.MaritalStatus;
            dest.YearlyIncome         = source.YearlyIncome;
            dest.Gender               = source.Gender;
            dest.TotalChildren        = source.TotalChildren;
            dest.NumberChildrenAtHome = source.NumberChildrenAtHome;
            dest.Education            = source.Education;
            dest.Occupation           = source.Occupation;
            dest.HomeOwnerFlag        = source.HomeOwnerFlag;
            dest.NumberCarsOwned      = source.NumberCarsOwned;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vPersonDemographics dest, DbModel.vPersonDemographics source)
        {
            dest.BusinessEntityID     = source.BusinessEntityID;
            dest.TotalPurchaseYTD     = (double)source.TotalPurchaseYTD;
            dest.DateFirstPurchase    = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.DateFirstPurchase);
            dest.BirthDate            = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.BirthDate);
            dest.MaritalStatus        = source.MaritalStatus;
            dest.YearlyIncome         = source.YearlyIncome;
            dest.Gender               = source.Gender;
            dest.TotalChildren        = source.TotalChildren;
            dest.NumberChildrenAtHome = source.NumberChildrenAtHome;
            dest.Education            = source.Education;
            dest.Occupation           = source.Occupation;
            dest.HomeOwnerFlag        = source.HomeOwnerFlag;
            dest.NumberCarsOwned      = source.NumberCarsOwned;
        }
        public static void CopyFrom(this DbModel.vJobCandidate dest, Model.vJobCandidate source)
        {
            dest.JobCandidateID         = source.JobCandidateID;
            dest.ModifiedDate           = source.ModifiedDate.ToDateTime();
            dest.BusinessEntityID       = source.BusinessEntityID;
            dest.NamePrefix             = source.NamePrefix;
            dest.NameFirst              = source.NameFirst;
            dest.NameMiddle             = source.NameMiddle;
            dest.NameLast               = source.NameLast;
            dest.NameSuffix             = source.NameSuffix;
            dest.Skills                 = source.Skills;
            dest.AddrType               = source.AddrType;
            dest.AddrLocCountryRegion   = source.AddrLocCountryRegion;
            dest.AddrLocState           = source.AddrLocState;
            dest.AddrLocCity            = source.AddrLocCity;
            dest.AddrPostalCode         = source.AddrPostalCode;
            dest.EMail                  = source.EMail;
            dest.WebSite                = source.WebSite;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vJobCandidate dest, DbModel.vJobCandidate source)
        {
            dest.JobCandidateID         = source.JobCandidateID;
            dest.ModifiedDate           = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.BusinessEntityID       = source.BusinessEntityID;
            dest.NamePrefix             = source.NamePrefix;
            dest.NameFirst              = source.NameFirst;
            dest.NameMiddle             = source.NameMiddle;
            dest.NameLast               = source.NameLast;
            dest.NameSuffix             = source.NameSuffix;
            dest.Skills                 = source.Skills;
            dest.AddrType               = source.AddrType;
            dest.AddrLocCountryRegion   = source.AddrLocCountryRegion;
            dest.AddrLocState           = source.AddrLocState;
            dest.AddrLocCity            = source.AddrLocCity;
            dest.AddrPostalCode         = source.AddrPostalCode;
            dest.EMail                  = source.EMail;
            dest.WebSite                = source.WebSite;
        }
        public static void CopyFrom(this DbModel.vJobCandidateEmployment dest, Model.vJobCandidateEmployment source)
        {
            dest.JobCandidateID        = source.JobCandidateID;
            dest.EmpStartDate          = source.EmpStartDate.ToDateTime();
            dest.EmpEndDate            = source.EmpEndDate.ToDateTime();
            dest.EmpOrgName            = source.EmpOrgName;
            dest.EmpJobTitle           = source.EmpJobTitle;
            dest.EmpResponsibility     = source.EmpResponsibility;
            dest.EmpFunctionCategory   = source.EmpFunctionCategory;
            dest.EmpIndustryCategory   = source.EmpIndustryCategory;
            dest.EmpLocCountryRegion   = source.EmpLocCountryRegion;
            dest.EmpLocState           = source.EmpLocState;
            dest.EmpLocCity            = source.EmpLocCity;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vJobCandidateEmployment dest, DbModel.vJobCandidateEmployment source)
        {
            dest.JobCandidateID        = source.JobCandidateID;
            dest.EmpStartDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EmpStartDate);
            dest.EmpEndDate            = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EmpEndDate);
            dest.EmpOrgName            = source.EmpOrgName;
            dest.EmpJobTitle           = source.EmpJobTitle;
            dest.EmpResponsibility     = source.EmpResponsibility;
            dest.EmpFunctionCategory   = source.EmpFunctionCategory;
            dest.EmpIndustryCategory   = source.EmpIndustryCategory;
            dest.EmpLocCountryRegion   = source.EmpLocCountryRegion;
            dest.EmpLocState           = source.EmpLocState;
            dest.EmpLocCity            = source.EmpLocCity;
        }
        public static void CopyFrom(this DbModel.vJobCandidateEducation dest, Model.vJobCandidateEducation source)
        {
            dest.JobCandidateID        = source.JobCandidateID;
            dest.EduLevel              = source.EduLevel;
            dest.EduStartDate          = source.EduStartDate.ToDateTime();
            dest.EduEndDate            = source.EduEndDate.ToDateTime();
            dest.EduDegree             = source.EduDegree;
            dest.EduMajor              = source.EduMajor;
            dest.EduMinor              = source.EduMinor;
            dest.EduGPA                = source.EduGPA;
            dest.EduGPAScale           = source.EduGPAScale;
            dest.EduSchool             = source.EduSchool;
            dest.EduLocCountryRegion   = source.EduLocCountryRegion;
            dest.EduLocState           = source.EduLocState;
            dest.EduLocCity            = source.EduLocCity;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vJobCandidateEducation dest, DbModel.vJobCandidateEducation source)
        {
            dest.JobCandidateID        = source.JobCandidateID;
            dest.EduLevel              = source.EduLevel;
            dest.EduStartDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EduStartDate);
            dest.EduEndDate            = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EduEndDate);
            dest.EduDegree             = source.EduDegree;
            dest.EduMajor              = source.EduMajor;
            dest.EduMinor              = source.EduMinor;
            dest.EduGPA                = source.EduGPA;
            dest.EduGPAScale           = source.EduGPAScale;
            dest.EduSchool             = source.EduSchool;
            dest.EduLocCountryRegion   = source.EduLocCountryRegion;
            dest.EduLocState           = source.EduLocState;
            dest.EduLocCity            = source.EduLocCity;
        }
        public static void CopyFrom(this DbModel.vProductAndDescription dest, Model.vProductAndDescription source)
        {
            dest.ProductID    = source.ProductID;
            dest.Name         = source.Name;
            dest.ProductModel = source.ProductModel;
            dest.CultureID    = source.CultureID;
            dest.Description  = source.Description;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vProductAndDescription dest, DbModel.vProductAndDescription source)
        {
            dest.ProductID    = source.ProductID;
            dest.Name         = source.Name;
            dest.ProductModel = source.ProductModel;
            dest.CultureID    = source.CultureID;
            dest.Description  = source.Description;
        }
        public static void CopyFrom(this DbModel.vProductModelCatalogDescription dest, Model.vProductModelCatalogDescription source)
        {
            dest.ProductModelID         = source.ProductModelID;
            dest.Name                   = source.Name;
            dest.Rowguid                =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate           = source.ModifiedDate.ToDateTime();
            dest.Summary                = source.Summary;
            dest.Manufacturer           = source.Manufacturer;
            dest.Copyright              = source.Copyright;
            dest.ProductURL             = source.ProductURL;
            dest.WarrantyPeriod         = source.WarrantyPeriod;
            dest.WarrantyDescription    = source.WarrantyDescription;
            dest.NoOfYears              = source.NoOfYears;
            dest.MaintenanceDescription = source.MaintenanceDescription;
            dest.Wheel                  = source.Wheel;
            dest.Saddle                 = source.Saddle;
            dest.Pedal                  = source.Pedal;
            dest.BikeFrame              = source.BikeFrame;
            dest.Crankset               = source.Crankset;
            dest.PictureAngle           = source.PictureAngle;
            dest.PictureSize            = source.PictureSize;
            dest.ProductPhotoID         = source.ProductPhotoID;
            dest.Material               = source.Material;
            dest.Color                  = source.Color;
            dest.ProductLine            = source.ProductLine;
            dest.Style                  = source.Style;
            dest.RiderExperience        = source.RiderExperience;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vProductModelCatalogDescription dest, DbModel.vProductModelCatalogDescription source)
        {
            dest.ProductModelID         = source.ProductModelID;
            dest.Name                   = source.Name;
            dest.Rowguid                =  source.Rowguid.ToString();
            dest.ModifiedDate           = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.Summary                = source.Summary;
            dest.Manufacturer           = source.Manufacturer;
            dest.Copyright              = source.Copyright;
            dest.ProductURL             = source.ProductURL;
            dest.WarrantyPeriod         = source.WarrantyPeriod;
            dest.WarrantyDescription    = source.WarrantyDescription;
            dest.NoOfYears              = source.NoOfYears;
            dest.MaintenanceDescription = source.MaintenanceDescription;
            dest.Wheel                  = source.Wheel;
            dest.Saddle                 = source.Saddle;
            dest.Pedal                  = source.Pedal;
            dest.BikeFrame              = source.BikeFrame;
            dest.Crankset               = source.Crankset;
            dest.PictureAngle           = source.PictureAngle;
            dest.PictureSize            = source.PictureSize;
            dest.ProductPhotoID         = source.ProductPhotoID;
            dest.Material               = source.Material;
            dest.Color                  = source.Color;
            dest.ProductLine            = source.ProductLine;
            dest.Style                  = source.Style;
            dest.RiderExperience        = source.RiderExperience;
        }
        public static void CopyFrom(this DbModel.vProductModelInstructions dest, Model.vProductModelInstructions source)
        {
            dest.ProductModelID = source.ProductModelID;
            dest.Name           = source.Name;
            dest.Rowguid        =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate   = source.ModifiedDate.ToDateTime();
            dest.Instructions   = source.Instructions;
            dest.LocationID     = source.LocationID;
            dest.SetupHours     = (decimal)source.SetupHours;
            dest.MachineHours   = (decimal)source.MachineHours;
            dest.LaborHours     = (decimal)source.LaborHours;
            dest.LotSize        = source.LotSize;
            dest.Step           = source.Step;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vProductModelInstructions dest, DbModel.vProductModelInstructions source)
        {
            dest.ProductModelID = source.ProductModelID;
            dest.Name           = source.Name;
            dest.Rowguid        =  source.Rowguid.ToString();
            dest.ModifiedDate   = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.Instructions   = source.Instructions;
            dest.LocationID     = source.LocationID;
            dest.SetupHours     = (double)source.SetupHours;
            dest.MachineHours   = (double)source.MachineHours;
            dest.LaborHours     = (double)source.LaborHours;
            dest.LotSize        = source.LotSize;
            dest.Step           = source.Step;
        }
        public static void CopyFrom(this DbModel.vSalesPerson dest, Model.vSalesPerson source)
        {
            dest.EmailPromotion    = source.EmailPromotion;
            dest.AddressLine1      = source.AddressLine1;
            dest.SalesYTD          = (decimal)source.SalesYTD;
            dest.SalesLastYear     = (decimal)source.SalesLastYear;
            dest.JobTitle          = source.JobTitle;
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.FirstName         = source.FirstName;
            dest.LastName          = source.LastName;
            dest.Suffix            = source.Suffix;
            dest.MiddleName        = source.MiddleName;
            dest.Title             = source.Title;
            dest.TerritoryName     = source.TerritoryName;
            dest.TerritoryGroup    = source.TerritoryGroup;
            dest.SalesQuota        = (decimal)source.SalesQuota;
            dest.PhoneNumber       = source.PhoneNumber;
            dest.PhoneNumberType   = source.PhoneNumberType;
            dest.EmailAddress      = source.EmailAddress;
            dest.AddressLine2      = source.AddressLine2;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vSalesPerson dest, DbModel.vSalesPerson source)
        {
            dest.EmailPromotion    = source.EmailPromotion;
            dest.AddressLine1      = source.AddressLine1;
            dest.SalesYTD          = (double)source.SalesYTD;
            dest.SalesLastYear     = (double)source.SalesLastYear;
            dest.JobTitle          = source.JobTitle;
            dest.City              = source.City;
            dest.StateProvinceName = source.StateProvinceName;
            dest.PostalCode        = source.PostalCode;
            dest.CountryRegionName = source.CountryRegionName;
            dest.BusinessEntityID  = source.BusinessEntityID;
            dest.FirstName         = source.FirstName;
            dest.LastName          = source.LastName;
            dest.Suffix            = source.Suffix;
            dest.MiddleName        = source.MiddleName;
            dest.Title             = source.Title;
            dest.TerritoryName     = source.TerritoryName;
            dest.TerritoryGroup    = source.TerritoryGroup;
            dest.SalesQuota        = (double)source.SalesQuota;
            dest.PhoneNumber       = source.PhoneNumber;
            dest.PhoneNumberType   = source.PhoneNumberType;
            dest.EmailAddress      = source.EmailAddress;
            dest.AddressLine2      = source.AddressLine2;
        }
        public static void CopyFrom(this DbModel.SalesTerritoryHistory dest, Model.SalesTerritoryHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.TerritoryID      = source.TerritoryID;
            dest.StartDate        = source.StartDate.ToDateTime();
            dest.Rowguid          =  Guid.Parse(source.Rowguid);
            dest.ModifiedDate     = source.ModifiedDate.ToDateTime();
            dest.EndDate          = source.EndDate.ToDateTime();
        }
        // ------------------------------
        public static void CopyFrom(this Model.SalesTerritoryHistory dest, DbModel.SalesTerritoryHistory source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.TerritoryID      = source.TerritoryID;
            dest.StartDate        = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate);
            dest.Rowguid          =  source.Rowguid.ToString();
            dest.ModifiedDate     = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.ModifiedDate);
            dest.EndDate          = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate);
        }
        public static void CopyFrom(this DbModel.vSalesPersonSalesByFiscalYears dest, Model.vSalesPersonSalesByFiscalYears source)
        {
            dest.JobTitle       = source.JobTitle;
            dest.SalesTerritory = source.SalesTerritory;
            dest.Field2002      = (decimal)source.Field2002;
            dest.Field2003      = (decimal)source.Field2003;
            dest.Field2004      = (decimal)source.Field2004;
            dest.SalesPersonID  = source.SalesPersonID;
            dest.FullName       = source.FullName;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vSalesPersonSalesByFiscalYears dest, DbModel.vSalesPersonSalesByFiscalYears source)
        {
            dest.JobTitle       = source.JobTitle;
            dest.SalesTerritory = source.SalesTerritory;
            dest.Field2002      = (double)source.Field2002;
            dest.Field2003      = (double)source.Field2003;
            dest.Field2004      = (double)source.Field2004;
            dest.SalesPersonID  = source.SalesPersonID;
            dest.FullName       = source.FullName;
        }
        public static void CopyFrom(this DbModel.vStateProvinceCountryRegion dest, Model.vStateProvinceCountryRegion source)
        {
            dest.StateProvinceID         = source.StateProvinceID;
            dest.StateProvinceCode       = source.StateProvinceCode;
            dest.IsOnlyStateProvinceFlag = source.IsOnlyStateProvinceFlag;
            dest.StateProvinceName       = source.StateProvinceName;
            dest.TerritoryID             = source.TerritoryID;
            dest.CountryRegionCode       = source.CountryRegionCode;
            dest.CountryRegionName       = source.CountryRegionName;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vStateProvinceCountryRegion dest, DbModel.vStateProvinceCountryRegion source)
        {
            dest.StateProvinceID         = source.StateProvinceID;
            dest.StateProvinceCode       = source.StateProvinceCode;
            dest.IsOnlyStateProvinceFlag = source.IsOnlyStateProvinceFlag;
            dest.StateProvinceName       = source.StateProvinceName;
            dest.TerritoryID             = source.TerritoryID;
            dest.CountryRegionCode       = source.CountryRegionCode;
            dest.CountryRegionName       = source.CountryRegionName;
        }
        public static void CopyFrom(this DbModel.vStoreWithDemographics dest, Model.vStoreWithDemographics source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.AnnualSales      = (decimal)source.AnnualSales;
            dest.AnnualRevenue    = (decimal)source.AnnualRevenue;
            dest.BankName         = source.BankName;
            dest.BusinessType     = source.BusinessType;
            dest.YearOpened       = source.YearOpened;
            dest.Specialty        = source.Specialty;
            dest.SquareFeet       = source.SquareFeet;
            dest.Brands           = source.Brands;
            dest.Internet         = source.Internet;
            dest.NumberEmployees  = source.NumberEmployees;
        }
        // ------------------------------
        public static void CopyFrom(this Model.vStoreWithDemographics dest, DbModel.vStoreWithDemographics source)
        {
            dest.BusinessEntityID = source.BusinessEntityID;
            dest.Name             = source.Name;
            dest.AnnualSales      = (double)source.AnnualSales;
            dest.AnnualRevenue    = (double)source.AnnualRevenue;
            dest.BankName         = source.BankName;
            dest.BusinessType     = source.BusinessType;
            dest.YearOpened       = source.YearOpened;
            dest.Specialty        = source.Specialty;
            dest.SquareFeet       = source.SquareFeet;
            dest.Brands           = source.Brands;
            dest.Internet         = source.Internet;
            dest.NumberEmployees  = source.NumberEmployees;
        }
    }
}