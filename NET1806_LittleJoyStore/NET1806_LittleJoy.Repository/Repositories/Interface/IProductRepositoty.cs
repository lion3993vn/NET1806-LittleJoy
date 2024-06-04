﻿using NET1806_LittleJoy.Repository.Commons;
using NET1806_LittleJoy.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1806_LittleJoy.Repository.Repositories.Interface
{
    public interface IProductRepositoty
    {
        public Task<Pagination<Product>> GetAllProductPagingAsync(PaginationParameter paginationParameter);

        public Task<Product?> GetProductByIdAsync(int productId);

        public Task<Product> AddNewProductAsync(Product productInfo);

        public Task<bool> DeleteProductAsync(Product productInfo);

        public Task<Product> UpdateProductAsync(Product productModify, Product productPlace);

    }
}
