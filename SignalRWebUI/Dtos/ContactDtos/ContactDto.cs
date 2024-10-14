﻿namespace SignalRWebUI.Dtos.ContactDtos;

public record ContactDto
{
    public Guid Id { get; set; }
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}