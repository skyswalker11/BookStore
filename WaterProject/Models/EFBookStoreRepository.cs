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
    }
}
