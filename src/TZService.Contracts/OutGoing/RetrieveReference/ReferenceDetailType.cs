namespace TZService.Contracts.OutGoing.RetrieveReference;

public class ReferenceDetailType
{
    public string MccNumber { get; set; }
    public string ReferenceNumber { get; set; }
    public string Ncage { get; set; }
    public string Nsn { get; set; }
    public string Sid { get; set; }
    public string Lid { get; set; }
    public string Rnsc { get; set; }
    public string RnsDescription { get; set; }
    public string ActivityStatus { get; set; }
    public string ItemNameDefinition { get; set; }
    public string OriginalName { get; set; }
    public string Nsg { get; set; }
    public string Nsc { get; set; }
    public string NiinSc { get; set;}
    public string NiinScDescription { get; set;}
    public double Weight { get; set; }
    public bool WeightSpecified { get; set;}
    public string UicOfWeight { get; set; }
    public double Capacity { get; set; }
    public bool CapacitySpecified { get; set; }
    public string UicOfCapacity { get; set; }
    public double height { get; set; }
    public bool HeightSpecified { get; set; }
    public string UicOfHeight { get; set; }
    public double Length { get; set; }
    public bool LengthSpecified { get; set; }
    public string UicOfLength { get; set; }
    public double Width { get; set; }
    public bool WidthSpecified { get; set;}
    public string UicOfWidth { get; set;}
}