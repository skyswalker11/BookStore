﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<FormResponse> FormResponses { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
