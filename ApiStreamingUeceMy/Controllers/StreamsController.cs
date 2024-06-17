using ApiStreamingUeceMy.Controllers.Base;
using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Request.Command;
using ApiStreamingUeceMy.Domain.Request.Query;
using ApiStreamingUeceMy.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Controllers
{

    public class StreamsController : BaseController
    {
        public StreamsController(IMediator mediator) : base(mediator) {}
        
        [HttpPost("create")]
        public Task<IActionResult> Create([FromBody] CreateStreamViewModel stream)
           => SendRequest(new CreateStreamRequest(stream));

        [HttpGet("getById")]
        public Task<IActionResult> GetById([FromQuery] Guid id) => SendRequest(new StreamGetByIdQuery(id));

        [HttpGet("getAll")]
        public Task<IActionResult> GetAll()
            => SendRequest(new StreamGetAllQuery());
    }
}
