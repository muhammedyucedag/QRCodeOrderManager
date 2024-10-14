using MediatR;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAboutById;

public record GetByIdAboutQueryCommand : IRequest<AboutDto>
{
    public Guid AboutId { get; set; }
}