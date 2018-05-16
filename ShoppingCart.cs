using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class ShoppingCart
    {
        private List<ItemToPurchase> itemsToPurchase;
        private double paymentAmount;
        private string paymentType;
        private Costumer costumer;

        ShoppingCart()
        {
            itemsToPurchase = new List<ItemToPurchase>();
        }
        public void addProduct(ItemToPurchase itemParam)
        {
            foreach (ItemToPurchase item in itemsToPurchase)
            {
                if (item.Product == itemParam.Product)
                {
                    item.Quantity += itemParam.Quantity;
                    paymentAmount += item.Quantity * item.Product.price;
                    Console.WriteLine("addProduct " + itemParam.Quantity);
                    return;
                }
            }
            itemsToPurchase.Add(itemParam);
            paymentAmount += itemParam.Quantity * itemParam.Product.price;
            Console.WriteLine("addProduct " + itemParam.Quantity);
        }
        public void removeProduct(ItemToPurchase itemParam)
        {
            foreach (ItemToPurchase item in itemsToPurchase)
            {
                if (item.Product == itemParam.Product)
                {
                    if (item.Quantity > itemParam.Quantity)
                    {
                        item.Quantity -= itemParam.Quantity;
                        paymentAmount -= itemParam.Quantity * item.Product.price;
                        Console.WriteLine("removeProduct " + item.Quantity);
                    }
                    else
                    {
                        paymentAmount -= item.Quantity * item.Product.price;
                        itemsToPurchase.Remove(item);
                        Console.WriteLine("removeProduct");
                    }

                }
            }
        }
        public void sendInvoiceByEmail()
        {
            Console.WriteLine("sendInvoiceByEmail");
        }
        public void placeOrder()
        {
            this.sendInvoiceByEmail();
            itemsToPurchase.Clear();
            paymentAmount = 0;
            Console.WriteLine("placeOrder");
        }
        public void cancelOrder()
        {
            itemsToPurchase.Clear();
            paymentAmount = 0;
            Console.WriteLine("cancelOrder");
        }
        public double PaymentAmount
        {
            get
            {
                return paymentAmount;
            }

            set
            {
                paymentAmount = value;
            }
        }
        public Costumer Costumer
        {
            get
            {
                return costumer;
            }

            set
            {
                costumer = value;
            }
        }
        public string PaymentType
        {
            get
            {
                return paymentType;
            }

            set
            {
                paymentType = value;
            }
        }
    }
}
