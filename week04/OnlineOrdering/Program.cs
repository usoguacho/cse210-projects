// Order 1: domestic customer
Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
Customer customer1 = new Customer("Jordan Reyes", address1);
Order order1 = new Order(customer1);

order1.AddProduct(new Product("Wireless Mouse", "A100", 24.99, 2));
order1.AddProduct(new Product("Mechanical Keyboard", "A101", 89.50, 1));
order1.AddProduct(new Product("USB-C Hub", "A102", 34.75, 1));

// Order 2: international customer 
Address address2 = new Address("48 Rue de Rivoli", "Paris", "Île-de-France", "France");
Customer customer2 = new Customer("Camille Laurent", address2);
Order order2 = new Order(customer2);

order2.AddProduct(new Product("Desk Lamp", "B200", 42.00, 1));
order2.AddProduct(new Product("Notebook Set", "B201", 12.25, 3));

List<Order> orders = new List<Order> { order1, order2 };

int orderNumber = 1;
foreach (Order order in orders)
{
    Console.WriteLine($"===== Order {orderNumber} =====");

    Console.WriteLine("Packing Label:");
    Console.WriteLine(order.GetPackingLabel());
    Console.WriteLine();

    Console.WriteLine("Shipping Label:");
    Console.WriteLine(order.GetShippingLabel());
    Console.WriteLine();

    Console.WriteLine($"Total Price: {order.GetTotalCost():C}");
    Console.WriteLine();

    orderNumber++;
}