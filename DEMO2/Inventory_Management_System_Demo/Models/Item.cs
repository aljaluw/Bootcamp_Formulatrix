using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Inventory_Management_System_Demo.Models;

public class Item
{
    [Key]
    public int ItemId { get; set; }
    [Required]
    [DisplayName("Name")]
    public string ItemName { get; set; }
    [DisplayName("Description")]
    public string? ItemDescription { get; set; }
    public bool Availability { get; set;} = true;
}
