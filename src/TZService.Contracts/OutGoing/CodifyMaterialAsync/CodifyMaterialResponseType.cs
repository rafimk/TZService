namespace TZService.Contracts.CodifyMaterialAsync;

public class CodifyMaterialResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set;}
    public string OperationError { get; set; }
    public CodificationRequestResultType OperationResult { get; set;}
    

}