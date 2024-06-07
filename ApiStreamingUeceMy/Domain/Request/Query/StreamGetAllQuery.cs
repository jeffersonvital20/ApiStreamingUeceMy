using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Validation;
using MediatR;
using OperationResult;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Domain.Request.Query;

public class StreamGetAllQuery : IRequest<Result<List<Stream>>>, IValidatable
{
}
