﻿namespace QRCodeOrderManager.Application.DTOs.Reservation;

public class CreateReservationDto
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime ReservationDate { get; set; }
}