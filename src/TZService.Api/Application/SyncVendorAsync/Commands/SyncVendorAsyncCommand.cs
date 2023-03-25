using MediatR;

namespace TZService.Api.Application.SyncVendorAsync.Commands;

public class SyncVendorAsyncCommand : IRequest<SyncVendorsResponseType>
{
    public string MessageId { get; set; }
    public SyncVendorsRequestTypeVendor[] Vendor { get; set; } 
}

public class SyncVendorsRequestTypeVendor
{
    public string Supplier { get; set; }
    public string SupplierName { get; set; }
    public string CountryCode { get; set; }
    public string SupplierNameArabic { get; set; }
    public SyncVendorsRequestTypeVendorAddress[] Address { get; set; }
}

public class SyncVendorsRequestTypeVendorAddress
{
    public string AddressLine1 { get; set;}
    public string AddressLine2 { get; set;}
    public string AddressLine3 { get; set;}
    public string AddressLine4 { get; set;}
    public string AddressLine5 { get; set;}
    public string AddressLine6 { get; set;}
    public string AddressLine7 { get; set;}
    public string Fax1 { get; set;}
    public string Fax2 { get; set;}
    public string Fax3 { get; set;}
    public string Telephone1 { get; set;}
    public string Telephone2 { get; set;}
    public string Telephone3 { get; set;}
    public string Email { get; set;}
    public string Remarks1 { get; set;}
    public string Remarks2 { get; set;}
}

public class SyncVendorsResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public SyncVendorsResponseTypeOperationResult[] OperationResult { get; set; }
    
}

public class SyncVendorsResponseTypeOperationResult
{
    public string EntityId { get; set; }
    public int Status { get; set; }
    public string Error { get; set; }
}

public class SearchReferenceCommandHandler : IRequestHandler<SyncVendorAsyncCommand, SyncVendorsResponseType>
{

    public SearchReferenceCommandHandler()
    {
    }

    public async Task<SyncVendorsResponseType> Handle(SyncVendorAsyncCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return new SyncVendorsResponseType();
    }
}