using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Validation;
using MediatR;
using OperationResult;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Domain.Request.Query;

public class StreamGetByIdQuery : IRequest<Result<Stream>>, IValidatable
{
    public Guid Id { get; set; }
    public StreamGetByIdQuery(Guid id)
    => Id = id;
}