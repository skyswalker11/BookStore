using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set; }

        public FormResponse FormResponse { get; set; }

        public int Quantity { get; set; }
    }
    public class Basket
    {
     
        public List<BasketLineItem> Items { get; set; } =  new List<BasketLineItem>();

        public virtual void AddItem (FormResponse fr, int qty)
        {
            BasketLineItem Lines = Items
                .Where(r => r.FormResponse.ISBN == fr.ISBN)
                .FirstOrDefault();

            if (Lines == null)
            {
                Items.Add(new BasketLineItem
                {
                    FormResponse = fr,
                    Quantity = qty
                });
            }
            else
            {
                Lines.Quantity += qty;
            }

            
        }
        public virtual void RemoveItem(FormResponse fr)
        {
            Items.RemoveAll(x => x.FormResponse.ISBN == fr.ISBN);
        }

        public virtual void ClearBasket()
        {
            Items.Clear();
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
