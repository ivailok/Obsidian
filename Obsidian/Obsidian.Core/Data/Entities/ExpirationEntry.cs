using System;

namespace Obsidian.Core.Data.Entities
{
    public class ExpirationEntry
    {
        public int Id { get; set; }

        public string ProductTypeId { get; set; }

        public string ProducerId { get; set; }

        public DateTime Expiration { get; set; }
    }
}
