using System.Security.Cryptography.X509Certificates;
namespace TZService.Contracts.RetrievceReference;

public class RetrievceReferenceRequestType
{
    public string MessageId { get; set; }
    public string[] Items { get; set; }   
    public ItemChoiceType[] ItemsElementName { get; set;}
}