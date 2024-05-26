using System.ComponentModel;

namespace SignalR.Entity.Entities;

public class BaseEntity
{
    [Description("Benzersiz Kimlik")]
    public Guid Id { get; set; }
    
    [Description("Oluşturma Tarihi")]
    public DateTime CreatedDate { get; set; }
    
    [Description("Güncelleme Tarihi")]
    public DateTime UpdateDate { get; set; }
}