using System.ComponentModel;

namespace QRCodeOrderManager.Domain.Entities;

public class BaseEntity
{
    [Description("Benzersiz Kimlik")]
    public Guid Id { get; set; }

    [Description("Oluşturma Tarihi")]
    public DateTime CreatedDate { get; set; }

    [Description("Güncelleme Tarihi")]
    public DateTime UpdateDate { get; set; }
}