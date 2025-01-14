﻿namespace SignalRWebUI.Dtos.AboutDtos;

public record AboutDto
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}