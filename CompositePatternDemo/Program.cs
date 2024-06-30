namespace CompositePatternDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Створюємо продукти
        var apple = new ProductLeaf(1, "Apple", 1.00m);
        var banana = new ProductLeaf(2, "Banana", 0.50m);
        var orange = new ProductLeaf(3, "Orange", 0.75m);
        var maracuya = new ProductLeaf(6, "Maracuya", 1.25m);

        var chocolate = new ProductLeaf(4, "Chocolate", 2.00m);
        var cookie = new ProductLeaf(5, "Cookie", 1.50m);

        // Створюємо коробки
        var fruitBox = new Box();
        fruitBox.AddProduct(apple);
        fruitBox.AddProduct(banana);
        fruitBox.AddProduct(orange);

        var smallFruitBox = new Box();
        smallFruitBox.AddProduct(maracuya);
        fruitBox.AddProduct(smallFruitBox);

        var snackBox = new Box();
        snackBox.AddProduct(chocolate);
        snackBox.AddProduct(cookie);

        // Створюємо велику коробку, що містить інші коробки
        var bigBox = new Box();
        bigBox.AddProduct(fruitBox);
        bigBox.AddProduct(snackBox);

        // Виводимо вміст великої коробки
        Console.WriteLine("Big Box contains:");
        bigBox.DisplayContents();

        // Виводимо загальну ціну великої коробки
        Console.WriteLine($"Total price of Big Box: ${bigBox.Price}");
    }
}
