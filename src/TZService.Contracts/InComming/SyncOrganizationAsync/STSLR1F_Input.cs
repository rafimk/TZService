namespace TZService.Contracts.InComming.SyncOrganizationAsync;

public class STSLR1F_Input
{
    public AddressMOV Address { get; set;}
    public Organization Organization { get; set; }
    public SyncOrganizationRequest SyncOrganizationRequest { get; set;}
}