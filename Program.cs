using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem item1 = new OrderItem("Chleb", 5, 4);
            OrderItemWithPackage item2 = new OrderItemWithPackage("Mleko", 4, 2.2m, "butelka szklana", 1);

            Console.WriteLine(item1);
            Console.WriteLine(item2);

            OrderItem[] orderItems = new OrderItem[2];
            orderItems[0] = item1;
            orderItems[1] = item2;

            Order order = new Order (orderItems);

            order.PrintTotalValue();
        }
    }
}
