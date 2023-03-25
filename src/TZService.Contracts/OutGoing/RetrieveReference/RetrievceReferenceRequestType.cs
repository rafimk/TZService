namespace TZService.Contracts.OutGoing.RetrieveReference;

public class RetrieveReferenceRequestType
{
    public string MessageId { get; set; }
    public string[] Items { get; set; }   
    public ItemChoiceType[] ItemsElementName { get; set;}
}