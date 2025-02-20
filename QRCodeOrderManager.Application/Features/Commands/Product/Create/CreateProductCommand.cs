﻿using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Create;

public record CreateProductCommand : IRequest<CreateProductCommandResponse>
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}