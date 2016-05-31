namespace HaulvShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HaulvShopDbContext dbContext;

        public HaulvShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HaulvShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}