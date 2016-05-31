using System;

namespace HaulvShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HaulvShopDbContext Init();
    }
}