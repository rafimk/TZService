namespace TZService.Contracts.SyncVendorAsync;

public class SyncVendorsRequestTypeVendor
{
    public string Supplier { get; set; }
    public string SupplierName { get; set; }
    public string CountryCode { get; set; }
    public string SupplierNameArabic { get; set; }
    public SyncVendorsRequestTypeVendorAddress[] Address { get; set; }
}