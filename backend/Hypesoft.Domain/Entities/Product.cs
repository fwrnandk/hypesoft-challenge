namespace Hypesoft.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public Guid CategoryId { get; private set; }

    protected Product() { } // necessário para ORMs, mas não usado aqui

    public Product(string name, decimal price, Guid categoryId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        CategoryId = categoryId;
    }
}
