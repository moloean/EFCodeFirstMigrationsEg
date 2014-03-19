using System.Data.Entity;

namespace Persistence
{
    public abstract class BaseContext<TContext> : DbContext where TContext : DbContext
    {

        protected BaseContext()
            : this(null) { }


        protected BaseContext(IDatabaseInitializer<TContext> databaseInitializer)
            : base("cmfdb")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(databaseInitializer);
        }
    }
}
