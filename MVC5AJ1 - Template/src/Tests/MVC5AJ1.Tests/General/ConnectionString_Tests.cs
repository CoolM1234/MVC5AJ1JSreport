using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace MVC5AJ1.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=MVC5AJ1; Trusted_Connection=True;");
            csb["Database"].ShouldBe("MVC5AJ1");
        }
    }
}
