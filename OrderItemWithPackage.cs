using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class OrderItemWithPackage : OrderItem
    {
        public string packageName;
        public decimal packagePrice;
        public OrderItemWithPackage(string productName, int quantity, decimal unitPrice, 
            string packageName, decimal packagePrice)
            :base (productName, quantity, unitPrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        public override decimal GetValue()
        {
            return quantity * (unitPrice + packagePrice);
        }

        public override string ToString()
        {
            return $"{productName} - cena: {unitPrice} PLN, opakowanie: {packageName} ({packagePrice} PLN / szt.)," +
                $"sztuk: {quantity}, łączna wartość: {GetValue()} PLN.";
        }
    }
}
