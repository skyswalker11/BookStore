using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookContext context { get; set; }
        public EFBookStoreRepository (BookContext temp)
        {
            context = temp;
        }
        public IQueryable<FormResponse> FormResponses => context.FormResponses;

        public void SaveBook(FormResponse fr)
        {
            context.SaveChanges();
        }

        public void CreateBook(FormResponse fr)
        {
            context.Add(fr);
            context.SaveChanges();
        }

        public void DeleteBook(FormResponse fr)
        {
            context.Remove(fr);
            context.SaveChanges();
        }
    }
}
