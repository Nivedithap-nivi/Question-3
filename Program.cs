namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                Product product = new Product();
                DeliverService deliveryService = new DeliverService();

                Console.WriteLine("Enter the product name");
                product.Name = Console.ReadLine();

                Console.WriteLine("Enter the number of stocks");
                product.Stock = int.Parse(Console.ReadLine());

                try
                {
                    bool result = deliveryService.PlaceOrder(product);
                    if (result)
                    {
                        Console.WriteLine("Order placed successfully");
                    }
                }
                catch (ProductOutOfStockException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Thank You! Shop Again.");
                }
            
        }
    }
}
    

