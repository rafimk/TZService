using MediatR;
using TZService.Api.Application.RetrieveReference.Commands;

namespace TZService.Api.Application.NotifyMaterialChangeAsync.Commands;

public class NotifyMaterialChangeAsyncCommand : IRequest<NotifyMaterialsChangeResponseType>
{
    public string MessageId { get; set; }
    public NotifyMaterialsChangeRequestTypeMaterial[] Material { get; set; }
}

public class NotifyMaterialsChangeRequestTypeMaterial
{
    public string MccNumber { get; set;}
    public string TadbeerNumber { get; set;}
}

public class NotifyMaterialsChangeResponseType
{
    public string MessageId { get; set; }
    public string RequestId { get; set;}
    public int OperationStatus { get; set; }
    public string OperationError { get; set; }
    public NotifyMaterialsChangeResponseTypeOperationResult[] OperationResult {get; set; }
}

public class NotifyMaterialsChangeResponseTypeOperationResult
{
    public string EntityId { get; set; }
    public int Status { get; set;}
    public string Error { get; set;}
}

public class RetrieveReferenceCommandHandler : IRequestHandler<NotifyMaterialChangeAsyncCommand, NotifyMaterialsChangeResponseType>
{

    public RetrieveReferenceCommandHandler()
    {
    }

    public async Task<NotifyMaterialsChangeResponseType> Handle(NotifyMaterialChangeAsyncCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return new NotifyMaterialsChangeResponseType();
    }
}