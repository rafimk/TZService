namespace TZService.Contracts.OutGoing.SearchReference;

public class SearchReferenceRequestType
{
    // Order 0
    public string MessageId { get; set; }
    // Order 1 Description 
    //         DescriptionOperator
    //         Ncage
    //         NcageOperator
    //         Nsn
    //         NsnOperator
    //         ReferenceNumber
    //         ReferenceNumberOPerator
    //         ItemsElementName
    public string[] Items { get; set; }
    public ItemsChoiceType[] ItemsElementName { get; set;}

}



