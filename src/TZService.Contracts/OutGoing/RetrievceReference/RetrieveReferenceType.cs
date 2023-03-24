namespace TZService.Contracts.RetrievceReference;

public class RetieveReferenceResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public RetrieveReferenceResultType OperationResult { get; set; }
}