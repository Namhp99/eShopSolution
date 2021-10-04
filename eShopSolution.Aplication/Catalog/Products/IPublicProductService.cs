using eShopSolution.Aplication.Catalog.Dtos;
using eShopSolution.Aplication.Catalog.Products.Dtos;
using eShopSolution.Aplication.Catalog.Products.Dtos.Public;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Aplication.Catalog.Products
{
    public interface IPublicProductService
    {
        Task <PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
