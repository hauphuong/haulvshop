﻿using HaulvShop.Data.Infrastructure;
using HaulvShop.Model.Models;

namespace HaulvShop.Data.Repositories
{ 
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}