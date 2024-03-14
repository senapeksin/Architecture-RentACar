using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class BaseController : ControllerBase
{
    private IMediator? _mediator;
    protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    // Eğer daha önce Mediatr enjecte edilmiş ise onu döndür, yoksa(null) IOC ortamından IMediatr karşılığını ver.
}
