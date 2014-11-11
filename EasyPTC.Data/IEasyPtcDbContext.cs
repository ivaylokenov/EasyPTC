namespace EasyPTC.Data
{
    using EasyPTC.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IEasyPtcDbContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Advertisement> Advertisements { get; set; }

        IDbSet<Category> Categories { get; set; }

        DbContext DbContext { get; }

        int SaveChanges();

        void Dispose();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
