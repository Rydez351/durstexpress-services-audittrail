using MediatR;

namespace Durstexpress.Services.AuditTrail.Application.Commands
{
    public class CreateAuditRowCommand : IRequest<Unit>
    {
        public CreateAuditRowCommand(string entityType)
        {
            EntityType = entityType;
        }
        
        public string EntityType { get; }
    }
}