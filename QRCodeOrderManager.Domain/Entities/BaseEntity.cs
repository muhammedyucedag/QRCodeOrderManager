using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QRCodeOrderManager.Domain.Entities;

public class BaseEntity
{
    [Key]
    [Description("Benzersiz Kimlik")]
    public Guid Id { get; set; }

    [Description("Oluşturma Tarihi")]
    public DateTimeOffset CreatedDate { get; set; }

    [Description("Güncelleme Tarihi")]
    public DateTimeOffset UpdatedDate { get; set; }
}