using System;

namespace Durstexpress.Service.Audit.Domain
{
    public class AuditRowEntity : BaseDbEntity
    {
        public string ObjectId { get; set; }

        public string ObjectType { get; set; }

        public string Description { get; set; }

        public string ActionType { get; set; }
    }
}
