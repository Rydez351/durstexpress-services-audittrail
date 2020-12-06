using System;
using System.Collections.Generic;
using System.Text;

namespace Durstexpress.Service.Audit.Domain
{
    public class BaseDbEntity
    {
        public int Id { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

    }
}
