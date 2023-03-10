using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;


public class Item
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }

    [Column(Order = 1)]
    public string CompanyId { get; set; }
    public Company? Company { get; set; }

    [Column(Order = 4)]
    public ItemType Type { get; set; }

    [Column(Order = 5)]
    public string Code { get; set; }

    [Column(Order = 6)]
    [StringLength(100)]
    public string Name { get; set; }

    [Column(Order = 7)]
    public string? Brand { get; set; }

    [Column(Order = 8)]
    [StringLength(200)]
    public string? Description { get; set; }

    [Column(Order = 9)]
    public string? Size { get; set; }

    [Column(Order = 10)]
    public string? BaseUOM { get; set; }

    [Column(Order = 11)]
    public string? PurchaseUOM { get; set; }

    [Column(Order = 12)]
    public string? TransferUOM { get; set; }

    [Column(Order = 13)]
    public string? Tag { get; set; }

    [Column(Order = 14)]
    public bool HasVariant { get; set; }

    [Column(Order = 15)]
    public ItemStatus Status { get; set; }


    public ICollection<SalesPrice>? SalesPrices { get; set; }




    // Not Mapped objects

    [NotMapped]
    public decimal SalesPrice { get; set; }

    






    public ItemType ConvertStringToItemType(string name) {

        if(name.ToLower() == "0") {
            return ItemType.Good;
        }
        else if(name.ToLower() == "1") {
            return ItemType.Service;
        }
        else
        {
            return ItemType.Other;
        }
    }

    public ItemStatus ConvertStringToItemStatus(string name) {

        if(name.ToLower() == "0") {
            return ItemStatus.Active;
        }
        else if(name.ToLower() == "1") {
            return ItemStatus.Inactive;
        }
        else if(name.ToLower() == "2") {
            return ItemStatus.OutOfStock;
        }
        else if(name.ToLower() == "3") {
            return ItemStatus.Deleted;
        }
        else
        {
            return ItemStatus.Active;
        }
    }
}