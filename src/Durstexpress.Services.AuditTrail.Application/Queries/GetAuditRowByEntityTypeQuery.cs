using Durstexpress.Service.Audit.Domain;
using MediatR;
using System.Collections;
using System.Collections.Generic;

namespace Durstexpress.Services.AuditTrail.Application.Queries
{
    public class GetAuditRowByEntityTypeQuery : IRequest<IList<AuditRowEntity>>
    {
        
    }
}