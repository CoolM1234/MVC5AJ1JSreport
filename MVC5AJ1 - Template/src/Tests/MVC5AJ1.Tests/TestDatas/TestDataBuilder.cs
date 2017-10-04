using EntityFramework.DynamicFilters;
using MVC5AJ1.EntityFramework;

namespace MVC5AJ1.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MVC5AJ1DbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(MVC5AJ1DbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
