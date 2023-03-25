namespace TZService.Contracts.OutGoing.SearchReference;

public class SearchReferenceResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public ReferenceBasicDataType[] OperationResult { get; set; }

}

