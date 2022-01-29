using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class OrderItem
    {
        public string productName;
        public int quantity;
        public decimal unitPrice;

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public virtual decimal GetValue()
        {
            return quantity * unitPrice;
        }

        public override string ToString()
        {
            return $"{productName} - cena: {unitPrice} PLN, sztuk: {quantity}, łączna wartość: {GetValue()} PLN.";
        }

    }
}
