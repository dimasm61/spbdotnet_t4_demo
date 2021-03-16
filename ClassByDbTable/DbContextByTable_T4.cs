
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Data.Entity;

namespace ClassByDbTable
{
    public partial class AdventureWorksDbContext
    {
        public DbSet<vStoreWithContacts> tvStoreWithContacts { get; set; }
        public DbSet<ScrapReason> tScrapReason { get; set; }
        public DbSet<vStoreWithAddresses> tvStoreWithAddresses { get; set; }
        public DbSet<vVendorWithContacts> tvVendorWithContacts { get; set; }
        public DbSet<Shift> tShift { get; set; }
        public DbSet<vVendorWithAddresses> tvVendorWithAddresses { get; set; }
        public DbSet<ProductCategory> tProductCategory { get; set; }
        public DbSet<ShipMethod> tShipMethod { get; set; }
        public DbSet<ProductCostHistory> tProductCostHistory { get; set; }
        public DbSet<ProductDescription> tProductDescription { get; set; }
        public DbSet<ShoppingCartItem> tShoppingCartItem { get; set; }
        public DbSet<ProductDocument> tProductDocument { get; set; }
        public DbSet<DatabaseLog> tDatabaseLog { get; set; }
        public DbSet<ProductInventory> tProductInventory { get; set; }
        public DbSet<SpecialOffer> tSpecialOffer { get; set; }
        public DbSet<ErrorLog> tErrorLog { get; set; }
        public DbSet<ProductListPriceHistory> tProductListPriceHistory { get; set; }
        public DbSet<Address> tAddress { get; set; }
        public DbSet<SpecialOfferProduct> tSpecialOfferProduct { get; set; }
        public DbSet<ProductModel> tProductModel { get; set; }
        public DbSet<AddressType> tAddressType { get; set; }
        public DbSet<StateProvince> tStateProvince { get; set; }
        public DbSet<ProductModelIllustration> tProductModelIllustration { get; set; }
        public DbSet<AWBuildVersion> tAWBuildVersion { get; set; }
        public DbSet<ProductModelProductDescriptionCulture> tProductModelProductDescriptionCulture { get; set; }
        public DbSet<BillOfMaterials> tBillOfMaterials { get; set; }
        public DbSet<Store> tStore { get; set; }
        public DbSet<ProductPhoto> tProductPhoto { get; set; }
        public DbSet<ProductProductPhoto> tProductProductPhoto { get; set; }
        public DbSet<TransactionHistory> tTransactionHistory { get; set; }
        public DbSet<ProductReview> tProductReview { get; set; }
        public DbSet<BusinessEntity> tBusinessEntity { get; set; }
        public DbSet<TransactionHistoryArchive> tTransactionHistoryArchive { get; set; }
        public DbSet<ProductSubcategory> tProductSubcategory { get; set; }
        public DbSet<BusinessEntityAddress> tBusinessEntityAddress { get; set; }
        public DbSet<ProductVendor> tProductVendor { get; set; }
        public DbSet<BusinessEntityContact> tBusinessEntityContact { get; set; }
        public DbSet<UnitMeasure> tUnitMeasure { get; set; }
        public DbSet<Vendor> tVendor { get; set; }
        public DbSet<ContactType> tContactType { get; set; }
        public DbSet<CountryRegionCurrency> tCountryRegionCurrency { get; set; }
        public DbSet<CountryRegion> tCountryRegion { get; set; }
        public DbSet<WorkOrder> tWorkOrder { get; set; }
        public DbSet<PurchaseOrderDetail> tPurchaseOrderDetail { get; set; }
        public DbSet<CreditCard> tCreditCard { get; set; }
        public DbSet<Culture> tCulture { get; set; }
        public DbSet<WorkOrderRouting> tWorkOrderRouting { get; set; }
        public DbSet<Currency> tCurrency { get; set; }
        public DbSet<PurchaseOrderHeader> tPurchaseOrderHeader { get; set; }
        public DbSet<CurrencyRate> tCurrencyRate { get; set; }
        public DbSet<Customer> tCustomer { get; set; }
        public DbSet<Department> tDepartment { get; set; }
        public DbSet<Document> tDocument { get; set; }
        public DbSet<SalesOrderDetail> tSalesOrderDetail { get; set; }
        public DbSet<EmailAddress> tEmailAddress { get; set; }
        public DbSet<Employee> tEmployee { get; set; }
        public DbSet<SalesOrderHeader> tSalesOrderHeader { get; set; }
        public DbSet<EmployeeDepartmentHistory> tEmployeeDepartmentHistory { get; set; }
        public DbSet<EmployeePayHistory> tEmployeePayHistory { get; set; }
        public DbSet<SalesOrderHeaderSalesReason> tSalesOrderHeaderSalesReason { get; set; }
        public DbSet<SalesPerson> tSalesPerson { get; set; }
        public DbSet<Illustration> tIllustration { get; set; }
        public DbSet<JobCandidate> tJobCandidate { get; set; }
        public DbSet<Location> tLocation { get; set; }
        public DbSet<Password> tPassword { get; set; }
        public DbSet<SalesPersonQuotaHistory> tSalesPersonQuotaHistory { get; set; }
        public DbSet<Person> tPerson { get; set; }
        public DbSet<SalesReason> tSalesReason { get; set; }
        public DbSet<SalesTaxRate> tSalesTaxRate { get; set; }
        public DbSet<PersonCreditCard> tPersonCreditCard { get; set; }
        public DbSet<vAdditionalContactInfo> tvAdditionalContactInfo { get; set; }
        public DbSet<PersonPhone> tPersonPhone { get; set; }
        public DbSet<vEmployee> tvEmployee { get; set; }
        public DbSet<SalesTerritory> tSalesTerritory { get; set; }
        public DbSet<vEmployeeDepartment> tvEmployeeDepartment { get; set; }
        public DbSet<PhoneNumberType> tPhoneNumberType { get; set; }
        public DbSet<vEmployeeDepartmentHistory> tvEmployeeDepartmentHistory { get; set; }
        public DbSet<vIndividualCustomer> tvIndividualCustomer { get; set; }
        public DbSet<Product> tProduct { get; set; }
        public DbSet<vPersonDemographics> tvPersonDemographics { get; set; }
        public DbSet<vJobCandidate> tvJobCandidate { get; set; }
        public DbSet<vJobCandidateEmployment> tvJobCandidateEmployment { get; set; }
        public DbSet<vJobCandidateEducation> tvJobCandidateEducation { get; set; }
        public DbSet<vProductAndDescription> tvProductAndDescription { get; set; }
        public DbSet<vProductModelCatalogDescription> tvProductModelCatalogDescription { get; set; }
        public DbSet<vProductModelInstructions> tvProductModelInstructions { get; set; }
        public DbSet<vSalesPerson> tvSalesPerson { get; set; }
        public DbSet<SalesTerritoryHistory> tSalesTerritoryHistory { get; set; }
        public DbSet<vSalesPersonSalesByFiscalYears> tvSalesPersonSalesByFiscalYears { get; set; }
        public DbSet<vStateProvinceCountryRegion> tvStateProvinceCountryRegion { get; set; }
        public DbSet<vStoreWithDemographics> tvStoreWithDemographics { get; set; }
    }
}