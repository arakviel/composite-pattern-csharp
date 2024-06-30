namespace CompositePatternDemo;

public class Box : Product
{
    private List<Product> Products { get; }
    public decimal Price
    {
        get
        {
            decimal total = 0.0m;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }

    public Box()
    {
        Products = new List<Product>();
    }

    public Box(List<Product> products)
    {
        Products = products;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public void DisplayContents(int depth = 0)
    {
        foreach (var product in Products)
        {
            if (product is ProductLeaf)
            {
                var leaf = product as ProductLeaf;
                Console.WriteLine(new String(' ', depth * 2) + $"- {leaf.Name}: ${leaf.Price}");
            }
            else if (product is Box)
            {
                var box = product as Box;
                Console.WriteLine(new String(' ', depth * 2) + "Box:");
                box.DisplayContents(depth + 1);
            }
        }
    }
}
