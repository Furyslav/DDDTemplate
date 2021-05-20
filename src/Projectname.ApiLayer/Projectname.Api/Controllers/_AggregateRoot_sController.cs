using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projectname.Client.Dto.Commands.Create_AggregateRoot_;
using Projectname.Client.Dto.Queries.Get_AggregateRoot_ById;
using Projectname.CrossCuttingLayer.Pipeline.MediatR;

namespace Projectname.Api.Controllers
{
    [ApiController]
    [Route("_AggregateRoot_s/v1")]
    public sealed class _AggregateRoot_sController : ControllerBase
    {
        private readonly IMediator _mediator;

        public _AggregateRoot_sController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public Task<Get_AggregateRoot_ByIdResult> Get(Guid id, CancellationToken cancellationToken)
        {
            var query = new Get_AggregateRoot_ByIdQuery
            {
                _AggregateRoot_Id = id
            };
            return _mediator.SendRequest<Get_AggregateRoot_ByIdQuery, Get_AggregateRoot_ByIdResult>(query,
                cancellationToken);
        }

        [HttpPost]
        [Authorize]
        public Task<Unit> Create([FromBody] Create_AggregateRoot_Command command, CancellationToken cancellationToken)
            => _mediator.SendRequest<Create_AggregateRoot_Command, Unit>(command, cancellationToken);
    }
}