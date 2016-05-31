namespace HaulvShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}