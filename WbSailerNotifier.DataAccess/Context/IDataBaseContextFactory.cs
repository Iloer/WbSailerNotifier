namespace WbSailerNotifier.DataAccess.Context
{
    public interface IDatabaseContextFactory
    {
        DatabaseContext CreateDbContext();
    }
}
