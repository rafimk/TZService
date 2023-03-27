namespace TZService.Contracts.CodifyMaterialAsync;

public class CodificationRequestResultType
{
    public string MccNumber { get; set;}
    public string ActivityStatus { get; set;}
    public int Status { get; set; }
    public string Error { get; set;}
}