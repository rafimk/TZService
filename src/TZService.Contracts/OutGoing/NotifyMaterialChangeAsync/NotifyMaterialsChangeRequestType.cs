namespace TZService.Contracts.NotifyMaterialChangeAsync;

public class NotifyMaterialsChangeRequestType
{
    public string MessageId { get; set; }
    public NotifyMaterialsChangeRequestTypeMaterial[] Material { get; set; }
}