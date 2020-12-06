using Durstexpress.Service.Audit.Domain;
using Durstexpress.Services.AuditTrail.Application.Abstractions;
using Durstexpress.Services.AuditTrail.Application.Queries;
using MediatR;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Durstexpress.Services.AuditTrail.Application.UseCases
{
    public class GetAuditRowByEntityTypeUseCase : IRequestHandler<GetAuditRowByEntityTypeQuery, IList<AuditRowEntity>>
    {
        private IDatabase _database;

        public GetAuditRowByEntityTypeUseCase(IDatabase database)
        {
            _database = database;
        }

        public async Task<IList<AuditRowEntity>> Handle(GetAuditRowByEntityTypeQuery request, CancellationToken cancellationToken)
        {
            var auditRowList = await _database.GetAuditRowsAsync();

            return auditRowList;
        }

    }
}