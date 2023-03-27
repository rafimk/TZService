namespace TZService.Contracts.RetrievePictureAsync;

public class RetrievePictureResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set;}
    public byte[][] OperationResult { get; set;}
}