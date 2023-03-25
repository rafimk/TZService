using MediatR;

namespace TZService.Api.Application.SearchReference.Commands;

public class SearchReferenceCommand : IRequest<SearchReferenceResponseType>
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public ReferenceBasicDataType[] OperationResult { get; set; }
}

public class ReferenceBasicDataType
{
    public string MccNumber { get; set; }
    public string ReferenceNumber { get; set; }
    public string Ncage { get; set; }
    public string Nsn { get; set; }
    public string Sid { get; set; }
    public string Lid { get; set; }
    public string Rnsc { get; set; }
    public string RnsDescription { get; set; }
    public string Uic { get; set; }
    public string UicDescription { get; set; }
}

public class SearchReferenceResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public ReferenceBasicDataType[] OperationResult { get; set; }

}

public class SearchReferenceCommandHandler : IRequestHandler<SearchReferenceCommand, SearchReferenceResponseType>
{

    public SearchReferenceCommandHandler()
    {
    }

    public async Task<SearchReferenceResponseType> Handle(SearchReferenceCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return new SearchReferenceResponseType();
    }
}