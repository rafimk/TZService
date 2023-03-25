using TZService.Contracts.SyncVendorAsync;

namespace TZService.Contracts.OutGoing.SyncVendorAsync;

public class SyncVendorsRequestType
{
    public string MessageId { get; set; }
    public SyncVendorsRequestTypeVendor[] Vendor { get; set; } 
}