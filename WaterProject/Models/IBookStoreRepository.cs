using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<FormResponse> FormResponses { get; }

        public void SaveBook(FormResponse fr);
        public void CreateBook(FormResponse fr);
        public void DeleteBook(FormResponse fr);

    }
}
