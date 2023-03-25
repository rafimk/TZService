namespace TZService.Contracts.OutGoing.SearchReference;

public class SearchReferenceRequestType
{
    // Order 0
    public string MessageId { get; set; }
    public string[] Items { get; set; }
    public ItemsChoiceType[] ItemsElementName { get; set;}

}



