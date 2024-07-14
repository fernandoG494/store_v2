namespace Infrastructure.Entities;

public partial class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public DateTime CreationDate { get; set; }
    public int BrandId { get; set; }
    public int CategoryId { get; set; }
    public virtual Brand Brand { get; set; } = null!;
    public virtual Category Category { get; set; } = null!;
}
