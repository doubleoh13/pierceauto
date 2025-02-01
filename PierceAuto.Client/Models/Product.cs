namespace PierceAuto.Client.Models;

internal class Product
{
    public int Id { get; set; }
    public string SKU { get; set; }
    public string Description { get; set; }
    public Supplier Supplier { get; set; }
    public ProductCategory ProductCategory { get; set; }

    public decimal Price { get; set; }
    public decimal Cost { get; set; }

    public double OnHand { get; set; }
    public double ReorderPoint { get; set; }
    public bool IsInventoryControlled { get; set; }
    public bool IsActive { get; set; } = true;
}