namespace CompositePatternDemo;

public class ProductLeaf : Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ProductLeaf(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}
