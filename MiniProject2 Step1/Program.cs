// Created Product List

List<Product> products = new List<Product>();


while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("To enter a new product - follow the steps | To quit - enter: \"Q\"");
    Console.ResetColor();

    Console.Write("Enter a Category:");
    string category = Console.ReadLine();

    if (category.ToLower().Trim() == "q")
    {
        break;
    }


    Console.Write("Enter a Product Name:");
    string productName = Console.ReadLine();

    if (productName.ToLower().Trim() == "q")
    {
        break;
    }

    Console.Write("Enter a Price:");
   
    
    int price = Convert.ToInt32(Console.ReadLine());
    if (price.ToString().ToLower().Trim() == "q")
    {
        break;
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Product was successfully added!");
    Console.ResetColor();

    Console.WriteLine("----------------------------------------------");


    products.Add(new Product(category,productName,price));

    

}

Console.WriteLine("----------------------------------------------");

// Created sorted list

List<Product> sortedList = products.OrderBy(product => product.Price).ToList();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Category".PadRight(15) + "ProductName".PadRight(17) + "Price");
Console.ResetColor();

foreach (Product product in sortedList)
{
    Console.WriteLine(product.Category.PadRight(15) +
        product.ProductName.PadRight(17) + product.Price.ToString());
    
}

Console.WriteLine();
int totalAmount = products.Sum(product => product.Price);
Console.WriteLine("               " + "Total Amount:    " + totalAmount);

Console.WriteLine("-----------------------------------------------");

ProductAction.addProducts(products);

List<Product> sortedProducts = products.OrderBy(product => product.Price).ToList();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Category".PadRight(15) + "ProductName".PadRight(20) + "Price".PadRight(15));
Console.ResetColor();

foreach (Product product in sortedProducts)
{
    Console.WriteLine(product.Category.PadRight(15) +
        product.ProductName.PadRight(20) + product.Price.ToString().PadRight(15));
}


Console.WriteLine();
int totalAmt = products.Sum(product => product.Price);
Console.WriteLine("               " + "Total Amount:       " + totalAmount);

Console.WriteLine("-----------------------------------------------");

public class Product
{
    //Properties
    public Product(string category, string productName, int price)
    {
        Category = category;
        ProductName = productName;
        Price = price;
    }

    //Methods
    public string Category { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }

    

}

public static class ProductAction
{
    public static void addProducts(List<Product> products) {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("To enter a new product - enter: \"p\"  | To search for a product \"s\" | To quit - enter: \"Q\"");
        Console.ResetColor();

        while (true) { 
        string action = Console.ReadLine();



        if (action.ToLower().Equals("p"))
        {
            Console.Write("Enter a Category:");
            string category = Console.ReadLine();

            if (category.ToLower().Trim() == "q")
            {
                break;
            }


            Console.Write("Enter a Product Name:");
            string productName = Console.ReadLine();

            if (category.ToLower().Trim() == "q")
            {
                break;
            }

            Console.Write("Enter a Price:");


            int price = Convert.ToInt32(Console.ReadLine());
            if (price.ToString().ToLower().Trim() == "q")
            {
                ;
            }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product was successfully added!");
                Console.ResetColor();

            Console.WriteLine("----------------------------------------------");


            products.Add(new Product(category, productName, price));


        }
            

        }
    }

}