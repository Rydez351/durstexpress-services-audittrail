using System.Threading;
using System.Threading.Tasks;
using Durstexpress.Service.Audit.Domain;
using Durstexpress.Services.AuditTrail.Application.Abstractions;
using Durstexpress.Services.AuditTrail.Application.Commands;
using MediatR;

namespace Durstexpress.Services.AuditTrail.Application.UseCases
{
    public class CreateAuditRowUseCase : IRequestHandler<CreateAuditRowCommand>
    {
        private IDatabase _database;

        public CreateAuditRowUseCase(IDatabase database)
        {
            _database = database;
        }

        public async Task<Unit> Handle(CreateAuditRowCommand request, CancellationToken cancellationToken)
        {
            var row = new AuditRowEntity();
            // todo create row in database
            await _database.WriteAuditRowAsync(row);

            return Unit.Value;
        }
    }
}