namespace TZService.Contracts.CodifyMaterialAsync;

public class CodifyMaterialRequestTypeMaterial
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public NotifyMaterialsChangeResponseTypeOperationResult[] OperationResult { get; set;}
}