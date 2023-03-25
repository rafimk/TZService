using Microsoft.AspNetCore.Mvc;
using TZService.Api.Application.NotifyMaterialChangeAsync.Commands;
using TZService.Api.Application.RetrieveReference.Commands;
using TZService.Api.Application.SearchReference.Commands;
using TZService.Api.Application.SyncVendorAsync.Commands;
using TZService.Api.Controllers;

namespace TZService.Api.WebApi.Controllers;

public class TzServiceController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<SearchReferenceResponseType>> SearchReference(SearchReferenceCommand command)
    {
        return await Mediator.Send(command);
    }
    
    [HttpPost]
    public async Task<ActionResult<RetrieveReferenceResponseType>> RetrieveReference(RetrieveReferenceCommand command)
    {
        return await Mediator.Send(command);
    }
    
    [HttpPost]
    public async Task<ActionResult<NotifyMaterialsChangeResponseType>> NotifyMaterialChangeAsync(NotifyMaterialChangeAsyncCommand command)
    {
        return await Mediator.Send(command);
    }
    
    [HttpPost]
    public async Task<ActionResult<SyncVendorsResponseType>> SyncVendorAsync(SyncVendorAsyncCommand command)
    {
        return await Mediator.Send(command);
    }
}