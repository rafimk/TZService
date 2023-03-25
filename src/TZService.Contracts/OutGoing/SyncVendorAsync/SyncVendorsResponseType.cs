using TZService.Contracts.SyncVendorAsync;

namespace TZService.Contracts.OutGoing.SyncVendorAsync;

public class SyncVendorsResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public SyncVendorsResponseTypeOperationResult[] OperationResult { get; set; }
    
}