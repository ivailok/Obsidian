using Obsidian.Core.Contracts;
using Obsidian.Core.Contracts.Data.Repositories;

namespace Obsidian.Core.Data.Repositories
{
    public class ExpirationEntryRepository : IExpirationEntryRepository
    {
        private readonly ISqliteConnectionService sqliteConnectionService;

        public ExpirationEntryRepository(ISqliteConnectionService sqliteConnectionService)
        {
            this.sqliteConnectionService = sqliteConnectionService;
        }

        public void Add()
        {

        }
    }
}
