using System.Threading;
using System.Threading.Tasks;
using Durstexpress.Service.Audit.Domain;
using Durstexpress.Services.AuditTrail.Application.Abstractions;
using Durstexpress.Services.AuditTrail.Application.Commands;
using Durstexpress.Services.AuditTrail.Application.UseCases;
using NSubstitute;
using Xunit;

namespace Durstexpress.Services.AuditTrail.Application.Test
{
    public class CreateAuditRowUseCaseTest
    {
        [Fact]
        public async Task CreateAuditRowUseCaseTest__CreatesAuditRow()
        {
            // -- Arrange
            var db = Substitute.For<IDatabase>();

            var sut = new CreateAuditRowUseCase(db);

            // -- Act
            var cmd = new CreateAuditRowCommand("orders");
            await sut.Handle(cmd, CancellationToken.None);

            // -- Assert
            await db.Received().WriteAuditRowAsync(Arg.Any<AuditRowEntity>());
        }
    }
}