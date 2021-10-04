﻿using eShopSolution.Aplication.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Aplication.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIDs { get; set; }

    }
}
