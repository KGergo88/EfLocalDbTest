using EfLocalDbTest.Data;
using EfLocalDbTest.TestCommon;

namespace EfLocalDbTest.TestProjectB;

public class TestClassB1 : TestBase
{
    [Fact]
    public async Task Test1()
    {
        await using var testDatabase = await LocalDb(databaseSuffix: Guid.NewGuid().ToString());
        var dbContext =  testDatabase.Context;

        dbContext.Cars.Add(
            new CarEntity
            {
                Id = Guid.NewGuid(),
                Manufacturer = "Seat",
                Model = "Cordoba",
                BuiltOn = DateTime.Now,
                Color = "yellow"
            }
        );

        await dbContext.SaveChangesAsync();
    }
}
