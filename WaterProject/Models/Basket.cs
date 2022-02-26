using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BasketLineItem
    {
        public int LineID { get; set; }

        public FormResponse FormResponse { get; set; }

        public int Quantity { get; set; }
    }
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } =  new List<BasketLineItem>();

        public void AddItem (FormResponse fr, int qty)
        {
            BasketLineItem line = Items
                .Where(r => r.FormResponse.ISBN == fr.ISBN)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    FormResponse = fr,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }

            
        }
        //public double CalculateTotal(FormResponse fr)
        //{
        //    double sum = Items.Sum(x => x.Quantity * fr.Price);

        //    return sum;
        //}
        public double CalculateTotal(List<BasketLineItem> List)
        {
            double total = 0;

            foreach (var i in List)
            {
                total += i.FormResponse.Price * i.Quantity;
            }
            return total;
        }
    }
   
    
   
}
