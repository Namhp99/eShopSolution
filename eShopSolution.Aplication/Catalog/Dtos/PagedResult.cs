using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Aplication.Catalog.Dtos
{
    public class PagedResult<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { get; set; }
    }
}
