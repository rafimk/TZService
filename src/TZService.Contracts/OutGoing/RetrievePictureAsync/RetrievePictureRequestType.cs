namespace TZService.Contracts.RetrievePictureAsync;

public class RetrievePictureRequestType
{
    public string MessageId { get; set;}
    public string[] Items { get; set;}
    public ItemsChoiceType[] ItemsElementName { get; set; }

}