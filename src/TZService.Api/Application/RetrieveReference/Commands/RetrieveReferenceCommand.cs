using MediatR;

namespace TZService.Api.Application.RetrieveReference.Commands;

public class RetrieveReferenceCommand : IRequest<RetrieveReferenceResponseType>
{
    public string MessageId { get; set; }
    public string[] Items { get; set; }   
    public ItemChoiceType[] ItemsElementName { get; set;}
}

public enum ItemChoiceType
{
    MccNumber,
    Ncage,
    Nsn,
    ReferenceNumber
}

public class RetrieveReferenceResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set; }
    public int OperationStatus { get; set; }
}

public class RetrieveReferenceCommandHandler : IRequestHandler<RetrieveReferenceCommand, RetrieveReferenceResponseType>
{

    public RetrieveReferenceCommandHandler()
    {
    }

    public async Task<RetrieveReferenceResponseType> Handle(RetrieveReferenceCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return new RetrieveReferenceResponseType();
    }
}