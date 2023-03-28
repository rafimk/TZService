namespace TZService.Contracts.NotifyRefChangeAsync;

public class Stmmsr1f_Input
{
    public InterchangeableMOV[] Interchangeable { get; set;}
    public NotifyReferencesChangeRequest NotifyReferencesChangeRequest { get; set;}
    public Reference Reference { get; set; }
    
}