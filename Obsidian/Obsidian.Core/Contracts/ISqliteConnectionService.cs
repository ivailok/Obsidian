using SQLite;

namespace Obsidian.Core.Contracts
{
    public interface ISqliteConnectionService
    {
        SQLiteAsyncConnection GetAsyncConnection();
    }
}
