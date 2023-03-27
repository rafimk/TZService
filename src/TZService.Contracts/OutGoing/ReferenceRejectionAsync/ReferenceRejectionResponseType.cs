namespace TZService.Contracts.ReferenceRejectionAsync;

public class ReferenceRejectionResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set;}
}