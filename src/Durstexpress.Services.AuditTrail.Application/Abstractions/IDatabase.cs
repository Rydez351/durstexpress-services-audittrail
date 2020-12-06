using Durstexpress.Service.Audit.Domain;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Durstexpress.Services.AuditTrail.Application.Abstractions
{
    public interface IDatabase
    {
        Task WriteAuditRowAsync(AuditRowEntity row);

        Task<IList<AuditRowEntity>> GetAuditRowsAsync();
    }
}