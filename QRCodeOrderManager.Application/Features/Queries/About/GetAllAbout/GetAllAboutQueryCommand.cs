using MediatR;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAllAbout;

public class GetAllAboutQueryCommand : IRequest<AboutDto[]>
{
}