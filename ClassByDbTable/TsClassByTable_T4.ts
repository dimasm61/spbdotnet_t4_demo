


/** Sales.vStoreWithContacts **/
class vStoreWithContacts
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Name **/
        Name             : string;

        /** ContactType **/
        ContactType      : string;

        /** LastName **/
        LastName         : string;

        /** FirstName **/
        FirstName        : string;

        /** EmailPromotion **/
        EmailPromotion   : number;

        /** MiddleName **/
        MiddleName       : string;

        /** Suffix **/
        Suffix           : string;

        /** PhoneNumber **/
        PhoneNumber      : string;

        /** PhoneNumberType **/
        PhoneNumberType  : string;

        /** EmailAddress **/
        EmailAddress     : string;

        /** Title **/
        Title            : string;

    constructor(
              businessEntityID: number
            , name            : string
            , contactType     : string
            , lastName        : string
            , firstName       : string
            , emailPromotion  : number
            , middleName      : string
            , suffix          : string
            , phoneNumber     : string
            , phoneNumberType : string
            , emailAddress    : string
            , title           : string
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.Name              = name;
        this.ContactType       = contactType;
        this.LastName          = lastName;
        this.FirstName         = firstName;
        this.EmailPromotion    = emailPromotion;
        this.MiddleName        = middleName;
        this.Suffix            = suffix;
        this.PhoneNumber       = phoneNumber;
        this.PhoneNumberType   = phoneNumberType;
        this.EmailAddress      = emailAddress;
        this.Title             = title;
    }
}

/** Production.ScrapReason **/
class ScrapReason
{
        /** ScrapReasonID **/
        ScrapReasonID : number;

        /** Name **/
        Name          : string;

        /** ModifiedDate **/
        ModifiedDate  : number;

    constructor(
              scrapReasonID: number
            , name         : string
            , modifiedDate : number
    )
    {
        this.ScrapReasonID  = scrapReasonID;
        this.Name           = name;
        this.ModifiedDate   = modifiedDate;
    }
}

/** Sales.vStoreWithAddresses **/
class vStoreWithAddresses
{
        /** City **/
        City : string;

        /** StateProvinceName **/
        StateProvinceName : string;

        /** PostalCode **/
        PostalCode        : string;

        /** CountryRegionName **/
        CountryRegionName : string;

        /** BusinessEntityID **/
        BusinessEntityID  : number;

        /** Name **/
        Name              : string;

        /** AddressType **/
        AddressType       : string;

        /** AddressLine1 **/
        AddressLine1      : string;

        /** AddressLine2 **/
        AddressLine2      : string;

    constructor(
              city             : string
            , stateProvinceName: string
            , postalCode       : string
            , countryRegionName: string
            , businessEntityID : number
            , name             : string
            , addressType      : string
            , addressLine1     : string
            , addressLine2     : string
    )
    {
        this.City               = city;
        this.StateProvinceName  = stateProvinceName;
        this.PostalCode         = postalCode;
        this.CountryRegionName  = countryRegionName;
        this.BusinessEntityID   = businessEntityID;
        this.Name               = name;
        this.AddressType        = addressType;
        this.AddressLine1       = addressLine1;
        this.AddressLine2       = addressLine2;
    }
}

/** Purchasing.vVendorWithContacts **/
class vVendorWithContacts
{
        /** EmailPromotion **/
        EmailPromotion : number;

        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Name **/
        Name             : string;

        /** ContactType **/
        ContactType      : string;

        /** FirstName **/
        FirstName        : string;

        /** LastName **/
        LastName         : string;

        /** Suffix **/
        Suffix           : string;

        /** PhoneNumber **/
        PhoneNumber      : string;

        /** PhoneNumberType **/
        PhoneNumberType  : string;

        /** EmailAddress **/
        EmailAddress     : string;

        /** MiddleName **/
        MiddleName       : string;

        /** Title **/
        Title            : string;

    constructor(
              emailPromotion  : number
            , businessEntityID: number
            , name            : string
            , contactType     : string
            , firstName       : string
            , lastName        : string
            , suffix          : string
            , phoneNumber     : string
            , phoneNumberType : string
            , emailAddress    : string
            , middleName      : string
            , title           : string
    )
    {
        this.EmailPromotion    = emailPromotion;
        this.BusinessEntityID  = businessEntityID;
        this.Name              = name;
        this.ContactType       = contactType;
        this.FirstName         = firstName;
        this.LastName          = lastName;
        this.Suffix            = suffix;
        this.PhoneNumber       = phoneNumber;
        this.PhoneNumberType   = phoneNumberType;
        this.EmailAddress      = emailAddress;
        this.MiddleName        = middleName;
        this.Title             = title;
    }
}

/** HumanResources.Shift **/
class Shift
{
        /** ShiftID **/
        ShiftID : number;

        /** Name **/
        Name    : string;

        /** StartTime **/
        StartTime : any;

        /** EndTime **/
        EndTime   : any;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              shiftID     : number
            , name        : string
            , startTime   : any
            , endTime     : any
            , modifiedDate: number
    )
    {
        this.ShiftID       = shiftID;
        this.Name          = name;
        this.StartTime     = startTime;
        this.EndTime       = endTime;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Purchasing.vVendorWithAddresses **/
class vVendorWithAddresses
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Name **/
        Name             : string;

        /** AddressType **/
        AddressType      : string;

        /** AddressLine1 **/
        AddressLine1     : string;

        /** City **/
        City             : string;

        /** StateProvinceName **/
        StateProvinceName : string;

        /** PostalCode **/
        PostalCode        : string;

        /** CountryRegionName **/
        CountryRegionName : string;

        /** AddressLine2 **/
        AddressLine2      : string;

    constructor(
              businessEntityID : number
            , name             : string
            , addressType      : string
            , addressLine1     : string
            , city             : string
            , stateProvinceName: string
            , postalCode       : string
            , countryRegionName: string
            , addressLine2     : string
    )
    {
        this.BusinessEntityID   = businessEntityID;
        this.Name               = name;
        this.AddressType        = addressType;
        this.AddressLine1       = addressLine1;
        this.City               = city;
        this.StateProvinceName  = stateProvinceName;
        this.PostalCode         = postalCode;
        this.CountryRegionName  = countryRegionName;
        this.AddressLine2       = addressLine2;
    }
}

/** Production.ProductCategory **/
class ProductCategory
{
        /** ProductCategoryID **/
        ProductCategoryID : number;

        /** Name **/
        Name              : string;

        /** rowguid **/
        rowguid           : string;

        /** ModifiedDate **/
        ModifiedDate      : number;

    constructor(
              productCategoryID: number
            , name             : string
            , rowguid          : string
            , modifiedDate     : number
    )
    {
        this.ProductCategoryID  = productCategoryID;
        this.Name               = name;
        this.rowguid            = rowguid;
        this.ModifiedDate       = modifiedDate;
    }
}

/** Purchasing.ShipMethod **/
class ShipMethod
{
        /** ShipMethodID **/
        ShipMethodID : number;

        /** Name **/
        Name         : string;

        /** ShipBase **/
        ShipBase     : number;

        /** ShipRate **/
        ShipRate     : number;

        /** rowguid **/
        rowguid      : string;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              shipMethodID: number
            , name        : string
            , shipBase    : number
            , shipRate    : number
            , rowguid     : string
            , modifiedDate: number
    )
    {
        this.ShipMethodID  = shipMethodID;
        this.Name          = name;
        this.ShipBase      = shipBase;
        this.ShipRate      = shipRate;
        this.rowguid       = rowguid;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Production.ProductCostHistory **/
class ProductCostHistory
{
        /** ProductID **/
        ProductID : number;

        /** StartDate **/
        StartDate : number;

        /** StandardCost **/
        StandardCost : number;

        /** ModifiedDate **/
        ModifiedDate : number;

        /** EndDate **/
        EndDate      : number;

    constructor(
              productID   : number
            , startDate   : number
            , standardCost: number
            , modifiedDate: number
            , endDate     : number
    )
    {
        this.ProductID     = productID;
        this.StartDate     = startDate;
        this.StandardCost  = standardCost;
        this.ModifiedDate  = modifiedDate;
        this.EndDate       = endDate;
    }
}

/** Production.ProductDescription **/
class ProductDescription
{
        /** ProductDescriptionID **/
        ProductDescriptionID : number;

        /** Description **/
        Description          : string;

        /** rowguid **/
        rowguid              : string;

        /** ModifiedDate **/
        ModifiedDate         : number;

    constructor(
              productDescriptionID: number
            , description         : string
            , rowguid             : string
            , modifiedDate        : number
    )
    {
        this.ProductDescriptionID  = productDescriptionID;
        this.Description           = description;
        this.rowguid               = rowguid;
        this.ModifiedDate          = modifiedDate;
    }
}

/** Sales.ShoppingCartItem **/
class ShoppingCartItem
{
        /** ShoppingCartItemID **/
        ShoppingCartItemID : number;

        /** ShoppingCartID **/
        ShoppingCartID     : string;

        /** Quantity **/
        Quantity           : number;

        /** ProductID **/
        ProductID          : number;

        /** DateCreated **/
        DateCreated        : number;

        /** ModifiedDate **/
        ModifiedDate       : number;

    constructor(
              shoppingCartItemID: number
            , shoppingCartID    : string
            , quantity          : number
            , productID         : number
            , dateCreated       : number
            , modifiedDate      : number
    )
    {
        this.ShoppingCartItemID  = shoppingCartItemID;
        this.ShoppingCartID      = shoppingCartID;
        this.Quantity            = quantity;
        this.ProductID           = productID;
        this.DateCreated         = dateCreated;
        this.ModifiedDate        = modifiedDate;
    }
}

/** Production.ProductDocument **/
class ProductDocument
{
        /** ProductID **/
        ProductID : number;

        /** DocumentNode **/
        DocumentNode : any;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              productID   : number
            , documentNode: any
            , modifiedDate: number
    )
    {
        this.ProductID     = productID;
        this.DocumentNode  = documentNode;
        this.ModifiedDate  = modifiedDate;
    }
}

/** dbo.DatabaseLog **/
class DatabaseLog
{
        /** TSQL **/
        TSQL : string;

        /** XmlEvent **/
        XmlEvent : string;

        /** DatabaseLogID **/
        DatabaseLogID : number;

        /** PostTime **/
        PostTime      : number;

        /** DatabaseUser **/
        DatabaseUser  : string;

        /** Event **/
        Event         : string;

        /** Schema **/
        Schema        : string;

        /** Object **/
        Object        : string;

    constructor(
              tSQL         : string
            , xmlEvent     : string
            , databaseLogID: number
            , postTime     : number
            , databaseUser : string
            , event        : string
            , schema       : string
            , object       : string
    )
    {
        this.TSQL           = tSQL;
        this.XmlEvent       = xmlEvent;
        this.DatabaseLogID  = databaseLogID;
        this.PostTime       = postTime;
        this.DatabaseUser   = databaseUser;
        this.Event          = event;
        this.Schema         = schema;
        this.Object         = object;
    }
}

/** Production.ProductInventory **/
class ProductInventory
{
        /** ProductID **/
        ProductID : number;

        /** LocationID **/
        LocationID : number;

        /** Shelf **/
        Shelf      : string;

        /** Bin **/
        Bin        : number;

        /** Quantity **/
        Quantity   : number;

        /** rowguid **/
        rowguid    : string;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              productID   : number
            , locationID  : number
            , shelf       : string
            , bin         : number
            , quantity    : number
            , rowguid     : string
            , modifiedDate: number
    )
    {
        this.ProductID     = productID;
        this.LocationID    = locationID;
        this.Shelf         = shelf;
        this.Bin           = bin;
        this.Quantity      = quantity;
        this.rowguid       = rowguid;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Sales.SpecialOffer **/
class SpecialOffer
{
        /** SpecialOfferID **/
        SpecialOfferID : number;

        /** Description **/
        Description    : string;

        /** DiscountPct **/
        DiscountPct    : number;

        /** Type **/
        Type           : string;

        /** Category **/
        Category       : string;

        /** StartDate **/
        StartDate      : number;

        /** EndDate **/
        EndDate        : number;

        /** MinQty **/
        MinQty         : number;

        /** rowguid **/
        rowguid        : string;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** MaxQty **/
        MaxQty         : number;

    constructor(
              specialOfferID: number
            , description   : string
            , discountPct   : number
            , type          : string
            , category      : string
            , startDate     : number
            , endDate       : number
            , minQty        : number
            , rowguid       : string
            , modifiedDate  : number
            , maxQty        : number
    )
    {
        this.SpecialOfferID  = specialOfferID;
        this.Description     = description;
        this.DiscountPct     = discountPct;
        this.Type            = type;
        this.Category        = category;
        this.StartDate       = startDate;
        this.EndDate         = endDate;
        this.MinQty          = minQty;
        this.rowguid         = rowguid;
        this.ModifiedDate    = modifiedDate;
        this.MaxQty          = maxQty;
    }
}

/** dbo.ErrorLog **/
class ErrorLog
{
        /** ErrorLogID **/
        ErrorLogID : number;

        /** ErrorTime **/
        ErrorTime  : number;

        /** UserName **/
        UserName   : string;

        /** ErrorNumber **/
        ErrorNumber : number;

        /** ErrorMessage **/
        ErrorMessage : string;

        /** ErrorSeverity **/
        ErrorSeverity : number;

        /** ErrorState **/
        ErrorState    : number;

        /** ErrorProcedure **/
        ErrorProcedure : string;

        /** ErrorLine **/
        ErrorLine      : number;

    constructor(
              errorLogID    : number
            , errorTime     : number
            , userName      : string
            , errorNumber   : number
            , errorMessage  : string
            , errorSeverity : number
            , errorState    : number
            , errorProcedure: string
            , errorLine     : number
    )
    {
        this.ErrorLogID      = errorLogID;
        this.ErrorTime       = errorTime;
        this.UserName        = userName;
        this.ErrorNumber     = errorNumber;
        this.ErrorMessage    = errorMessage;
        this.ErrorSeverity   = errorSeverity;
        this.ErrorState      = errorState;
        this.ErrorProcedure  = errorProcedure;
        this.ErrorLine       = errorLine;
    }
}

/** Production.ProductListPriceHistory **/
class ProductListPriceHistory
{
        /** ListPrice **/
        ListPrice : number;

        /** ModifiedDate **/
        ModifiedDate : number;

        /** ProductID **/
        ProductID    : number;

        /** StartDate **/
        StartDate    : number;

        /** EndDate **/
        EndDate      : number;

    constructor(
              listPrice   : number
            , modifiedDate: number
            , productID   : number
            , startDate   : number
            , endDate     : number
    )
    {
        this.ListPrice     = listPrice;
        this.ModifiedDate  = modifiedDate;
        this.ProductID     = productID;
        this.StartDate     = startDate;
        this.EndDate       = endDate;
    }
}

/** Person.Address **/
class Address
{
        /** AddressID **/
        AddressID : number;

        /** AddressLine1 **/
        AddressLine1 : string;

        /** City **/
        City         : string;

        /** StateProvinceID **/
        StateProvinceID : number;

        /** PostalCode **/
        PostalCode      : string;

        /** rowguid **/
        rowguid         : string;

        /** ModifiedDate **/
        ModifiedDate    : number;

        /** SpatialLocation **/
        SpatialLocation : any;

        /** AddressLine2 **/
        AddressLine2    : string;

    constructor(
              addressID      : number
            , addressLine1   : string
            , city           : string
            , stateProvinceID: number
            , postalCode     : string
            , rowguid        : string
            , modifiedDate   : number
            , spatialLocation: any
            , addressLine2   : string
    )
    {
        this.AddressID        = addressID;
        this.AddressLine1     = addressLine1;
        this.City             = city;
        this.StateProvinceID  = stateProvinceID;
        this.PostalCode       = postalCode;
        this.rowguid          = rowguid;
        this.ModifiedDate     = modifiedDate;
        this.SpatialLocation  = spatialLocation;
        this.AddressLine2     = addressLine2;
    }
}

/** Sales.SpecialOfferProduct **/
class SpecialOfferProduct
{
        /** SpecialOfferID **/
        SpecialOfferID : number;

        /** ProductID **/
        ProductID      : number;

        /** rowguid **/
        rowguid        : string;

        /** ModifiedDate **/
        ModifiedDate   : number;

    constructor(
              specialOfferID: number
            , productID     : number
            , rowguid       : string
            , modifiedDate  : number
    )
    {
        this.SpecialOfferID  = specialOfferID;
        this.ProductID       = productID;
        this.rowguid         = rowguid;
        this.ModifiedDate    = modifiedDate;
    }
}

/** Production.ProductModel **/
class ProductModel
{
        /** rowguid **/
        rowguid : string;

        /** ModifiedDate **/
        ModifiedDate : number;

        /** ProductModelID **/
        ProductModelID : number;

        /** Name **/
        Name           : string;

        /** CatalogDescription **/
        CatalogDescription : string;

        /** Instructions **/
        Instructions       : string;

    constructor(
              rowguid           : string
            , modifiedDate      : number
            , productModelID    : number
            , name              : string
            , catalogDescription: string
            , instructions      : string
    )
    {
        this.rowguid             = rowguid;
        this.ModifiedDate        = modifiedDate;
        this.ProductModelID      = productModelID;
        this.Name                = name;
        this.CatalogDescription  = catalogDescription;
        this.Instructions        = instructions;
    }
}

/** Person.AddressType **/
class AddressType
{
        /** AddressTypeID **/
        AddressTypeID : number;

        /** Name **/
        Name          : string;

        /** rowguid **/
        rowguid       : string;

        /** ModifiedDate **/
        ModifiedDate  : number;

    constructor(
              addressTypeID: number
            , name         : string
            , rowguid      : string
            , modifiedDate : number
    )
    {
        this.AddressTypeID  = addressTypeID;
        this.Name           = name;
        this.rowguid        = rowguid;
        this.ModifiedDate   = modifiedDate;
    }
}

/** Person.StateProvince **/
class StateProvince
{
        /** StateProvinceID **/
        StateProvinceID : number;

        /** StateProvinceCode **/
        StateProvinceCode : string;

        /** CountryRegionCode **/
        CountryRegionCode : string;

        /** IsOnlyStateProvinceFlag **/
        IsOnlyStateProvinceFlag : number;

        /** Name **/
        Name                    : string;

        /** TerritoryID **/
        TerritoryID             : number;

        /** rowguid **/
        rowguid                 : string;

        /** ModifiedDate **/
        ModifiedDate            : number;

    constructor(
              stateProvinceID        : number
            , stateProvinceCode      : string
            , countryRegionCode      : string
            , isOnlyStateProvinceFlag: number
            , name                   : string
            , territoryID            : number
            , rowguid                : string
            , modifiedDate           : number
    )
    {
        this.StateProvinceID          = stateProvinceID;
        this.StateProvinceCode        = stateProvinceCode;
        this.CountryRegionCode        = countryRegionCode;
        this.IsOnlyStateProvinceFlag  = isOnlyStateProvinceFlag;
        this.Name                     = name;
        this.TerritoryID              = territoryID;
        this.rowguid                  = rowguid;
        this.ModifiedDate             = modifiedDate;
    }
}

/** Production.ProductModelIllustration **/
class ProductModelIllustration
{
        /** ProductModelID **/
        ProductModelID : number;

        /** IllustrationID **/
        IllustrationID : number;

        /** ModifiedDate **/
        ModifiedDate   : number;

    constructor(
              productModelID: number
            , illustrationID: number
            , modifiedDate  : number
    )
    {
        this.ProductModelID  = productModelID;
        this.IllustrationID  = illustrationID;
        this.ModifiedDate    = modifiedDate;
    }
}

/** dbo.AWBuildVersion **/
class AWBuildVersion
{
        /** SystemInformationID **/
        SystemInformationID : number;

        /** Database Version **/
        Database_Version    : string;

        /** VersionDate **/
        VersionDate         : number;

        /** ModifiedDate **/
        ModifiedDate        : number;

    constructor(
              systemInformationID: number
            , database_Version   : string
            , versionDate        : number
            , modifiedDate       : number
    )
    {
        this.SystemInformationID  = systemInformationID;
        this.Database_Version     = database_Version;
        this.VersionDate          = versionDate;
        this.ModifiedDate         = modifiedDate;
    }
}

/** Production.ProductModelProductDescriptionCulture **/
class ProductModelProductDescriptionCulture
{
        /** ProductModelID **/
        ProductModelID : number;

        /** ProductDescriptionID **/
        ProductDescriptionID : number;

        /** CultureID **/
        CultureID            : string;

        /** ModifiedDate **/
        ModifiedDate         : number;

    constructor(
              productModelID      : number
            , productDescriptionID: number
            , cultureID           : string
            , modifiedDate        : number
    )
    {
        this.ProductModelID        = productModelID;
        this.ProductDescriptionID  = productDescriptionID;
        this.CultureID             = cultureID;
        this.ModifiedDate          = modifiedDate;
    }
}

/** Production.BillOfMaterials **/
class BillOfMaterials
{
        /** BillOfMaterialsID **/
        BillOfMaterialsID : number;

        /** UnitMeasureCode **/
        UnitMeasureCode   : string;

        /** BOMLevel **/
        BOMLevel          : number;

        /** PerAssemblyQty **/
        PerAssemblyQty    : number;

        /** ModifiedDate **/
        ModifiedDate      : number;

        /** ComponentID **/
        ComponentID       : number;

        /** StartDate **/
        StartDate         : number;

        /** EndDate **/
        EndDate           : number;

        /** ProductAssemblyID **/
        ProductAssemblyID : number;

    constructor(
              billOfMaterialsID: number
            , unitMeasureCode  : string
            , bOMLevel         : number
            , perAssemblyQty   : number
            , modifiedDate     : number
            , componentID      : number
            , startDate        : number
            , endDate          : number
            , productAssemblyID: number
    )
    {
        this.BillOfMaterialsID  = billOfMaterialsID;
        this.UnitMeasureCode    = unitMeasureCode;
        this.BOMLevel           = bOMLevel;
        this.PerAssemblyQty     = perAssemblyQty;
        this.ModifiedDate       = modifiedDate;
        this.ComponentID        = componentID;
        this.StartDate          = startDate;
        this.EndDate            = endDate;
        this.ProductAssemblyID  = productAssemblyID;
    }
}

/** Sales.Store **/
class Store
{
        /** rowguid **/
        rowguid : string;

        /** ModifiedDate **/
        ModifiedDate : number;

        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Name **/
        Name             : string;

        /** SalesPersonID **/
        SalesPersonID    : number;

        /** Demographics **/
        Demographics     : string;

    constructor(
              rowguid         : string
            , modifiedDate    : number
            , businessEntityID: number
            , name            : string
            , salesPersonID   : number
            , demographics    : string
    )
    {
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
        this.BusinessEntityID  = businessEntityID;
        this.Name              = name;
        this.SalesPersonID     = salesPersonID;
        this.Demographics      = demographics;
    }
}

/** Production.ProductPhoto **/
class ProductPhoto
{
        /** ProductPhotoID **/
        ProductPhotoID : number;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** ThumbNailPhoto **/
        ThumbNailPhoto : number[];

        /** ThumbnailPhotoFileName **/
        ThumbnailPhotoFileName : string;

        /** LargePhoto **/
        LargePhoto             : number[];

        /** LargePhotoFileName **/
        LargePhotoFileName     : string;

    constructor(
              productPhotoID        : number
            , modifiedDate          : number
            , thumbNailPhoto        : number[]
            , thumbnailPhotoFileName: string
            , largePhoto            : number[]
            , largePhotoFileName    : string
    )
    {
        this.ProductPhotoID          = productPhotoID;
        this.ModifiedDate            = modifiedDate;
        this.ThumbNailPhoto          = thumbNailPhoto;
        this.ThumbnailPhotoFileName  = thumbnailPhotoFileName;
        this.LargePhoto              = largePhoto;
        this.LargePhotoFileName      = largePhotoFileName;
    }
}

/** Production.ProductProductPhoto **/
class ProductProductPhoto
{
        /** ProductID **/
        ProductID : number;

        /** ProductPhotoID **/
        ProductPhotoID : number;

        /** Primary **/
        Primary        : number;

        /** ModifiedDate **/
        ModifiedDate   : number;

    constructor(
              productID     : number
            , productPhotoID: number
            , primary       : number
            , modifiedDate  : number
    )
    {
        this.ProductID       = productID;
        this.ProductPhotoID  = productPhotoID;
        this.Primary         = primary;
        this.ModifiedDate    = modifiedDate;
    }
}

/** Production.TransactionHistory **/
class TransactionHistory
{
        /** TransactionID **/
        TransactionID : number;

        /** ProductID **/
        ProductID     : number;

        /** ReferenceOrderID **/
        ReferenceOrderID : number;

        /** ReferenceOrderLineID **/
        ReferenceOrderLineID : number;

        /** TransactionDate **/
        TransactionDate      : number;

        /** TransactionType **/
        TransactionType      : string;

        /** Quantity **/
        Quantity             : number;

        /** ActualCost **/
        ActualCost           : number;

        /** ModifiedDate **/
        ModifiedDate         : number;

    constructor(
              transactionID       : number
            , productID           : number
            , referenceOrderID    : number
            , referenceOrderLineID: number
            , transactionDate     : number
            , transactionType     : string
            , quantity            : number
            , actualCost          : number
            , modifiedDate        : number
    )
    {
        this.TransactionID         = transactionID;
        this.ProductID             = productID;
        this.ReferenceOrderID      = referenceOrderID;
        this.ReferenceOrderLineID  = referenceOrderLineID;
        this.TransactionDate       = transactionDate;
        this.TransactionType       = transactionType;
        this.Quantity              = quantity;
        this.ActualCost            = actualCost;
        this.ModifiedDate          = modifiedDate;
    }
}

/** Production.ProductReview **/
class ProductReview
{
        /** ProductReviewID **/
        ProductReviewID : number;

        /** ProductID **/
        ProductID       : number;

        /** ReviewerName **/
        ReviewerName    : string;

        /** ReviewDate **/
        ReviewDate      : number;

        /** EmailAddress **/
        EmailAddress    : string;

        /** Rating **/
        Rating          : number;

        /** ModifiedDate **/
        ModifiedDate    : number;

        /** Comments **/
        Comments        : string;

    constructor(
              productReviewID: number
            , productID      : number
            , reviewerName   : string
            , reviewDate     : number
            , emailAddress   : string
            , rating         : number
            , modifiedDate   : number
            , comments       : string
    )
    {
        this.ProductReviewID  = productReviewID;
        this.ProductID        = productID;
        this.ReviewerName     = reviewerName;
        this.ReviewDate       = reviewDate;
        this.EmailAddress     = emailAddress;
        this.Rating           = rating;
        this.ModifiedDate     = modifiedDate;
        this.Comments         = comments;
    }
}

/** Person.BusinessEntity **/
class BusinessEntity
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              businessEntityID: number
            , rowguid         : string
            , modifiedDate    : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Production.TransactionHistoryArchive **/
class TransactionHistoryArchive
{
        /** TransactionID **/
        TransactionID : number;

        /** ProductID **/
        ProductID     : number;

        /** ReferenceOrderID **/
        ReferenceOrderID : number;

        /** ReferenceOrderLineID **/
        ReferenceOrderLineID : number;

        /** TransactionDate **/
        TransactionDate      : number;

        /** TransactionType **/
        TransactionType      : string;

        /** Quantity **/
        Quantity             : number;

        /** ActualCost **/
        ActualCost           : number;

        /** ModifiedDate **/
        ModifiedDate         : number;

    constructor(
              transactionID       : number
            , productID           : number
            , referenceOrderID    : number
            , referenceOrderLineID: number
            , transactionDate     : number
            , transactionType     : string
            , quantity            : number
            , actualCost          : number
            , modifiedDate        : number
    )
    {
        this.TransactionID         = transactionID;
        this.ProductID             = productID;
        this.ReferenceOrderID      = referenceOrderID;
        this.ReferenceOrderLineID  = referenceOrderLineID;
        this.TransactionDate       = transactionDate;
        this.TransactionType       = transactionType;
        this.Quantity              = quantity;
        this.ActualCost            = actualCost;
        this.ModifiedDate          = modifiedDate;
    }
}

/** Production.ProductSubcategory **/
class ProductSubcategory
{
        /** ProductSubcategoryID **/
        ProductSubcategoryID : number;

        /** ProductCategoryID **/
        ProductCategoryID    : number;

        /** Name **/
        Name                 : string;

        /** rowguid **/
        rowguid              : string;

        /** ModifiedDate **/
        ModifiedDate         : number;

    constructor(
              productSubcategoryID: number
            , productCategoryID   : number
            , name                : string
            , rowguid             : string
            , modifiedDate        : number
    )
    {
        this.ProductSubcategoryID  = productSubcategoryID;
        this.ProductCategoryID     = productCategoryID;
        this.Name                  = name;
        this.rowguid               = rowguid;
        this.ModifiedDate          = modifiedDate;
    }
}

/** Person.BusinessEntityAddress **/
class BusinessEntityAddress
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** AddressID **/
        AddressID        : number;

        /** AddressTypeID **/
        AddressTypeID    : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              businessEntityID: number
            , addressID       : number
            , addressTypeID   : number
            , rowguid         : string
            , modifiedDate    : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.AddressID         = addressID;
        this.AddressTypeID     = addressTypeID;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Purchasing.ProductVendor **/
class ProductVendor
{
        /** MinOrderQty **/
        MinOrderQty : number;

        /** MaxOrderQty **/
        MaxOrderQty : number;

        /** UnitMeasureCode **/
        UnitMeasureCode : string;

        /** ModifiedDate **/
        ModifiedDate    : number;

        /** ProductID **/
        ProductID       : number;

        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** AverageLeadTime **/
        AverageLeadTime  : number;

        /** StandardPrice **/
        StandardPrice    : number;

        /** LastReceiptCost **/
        LastReceiptCost  : number;

        /** LastReceiptDate **/
        LastReceiptDate  : number;

        /** OnOrderQty **/
        OnOrderQty       : number;

    constructor(
              minOrderQty     : number
            , maxOrderQty     : number
            , unitMeasureCode : string
            , modifiedDate    : number
            , productID       : number
            , businessEntityID: number
            , averageLeadTime : number
            , standardPrice   : number
            , lastReceiptCost : number
            , lastReceiptDate : number
            , onOrderQty      : number
    )
    {
        this.MinOrderQty       = minOrderQty;
        this.MaxOrderQty       = maxOrderQty;
        this.UnitMeasureCode   = unitMeasureCode;
        this.ModifiedDate      = modifiedDate;
        this.ProductID         = productID;
        this.BusinessEntityID  = businessEntityID;
        this.AverageLeadTime   = averageLeadTime;
        this.StandardPrice     = standardPrice;
        this.LastReceiptCost   = lastReceiptCost;
        this.LastReceiptDate   = lastReceiptDate;
        this.OnOrderQty        = onOrderQty;
    }
}

/** Person.BusinessEntityContact **/
class BusinessEntityContact
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** PersonID **/
        PersonID         : number;

        /** ContactTypeID **/
        ContactTypeID    : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              businessEntityID: number
            , personID        : number
            , contactTypeID   : number
            , rowguid         : string
            , modifiedDate    : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.PersonID          = personID;
        this.ContactTypeID     = contactTypeID;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Production.UnitMeasure **/
class UnitMeasure
{
        /** UnitMeasureCode **/
        UnitMeasureCode : string;

        /** Name **/
        Name            : string;

        /** ModifiedDate **/
        ModifiedDate    : number;

    constructor(
              unitMeasureCode: string
            , name           : string
            , modifiedDate   : number
    )
    {
        this.UnitMeasureCode  = unitMeasureCode;
        this.Name             = name;
        this.ModifiedDate     = modifiedDate;
    }
}

/** Purchasing.Vendor **/
class Vendor
{
        /** ModifiedDate **/
        ModifiedDate : number;

        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** AccountNumber **/
        AccountNumber    : string;

        /** Name **/
        Name             : string;

        /** CreditRating **/
        CreditRating     : number;

        /** PreferredVendorStatus **/
        PreferredVendorStatus : number;

        /** ActiveFlag **/
        ActiveFlag            : number;

        /** PurchasingWebServiceURL **/
        PurchasingWebServiceURL : string;

    constructor(
              modifiedDate           : number
            , businessEntityID       : number
            , accountNumber          : string
            , name                   : string
            , creditRating           : number
            , preferredVendorStatus  : number
            , activeFlag             : number
            , purchasingWebServiceURL: string
    )
    {
        this.ModifiedDate             = modifiedDate;
        this.BusinessEntityID         = businessEntityID;
        this.AccountNumber            = accountNumber;
        this.Name                     = name;
        this.CreditRating             = creditRating;
        this.PreferredVendorStatus    = preferredVendorStatus;
        this.ActiveFlag               = activeFlag;
        this.PurchasingWebServiceURL  = purchasingWebServiceURL;
    }
}

/** Person.ContactType **/
class ContactType
{
        /** ContactTypeID **/
        ContactTypeID : number;

        /** Name **/
        Name          : string;

        /** ModifiedDate **/
        ModifiedDate  : number;

    constructor(
              contactTypeID: number
            , name         : string
            , modifiedDate : number
    )
    {
        this.ContactTypeID  = contactTypeID;
        this.Name           = name;
        this.ModifiedDate   = modifiedDate;
    }
}

/** Sales.CountryRegionCurrency **/
class CountryRegionCurrency
{
        /** CountryRegionCode **/
        CountryRegionCode : string;

        /** CurrencyCode **/
        CurrencyCode      : string;

        /** ModifiedDate **/
        ModifiedDate      : number;

    constructor(
              countryRegionCode: string
            , currencyCode     : string
            , modifiedDate     : number
    )
    {
        this.CountryRegionCode  = countryRegionCode;
        this.CurrencyCode       = currencyCode;
        this.ModifiedDate       = modifiedDate;
    }
}

/** Person.CountryRegion **/
class CountryRegion
{
        /** CountryRegionCode **/
        CountryRegionCode : string;

        /** Name **/
        Name              : string;

        /** ModifiedDate **/
        ModifiedDate      : number;

    constructor(
              countryRegionCode: string
            , name             : string
            , modifiedDate     : number
    )
    {
        this.CountryRegionCode  = countryRegionCode;
        this.Name               = name;
        this.ModifiedDate       = modifiedDate;
    }
}

/** Production.WorkOrder **/
class WorkOrder
{
        /** DueDate **/
        DueDate : number;

        /** WorkOrderID **/
        WorkOrderID : number;

        /** ProductID **/
        ProductID   : number;

        /** OrderQty **/
        OrderQty    : number;

        /** StockedQty **/
        StockedQty  : number;

        /** ScrappedQty **/
        ScrappedQty : number;

        /** StartDate **/
        StartDate   : number;

        /** ModifiedDate **/
        ModifiedDate : number;

        /** EndDate **/
        EndDate      : number;

        /** ScrapReasonID **/
        ScrapReasonID : number;

    constructor(
              dueDate      : number
            , workOrderID  : number
            , productID    : number
            , orderQty     : number
            , stockedQty   : number
            , scrappedQty  : number
            , startDate    : number
            , modifiedDate : number
            , endDate      : number
            , scrapReasonID: number
    )
    {
        this.DueDate        = dueDate;
        this.WorkOrderID    = workOrderID;
        this.ProductID      = productID;
        this.OrderQty       = orderQty;
        this.StockedQty     = stockedQty;
        this.ScrappedQty    = scrappedQty;
        this.StartDate      = startDate;
        this.ModifiedDate   = modifiedDate;
        this.EndDate        = endDate;
        this.ScrapReasonID  = scrapReasonID;
    }
}

/** Purchasing.PurchaseOrderDetail **/
class PurchaseOrderDetail
{
        /** PurchaseOrderID **/
        PurchaseOrderID : number;

        /** PurchaseOrderDetailID **/
        PurchaseOrderDetailID : number;

        /** DueDate **/
        DueDate               : number;

        /** OrderQty **/
        OrderQty              : number;

        /** ProductID **/
        ProductID             : number;

        /** UnitPrice **/
        UnitPrice             : number;

        /** LineTotal **/
        LineTotal             : number;

        /** ReceivedQty **/
        ReceivedQty           : number;

        /** RejectedQty **/
        RejectedQty           : number;

        /** StockedQty **/
        StockedQty            : number;

        /** ModifiedDate **/
        ModifiedDate          : number;

    constructor(
              purchaseOrderID      : number
            , purchaseOrderDetailID: number
            , dueDate              : number
            , orderQty             : number
            , productID            : number
            , unitPrice            : number
            , lineTotal            : number
            , receivedQty          : number
            , rejectedQty          : number
            , stockedQty           : number
            , modifiedDate         : number
    )
    {
        this.PurchaseOrderID        = purchaseOrderID;
        this.PurchaseOrderDetailID  = purchaseOrderDetailID;
        this.DueDate                = dueDate;
        this.OrderQty               = orderQty;
        this.ProductID              = productID;
        this.UnitPrice              = unitPrice;
        this.LineTotal              = lineTotal;
        this.ReceivedQty            = receivedQty;
        this.RejectedQty            = rejectedQty;
        this.StockedQty             = stockedQty;
        this.ModifiedDate           = modifiedDate;
    }
}

/** Sales.CreditCard **/
class CreditCard
{
        /** CreditCardID **/
        CreditCardID : number;

        /** CardType **/
        CardType     : string;

        /** CardNumber **/
        CardNumber   : string;

        /** ExpMonth **/
        ExpMonth     : number;

        /** ExpYear **/
        ExpYear      : number;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              creditCardID: number
            , cardType    : string
            , cardNumber  : string
            , expMonth    : number
            , expYear     : number
            , modifiedDate: number
    )
    {
        this.CreditCardID  = creditCardID;
        this.CardType      = cardType;
        this.CardNumber    = cardNumber;
        this.ExpMonth      = expMonth;
        this.ExpYear       = expYear;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Production.Culture **/
class Culture
{
        /** CultureID **/
        CultureID : string;

        /** Name **/
        Name      : string;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              cultureID   : string
            , name        : string
            , modifiedDate: number
    )
    {
        this.CultureID     = cultureID;
        this.Name          = name;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Production.WorkOrderRouting **/
class WorkOrderRouting
{
        /** ModifiedDate **/
        ModifiedDate : number;

        /** WorkOrderID **/
        WorkOrderID  : number;

        /** ProductID **/
        ProductID    : number;

        /** OperationSequence **/
        OperationSequence : number;

        /** LocationID **/
        LocationID        : number;

        /** ScheduledStartDate **/
        ScheduledStartDate : number;

        /** ScheduledEndDate **/
        ScheduledEndDate   : number;

        /** PlannedCost **/
        PlannedCost        : number;

        /** ActualCost **/
        ActualCost         : number;

        /** ActualStartDate **/
        ActualStartDate    : number;

        /** ActualEndDate **/
        ActualEndDate      : number;

        /** ActualResourceHrs **/
        ActualResourceHrs  : number;

    constructor(
              modifiedDate      : number
            , workOrderID       : number
            , productID         : number
            , operationSequence : number
            , locationID        : number
            , scheduledStartDate: number
            , scheduledEndDate  : number
            , plannedCost       : number
            , actualCost        : number
            , actualStartDate   : number
            , actualEndDate     : number
            , actualResourceHrs : number
    )
    {
        this.ModifiedDate        = modifiedDate;
        this.WorkOrderID         = workOrderID;
        this.ProductID           = productID;
        this.OperationSequence   = operationSequence;
        this.LocationID          = locationID;
        this.ScheduledStartDate  = scheduledStartDate;
        this.ScheduledEndDate    = scheduledEndDate;
        this.PlannedCost         = plannedCost;
        this.ActualCost          = actualCost;
        this.ActualStartDate     = actualStartDate;
        this.ActualEndDate       = actualEndDate;
        this.ActualResourceHrs   = actualResourceHrs;
    }
}

/** Sales.Currency **/
class Currency
{
        /** CurrencyCode **/
        CurrencyCode : string;

        /** Name **/
        Name         : string;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              currencyCode: string
            , name        : string
            , modifiedDate: number
    )
    {
        this.CurrencyCode  = currencyCode;
        this.Name          = name;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Purchasing.PurchaseOrderHeader **/
class PurchaseOrderHeader
{
        /** SubTotal **/
        SubTotal : number;

        /** TaxAmt **/
        TaxAmt   : number;

        /** Freight **/
        Freight  : number;

        /** TotalDue **/
        TotalDue : number;

        /** ModifiedDate **/
        ModifiedDate : number;

        /** PurchaseOrderID **/
        PurchaseOrderID : number;

        /** RevisionNumber **/
        RevisionNumber  : number;

        /** Status **/
        Status          : number;

        /** EmployeeID **/
        EmployeeID      : number;

        /** VendorID **/
        VendorID        : number;

        /** ShipMethodID **/
        ShipMethodID    : number;

        /** OrderDate **/
        OrderDate       : number;

        /** ShipDate **/
        ShipDate        : number;

    constructor(
              subTotal       : number
            , taxAmt         : number
            , freight        : number
            , totalDue       : number
            , modifiedDate   : number
            , purchaseOrderID: number
            , revisionNumber : number
            , status         : number
            , employeeID     : number
            , vendorID       : number
            , shipMethodID   : number
            , orderDate      : number
            , shipDate       : number
    )
    {
        this.SubTotal         = subTotal;
        this.TaxAmt           = taxAmt;
        this.Freight          = freight;
        this.TotalDue         = totalDue;
        this.ModifiedDate     = modifiedDate;
        this.PurchaseOrderID  = purchaseOrderID;
        this.RevisionNumber   = revisionNumber;
        this.Status           = status;
        this.EmployeeID       = employeeID;
        this.VendorID         = vendorID;
        this.ShipMethodID     = shipMethodID;
        this.OrderDate        = orderDate;
        this.ShipDate         = shipDate;
    }
}

/** Sales.CurrencyRate **/
class CurrencyRate
{
        /** CurrencyRateID **/
        CurrencyRateID : number;

        /** CurrencyRateDate **/
        CurrencyRateDate : number;

        /** FromCurrencyCode **/
        FromCurrencyCode : string;

        /** ToCurrencyCode **/
        ToCurrencyCode   : string;

        /** AverageRate **/
        AverageRate      : number;

        /** EndOfDayRate **/
        EndOfDayRate     : number;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              currencyRateID  : number
            , currencyRateDate: number
            , fromCurrencyCode: string
            , toCurrencyCode  : string
            , averageRate     : number
            , endOfDayRate    : number
            , modifiedDate    : number
    )
    {
        this.CurrencyRateID    = currencyRateID;
        this.CurrencyRateDate  = currencyRateDate;
        this.FromCurrencyCode  = fromCurrencyCode;
        this.ToCurrencyCode    = toCurrencyCode;
        this.AverageRate       = averageRate;
        this.EndOfDayRate      = endOfDayRate;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Sales.Customer **/
class Customer
{
        /** CustomerID **/
        CustomerID : number;

        /** AccountNumber **/
        AccountNumber : string;

        /** rowguid **/
        rowguid       : string;

        /** ModifiedDate **/
        ModifiedDate  : number;

        /** PersonID **/
        PersonID      : number;

        /** StoreID **/
        StoreID       : number;

        /** TerritoryID **/
        TerritoryID   : number;

    constructor(
              customerID   : number
            , accountNumber: string
            , rowguid      : string
            , modifiedDate : number
            , personID     : number
            , storeID      : number
            , territoryID  : number
    )
    {
        this.CustomerID     = customerID;
        this.AccountNumber  = accountNumber;
        this.rowguid        = rowguid;
        this.ModifiedDate   = modifiedDate;
        this.PersonID       = personID;
        this.StoreID        = storeID;
        this.TerritoryID    = territoryID;
    }
}

/** HumanResources.Department **/
class Department
{
        /** DepartmentID **/
        DepartmentID : number;

        /** Name **/
        Name         : string;

        /** GroupName **/
        GroupName    : string;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              departmentID: number
            , name        : string
            , groupName   : string
            , modifiedDate: number
    )
    {
        this.DepartmentID  = departmentID;
        this.Name          = name;
        this.GroupName     = groupName;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Production.Document **/
class Document
{
        /** rowguid **/
        rowguid : string;

        /** ModifiedDate **/
        ModifiedDate : number;

        /** DocumentNode **/
        DocumentNode : any;

        /** Title **/
        Title        : string;

        /** Owner **/
        Owner        : number;

        /** FolderFlag **/
        FolderFlag   : number;

        /** FileName **/
        FileName     : string;

        /** FileExtension **/
        FileExtension : string;

        /** Revision **/
        Revision      : string;

        /** ChangeNumber **/
        ChangeNumber  : number;

        /** Status **/
        Status        : number;

        /** DocumentSummary **/
        DocumentSummary : string;

        /** Document **/
        DocumentData    : number[];

        /** DocumentLevel **/
        DocumentLevel   : number;

    constructor(
              rowguid        : string
            , modifiedDate   : number
            , documentNode   : any
            , title          : string
            , owner          : number
            , folderFlag     : number
            , fileName       : string
            , fileExtension  : string
            , revision       : string
            , changeNumber   : number
            , status         : number
            , documentSummary: string
            , documentData   : number[]
            , documentLevel  : number
    )
    {
        this.rowguid          = rowguid;
        this.ModifiedDate     = modifiedDate;
        this.DocumentNode     = documentNode;
        this.Title            = title;
        this.Owner            = owner;
        this.FolderFlag       = folderFlag;
        this.FileName         = fileName;
        this.FileExtension    = fileExtension;
        this.Revision         = revision;
        this.ChangeNumber     = changeNumber;
        this.Status           = status;
        this.DocumentSummary  = documentSummary;
        this.DocumentData     = documentData;
        this.DocumentLevel    = documentLevel;
    }
}

/** Sales.SalesOrderDetail **/
class SalesOrderDetail
{
        /** OrderQty **/
        OrderQty : number;

        /** ProductID **/
        ProductID : number;

        /** SpecialOfferID **/
        SpecialOfferID : number;

        /** UnitPrice **/
        UnitPrice      : number;

        /** UnitPriceDiscount **/
        UnitPriceDiscount : number;

        /** LineTotal **/
        LineTotal         : number;

        /** rowguid **/
        rowguid           : string;

        /** ModifiedDate **/
        ModifiedDate      : number;

        /** SalesOrderID **/
        SalesOrderID      : number;

        /** SalesOrderDetailID **/
        SalesOrderDetailID : number;

        /** CarrierTrackingNumber **/
        CarrierTrackingNumber : string;

    constructor(
              orderQty             : number
            , productID            : number
            , specialOfferID       : number
            , unitPrice            : number
            , unitPriceDiscount    : number
            , lineTotal            : number
            , rowguid              : string
            , modifiedDate         : number
            , salesOrderID         : number
            , salesOrderDetailID   : number
            , carrierTrackingNumber: string
    )
    {
        this.OrderQty               = orderQty;
        this.ProductID              = productID;
        this.SpecialOfferID         = specialOfferID;
        this.UnitPrice              = unitPrice;
        this.UnitPriceDiscount      = unitPriceDiscount;
        this.LineTotal              = lineTotal;
        this.rowguid                = rowguid;
        this.ModifiedDate           = modifiedDate;
        this.SalesOrderID           = salesOrderID;
        this.SalesOrderDetailID     = salesOrderDetailID;
        this.CarrierTrackingNumber  = carrierTrackingNumber;
    }
}

/** Person.EmailAddress **/
class EmailAddress
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** EmailAddressID **/
        EmailAddressID   : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

        /** EmailAddress **/
        EmailAddressData : string;

    constructor(
              businessEntityID: number
            , emailAddressID  : number
            , rowguid         : string
            , modifiedDate    : number
            , emailAddressData: string
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.EmailAddressID    = emailAddressID;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
        this.EmailAddressData  = emailAddressData;
    }
}

/** HumanResources.Employee **/
class Employee
{
        /** JobTitle **/
        JobTitle : string;

        /** BirthDate **/
        BirthDate : any;

        /** MaritalStatus **/
        MaritalStatus : string;

        /** Gender **/
        Gender        : string;

        /** HireDate **/
        HireDate      : any;

        /** SalariedFlag **/
        SalariedFlag  : number;

        /** VacationHours **/
        VacationHours : number;

        /** SickLeaveHours **/
        SickLeaveHours : number;

        /** CurrentFlag **/
        CurrentFlag    : number;

        /** rowguid **/
        rowguid        : string;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** NationalIDNumber **/
        NationalIDNumber : string;

        /** LoginID **/
        LoginID          : string;

        /** OrganizationNode **/
        OrganizationNode : any;

        /** OrganizationLevel **/
        OrganizationLevel : number;

    constructor(
              jobTitle         : string
            , birthDate        : any
            , maritalStatus    : string
            , gender           : string
            , hireDate         : any
            , salariedFlag     : number
            , vacationHours    : number
            , sickLeaveHours   : number
            , currentFlag      : number
            , rowguid          : string
            , modifiedDate     : number
            , businessEntityID : number
            , nationalIDNumber : string
            , loginID          : string
            , organizationNode : any
            , organizationLevel: number
    )
    {
        this.JobTitle           = jobTitle;
        this.BirthDate          = birthDate;
        this.MaritalStatus      = maritalStatus;
        this.Gender             = gender;
        this.HireDate           = hireDate;
        this.SalariedFlag       = salariedFlag;
        this.VacationHours      = vacationHours;
        this.SickLeaveHours     = sickLeaveHours;
        this.CurrentFlag        = currentFlag;
        this.rowguid            = rowguid;
        this.ModifiedDate       = modifiedDate;
        this.BusinessEntityID   = businessEntityID;
        this.NationalIDNumber   = nationalIDNumber;
        this.LoginID            = loginID;
        this.OrganizationNode   = organizationNode;
        this.OrganizationLevel  = organizationLevel;
    }
}

/** Sales.SalesOrderHeader **/
class SalesOrderHeader
{
        /** Status **/
        Status : number;

        /** OnlineOrderFlag **/
        OnlineOrderFlag : number;

        /** SalesOrderNumber **/
        SalesOrderNumber : string;

        /** SalesOrderID **/
        SalesOrderID     : number;

        /** RevisionNumber **/
        RevisionNumber   : number;

        /** OrderDate **/
        OrderDate        : number;

        /** DueDate **/
        DueDate          : number;

        /** CustomerID **/
        CustomerID       : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

        /** BillToAddressID **/
        BillToAddressID  : number;

        /** ShipToAddressID **/
        ShipToAddressID  : number;

        /** ShipMethodID **/
        ShipMethodID     : number;

        /** SubTotal **/
        SubTotal         : number;

        /** TaxAmt **/
        TaxAmt           : number;

        /** Freight **/
        Freight          : number;

        /** TotalDue **/
        TotalDue         : number;

        /** Comment **/
        Comment          : string;

        /** CreditCardID **/
        CreditCardID     : number;

        /** CreditCardApprovalCode **/
        CreditCardApprovalCode : string;

        /** CurrencyRateID **/
        CurrencyRateID         : number;

        /** SalesPersonID **/
        SalesPersonID          : number;

        /** TerritoryID **/
        TerritoryID            : number;

        /** ShipDate **/
        ShipDate               : number;

        /** PurchaseOrderNumber **/
        PurchaseOrderNumber    : string;

        /** AccountNumber **/
        AccountNumber          : string;

    constructor(
              status                : number
            , onlineOrderFlag       : number
            , salesOrderNumber      : string
            , salesOrderID          : number
            , revisionNumber        : number
            , orderDate             : number
            , dueDate               : number
            , customerID            : number
            , rowguid               : string
            , modifiedDate          : number
            , billToAddressID       : number
            , shipToAddressID       : number
            , shipMethodID          : number
            , subTotal              : number
            , taxAmt                : number
            , freight               : number
            , totalDue              : number
            , comment               : string
            , creditCardID          : number
            , creditCardApprovalCode: string
            , currencyRateID        : number
            , salesPersonID         : number
            , territoryID           : number
            , shipDate              : number
            , purchaseOrderNumber   : string
            , accountNumber         : string
    )
    {
        this.Status                  = status;
        this.OnlineOrderFlag         = onlineOrderFlag;
        this.SalesOrderNumber        = salesOrderNumber;
        this.SalesOrderID            = salesOrderID;
        this.RevisionNumber          = revisionNumber;
        this.OrderDate               = orderDate;
        this.DueDate                 = dueDate;
        this.CustomerID              = customerID;
        this.rowguid                 = rowguid;
        this.ModifiedDate            = modifiedDate;
        this.BillToAddressID         = billToAddressID;
        this.ShipToAddressID         = shipToAddressID;
        this.ShipMethodID            = shipMethodID;
        this.SubTotal                = subTotal;
        this.TaxAmt                  = taxAmt;
        this.Freight                 = freight;
        this.TotalDue                = totalDue;
        this.Comment                 = comment;
        this.CreditCardID            = creditCardID;
        this.CreditCardApprovalCode  = creditCardApprovalCode;
        this.CurrencyRateID          = currencyRateID;
        this.SalesPersonID           = salesPersonID;
        this.TerritoryID             = territoryID;
        this.ShipDate                = shipDate;
        this.PurchaseOrderNumber     = purchaseOrderNumber;
        this.AccountNumber           = accountNumber;
    }
}

/** HumanResources.EmployeeDepartmentHistory **/
class EmployeeDepartmentHistory
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** DepartmentID **/
        DepartmentID     : number;

        /** ShiftID **/
        ShiftID          : number;

        /** StartDate **/
        StartDate        : any;

        /** ModifiedDate **/
        ModifiedDate     : number;

        /** EndDate **/
        EndDate          : any;

    constructor(
              businessEntityID: number
            , departmentID    : number
            , shiftID         : number
            , startDate       : any
            , modifiedDate    : number
            , endDate         : any
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.DepartmentID      = departmentID;
        this.ShiftID           = shiftID;
        this.StartDate         = startDate;
        this.ModifiedDate      = modifiedDate;
        this.EndDate           = endDate;
    }
}

/** HumanResources.EmployeePayHistory **/
class EmployeePayHistory
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** RateChangeDate **/
        RateChangeDate   : number;

        /** Rate **/
        Rate             : number;

        /** PayFrequency **/
        PayFrequency     : number;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              businessEntityID: number
            , rateChangeDate  : number
            , rate            : number
            , payFrequency    : number
            , modifiedDate    : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.RateChangeDate    = rateChangeDate;
        this.Rate              = rate;
        this.PayFrequency      = payFrequency;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Sales.SalesOrderHeaderSalesReason **/
class SalesOrderHeaderSalesReason
{
        /** SalesOrderID **/
        SalesOrderID : number;

        /** SalesReasonID **/
        SalesReasonID : number;

        /** ModifiedDate **/
        ModifiedDate  : number;

    constructor(
              salesOrderID : number
            , salesReasonID: number
            , modifiedDate : number
    )
    {
        this.SalesOrderID   = salesOrderID;
        this.SalesReasonID  = salesReasonID;
        this.ModifiedDate   = modifiedDate;
    }
}

/** Sales.SalesPerson **/
class SalesPerson
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Bonus **/
        Bonus            : number;

        /** CommissionPct **/
        CommissionPct    : number;

        /** SalesYTD **/
        SalesYTD         : number;

        /** SalesLastYear **/
        SalesLastYear    : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

        /** TerritoryID **/
        TerritoryID      : number;

        /** SalesQuota **/
        SalesQuota       : number;

    constructor(
              businessEntityID: number
            , bonus           : number
            , commissionPct   : number
            , salesYTD        : number
            , salesLastYear   : number
            , rowguid         : string
            , modifiedDate    : number
            , territoryID     : number
            , salesQuota      : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.Bonus             = bonus;
        this.CommissionPct     = commissionPct;
        this.SalesYTD          = salesYTD;
        this.SalesLastYear     = salesLastYear;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
        this.TerritoryID       = territoryID;
        this.SalesQuota        = salesQuota;
    }
}

/** Production.Illustration **/
class Illustration
{
        /** IllustrationID **/
        IllustrationID : number;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** Diagram **/
        Diagram        : string;

    constructor(
              illustrationID: number
            , modifiedDate  : number
            , diagram       : string
    )
    {
        this.IllustrationID  = illustrationID;
        this.ModifiedDate    = modifiedDate;
        this.Diagram         = diagram;
    }
}

/** HumanResources.JobCandidate **/
class JobCandidate
{
        /** JobCandidateID **/
        JobCandidateID : number;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Resume **/
        Resume           : string;

    constructor(
              jobCandidateID  : number
            , modifiedDate    : number
            , businessEntityID: number
            , resume          : string
    )
    {
        this.JobCandidateID    = jobCandidateID;
        this.ModifiedDate      = modifiedDate;
        this.BusinessEntityID  = businessEntityID;
        this.Resume            = resume;
    }
}

/** Production.Location **/
class Location
{
        /** LocationID **/
        LocationID : number;

        /** Name **/
        Name       : string;

        /** CostRate **/
        CostRate   : number;

        /** Availability **/
        Availability : number;

        /** ModifiedDate **/
        ModifiedDate : number;

    constructor(
              locationID  : number
            , name        : string
            , costRate    : number
            , availability: number
            , modifiedDate: number
    )
    {
        this.LocationID    = locationID;
        this.Name          = name;
        this.CostRate      = costRate;
        this.Availability  = availability;
        this.ModifiedDate  = modifiedDate;
    }
}

/** Person.Password **/
class Password
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** PasswordHash **/
        PasswordHash     : string;

        /** PasswordSalt **/
        PasswordSalt     : string;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              businessEntityID: number
            , passwordHash    : string
            , passwordSalt    : string
            , rowguid         : string
            , modifiedDate    : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.PasswordHash      = passwordHash;
        this.PasswordSalt      = passwordSalt;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Sales.SalesPersonQuotaHistory **/
class SalesPersonQuotaHistory
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** QuotaDate **/
        QuotaDate        : number;

        /** SalesQuota **/
        SalesQuota       : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              businessEntityID: number
            , quotaDate       : number
            , salesQuota      : number
            , rowguid         : string
            , modifiedDate    : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.QuotaDate         = quotaDate;
        this.SalesQuota        = salesQuota;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Person.Person **/
class Person
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** PersonType **/
        PersonType       : string;

        /** NameStyle **/
        NameStyle        : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

        /** FirstName **/
        FirstName        : string;

        /** LastName **/
        LastName         : string;

        /** EmailPromotion **/
        EmailPromotion   : number;

        /** AdditionalContactInfo **/
        AdditionalContactInfo : string;

        /** Demographics **/
        Demographics          : string;

        /** Suffix **/
        Suffix                : string;

        /** MiddleName **/
        MiddleName            : string;

        /** Title **/
        Title                 : string;

    constructor(
              businessEntityID     : number
            , personType           : string
            , nameStyle            : number
            , rowguid              : string
            , modifiedDate         : number
            , firstName            : string
            , lastName             : string
            , emailPromotion       : number
            , additionalContactInfo: string
            , demographics         : string
            , suffix               : string
            , middleName           : string
            , title                : string
    )
    {
        this.BusinessEntityID       = businessEntityID;
        this.PersonType             = personType;
        this.NameStyle              = nameStyle;
        this.rowguid                = rowguid;
        this.ModifiedDate           = modifiedDate;
        this.FirstName              = firstName;
        this.LastName               = lastName;
        this.EmailPromotion         = emailPromotion;
        this.AdditionalContactInfo  = additionalContactInfo;
        this.Demographics           = demographics;
        this.Suffix                 = suffix;
        this.MiddleName             = middleName;
        this.Title                  = title;
    }
}

/** Sales.SalesReason **/
class SalesReason
{
        /** SalesReasonID **/
        SalesReasonID : number;

        /** Name **/
        Name          : string;

        /** ReasonType **/
        ReasonType    : string;

        /** ModifiedDate **/
        ModifiedDate  : number;

    constructor(
              salesReasonID: number
            , name         : string
            , reasonType   : string
            , modifiedDate : number
    )
    {
        this.SalesReasonID  = salesReasonID;
        this.Name           = name;
        this.ReasonType     = reasonType;
        this.ModifiedDate   = modifiedDate;
    }
}

/** Sales.SalesTaxRate **/
class SalesTaxRate
{
        /** SalesTaxRateID **/
        SalesTaxRateID : number;

        /** StateProvinceID **/
        StateProvinceID : number;

        /** TaxType **/
        TaxType         : number;

        /** TaxRate **/
        TaxRate         : number;

        /** Name **/
        Name            : string;

        /** rowguid **/
        rowguid         : string;

        /** ModifiedDate **/
        ModifiedDate    : number;

    constructor(
              salesTaxRateID : number
            , stateProvinceID: number
            , taxType        : number
            , taxRate        : number
            , name           : string
            , rowguid        : string
            , modifiedDate   : number
    )
    {
        this.SalesTaxRateID   = salesTaxRateID;
        this.StateProvinceID  = stateProvinceID;
        this.TaxType          = taxType;
        this.TaxRate          = taxRate;
        this.Name             = name;
        this.rowguid          = rowguid;
        this.ModifiedDate     = modifiedDate;
    }
}

/** Sales.PersonCreditCard **/
class PersonCreditCard
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** CreditCardID **/
        CreditCardID     : number;

        /** ModifiedDate **/
        ModifiedDate     : number;

    constructor(
              businessEntityID: number
            , creditCardID    : number
            , modifiedDate    : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.CreditCardID      = creditCardID;
        this.ModifiedDate      = modifiedDate;
    }
}

/** Person.vAdditionalContactInfo **/
class vAdditionalContactInfo
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** FirstName **/
        FirstName        : string;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

        /** LastName **/
        LastName         : string;

        /** TelephoneNumber **/
        TelephoneNumber  : string;

        /** TelephoneSpecialInstructions **/
        TelephoneSpecialInstructions : string;

        /** Street **/
        Street                       : string;

        /** City **/
        City                         : string;

        /** StateProvince **/
        StateProvince                : string;

        /** PostalCode **/
        PostalCode                   : string;

        /** CountryRegion **/
        CountryRegion                : string;

        /** HomeAddressSpecialInstructions **/
        HomeAddressSpecialInstructions : string;

        /** EMailAddress **/
        EMailAddress                   : string;

        /** EMailSpecialInstructions **/
        EMailSpecialInstructions       : string;

        /** EMailTelephoneNumber **/
        EMailTelephoneNumber           : string;

        /** MiddleName **/
        MiddleName                     : string;

    constructor(
              businessEntityID              : number
            , firstName                     : string
            , rowguid                       : string
            , modifiedDate                  : number
            , lastName                      : string
            , telephoneNumber               : string
            , telephoneSpecialInstructions  : string
            , street                        : string
            , city                          : string
            , stateProvince                 : string
            , postalCode                    : string
            , countryRegion                 : string
            , homeAddressSpecialInstructions: string
            , eMailAddress                  : string
            , eMailSpecialInstructions      : string
            , eMailTelephoneNumber          : string
            , middleName                    : string
    )
    {
        this.BusinessEntityID                = businessEntityID;
        this.FirstName                       = firstName;
        this.rowguid                         = rowguid;
        this.ModifiedDate                    = modifiedDate;
        this.LastName                        = lastName;
        this.TelephoneNumber                 = telephoneNumber;
        this.TelephoneSpecialInstructions    = telephoneSpecialInstructions;
        this.Street                          = street;
        this.City                            = city;
        this.StateProvince                   = stateProvince;
        this.PostalCode                      = postalCode;
        this.CountryRegion                   = countryRegion;
        this.HomeAddressSpecialInstructions  = homeAddressSpecialInstructions;
        this.EMailAddress                    = eMailAddress;
        this.EMailSpecialInstructions        = eMailSpecialInstructions;
        this.EMailTelephoneNumber            = eMailTelephoneNumber;
        this.MiddleName                      = middleName;
    }
}

/** Person.PersonPhone **/
class PersonPhone
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** PhoneNumber **/
        PhoneNumber      : string;

        /** PhoneNumberTypeID **/
        PhoneNumberTypeID : number;

        /** ModifiedDate **/
        ModifiedDate      : number;

    constructor(
              businessEntityID : number
            , phoneNumber      : string
            , phoneNumberTypeID: number
            , modifiedDate     : number
    )
    {
        this.BusinessEntityID   = businessEntityID;
        this.PhoneNumber        = phoneNumber;
        this.PhoneNumberTypeID  = phoneNumberTypeID;
        this.ModifiedDate       = modifiedDate;
    }
}

/** HumanResources.vEmployee **/
class vEmployee
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** FirstName **/
        FirstName        : string;

        /** JobTitle **/
        JobTitle         : string;

        /** City **/
        City             : string;

        /** StateProvinceName **/
        StateProvinceName : string;

        /** PostalCode **/
        PostalCode        : string;

        /** CountryRegionName **/
        CountryRegionName : string;

        /** LastName **/
        LastName          : string;

        /** EmailPromotion **/
        EmailPromotion    : number;

        /** AddressLine1 **/
        AddressLine1      : string;

        /** AddressLine2 **/
        AddressLine2      : string;

        /** Suffix **/
        Suffix            : string;

        /** AdditionalContactInfo **/
        AdditionalContactInfo : string;

        /** PhoneNumber **/
        PhoneNumber           : string;

        /** PhoneNumberType **/
        PhoneNumberType       : string;

        /** EmailAddress **/
        EmailAddress          : string;

        /** MiddleName **/
        MiddleName            : string;

        /** Title **/
        Title                 : string;

    constructor(
              businessEntityID     : number
            , firstName            : string
            , jobTitle             : string
            , city                 : string
            , stateProvinceName    : string
            , postalCode           : string
            , countryRegionName    : string
            , lastName             : string
            , emailPromotion       : number
            , addressLine1         : string
            , addressLine2         : string
            , suffix               : string
            , additionalContactInfo: string
            , phoneNumber          : string
            , phoneNumberType      : string
            , emailAddress         : string
            , middleName           : string
            , title                : string
    )
    {
        this.BusinessEntityID       = businessEntityID;
        this.FirstName              = firstName;
        this.JobTitle               = jobTitle;
        this.City                   = city;
        this.StateProvinceName      = stateProvinceName;
        this.PostalCode             = postalCode;
        this.CountryRegionName      = countryRegionName;
        this.LastName               = lastName;
        this.EmailPromotion         = emailPromotion;
        this.AddressLine1           = addressLine1;
        this.AddressLine2           = addressLine2;
        this.Suffix                 = suffix;
        this.AdditionalContactInfo  = additionalContactInfo;
        this.PhoneNumber            = phoneNumber;
        this.PhoneNumberType        = phoneNumberType;
        this.EmailAddress           = emailAddress;
        this.MiddleName             = middleName;
        this.Title                  = title;
    }
}

/** Sales.SalesTerritory **/
class SalesTerritory
{
        /** TerritoryID **/
        TerritoryID : number;

        /** Name **/
        Name        : string;

        /** CountryRegionCode **/
        CountryRegionCode : string;

        /** Group **/
        Group             : string;

        /** SalesYTD **/
        SalesYTD          : number;

        /** SalesLastYear **/
        SalesLastYear     : number;

        /** CostYTD **/
        CostYTD           : number;

        /** CostLastYear **/
        CostLastYear      : number;

        /** rowguid **/
        rowguid           : string;

        /** ModifiedDate **/
        ModifiedDate      : number;

    constructor(
              territoryID      : number
            , name             : string
            , countryRegionCode: string
            , group            : string
            , salesYTD         : number
            , salesLastYear    : number
            , costYTD          : number
            , costLastYear     : number
            , rowguid          : string
            , modifiedDate     : number
    )
    {
        this.TerritoryID        = territoryID;
        this.Name               = name;
        this.CountryRegionCode  = countryRegionCode;
        this.Group              = group;
        this.SalesYTD           = salesYTD;
        this.SalesLastYear      = salesLastYear;
        this.CostYTD            = costYTD;
        this.CostLastYear       = costLastYear;
        this.rowguid            = rowguid;
        this.ModifiedDate       = modifiedDate;
    }
}

/** HumanResources.vEmployeeDepartment **/
class vEmployeeDepartment
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** FirstName **/
        FirstName        : string;

        /** JobTitle **/
        JobTitle         : string;

        /** Department **/
        Department       : string;

        /** GroupName **/
        GroupName        : string;

        /** StartDate **/
        StartDate        : any;

        /** LastName **/
        LastName         : string;

        /** Suffix **/
        Suffix           : string;

        /** MiddleName **/
        MiddleName       : string;

        /** Title **/
        Title            : string;

    constructor(
              businessEntityID: number
            , firstName       : string
            , jobTitle        : string
            , department      : string
            , groupName       : string
            , startDate       : any
            , lastName        : string
            , suffix          : string
            , middleName      : string
            , title           : string
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.FirstName         = firstName;
        this.JobTitle          = jobTitle;
        this.Department        = department;
        this.GroupName         = groupName;
        this.StartDate         = startDate;
        this.LastName          = lastName;
        this.Suffix            = suffix;
        this.MiddleName        = middleName;
        this.Title             = title;
    }
}

/** Person.PhoneNumberType **/
class PhoneNumberType
{
        /** PhoneNumberTypeID **/
        PhoneNumberTypeID : number;

        /** Name **/
        Name              : string;

        /** ModifiedDate **/
        ModifiedDate      : number;

    constructor(
              phoneNumberTypeID: number
            , name             : string
            , modifiedDate     : number
    )
    {
        this.PhoneNumberTypeID  = phoneNumberTypeID;
        this.Name               = name;
        this.ModifiedDate       = modifiedDate;
    }
}

/** HumanResources.vEmployeeDepartmentHistory **/
class vEmployeeDepartmentHistory
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** FirstName **/
        FirstName        : string;

        /** LastName **/
        LastName         : string;

        /** Shift **/
        Shift            : string;

        /** Department **/
        Department       : string;

        /** GroupName **/
        GroupName        : string;

        /** StartDate **/
        StartDate        : any;

        /** EndDate **/
        EndDate          : any;

        /** Suffix **/
        Suffix           : string;

        /** MiddleName **/
        MiddleName       : string;

        /** Title **/
        Title            : string;

    constructor(
              businessEntityID: number
            , firstName       : string
            , lastName        : string
            , shift           : string
            , department      : string
            , groupName       : string
            , startDate       : any
            , endDate         : any
            , suffix          : string
            , middleName      : string
            , title           : string
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.FirstName         = firstName;
        this.LastName          = lastName;
        this.Shift             = shift;
        this.Department        = department;
        this.GroupName         = groupName;
        this.StartDate         = startDate;
        this.EndDate           = endDate;
        this.Suffix            = suffix;
        this.MiddleName        = middleName;
        this.Title             = title;
    }
}

/** Sales.vIndividualCustomer **/
class vIndividualCustomer
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** LastName **/
        LastName         : string;

        /** EmailPromotion **/
        EmailPromotion   : number;

        /** AddressType **/
        AddressType      : string;

        /** AddressLine1 **/
        AddressLine1     : string;

        /** City **/
        City             : string;

        /** StateProvinceName **/
        StateProvinceName : string;

        /** PostalCode **/
        PostalCode        : string;

        /** CountryRegionName **/
        CountryRegionName : string;

        /** FirstName **/
        FirstName         : string;

        /** MiddleName **/
        MiddleName        : string;

        /** Demographics **/
        Demographics      : string;

        /** AddressLine2 **/
        AddressLine2      : string;

        /** Suffix **/
        Suffix            : string;

        /** PhoneNumber **/
        PhoneNumber       : string;

        /** PhoneNumberType **/
        PhoneNumberType   : string;

        /** EmailAddress **/
        EmailAddress      : string;

        /** Title **/
        Title             : string;

    constructor(
              businessEntityID : number
            , lastName         : string
            , emailPromotion   : number
            , addressType      : string
            , addressLine1     : string
            , city             : string
            , stateProvinceName: string
            , postalCode       : string
            , countryRegionName: string
            , firstName        : string
            , middleName       : string
            , demographics     : string
            , addressLine2     : string
            , suffix           : string
            , phoneNumber      : string
            , phoneNumberType  : string
            , emailAddress     : string
            , title            : string
    )
    {
        this.BusinessEntityID   = businessEntityID;
        this.LastName           = lastName;
        this.EmailPromotion     = emailPromotion;
        this.AddressType        = addressType;
        this.AddressLine1       = addressLine1;
        this.City               = city;
        this.StateProvinceName  = stateProvinceName;
        this.PostalCode         = postalCode;
        this.CountryRegionName  = countryRegionName;
        this.FirstName          = firstName;
        this.MiddleName         = middleName;
        this.Demographics       = demographics;
        this.AddressLine2       = addressLine2;
        this.Suffix             = suffix;
        this.PhoneNumber        = phoneNumber;
        this.PhoneNumberType    = phoneNumberType;
        this.EmailAddress       = emailAddress;
        this.Title              = title;
    }
}

/** Production.Product **/
class Product
{
        /** ProductID **/
        ProductID : number;

        /** Name **/
        Name      : string;

        /** ProductNumber **/
        ProductNumber : string;

        /** MakeFlag **/
        MakeFlag      : number;

        /** FinishedGoodsFlag **/
        FinishedGoodsFlag : number;

        /** SafetyStockLevel **/
        SafetyStockLevel  : number;

        /** ReorderPoint **/
        ReorderPoint      : number;

        /** StandardCost **/
        StandardCost      : number;

        /** ListPrice **/
        ListPrice         : number;

        /** DaysToManufacture **/
        DaysToManufacture : number;

        /** SellStartDate **/
        SellStartDate     : number;

        /** rowguid **/
        rowguid           : string;

        /** ModifiedDate **/
        ModifiedDate      : number;

        /** SellEndDate **/
        SellEndDate       : number;

        /** DiscontinuedDate **/
        DiscontinuedDate  : number;

        /** ProductLine **/
        ProductLine       : string;

        /** Class **/
        ClassItem         : string;

        /** Style **/
        Style             : string;

        /** ProductSubcategoryID **/
        ProductSubcategoryID : number;

        /** ProductModelID **/
        ProductModelID       : number;

        /** Size **/
        Size                 : string;

        /** SizeUnitMeasureCode **/
        SizeUnitMeasureCode  : string;

        /** WeightUnitMeasureCode **/
        WeightUnitMeasureCode : string;

        /** Weight **/
        Weight                : number;

        /** Color **/
        Color                 : string;

    constructor(
              productID            : number
            , name                 : string
            , productNumber        : string
            , makeFlag             : number
            , finishedGoodsFlag    : number
            , safetyStockLevel     : number
            , reorderPoint         : number
            , standardCost         : number
            , listPrice            : number
            , daysToManufacture    : number
            , sellStartDate        : number
            , rowguid              : string
            , modifiedDate         : number
            , sellEndDate          : number
            , discontinuedDate     : number
            , productLine          : string
            , classItem            : string
            , style                : string
            , productSubcategoryID : number
            , productModelID       : number
            , size                 : string
            , sizeUnitMeasureCode  : string
            , weightUnitMeasureCode: string
            , weight               : number
            , color                : string
    )
    {
        this.ProductID              = productID;
        this.Name                   = name;
        this.ProductNumber          = productNumber;
        this.MakeFlag               = makeFlag;
        this.FinishedGoodsFlag      = finishedGoodsFlag;
        this.SafetyStockLevel       = safetyStockLevel;
        this.ReorderPoint           = reorderPoint;
        this.StandardCost           = standardCost;
        this.ListPrice              = listPrice;
        this.DaysToManufacture      = daysToManufacture;
        this.SellStartDate          = sellStartDate;
        this.rowguid                = rowguid;
        this.ModifiedDate           = modifiedDate;
        this.SellEndDate            = sellEndDate;
        this.DiscontinuedDate       = discontinuedDate;
        this.ProductLine            = productLine;
        this.ClassItem              = classItem;
        this.Style                  = style;
        this.ProductSubcategoryID   = productSubcategoryID;
        this.ProductModelID         = productModelID;
        this.Size                   = size;
        this.SizeUnitMeasureCode    = sizeUnitMeasureCode;
        this.WeightUnitMeasureCode  = weightUnitMeasureCode;
        this.Weight                 = weight;
        this.Color                  = color;
    }
}

/** Sales.vPersonDemographics **/
class vPersonDemographics
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** TotalPurchaseYTD **/
        TotalPurchaseYTD : number;

        /** DateFirstPurchase **/
        DateFirstPurchase : number;

        /** BirthDate **/
        BirthDate         : number;

        /** MaritalStatus **/
        MaritalStatus     : string;

        /** YearlyIncome **/
        YearlyIncome      : string;

        /** Gender **/
        Gender            : string;

        /** TotalChildren **/
        TotalChildren     : number;

        /** NumberChildrenAtHome **/
        NumberChildrenAtHome : number;

        /** Education **/
        Education            : string;

        /** Occupation **/
        Occupation           : string;

        /** HomeOwnerFlag **/
        HomeOwnerFlag        : number;

        /** NumberCarsOwned **/
        NumberCarsOwned      : number;

    constructor(
              businessEntityID    : number
            , totalPurchaseYTD    : number
            , dateFirstPurchase   : number
            , birthDate           : number
            , maritalStatus       : string
            , yearlyIncome        : string
            , gender              : string
            , totalChildren       : number
            , numberChildrenAtHome: number
            , education           : string
            , occupation          : string
            , homeOwnerFlag       : number
            , numberCarsOwned     : number
    )
    {
        this.BusinessEntityID      = businessEntityID;
        this.TotalPurchaseYTD      = totalPurchaseYTD;
        this.DateFirstPurchase     = dateFirstPurchase;
        this.BirthDate             = birthDate;
        this.MaritalStatus         = maritalStatus;
        this.YearlyIncome          = yearlyIncome;
        this.Gender                = gender;
        this.TotalChildren         = totalChildren;
        this.NumberChildrenAtHome  = numberChildrenAtHome;
        this.Education             = education;
        this.Occupation            = occupation;
        this.HomeOwnerFlag         = homeOwnerFlag;
        this.NumberCarsOwned       = numberCarsOwned;
    }
}

/** HumanResources.vJobCandidate **/
class vJobCandidate
{
        /** JobCandidateID **/
        JobCandidateID : number;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Name.Prefix **/
        Name_Prefix      : string;

        /** Name.First **/
        Name_First       : string;

        /** Name.Middle **/
        Name_Middle      : string;

        /** Name.Last **/
        Name_Last        : string;

        /** Name.Suffix **/
        Name_Suffix      : string;

        /** Skills **/
        Skills           : string;

        /** Addr.Type **/
        Addr_Type        : string;

        /** Addr.Loc.CountryRegion **/
        Addr_Loc_CountryRegion : string;

        /** Addr.Loc.State **/
        Addr_Loc_State         : string;

        /** Addr.Loc.City **/
        Addr_Loc_City          : string;

        /** Addr.PostalCode **/
        Addr_PostalCode        : string;

        /** EMail **/
        EMail                  : string;

        /** WebSite **/
        WebSite                : string;

    constructor(
              jobCandidateID        : number
            , modifiedDate          : number
            , businessEntityID      : number
            , name_Prefix           : string
            , name_First            : string
            , name_Middle           : string
            , name_Last             : string
            , name_Suffix           : string
            , skills                : string
            , addr_Type             : string
            , addr_Loc_CountryRegion: string
            , addr_Loc_State        : string
            , addr_Loc_City         : string
            , addr_PostalCode       : string
            , eMail                 : string
            , webSite               : string
    )
    {
        this.JobCandidateID          = jobCandidateID;
        this.ModifiedDate            = modifiedDate;
        this.BusinessEntityID        = businessEntityID;
        this.Name_Prefix             = name_Prefix;
        this.Name_First              = name_First;
        this.Name_Middle             = name_Middle;
        this.Name_Last               = name_Last;
        this.Name_Suffix             = name_Suffix;
        this.Skills                  = skills;
        this.Addr_Type               = addr_Type;
        this.Addr_Loc_CountryRegion  = addr_Loc_CountryRegion;
        this.Addr_Loc_State          = addr_Loc_State;
        this.Addr_Loc_City           = addr_Loc_City;
        this.Addr_PostalCode         = addr_PostalCode;
        this.EMail                   = eMail;
        this.WebSite                 = webSite;
    }
}

/** HumanResources.vJobCandidateEmployment **/
class vJobCandidateEmployment
{
        /** JobCandidateID **/
        JobCandidateID : number;

        /** Emp.StartDate **/
        Emp_StartDate  : number;

        /** Emp.EndDate **/
        Emp_EndDate    : number;

        /** Emp.OrgName **/
        Emp_OrgName    : string;

        /** Emp.JobTitle **/
        Emp_JobTitle   : string;

        /** Emp.Responsibility **/
        Emp_Responsibility : string;

        /** Emp.FunctionCategory **/
        Emp_FunctionCategory : string;

        /** Emp.IndustryCategory **/
        Emp_IndustryCategory : string;

        /** Emp.Loc.CountryRegion **/
        Emp_Loc_CountryRegion : string;

        /** Emp.Loc.State **/
        Emp_Loc_State         : string;

        /** Emp.Loc.City **/
        Emp_Loc_City          : string;

    constructor(
              jobCandidateID       : number
            , emp_StartDate        : number
            , emp_EndDate          : number
            , emp_OrgName          : string
            , emp_JobTitle         : string
            , emp_Responsibility   : string
            , emp_FunctionCategory : string
            , emp_IndustryCategory : string
            , emp_Loc_CountryRegion: string
            , emp_Loc_State        : string
            , emp_Loc_City         : string
    )
    {
        this.JobCandidateID         = jobCandidateID;
        this.Emp_StartDate          = emp_StartDate;
        this.Emp_EndDate            = emp_EndDate;
        this.Emp_OrgName            = emp_OrgName;
        this.Emp_JobTitle           = emp_JobTitle;
        this.Emp_Responsibility     = emp_Responsibility;
        this.Emp_FunctionCategory   = emp_FunctionCategory;
        this.Emp_IndustryCategory   = emp_IndustryCategory;
        this.Emp_Loc_CountryRegion  = emp_Loc_CountryRegion;
        this.Emp_Loc_State          = emp_Loc_State;
        this.Emp_Loc_City           = emp_Loc_City;
    }
}

/** HumanResources.vJobCandidateEducation **/
class vJobCandidateEducation
{
        /** JobCandidateID **/
        JobCandidateID : number;

        /** Edu.Level **/
        Edu_Level      : string;

        /** Edu.StartDate **/
        Edu_StartDate  : number;

        /** Edu.EndDate **/
        Edu_EndDate    : number;

        /** Edu.Degree **/
        Edu_Degree     : string;

        /** Edu.Major **/
        Edu_Major      : string;

        /** Edu.Minor **/
        Edu_Minor      : string;

        /** Edu.GPA **/
        Edu_GPA        : string;

        /** Edu.GPAScale **/
        Edu_GPAScale   : string;

        /** Edu.School **/
        Edu_School     : string;

        /** Edu.Loc.CountryRegion **/
        Edu_Loc_CountryRegion : string;

        /** Edu.Loc.State **/
        Edu_Loc_State         : string;

        /** Edu.Loc.City **/
        Edu_Loc_City          : string;

    constructor(
              jobCandidateID       : number
            , edu_Level            : string
            , edu_StartDate        : number
            , edu_EndDate          : number
            , edu_Degree           : string
            , edu_Major            : string
            , edu_Minor            : string
            , edu_GPA              : string
            , edu_GPAScale         : string
            , edu_School           : string
            , edu_Loc_CountryRegion: string
            , edu_Loc_State        : string
            , edu_Loc_City         : string
    )
    {
        this.JobCandidateID         = jobCandidateID;
        this.Edu_Level              = edu_Level;
        this.Edu_StartDate          = edu_StartDate;
        this.Edu_EndDate            = edu_EndDate;
        this.Edu_Degree             = edu_Degree;
        this.Edu_Major              = edu_Major;
        this.Edu_Minor              = edu_Minor;
        this.Edu_GPA                = edu_GPA;
        this.Edu_GPAScale           = edu_GPAScale;
        this.Edu_School             = edu_School;
        this.Edu_Loc_CountryRegion  = edu_Loc_CountryRegion;
        this.Edu_Loc_State          = edu_Loc_State;
        this.Edu_Loc_City           = edu_Loc_City;
    }
}

/** Production.vProductAndDescription **/
class vProductAndDescription
{
        /** ProductID **/
        ProductID : number;

        /** Name **/
        Name      : string;

        /** ProductModel **/
        ProductModel : string;

        /** CultureID **/
        CultureID    : string;

        /** Description **/
        Description  : string;

    constructor(
              productID   : number
            , name        : string
            , productModel: string
            , cultureID   : string
            , description : string
    )
    {
        this.ProductID     = productID;
        this.Name          = name;
        this.ProductModel  = productModel;
        this.CultureID     = cultureID;
        this.Description   = description;
    }
}

/** Production.vProductModelCatalogDescription **/
class vProductModelCatalogDescription
{
        /** ProductModelID **/
        ProductModelID : number;

        /** Name **/
        Name           : string;

        /** rowguid **/
        rowguid        : string;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** Summary **/
        Summary        : string;

        /** Manufacturer **/
        Manufacturer   : string;

        /** Copyright **/
        Copyright      : string;

        /** ProductURL **/
        ProductURL     : string;

        /** WarrantyPeriod **/
        WarrantyPeriod : string;

        /** WarrantyDescription **/
        WarrantyDescription : string;

        /** NoOfYears **/
        NoOfYears           : string;

        /** MaintenanceDescription **/
        MaintenanceDescription : string;

        /** Wheel **/
        Wheel                  : string;

        /** Saddle **/
        Saddle                 : string;

        /** Pedal **/
        Pedal                  : string;

        /** BikeFrame **/
        BikeFrame              : string;

        /** Crankset **/
        Crankset               : string;

        /** PictureAngle **/
        PictureAngle           : string;

        /** PictureSize **/
        PictureSize            : string;

        /** ProductPhotoID **/
        ProductPhotoID         : string;

        /** Material **/
        Material               : string;

        /** Color **/
        Color                  : string;

        /** ProductLine **/
        ProductLine            : string;

        /** Style **/
        Style                  : string;

        /** RiderExperience **/
        RiderExperience        : string;

    constructor(
              productModelID        : number
            , name                  : string
            , rowguid               : string
            , modifiedDate          : number
            , summary               : string
            , manufacturer          : string
            , copyright             : string
            , productURL            : string
            , warrantyPeriod        : string
            , warrantyDescription   : string
            , noOfYears             : string
            , maintenanceDescription: string
            , wheel                 : string
            , saddle                : string
            , pedal                 : string
            , bikeFrame             : string
            , crankset              : string
            , pictureAngle          : string
            , pictureSize           : string
            , productPhotoID        : string
            , material              : string
            , color                 : string
            , productLine           : string
            , style                 : string
            , riderExperience       : string
    )
    {
        this.ProductModelID          = productModelID;
        this.Name                    = name;
        this.rowguid                 = rowguid;
        this.ModifiedDate            = modifiedDate;
        this.Summary                 = summary;
        this.Manufacturer            = manufacturer;
        this.Copyright               = copyright;
        this.ProductURL              = productURL;
        this.WarrantyPeriod          = warrantyPeriod;
        this.WarrantyDescription     = warrantyDescription;
        this.NoOfYears               = noOfYears;
        this.MaintenanceDescription  = maintenanceDescription;
        this.Wheel                   = wheel;
        this.Saddle                  = saddle;
        this.Pedal                   = pedal;
        this.BikeFrame               = bikeFrame;
        this.Crankset                = crankset;
        this.PictureAngle            = pictureAngle;
        this.PictureSize             = pictureSize;
        this.ProductPhotoID          = productPhotoID;
        this.Material                = material;
        this.Color                   = color;
        this.ProductLine             = productLine;
        this.Style                   = style;
        this.RiderExperience         = riderExperience;
    }
}

/** Production.vProductModelInstructions **/
class vProductModelInstructions
{
        /** ProductModelID **/
        ProductModelID : number;

        /** Name **/
        Name           : string;

        /** rowguid **/
        rowguid        : string;

        /** ModifiedDate **/
        ModifiedDate   : number;

        /** Instructions **/
        Instructions   : string;

        /** LocationID **/
        LocationID     : number;

        /** SetupHours **/
        SetupHours     : number;

        /** MachineHours **/
        MachineHours   : number;

        /** LaborHours **/
        LaborHours     : number;

        /** LotSize **/
        LotSize        : number;

        /** Step **/
        Step           : string;

    constructor(
              productModelID: number
            , name          : string
            , rowguid       : string
            , modifiedDate  : number
            , instructions  : string
            , locationID    : number
            , setupHours    : number
            , machineHours  : number
            , laborHours    : number
            , lotSize       : number
            , step          : string
    )
    {
        this.ProductModelID  = productModelID;
        this.Name            = name;
        this.rowguid         = rowguid;
        this.ModifiedDate    = modifiedDate;
        this.Instructions    = instructions;
        this.LocationID      = locationID;
        this.SetupHours      = setupHours;
        this.MachineHours    = machineHours;
        this.LaborHours      = laborHours;
        this.LotSize         = lotSize;
        this.Step            = step;
    }
}

/** Sales.vSalesPerson **/
class vSalesPerson
{
        /** EmailPromotion **/
        EmailPromotion : number;

        /** AddressLine1 **/
        AddressLine1   : string;

        /** SalesYTD **/
        SalesYTD       : number;

        /** SalesLastYear **/
        SalesLastYear  : number;

        /** JobTitle **/
        JobTitle       : string;

        /** City **/
        City           : string;

        /** StateProvinceName **/
        StateProvinceName : string;

        /** PostalCode **/
        PostalCode        : string;

        /** CountryRegionName **/
        CountryRegionName : string;

        /** BusinessEntityID **/
        BusinessEntityID  : number;

        /** FirstName **/
        FirstName         : string;

        /** LastName **/
        LastName          : string;

        /** Suffix **/
        Suffix            : string;

        /** MiddleName **/
        MiddleName        : string;

        /** Title **/
        Title             : string;

        /** TerritoryName **/
        TerritoryName     : string;

        /** TerritoryGroup **/
        TerritoryGroup    : string;

        /** SalesQuota **/
        SalesQuota        : number;

        /** PhoneNumber **/
        PhoneNumber       : string;

        /** PhoneNumberType **/
        PhoneNumberType   : string;

        /** EmailAddress **/
        EmailAddress      : string;

        /** AddressLine2 **/
        AddressLine2      : string;

    constructor(
              emailPromotion   : number
            , addressLine1     : string
            , salesYTD         : number
            , salesLastYear    : number
            , jobTitle         : string
            , city             : string
            , stateProvinceName: string
            , postalCode       : string
            , countryRegionName: string
            , businessEntityID : number
            , firstName        : string
            , lastName         : string
            , suffix           : string
            , middleName       : string
            , title            : string
            , territoryName    : string
            , territoryGroup   : string
            , salesQuota       : number
            , phoneNumber      : string
            , phoneNumberType  : string
            , emailAddress     : string
            , addressLine2     : string
    )
    {
        this.EmailPromotion     = emailPromotion;
        this.AddressLine1       = addressLine1;
        this.SalesYTD           = salesYTD;
        this.SalesLastYear      = salesLastYear;
        this.JobTitle           = jobTitle;
        this.City               = city;
        this.StateProvinceName  = stateProvinceName;
        this.PostalCode         = postalCode;
        this.CountryRegionName  = countryRegionName;
        this.BusinessEntityID   = businessEntityID;
        this.FirstName          = firstName;
        this.LastName           = lastName;
        this.Suffix             = suffix;
        this.MiddleName         = middleName;
        this.Title              = title;
        this.TerritoryName      = territoryName;
        this.TerritoryGroup     = territoryGroup;
        this.SalesQuota         = salesQuota;
        this.PhoneNumber        = phoneNumber;
        this.PhoneNumberType    = phoneNumberType;
        this.EmailAddress       = emailAddress;
        this.AddressLine2       = addressLine2;
    }
}

/** Sales.SalesTerritoryHistory **/
class SalesTerritoryHistory
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** TerritoryID **/
        TerritoryID      : number;

        /** StartDate **/
        StartDate        : number;

        /** rowguid **/
        rowguid          : string;

        /** ModifiedDate **/
        ModifiedDate     : number;

        /** EndDate **/
        EndDate          : number;

    constructor(
              businessEntityID: number
            , territoryID     : number
            , startDate       : number
            , rowguid         : string
            , modifiedDate    : number
            , endDate         : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.TerritoryID       = territoryID;
        this.StartDate         = startDate;
        this.rowguid           = rowguid;
        this.ModifiedDate      = modifiedDate;
        this.EndDate           = endDate;
    }
}

/** Sales.vSalesPersonSalesByFiscalYears **/
class vSalesPersonSalesByFiscalYears
{
        /** JobTitle **/
        JobTitle : string;

        /** SalesTerritory **/
        SalesTerritory : string;

        /** 2002 **/
        field2002      : number;

        /** 2003 **/
        field2003      : number;

        /** 2004 **/
        field2004      : number;

        /** SalesPersonID **/
        SalesPersonID  : number;

        /** FullName **/
        FullName       : string;

    constructor(
              jobTitle      : string
            , salesTerritory: string
            , field2002     : number
            , field2003     : number
            , field2004     : number
            , salesPersonID : number
            , fullName      : string
    )
    {
        this.JobTitle        = jobTitle;
        this.SalesTerritory  = salesTerritory;
        this.field2002       = field2002;
        this.field2003       = field2003;
        this.field2004       = field2004;
        this.SalesPersonID   = salesPersonID;
        this.FullName        = fullName;
    }
}

/** Person.vStateProvinceCountryRegion **/
class vStateProvinceCountryRegion
{
        /** StateProvinceID **/
        StateProvinceID : number;

        /** StateProvinceCode **/
        StateProvinceCode : string;

        /** IsOnlyStateProvinceFlag **/
        IsOnlyStateProvinceFlag : number;

        /** StateProvinceName **/
        StateProvinceName       : string;

        /** TerritoryID **/
        TerritoryID             : number;

        /** CountryRegionCode **/
        CountryRegionCode       : string;

        /** CountryRegionName **/
        CountryRegionName       : string;

    constructor(
              stateProvinceID        : number
            , stateProvinceCode      : string
            , isOnlyStateProvinceFlag: number
            , stateProvinceName      : string
            , territoryID            : number
            , countryRegionCode      : string
            , countryRegionName      : string
    )
    {
        this.StateProvinceID          = stateProvinceID;
        this.StateProvinceCode        = stateProvinceCode;
        this.IsOnlyStateProvinceFlag  = isOnlyStateProvinceFlag;
        this.StateProvinceName        = stateProvinceName;
        this.TerritoryID              = territoryID;
        this.CountryRegionCode        = countryRegionCode;
        this.CountryRegionName        = countryRegionName;
    }
}

/** Sales.vStoreWithDemographics **/
class vStoreWithDemographics
{
        /** BusinessEntityID **/
        BusinessEntityID : number;

        /** Name **/
        Name             : string;

        /** AnnualSales **/
        AnnualSales      : number;

        /** AnnualRevenue **/
        AnnualRevenue    : number;

        /** BankName **/
        BankName         : string;

        /** BusinessType **/
        BusinessType     : string;

        /** YearOpened **/
        YearOpened       : number;

        /** Specialty **/
        Specialty        : string;

        /** SquareFeet **/
        SquareFeet       : number;

        /** Brands **/
        Brands           : string;

        /** Internet **/
        Internet         : string;

        /** NumberEmployees **/
        NumberEmployees  : number;

    constructor(
              businessEntityID: number
            , name            : string
            , annualSales     : number
            , annualRevenue   : number
            , bankName        : string
            , businessType    : string
            , yearOpened      : number
            , specialty       : string
            , squareFeet      : number
            , brands          : string
            , internet        : string
            , numberEmployees : number
    )
    {
        this.BusinessEntityID  = businessEntityID;
        this.Name              = name;
        this.AnnualSales       = annualSales;
        this.AnnualRevenue     = annualRevenue;
        this.BankName          = bankName;
        this.BusinessType      = businessType;
        this.YearOpened        = yearOpened;
        this.Specialty         = specialty;
        this.SquareFeet        = squareFeet;
        this.Brands            = brands;
        this.Internet          = internet;
        this.NumberEmployees   = numberEmployees;
    }
}
