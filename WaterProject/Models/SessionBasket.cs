using BookStore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SessionBasket : Basket
    {

        public static Basket GetBasket (IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionBasket basket = session?.GetJson<SessionBasket>("Basket") ?? new SessionBasket();

            basket.Session = session; 

            return basket;
        }

        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(FormResponse fr, int qty)
        {
            base.AddItem(fr, qty);
            Session.SetJson("Basket", this);
        }
        public override void RemoveItem(FormResponse fr)
        {
            base.RemoveItem(fr);
            Session.SetJson("Basket", this);
        }
        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Basket");
        }
    }
}
