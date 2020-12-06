using Durstexpress.Service.Audit.Domain;
using Durstexpress.Services.AuditTrail.Application.Abstractions;
using Durstexpress.Services.AuditTrail.Application.Queries;
using Durstexpress.Services.AuditTrail.Application.UseCases;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Durstexpress.Services.AuditTrail.Application.Test
{
    public class GetAuditRowByEntityTypeUseCaseTest
    {
        [Fact]
        public async Task GetAuditRowByEntityTypeUseCaseTest__GetAuditRows()
        {
            // -- Arrange
            var db = Substitute.For<IDatabase>();
            var auditRowList = new List<AuditRowEntity> {
            new AuditRowEntity{} , 
            new AuditRowEntity{}
            
            };
            db.GetAuditRowsAsync().Returns(auditRowList);

            //db.GetAuditRowsAsyn().Returns(new List<AuditRowEntity> {})

            var sut = new GetAuditRowByEntityTypeUseCase(db);

            // -- Act
            var cmd = new GetAuditRowByEntityTypeQuery();
            var result = await sut.Handle(cmd, CancellationToken.None);


            // -- Assert
            await db.Received().GetAuditRowsAsync();
            Assert.Equal(2, result.Count);
        }
    }
}
