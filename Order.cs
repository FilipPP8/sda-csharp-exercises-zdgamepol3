using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class Order
    {
        OrderItem[] orderItems;

        public Order(OrderItem[] orderItems)
        {
            this.orderItems = orderItems;
        }

        public void PrintTotalValue()
        {
            decimal sum = 0;
            
            foreach (OrderItem item in orderItems)
            {
                sum += item.GetValue();
     
            }
            Console.WriteLine($"Łączna wartość zamówienia wynosi: {sum} PLN.");
        }
    }
}
