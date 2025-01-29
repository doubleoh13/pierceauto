using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PierceAuto.Models;

internal class Product : IHasID
{
    [DisplayName("Part Number")]
    [Required(ErrorMessage = "Part Number is required")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Part Number must be between 2 and 50 characters")]
    public string SKU { get; set; }

    [DisplayName("Product Name")]
    [Required(ErrorMessage = "Product Name is required")]
    public string Name { get; set; }

    [DisplayName("Product ID")] public int ID { get; set; }
}