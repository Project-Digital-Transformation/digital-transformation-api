using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design; //VSCode says these are unneccesary.. whot

namespace Jet_Piranha.Data;

public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
    public StoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

        optionsBuilder.UseSqlite("Data Source=../Registr.sqlite");

        return new StoreContext(optionsBuilder.Options);
    }
//https://youtu.be/UeTfTup0H5w?si=T1HVDEdKpk_V2PFS for help
}

