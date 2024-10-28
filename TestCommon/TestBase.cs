using EfLocalDb;

using EfLocalDbTest.Data;

using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EfLocalDbTest.TestCommon
{
    public abstract class TestBase
    {
        static SqlInstance<EfLocalDbTestDbContext> sqlInstance;

        static TestBase() =>
            sqlInstance = new(
                constructInstance: builder => new(builder.Options));

        public static Task<SqlDatabase<EfLocalDbTestDbContext>> LocalDb(
            [CallerFilePath] string testFile = "",
            string? databaseSuffix = null,
            [CallerMemberName] string memberName = "") =>
            sqlInstance.Build(testFile, databaseSuffix, memberName);
    }
}
