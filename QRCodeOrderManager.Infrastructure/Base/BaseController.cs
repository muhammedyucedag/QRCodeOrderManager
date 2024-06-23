using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace QRCodeOrderManager.Infrastructure.Base;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController : ControllerBase
{
    protected readonly IMediator Mediator;

    protected BaseController(IMediator mediator)
    {
        Mediator = mediator;
    }
}