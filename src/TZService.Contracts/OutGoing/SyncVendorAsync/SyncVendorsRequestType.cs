namespace TZService.Contracts.SyncVendorAsync;

public class SyncVendorsRequestType
{
    public string MessageId { get; set; }
    public SyncVendorsRequestTypeVendor[] Vendor { get; set; } 
}