using System.Runtime.InteropServices.JavaScript;

namespace SignalRAPI.Dal.Entities;

public class Reservation : BaseEntity
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime ReservationDate { get; set; }
}