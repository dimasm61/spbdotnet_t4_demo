


using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace gRpcService.DbModel
{


    [Table("vStoreWithContacts", Schema = "Sales")]
    public partial class vStoreWithContacts
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ContactType")]
        public  string ContactType { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"EmailPromotion")]
        public  int EmailPromotion { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"PhoneNumber")]
        public  string PhoneNumber { get; set; }

        [Column(name:"PhoneNumberType")]
        public  string PhoneNumberType { get; set; }

        [Column(name:"EmailAddress")]
        public  string EmailAddress { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

    }

    [Table("ScrapReason", Schema = "Production")]
    public partial class ScrapReason
    {
        [Column(name:"ScrapReasonID")]
        public  short ScrapReasonID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("vStoreWithAddresses", Schema = "Sales")]
    public partial class vStoreWithAddresses
    {
        [Column(name:"City")]
        public  string City { get; set; }

        [Column(name:"StateProvinceName")]
        public  string StateProvinceName { get; set; }

        [Column(name:"PostalCode")]
        public  string PostalCode { get; set; }

        [Column(name:"CountryRegionName")]
        public  string CountryRegionName { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"AddressType")]
        public  string AddressType { get; set; }

        [Column(name:"AddressLine1")]
        public  string AddressLine1 { get; set; }

        [Column(name:"AddressLine2")]
        public  string AddressLine2 { get; set; }

    }

    [Table("vVendorWithContacts", Schema = "Purchasing")]
    public partial class vVendorWithContacts
    {
        [Column(name:"EmailPromotion")]
        public  int EmailPromotion { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ContactType")]
        public  string ContactType { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"PhoneNumber")]
        public  string PhoneNumber { get; set; }

        [Column(name:"PhoneNumberType")]
        public  string PhoneNumberType { get; set; }

        [Column(name:"EmailAddress")]
        public  string EmailAddress { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

    }

    [Table("Shift", Schema = "HumanResources")]
    public partial class Shift
    {
        [Column(name:"ShiftID")]
        public  byte ShiftID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"StartTime")]
        public  DateTime StartTime { get; set; }

        [Column(name:"EndTime")]
        public  DateTime EndTime { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("vVendorWithAddresses", Schema = "Purchasing")]
    public partial class vVendorWithAddresses
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"AddressType")]
        public  string AddressType { get; set; }

        [Column(name:"AddressLine1")]
        public  string AddressLine1 { get; set; }

        [Column(name:"City")]
        public  string City { get; set; }

        [Column(name:"StateProvinceName")]
        public  string StateProvinceName { get; set; }

        [Column(name:"PostalCode")]
        public  string PostalCode { get; set; }

        [Column(name:"CountryRegionName")]
        public  string CountryRegionName { get; set; }

        [Column(name:"AddressLine2")]
        public  string AddressLine2 { get; set; }

    }

    [Table("ProductCategory", Schema = "Production")]
    public partial class ProductCategory
    {
        [Column(name:"ProductCategoryID")]
        public  int ProductCategoryID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ShipMethod", Schema = "Purchasing")]
    public partial class ShipMethod
    {
        [Column(name:"ShipMethodID")]
        public  int ShipMethodID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ShipBase")]
        public  decimal ShipBase { get; set; }

        [Column(name:"ShipRate")]
        public  decimal ShipRate { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductCostHistory", Schema = "Production")]
    public partial class ProductCostHistory
    {
        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"StandardCost")]
        public  decimal StandardCost { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

    }

    [Table("ProductDescription", Schema = "Production")]
    public partial class ProductDescription
    {
        [Column(name:"ProductDescriptionID")]
        public  int ProductDescriptionID { get; set; }

        [Column(name:"Description")]
        public  string Description { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ShoppingCartItem", Schema = "Sales")]
    public partial class ShoppingCartItem
    {
        [Column(name:"ShoppingCartItemID")]
        public  int ShoppingCartItemID { get; set; }

        [Column(name:"ShoppingCartID")]
        public  string ShoppingCartID { get; set; }

        [Column(name:"Quantity")]
        public  int Quantity { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"DateCreated")]
        public  DateTime DateCreated { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductDocument", Schema = "Production")]
    public partial class ProductDocument
    {
        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"DocumentNode")]
        public  byte[] DocumentNode { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("DatabaseLog", Schema = "dbo")]
    public partial class DatabaseLog
    {
        [Column(name:"TSQL")]
        public  string TSQL { get; set; }

        [Column(name:"XmlEvent")]
        public  string XmlEvent { get; set; }

        [Column(name:"DatabaseLogID")]
        public  int DatabaseLogID { get; set; }

        [Column(name:"PostTime")]
        public  DateTime PostTime { get; set; }

        [Column(name:"DatabaseUser")]
        public  string DatabaseUser { get; set; }

        [Column(name:"Event")]
        public  string Event { get; set; }

        [Column(name:"Schema")]
        public  string Schema { get; set; }

        [Column(name:"Object")]
        public  string Object { get; set; }

    }

    [Table("ProductInventory", Schema = "Production")]
    public partial class ProductInventory
    {
        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"LocationID")]
        public  short LocationID { get; set; }

        [Column(name:"Shelf")]
        public  string Shelf { get; set; }

        [Column(name:"Bin")]
        public  byte Bin { get; set; }

        [Column(name:"Quantity")]
        public  short Quantity { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("SpecialOffer", Schema = "Sales")]
    public partial class SpecialOffer
    {
        [Column(name:"SpecialOfferID")]
        public  int SpecialOfferID { get; set; }

        [Column(name:"Description")]
        public  string Description { get; set; }

        [Column(name:"DiscountPct")]
        public  decimal DiscountPct { get; set; }

        [Column(name:"Type")]
        public  string Type { get; set; }

        [Column(name:"Category")]
        public  string Category { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

        [Column(name:"MinQty")]
        public  int MinQty { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"MaxQty")]
        public  int MaxQty { get; set; }

    }

    [Table("ErrorLog", Schema = "dbo")]
    public partial class ErrorLog
    {
        [Column(name:"ErrorLogID")]
        public  int ErrorLogID { get; set; }

        [Column(name:"ErrorTime")]
        public  DateTime ErrorTime { get; set; }

        [Column(name:"UserName")]
        public  string UserName { get; set; }

        [Column(name:"ErrorNumber")]
        public  int ErrorNumber { get; set; }

        [Column(name:"ErrorMessage")]
        public  string ErrorMessage { get; set; }

        [Column(name:"ErrorSeverity")]
        public  int ErrorSeverity { get; set; }

        [Column(name:"ErrorState")]
        public  int ErrorState { get; set; }

        [Column(name:"ErrorProcedure")]
        public  string ErrorProcedure { get; set; }

        [Column(name:"ErrorLine")]
        public  int ErrorLine { get; set; }

    }

    [Table("ProductListPriceHistory", Schema = "Production")]
    public partial class ProductListPriceHistory
    {
        [Column(name:"ListPrice")]
        public  decimal ListPrice { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

    }

    [Table("Address", Schema = "Person")]
    public partial class Address
    {
        [Column(name:"AddressID")]
        public  int AddressID { get; set; }

        [Column(name:"AddressLine1")]
        public  string AddressLine1 { get; set; }

        [Column(name:"City")]
        public  string City { get; set; }

        [Column(name:"StateProvinceID")]
        public  int StateProvinceID { get; set; }

        [Column(name:"PostalCode")]
        public  string PostalCode { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"SpatialLocation")]
        public  byte[] SpatialLocation { get; set; }

        [Column(name:"AddressLine2")]
        public  string AddressLine2 { get; set; }

    }

    [Table("SpecialOfferProduct", Schema = "Sales")]
    public partial class SpecialOfferProduct
    {
        [Column(name:"SpecialOfferID")]
        public  int SpecialOfferID { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductModel", Schema = "Production")]
    public partial class ProductModel
    {
        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"ProductModelID")]
        public  int ProductModelID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"CatalogDescription")]
        public  string CatalogDescription { get; set; }

        [Column(name:"Instructions")]
        public  string Instructions { get; set; }

    }

    [Table("AddressType", Schema = "Person")]
    public partial class AddressType
    {
        [Column(name:"AddressTypeID")]
        public  int AddressTypeID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("StateProvince", Schema = "Person")]
    public partial class StateProvince
    {
        [Column(name:"StateProvinceID")]
        public  int StateProvinceID { get; set; }

        [Column(name:"StateProvinceCode")]
        public  string StateProvinceCode { get; set; }

        [Column(name:"CountryRegionCode")]
        public  string CountryRegionCode { get; set; }

        [Column(name:"IsOnlyStateProvinceFlag")]
        public  bool IsOnlyStateProvinceFlag { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"TerritoryID")]
        public  int TerritoryID { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductModelIllustration", Schema = "Production")]
    public partial class ProductModelIllustration
    {
        [Column(name:"ProductModelID")]
        public  int ProductModelID { get; set; }

        [Column(name:"IllustrationID")]
        public  int IllustrationID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("AWBuildVersion", Schema = "dbo")]
    public partial class AWBuildVersion
    {
        [Column(name:"SystemInformationID")]
        public  byte SystemInformationID { get; set; }

        [Column(name:"Database Version")]
        public  string DatabaseVersion { get; set; }

        [Column(name:"VersionDate")]
        public  DateTime VersionDate { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductModelProductDescriptionCulture", Schema = "Production")]
    public partial class ProductModelProductDescriptionCulture
    {
        [Column(name:"ProductModelID")]
        public  int ProductModelID { get; set; }

        [Column(name:"ProductDescriptionID")]
        public  int ProductDescriptionID { get; set; }

        [Column(name:"CultureID")]
        public  string CultureID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("BillOfMaterials", Schema = "Production")]
    public partial class BillOfMaterials
    {
        [Column(name:"BillOfMaterialsID")]
        public  int BillOfMaterialsID { get; set; }

        [Column(name:"UnitMeasureCode")]
        public  string UnitMeasureCode { get; set; }

        [Column(name:"BOMLevel")]
        public  short BOMLevel { get; set; }

        [Column(name:"PerAssemblyQty")]
        public  decimal PerAssemblyQty { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"ComponentID")]
        public  int ComponentID { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

        [Column(name:"ProductAssemblyID")]
        public  int ProductAssemblyID { get; set; }

    }

    [Table("Store", Schema = "Sales")]
    public partial class Store
    {
        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"SalesPersonID")]
        public  int SalesPersonID { get; set; }

        [Column(name:"Demographics")]
        public  string Demographics { get; set; }

    }

    [Table("ProductPhoto", Schema = "Production")]
    public partial class ProductPhoto
    {
        [Column(name:"ProductPhotoID")]
        public  int ProductPhotoID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"ThumbNailPhoto")]
        public  byte[] ThumbNailPhoto { get; set; }

        [Column(name:"ThumbnailPhotoFileName")]
        public  string ThumbnailPhotoFileName { get; set; }

        [Column(name:"LargePhoto")]
        public  byte[] LargePhoto { get; set; }

        [Column(name:"LargePhotoFileName")]
        public  string LargePhotoFileName { get; set; }

    }

    [Table("ProductProductPhoto", Schema = "Production")]
    public partial class ProductProductPhoto
    {
        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"ProductPhotoID")]
        public  int ProductPhotoID { get; set; }

        [Column(name:"Primary")]
        public  bool Primary { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("TransactionHistory", Schema = "Production")]
    public partial class TransactionHistory
    {
        [Column(name:"TransactionID")]
        public  int TransactionID { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"ReferenceOrderID")]
        public  int ReferenceOrderID { get; set; }

        [Column(name:"ReferenceOrderLineID")]
        public  int ReferenceOrderLineID { get; set; }

        [Column(name:"TransactionDate")]
        public  DateTime TransactionDate { get; set; }

        [Column(name:"TransactionType")]
        public  string TransactionType { get; set; }

        [Column(name:"Quantity")]
        public  int Quantity { get; set; }

        [Column(name:"ActualCost")]
        public  decimal ActualCost { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductReview", Schema = "Production")]
    public partial class ProductReview
    {
        [Column(name:"ProductReviewID")]
        public  int ProductReviewID { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"ReviewerName")]
        public  string ReviewerName { get; set; }

        [Column(name:"ReviewDate")]
        public  DateTime ReviewDate { get; set; }

        [Column(name:"EmailAddress")]
        public  string EmailAddress { get; set; }

        [Column(name:"Rating")]
        public  int Rating { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"Comments")]
        public  string Comments { get; set; }

    }

    [Table("BusinessEntity", Schema = "Person")]
    public partial class BusinessEntity
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("TransactionHistoryArchive", Schema = "Production")]
    public partial class TransactionHistoryArchive
    {
        [Column(name:"TransactionID")]
        public  int TransactionID { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"ReferenceOrderID")]
        public  int ReferenceOrderID { get; set; }

        [Column(name:"ReferenceOrderLineID")]
        public  int ReferenceOrderLineID { get; set; }

        [Column(name:"TransactionDate")]
        public  DateTime TransactionDate { get; set; }

        [Column(name:"TransactionType")]
        public  string TransactionType { get; set; }

        [Column(name:"Quantity")]
        public  int Quantity { get; set; }

        [Column(name:"ActualCost")]
        public  decimal ActualCost { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductSubcategory", Schema = "Production")]
    public partial class ProductSubcategory
    {
        [Column(name:"ProductSubcategoryID")]
        public  int ProductSubcategoryID { get; set; }

        [Column(name:"ProductCategoryID")]
        public  int ProductCategoryID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("BusinessEntityAddress", Schema = "Person")]
    public partial class BusinessEntityAddress
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"AddressID")]
        public  int AddressID { get; set; }

        [Column(name:"AddressTypeID")]
        public  int AddressTypeID { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("ProductVendor", Schema = "Purchasing")]
    public partial class ProductVendor
    {
        [Column(name:"MinOrderQty")]
        public  int MinOrderQty { get; set; }

        [Column(name:"MaxOrderQty")]
        public  int MaxOrderQty { get; set; }

        [Column(name:"UnitMeasureCode")]
        public  string UnitMeasureCode { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"AverageLeadTime")]
        public  int AverageLeadTime { get; set; }

        [Column(name:"StandardPrice")]
        public  decimal StandardPrice { get; set; }

        [Column(name:"LastReceiptCost")]
        public  decimal LastReceiptCost { get; set; }

        [Column(name:"LastReceiptDate")]
        public  DateTime LastReceiptDate { get; set; }

        [Column(name:"OnOrderQty")]
        public  int OnOrderQty { get; set; }

    }

    [Table("BusinessEntityContact", Schema = "Person")]
    public partial class BusinessEntityContact
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"PersonID")]
        public  int PersonID { get; set; }

        [Column(name:"ContactTypeID")]
        public  int ContactTypeID { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("UnitMeasure", Schema = "Production")]
    public partial class UnitMeasure
    {
        [Column(name:"UnitMeasureCode")]
        public  string UnitMeasureCode { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("Vendor", Schema = "Purchasing")]
    public partial class Vendor
    {
        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"AccountNumber")]
        public  string AccountNumber { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"CreditRating")]
        public  byte CreditRating { get; set; }

        [Column(name:"PreferredVendorStatus")]
        public  bool PreferredVendorStatus { get; set; }

        [Column(name:"ActiveFlag")]
        public  bool ActiveFlag { get; set; }

        [Column(name:"PurchasingWebServiceURL")]
        public  string PurchasingWebServiceURL { get; set; }

    }

    [Table("ContactType", Schema = "Person")]
    public partial class ContactType
    {
        [Column(name:"ContactTypeID")]
        public  int ContactTypeID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("CountryRegionCurrency", Schema = "Sales")]
    public partial class CountryRegionCurrency
    {
        [Column(name:"CountryRegionCode")]
        public  string CountryRegionCode { get; set; }

        [Column(name:"CurrencyCode")]
        public  string CurrencyCode { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("CountryRegion", Schema = "Person")]
    public partial class CountryRegion
    {
        [Column(name:"CountryRegionCode")]
        public  string CountryRegionCode { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("WorkOrder", Schema = "Production")]
    public partial class WorkOrder
    {
        [Column(name:"DueDate")]
        public  DateTime DueDate { get; set; }

        [Column(name:"WorkOrderID")]
        public  int WorkOrderID { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"OrderQty")]
        public  int OrderQty { get; set; }

        [Column(name:"StockedQty")]
        public  int StockedQty { get; set; }

        [Column(name:"ScrappedQty")]
        public  short ScrappedQty { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

        [Column(name:"ScrapReasonID")]
        public  short ScrapReasonID { get; set; }

    }

    [Table("PurchaseOrderDetail", Schema = "Purchasing")]
    public partial class PurchaseOrderDetail
    {
        [Column(name:"PurchaseOrderID")]
        public  int PurchaseOrderID { get; set; }

        [Column(name:"PurchaseOrderDetailID")]
        public  int PurchaseOrderDetailID { get; set; }

        [Column(name:"DueDate")]
        public  DateTime DueDate { get; set; }

        [Column(name:"OrderQty")]
        public  short OrderQty { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"UnitPrice")]
        public  decimal UnitPrice { get; set; }

        [Column(name:"LineTotal")]
        public  decimal LineTotal { get; set; }

        [Column(name:"ReceivedQty")]
        public  decimal ReceivedQty { get; set; }

        [Column(name:"RejectedQty")]
        public  decimal RejectedQty { get; set; }

        [Column(name:"StockedQty")]
        public  decimal StockedQty { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("CreditCard", Schema = "Sales")]
    public partial class CreditCard
    {
        [Column(name:"CreditCardID")]
        public  int CreditCardID { get; set; }

        [Column(name:"CardType")]
        public  string CardType { get; set; }

        [Column(name:"CardNumber")]
        public  string CardNumber { get; set; }

        [Column(name:"ExpMonth")]
        public  byte ExpMonth { get; set; }

        [Column(name:"ExpYear")]
        public  short ExpYear { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("Culture", Schema = "Production")]
    public partial class Culture
    {
        [Column(name:"CultureID")]
        public  string CultureID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("WorkOrderRouting", Schema = "Production")]
    public partial class WorkOrderRouting
    {
        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"WorkOrderID")]
        public  int WorkOrderID { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"OperationSequence")]
        public  short OperationSequence { get; set; }

        [Column(name:"LocationID")]
        public  short LocationID { get; set; }

        [Column(name:"ScheduledStartDate")]
        public  DateTime ScheduledStartDate { get; set; }

        [Column(name:"ScheduledEndDate")]
        public  DateTime ScheduledEndDate { get; set; }

        [Column(name:"PlannedCost")]
        public  decimal PlannedCost { get; set; }

        [Column(name:"ActualCost")]
        public  decimal ActualCost { get; set; }

        [Column(name:"ActualStartDate")]
        public  DateTime ActualStartDate { get; set; }

        [Column(name:"ActualEndDate")]
        public  DateTime ActualEndDate { get; set; }

        [Column(name:"ActualResourceHrs")]
        public  decimal ActualResourceHrs { get; set; }

    }

    [Table("Currency", Schema = "Sales")]
    public partial class Currency
    {
        [Column(name:"CurrencyCode")]
        public  string CurrencyCode { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("PurchaseOrderHeader", Schema = "Purchasing")]
    public partial class PurchaseOrderHeader
    {
        [Column(name:"SubTotal")]
        public  decimal SubTotal { get; set; }

        [Column(name:"TaxAmt")]
        public  decimal TaxAmt { get; set; }

        [Column(name:"Freight")]
        public  decimal Freight { get; set; }

        [Column(name:"TotalDue")]
        public  decimal TotalDue { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"PurchaseOrderID")]
        public  int PurchaseOrderID { get; set; }

        [Column(name:"RevisionNumber")]
        public  byte RevisionNumber { get; set; }

        [Column(name:"Status")]
        public  byte Status { get; set; }

        [Column(name:"EmployeeID")]
        public  int EmployeeID { get; set; }

        [Column(name:"VendorID")]
        public  int VendorID { get; set; }

        [Column(name:"ShipMethodID")]
        public  int ShipMethodID { get; set; }

        [Column(name:"OrderDate")]
        public  DateTime OrderDate { get; set; }

        [Column(name:"ShipDate")]
        public  DateTime ShipDate { get; set; }

    }

    [Table("CurrencyRate", Schema = "Sales")]
    public partial class CurrencyRate
    {
        [Column(name:"CurrencyRateID")]
        public  int CurrencyRateID { get; set; }

        [Column(name:"CurrencyRateDate")]
        public  DateTime CurrencyRateDate { get; set; }

        [Column(name:"FromCurrencyCode")]
        public  string FromCurrencyCode { get; set; }

        [Column(name:"ToCurrencyCode")]
        public  string ToCurrencyCode { get; set; }

        [Column(name:"AverageRate")]
        public  decimal AverageRate { get; set; }

        [Column(name:"EndOfDayRate")]
        public  decimal EndOfDayRate { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("Customer", Schema = "Sales")]
    public partial class Customer
    {
        [Column(name:"CustomerID")]
        public  int CustomerID { get; set; }

        [Column(name:"AccountNumber")]
        public  string AccountNumber { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"PersonID")]
        public  int PersonID { get; set; }

        [Column(name:"StoreID")]
        public  int StoreID { get; set; }

        [Column(name:"TerritoryID")]
        public  int TerritoryID { get; set; }

    }

    [Table("Department", Schema = "HumanResources")]
    public partial class Department
    {
        [Column(name:"DepartmentID")]
        public  short DepartmentID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"GroupName")]
        public  string GroupName { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("Document", Schema = "Production")]
    public partial class Document
    {
        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"DocumentNode")]
        public  byte[] DocumentNode { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

        [Column(name:"Owner")]
        public  int Owner { get; set; }

        [Column(name:"FolderFlag")]
        public  bool FolderFlag { get; set; }

        [Column(name:"FileName")]
        public  string FileName { get; set; }

        [Column(name:"FileExtension")]
        public  string FileExtension { get; set; }

        [Column(name:"Revision")]
        public  string Revision { get; set; }

        [Column(name:"ChangeNumber")]
        public  int ChangeNumber { get; set; }

        [Column(name:"Status")]
        public  byte Status { get; set; }

        [Column(name:"DocumentSummary")]
        public  string DocumentSummary { get; set; }

        [Column(name:"Document")]
        public  byte[] DocumentData { get; set; }

        [Column(name:"DocumentLevel")]
        public  short DocumentLevel { get; set; }

    }

    [Table("SalesOrderDetail", Schema = "Sales")]
    public partial class SalesOrderDetail
    {
        [Column(name:"OrderQty")]
        public  short OrderQty { get; set; }

        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"SpecialOfferID")]
        public  int SpecialOfferID { get; set; }

        [Column(name:"UnitPrice")]
        public  decimal UnitPrice { get; set; }

        [Column(name:"UnitPriceDiscount")]
        public  decimal UnitPriceDiscount { get; set; }

        [Column(name:"LineTotal")]
        public  double LineTotal { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"SalesOrderID")]
        public  int SalesOrderID { get; set; }

        [Column(name:"SalesOrderDetailID")]
        public  int SalesOrderDetailID { get; set; }

        [Column(name:"CarrierTrackingNumber")]
        public  string CarrierTrackingNumber { get; set; }

    }

    [Table("EmailAddress", Schema = "Person")]
    public partial class EmailAddress
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"EmailAddressID")]
        public  int EmailAddressID { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"EmailAddress")]
        public  string EmailAddressData { get; set; }

    }

    [Table("Employee", Schema = "HumanResources")]
    public partial class Employee
    {
        [Column(name:"JobTitle")]
        public  string JobTitle { get; set; }

        [Column(name:"BirthDate")]
        public  DateTime BirthDate { get; set; }

        [Column(name:"MaritalStatus")]
        public  string MaritalStatus { get; set; }

        [Column(name:"Gender")]
        public  string Gender { get; set; }

        [Column(name:"HireDate")]
        public  DateTime HireDate { get; set; }

        [Column(name:"SalariedFlag")]
        public  bool SalariedFlag { get; set; }

        [Column(name:"VacationHours")]
        public  short VacationHours { get; set; }

        [Column(name:"SickLeaveHours")]
        public  short SickLeaveHours { get; set; }

        [Column(name:"CurrentFlag")]
        public  bool CurrentFlag { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"NationalIDNumber")]
        public  string NationalIDNumber { get; set; }

        [Column(name:"LoginID")]
        public  string LoginID { get; set; }

        [Column(name:"OrganizationNode")]
        public  byte[] OrganizationNode { get; set; }

        [Column(name:"OrganizationLevel")]
        public  short OrganizationLevel { get; set; }

    }

    [Table("SalesOrderHeader", Schema = "Sales")]
    public partial class SalesOrderHeader
    {
        [Column(name:"Status")]
        public  byte Status { get; set; }

        [Column(name:"OnlineOrderFlag")]
        public  bool OnlineOrderFlag { get; set; }

        [Column(name:"SalesOrderNumber")]
        public  string SalesOrderNumber { get; set; }

        [Column(name:"SalesOrderID")]
        public  int SalesOrderID { get; set; }

        [Column(name:"RevisionNumber")]
        public  byte RevisionNumber { get; set; }

        [Column(name:"OrderDate")]
        public  DateTime OrderDate { get; set; }

        [Column(name:"DueDate")]
        public  DateTime DueDate { get; set; }

        [Column(name:"CustomerID")]
        public  int CustomerID { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"BillToAddressID")]
        public  int BillToAddressID { get; set; }

        [Column(name:"ShipToAddressID")]
        public  int ShipToAddressID { get; set; }

        [Column(name:"ShipMethodID")]
        public  int ShipMethodID { get; set; }

        [Column(name:"SubTotal")]
        public  decimal SubTotal { get; set; }

        [Column(name:"TaxAmt")]
        public  decimal TaxAmt { get; set; }

        [Column(name:"Freight")]
        public  decimal Freight { get; set; }

        [Column(name:"TotalDue")]
        public  decimal TotalDue { get; set; }

        [Column(name:"Comment")]
        public  string Comment { get; set; }

        [Column(name:"CreditCardID")]
        public  int CreditCardID { get; set; }

        [Column(name:"CreditCardApprovalCode")]
        public  string CreditCardApprovalCode { get; set; }

        [Column(name:"CurrencyRateID")]
        public  int CurrencyRateID { get; set; }

        [Column(name:"SalesPersonID")]
        public  int SalesPersonID { get; set; }

        [Column(name:"TerritoryID")]
        public  int TerritoryID { get; set; }

        [Column(name:"ShipDate")]
        public  DateTime ShipDate { get; set; }

        [Column(name:"PurchaseOrderNumber")]
        public  string PurchaseOrderNumber { get; set; }

        [Column(name:"AccountNumber")]
        public  string AccountNumber { get; set; }

    }

    [Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
    public partial class EmployeeDepartmentHistory
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"DepartmentID")]
        public  short DepartmentID { get; set; }

        [Column(name:"ShiftID")]
        public  byte ShiftID { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

    }

    [Table("EmployeePayHistory", Schema = "HumanResources")]
    public partial class EmployeePayHistory
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"RateChangeDate")]
        public  DateTime RateChangeDate { get; set; }

        [Column(name:"Rate")]
        public  decimal Rate { get; set; }

        [Column(name:"PayFrequency")]
        public  byte PayFrequency { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
    public partial class SalesOrderHeaderSalesReason
    {
        [Column(name:"SalesOrderID")]
        public  int SalesOrderID { get; set; }

        [Column(name:"SalesReasonID")]
        public  int SalesReasonID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("SalesPerson", Schema = "Sales")]
    public partial class SalesPerson
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Bonus")]
        public  decimal Bonus { get; set; }

        [Column(name:"CommissionPct")]
        public  decimal CommissionPct { get; set; }

        [Column(name:"SalesYTD")]
        public  decimal SalesYTD { get; set; }

        [Column(name:"SalesLastYear")]
        public  decimal SalesLastYear { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"TerritoryID")]
        public  int TerritoryID { get; set; }

        [Column(name:"SalesQuota")]
        public  decimal SalesQuota { get; set; }

    }

    [Table("Illustration", Schema = "Production")]
    public partial class Illustration
    {
        [Column(name:"IllustrationID")]
        public  int IllustrationID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"Diagram")]
        public  string Diagram { get; set; }

    }

    [Table("JobCandidate", Schema = "HumanResources")]
    public partial class JobCandidate
    {
        [Column(name:"JobCandidateID")]
        public  int JobCandidateID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Resume")]
        public  string Resume { get; set; }

    }

    [Table("Location", Schema = "Production")]
    public partial class Location
    {
        [Column(name:"LocationID")]
        public  short LocationID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"CostRate")]
        public  decimal CostRate { get; set; }

        [Column(name:"Availability")]
        public  decimal Availability { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("Password", Schema = "Person")]
    public partial class Password
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"PasswordHash")]
        public  string PasswordHash { get; set; }

        [Column(name:"PasswordSalt")]
        public  string PasswordSalt { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("SalesPersonQuotaHistory", Schema = "Sales")]
    public partial class SalesPersonQuotaHistory
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"QuotaDate")]
        public  DateTime QuotaDate { get; set; }

        [Column(name:"SalesQuota")]
        public  decimal SalesQuota { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("Person", Schema = "Person")]
    public partial class Person
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"PersonType")]
        public  string PersonType { get; set; }

        [Column(name:"NameStyle")]
        public  bool NameStyle { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"EmailPromotion")]
        public  int EmailPromotion { get; set; }

        [Column(name:"AdditionalContactInfo")]
        public  string AdditionalContactInfo { get; set; }

        [Column(name:"Demographics")]
        public  string Demographics { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

    }

    [Table("SalesReason", Schema = "Sales")]
    public partial class SalesReason
    {
        [Column(name:"SalesReasonID")]
        public  int SalesReasonID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ReasonType")]
        public  string ReasonType { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("SalesTaxRate", Schema = "Sales")]
    public partial class SalesTaxRate
    {
        [Column(name:"SalesTaxRateID")]
        public  int SalesTaxRateID { get; set; }

        [Column(name:"StateProvinceID")]
        public  int StateProvinceID { get; set; }

        [Column(name:"TaxType")]
        public  byte TaxType { get; set; }

        [Column(name:"TaxRate")]
        public  decimal TaxRate { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("PersonCreditCard", Schema = "Sales")]
    public partial class PersonCreditCard
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"CreditCardID")]
        public  int CreditCardID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("vAdditionalContactInfo", Schema = "Person")]
    public partial class vAdditionalContactInfo
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"TelephoneNumber")]
        public  string TelephoneNumber { get; set; }

        [Column(name:"TelephoneSpecialInstructions")]
        public  string TelephoneSpecialInstructions { get; set; }

        [Column(name:"Street")]
        public  string Street { get; set; }

        [Column(name:"City")]
        public  string City { get; set; }

        [Column(name:"StateProvince")]
        public  string StateProvince { get; set; }

        [Column(name:"PostalCode")]
        public  string PostalCode { get; set; }

        [Column(name:"CountryRegion")]
        public  string CountryRegion { get; set; }

        [Column(name:"HomeAddressSpecialInstructions")]
        public  string HomeAddressSpecialInstructions { get; set; }

        [Column(name:"EMailAddress")]
        public  string EMailAddress { get; set; }

        [Column(name:"EMailSpecialInstructions")]
        public  string EMailSpecialInstructions { get; set; }

        [Column(name:"EMailTelephoneNumber")]
        public  string EMailTelephoneNumber { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

    }

    [Table("PersonPhone", Schema = "Person")]
    public partial class PersonPhone
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"PhoneNumber")]
        public  string PhoneNumber { get; set; }

        [Column(name:"PhoneNumberTypeID")]
        public  int PhoneNumberTypeID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("vEmployee", Schema = "HumanResources")]
    public partial class vEmployee
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"JobTitle")]
        public  string JobTitle { get; set; }

        [Column(name:"City")]
        public  string City { get; set; }

        [Column(name:"StateProvinceName")]
        public  string StateProvinceName { get; set; }

        [Column(name:"PostalCode")]
        public  string PostalCode { get; set; }

        [Column(name:"CountryRegionName")]
        public  string CountryRegionName { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"EmailPromotion")]
        public  int EmailPromotion { get; set; }

        [Column(name:"AddressLine1")]
        public  string AddressLine1 { get; set; }

        [Column(name:"AddressLine2")]
        public  string AddressLine2 { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"AdditionalContactInfo")]
        public  string AdditionalContactInfo { get; set; }

        [Column(name:"PhoneNumber")]
        public  string PhoneNumber { get; set; }

        [Column(name:"PhoneNumberType")]
        public  string PhoneNumberType { get; set; }

        [Column(name:"EmailAddress")]
        public  string EmailAddress { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

    }

    [Table("SalesTerritory", Schema = "Sales")]
    public partial class SalesTerritory
    {
        [Column(name:"TerritoryID")]
        public  int TerritoryID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"CountryRegionCode")]
        public  string CountryRegionCode { get; set; }

        [Column(name:"Group")]
        public  string Group { get; set; }

        [Column(name:"SalesYTD")]
        public  decimal SalesYTD { get; set; }

        [Column(name:"SalesLastYear")]
        public  decimal SalesLastYear { get; set; }

        [Column(name:"CostYTD")]
        public  decimal CostYTD { get; set; }

        [Column(name:"CostLastYear")]
        public  decimal CostLastYear { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("vEmployeeDepartment", Schema = "HumanResources")]
    public partial class vEmployeeDepartment
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"JobTitle")]
        public  string JobTitle { get; set; }

        [Column(name:"Department")]
        public  string Department { get; set; }

        [Column(name:"GroupName")]
        public  string GroupName { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

    }

    [Table("PhoneNumberType", Schema = "Person")]
    public partial class PhoneNumberType
    {
        [Column(name:"PhoneNumberTypeID")]
        public  int PhoneNumberTypeID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

    }

    [Table("vEmployeeDepartmentHistory", Schema = "HumanResources")]
    public partial class vEmployeeDepartmentHistory
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"Shift")]
        public  string Shift { get; set; }

        [Column(name:"Department")]
        public  string Department { get; set; }

        [Column(name:"GroupName")]
        public  string GroupName { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

    }

    [Table("vIndividualCustomer", Schema = "Sales")]
    public partial class vIndividualCustomer
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"EmailPromotion")]
        public  int EmailPromotion { get; set; }

        [Column(name:"AddressType")]
        public  string AddressType { get; set; }

        [Column(name:"AddressLine1")]
        public  string AddressLine1 { get; set; }

        [Column(name:"City")]
        public  string City { get; set; }

        [Column(name:"StateProvinceName")]
        public  string StateProvinceName { get; set; }

        [Column(name:"PostalCode")]
        public  string PostalCode { get; set; }

        [Column(name:"CountryRegionName")]
        public  string CountryRegionName { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Demographics")]
        public  string Demographics { get; set; }

        [Column(name:"AddressLine2")]
        public  string AddressLine2 { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"PhoneNumber")]
        public  string PhoneNumber { get; set; }

        [Column(name:"PhoneNumberType")]
        public  string PhoneNumberType { get; set; }

        [Column(name:"EmailAddress")]
        public  string EmailAddress { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

    }

    [Table("Product", Schema = "Production")]
    public partial class Product
    {
        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ProductNumber")]
        public  string ProductNumber { get; set; }

        [Column(name:"MakeFlag")]
        public  bool MakeFlag { get; set; }

        [Column(name:"FinishedGoodsFlag")]
        public  bool FinishedGoodsFlag { get; set; }

        [Column(name:"SafetyStockLevel")]
        public  short SafetyStockLevel { get; set; }

        [Column(name:"ReorderPoint")]
        public  short ReorderPoint { get; set; }

        [Column(name:"StandardCost")]
        public  decimal StandardCost { get; set; }

        [Column(name:"ListPrice")]
        public  decimal ListPrice { get; set; }

        [Column(name:"DaysToManufacture")]
        public  int DaysToManufacture { get; set; }

        [Column(name:"SellStartDate")]
        public  DateTime SellStartDate { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"SellEndDate")]
        public  DateTime SellEndDate { get; set; }

        [Column(name:"DiscontinuedDate")]
        public  DateTime DiscontinuedDate { get; set; }

        [Column(name:"ProductLine")]
        public  string ProductLine { get; set; }

        [Column(name:"Class")]
        public  string Class { get; set; }

        [Column(name:"Style")]
        public  string Style { get; set; }

        [Column(name:"ProductSubcategoryID")]
        public  int ProductSubcategoryID { get; set; }

        [Column(name:"ProductModelID")]
        public  int ProductModelID { get; set; }

        [Column(name:"Size")]
        public  string Size { get; set; }

        [Column(name:"SizeUnitMeasureCode")]
        public  string SizeUnitMeasureCode { get; set; }

        [Column(name:"WeightUnitMeasureCode")]
        public  string WeightUnitMeasureCode { get; set; }

        [Column(name:"Weight")]
        public  decimal Weight { get; set; }

        [Column(name:"Color")]
        public  string Color { get; set; }

    }

    [Table("vPersonDemographics", Schema = "Sales")]
    public partial class vPersonDemographics
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"TotalPurchaseYTD")]
        public  decimal TotalPurchaseYTD { get; set; }

        [Column(name:"DateFirstPurchase")]
        public  DateTime DateFirstPurchase { get; set; }

        [Column(name:"BirthDate")]
        public  DateTime BirthDate { get; set; }

        [Column(name:"MaritalStatus")]
        public  string MaritalStatus { get; set; }

        [Column(name:"YearlyIncome")]
        public  string YearlyIncome { get; set; }

        [Column(name:"Gender")]
        public  string Gender { get; set; }

        [Column(name:"TotalChildren")]
        public  int TotalChildren { get; set; }

        [Column(name:"NumberChildrenAtHome")]
        public  int NumberChildrenAtHome { get; set; }

        [Column(name:"Education")]
        public  string Education { get; set; }

        [Column(name:"Occupation")]
        public  string Occupation { get; set; }

        [Column(name:"HomeOwnerFlag")]
        public  bool HomeOwnerFlag { get; set; }

        [Column(name:"NumberCarsOwned")]
        public  int NumberCarsOwned { get; set; }

    }

    [Table("vJobCandidate", Schema = "HumanResources")]
    public partial class vJobCandidate
    {
        [Column(name:"JobCandidateID")]
        public  int JobCandidateID { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Name.Prefix")]
        public  string NamePrefix { get; set; }

        [Column(name:"Name.First")]
        public  string NameFirst { get; set; }

        [Column(name:"Name.Middle")]
        public  string NameMiddle { get; set; }

        [Column(name:"Name.Last")]
        public  string NameLast { get; set; }

        [Column(name:"Name.Suffix")]
        public  string NameSuffix { get; set; }

        [Column(name:"Skills")]
        public  string Skills { get; set; }

        [Column(name:"Addr.Type")]
        public  string AddrType { get; set; }

        [Column(name:"Addr.Loc.CountryRegion")]
        public  string AddrLocCountryRegion { get; set; }

        [Column(name:"Addr.Loc.State")]
        public  string AddrLocState { get; set; }

        [Column(name:"Addr.Loc.City")]
        public  string AddrLocCity { get; set; }

        [Column(name:"Addr.PostalCode")]
        public  string AddrPostalCode { get; set; }

        [Column(name:"EMail")]
        public  string EMail { get; set; }

        [Column(name:"WebSite")]
        public  string WebSite { get; set; }

    }

    [Table("vJobCandidateEmployment", Schema = "HumanResources")]
    public partial class vJobCandidateEmployment
    {
        [Column(name:"JobCandidateID")]
        public  int JobCandidateID { get; set; }

        [Column(name:"Emp.StartDate")]
        public  DateTime EmpStartDate { get; set; }

        [Column(name:"Emp.EndDate")]
        public  DateTime EmpEndDate { get; set; }

        [Column(name:"Emp.OrgName")]
        public  string EmpOrgName { get; set; }

        [Column(name:"Emp.JobTitle")]
        public  string EmpJobTitle { get; set; }

        [Column(name:"Emp.Responsibility")]
        public  string EmpResponsibility { get; set; }

        [Column(name:"Emp.FunctionCategory")]
        public  string EmpFunctionCategory { get; set; }

        [Column(name:"Emp.IndustryCategory")]
        public  string EmpIndustryCategory { get; set; }

        [Column(name:"Emp.Loc.CountryRegion")]
        public  string EmpLocCountryRegion { get; set; }

        [Column(name:"Emp.Loc.State")]
        public  string EmpLocState { get; set; }

        [Column(name:"Emp.Loc.City")]
        public  string EmpLocCity { get; set; }

    }

    [Table("vJobCandidateEducation", Schema = "HumanResources")]
    public partial class vJobCandidateEducation
    {
        [Column(name:"JobCandidateID")]
        public  int JobCandidateID { get; set; }

        [Column(name:"Edu.Level")]
        public  string EduLevel { get; set; }

        [Column(name:"Edu.StartDate")]
        public  DateTime EduStartDate { get; set; }

        [Column(name:"Edu.EndDate")]
        public  DateTime EduEndDate { get; set; }

        [Column(name:"Edu.Degree")]
        public  string EduDegree { get; set; }

        [Column(name:"Edu.Major")]
        public  string EduMajor { get; set; }

        [Column(name:"Edu.Minor")]
        public  string EduMinor { get; set; }

        [Column(name:"Edu.GPA")]
        public  string EduGPA { get; set; }

        [Column(name:"Edu.GPAScale")]
        public  string EduGPAScale { get; set; }

        [Column(name:"Edu.School")]
        public  string EduSchool { get; set; }

        [Column(name:"Edu.Loc.CountryRegion")]
        public  string EduLocCountryRegion { get; set; }

        [Column(name:"Edu.Loc.State")]
        public  string EduLocState { get; set; }

        [Column(name:"Edu.Loc.City")]
        public  string EduLocCity { get; set; }

    }

    [Table("vProductAndDescription", Schema = "Production")]
    public partial class vProductAndDescription
    {
        [Column(name:"ProductID")]
        public  int ProductID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"ProductModel")]
        public  string ProductModel { get; set; }

        [Column(name:"CultureID")]
        public  string CultureID { get; set; }

        [Column(name:"Description")]
        public  string Description { get; set; }

    }

    [Table("vProductModelCatalogDescription", Schema = "Production")]
    public partial class vProductModelCatalogDescription
    {
        [Column(name:"ProductModelID")]
        public  int ProductModelID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"Summary")]
        public  string Summary { get; set; }

        [Column(name:"Manufacturer")]
        public  string Manufacturer { get; set; }

        [Column(name:"Copyright")]
        public  string Copyright { get; set; }

        [Column(name:"ProductURL")]
        public  string ProductURL { get; set; }

        [Column(name:"WarrantyPeriod")]
        public  string WarrantyPeriod { get; set; }

        [Column(name:"WarrantyDescription")]
        public  string WarrantyDescription { get; set; }

        [Column(name:"NoOfYears")]
        public  string NoOfYears { get; set; }

        [Column(name:"MaintenanceDescription")]
        public  string MaintenanceDescription { get; set; }

        [Column(name:"Wheel")]
        public  string Wheel { get; set; }

        [Column(name:"Saddle")]
        public  string Saddle { get; set; }

        [Column(name:"Pedal")]
        public  string Pedal { get; set; }

        [Column(name:"BikeFrame")]
        public  string BikeFrame { get; set; }

        [Column(name:"Crankset")]
        public  string Crankset { get; set; }

        [Column(name:"PictureAngle")]
        public  string PictureAngle { get; set; }

        [Column(name:"PictureSize")]
        public  string PictureSize { get; set; }

        [Column(name:"ProductPhotoID")]
        public  string ProductPhotoID { get; set; }

        [Column(name:"Material")]
        public  string Material { get; set; }

        [Column(name:"Color")]
        public  string Color { get; set; }

        [Column(name:"ProductLine")]
        public  string ProductLine { get; set; }

        [Column(name:"Style")]
        public  string Style { get; set; }

        [Column(name:"RiderExperience")]
        public  string RiderExperience { get; set; }

    }

    [Table("vProductModelInstructions", Schema = "Production")]
    public partial class vProductModelInstructions
    {
        [Column(name:"ProductModelID")]
        public  int ProductModelID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"Instructions")]
        public  string Instructions { get; set; }

        [Column(name:"LocationID")]
        public  int LocationID { get; set; }

        [Column(name:"SetupHours")]
        public  decimal SetupHours { get; set; }

        [Column(name:"MachineHours")]
        public  decimal MachineHours { get; set; }

        [Column(name:"LaborHours")]
        public  decimal LaborHours { get; set; }

        [Column(name:"LotSize")]
        public  int LotSize { get; set; }

        [Column(name:"Step")]
        public  string Step { get; set; }

    }

    [Table("vSalesPerson", Schema = "Sales")]
    public partial class vSalesPerson
    {
        [Column(name:"EmailPromotion")]
        public  int EmailPromotion { get; set; }

        [Column(name:"AddressLine1")]
        public  string AddressLine1 { get; set; }

        [Column(name:"SalesYTD")]
        public  decimal SalesYTD { get; set; }

        [Column(name:"SalesLastYear")]
        public  decimal SalesLastYear { get; set; }

        [Column(name:"JobTitle")]
        public  string JobTitle { get; set; }

        [Column(name:"City")]
        public  string City { get; set; }

        [Column(name:"StateProvinceName")]
        public  string StateProvinceName { get; set; }

        [Column(name:"PostalCode")]
        public  string PostalCode { get; set; }

        [Column(name:"CountryRegionName")]
        public  string CountryRegionName { get; set; }

        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"FirstName")]
        public  string FirstName { get; set; }

        [Column(name:"LastName")]
        public  string LastName { get; set; }

        [Column(name:"Suffix")]
        public  string Suffix { get; set; }

        [Column(name:"MiddleName")]
        public  string MiddleName { get; set; }

        [Column(name:"Title")]
        public  string Title { get; set; }

        [Column(name:"TerritoryName")]
        public  string TerritoryName { get; set; }

        [Column(name:"TerritoryGroup")]
        public  string TerritoryGroup { get; set; }

        [Column(name:"SalesQuota")]
        public  decimal SalesQuota { get; set; }

        [Column(name:"PhoneNumber")]
        public  string PhoneNumber { get; set; }

        [Column(name:"PhoneNumberType")]
        public  string PhoneNumberType { get; set; }

        [Column(name:"EmailAddress")]
        public  string EmailAddress { get; set; }

        [Column(name:"AddressLine2")]
        public  string AddressLine2 { get; set; }

    }

    [Table("SalesTerritoryHistory", Schema = "Sales")]
    public partial class SalesTerritoryHistory
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"TerritoryID")]
        public  int TerritoryID { get; set; }

        [Column(name:"StartDate")]
        public  DateTime StartDate { get; set; }

        [Column(name:"rowguid")]
        public  Guid Rowguid { get; set; }

        [Column(name:"ModifiedDate")]
        public  DateTime ModifiedDate { get; set; }

        [Column(name:"EndDate")]
        public  DateTime EndDate { get; set; }

    }

    [Table("vSalesPersonSalesByFiscalYears", Schema = "Sales")]
    public partial class vSalesPersonSalesByFiscalYears
    {
        [Column(name:"JobTitle")]
        public  string JobTitle { get; set; }

        [Column(name:"SalesTerritory")]
        public  string SalesTerritory { get; set; }

        [Column(name:"2002")]
        public  decimal Field2002 { get; set; }

        [Column(name:"2003")]
        public  decimal Field2003 { get; set; }

        [Column(name:"2004")]
        public  decimal Field2004 { get; set; }

        [Column(name:"SalesPersonID")]
        public  int SalesPersonID { get; set; }

        [Column(name:"FullName")]
        public  string FullName { get; set; }

    }

    [Table("vStateProvinceCountryRegion", Schema = "Person")]
    public partial class vStateProvinceCountryRegion
    {
        [Column(name:"StateProvinceID")]
        public  int StateProvinceID { get; set; }

        [Column(name:"StateProvinceCode")]
        public  string StateProvinceCode { get; set; }

        [Column(name:"IsOnlyStateProvinceFlag")]
        public  bool IsOnlyStateProvinceFlag { get; set; }

        [Column(name:"StateProvinceName")]
        public  string StateProvinceName { get; set; }

        [Column(name:"TerritoryID")]
        public  int TerritoryID { get; set; }

        [Column(name:"CountryRegionCode")]
        public  string CountryRegionCode { get; set; }

        [Column(name:"CountryRegionName")]
        public  string CountryRegionName { get; set; }

    }

    [Table("vStoreWithDemographics", Schema = "Sales")]
    public partial class vStoreWithDemographics
    {
        [Column(name:"BusinessEntityID")]
        public  int BusinessEntityID { get; set; }

        [Column(name:"Name")]
        public  string Name { get; set; }

        [Column(name:"AnnualSales")]
        public  decimal AnnualSales { get; set; }

        [Column(name:"AnnualRevenue")]
        public  decimal AnnualRevenue { get; set; }

        [Column(name:"BankName")]
        public  string BankName { get; set; }

        [Column(name:"BusinessType")]
        public  string BusinessType { get; set; }

        [Column(name:"YearOpened")]
        public  int YearOpened { get; set; }

        [Column(name:"Specialty")]
        public  string Specialty { get; set; }

        [Column(name:"SquareFeet")]
        public  int SquareFeet { get; set; }

        [Column(name:"Brands")]
        public  string Brands { get; set; }

        [Column(name:"Internet")]
        public  string Internet { get; set; }

        [Column(name:"NumberEmployees")]
        public  int NumberEmployees { get; set; }

    }

}