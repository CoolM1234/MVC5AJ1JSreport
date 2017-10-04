using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using MVC5AJ1.Authorization.Roles;
using MVC5AJ1.Authorization.Users;
using MVC5AJ1.Chat;
using MVC5AJ1.Friendships;
using MVC5AJ1.MultiTenancy;
using MVC5AJ1.Storage;

namespace MVC5AJ1.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class MVC5AJ1DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public MVC5AJ1DbContext()
            : base("Default")
        {
            
        }

        public MVC5AJ1DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public MVC5AJ1DbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public MVC5AJ1DbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
