using MediatR;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAboutById;

public class GetByIdAboutCommand : IRequest<GetByIdAboutDto>
{
    public Guid Id { get; set; }
}