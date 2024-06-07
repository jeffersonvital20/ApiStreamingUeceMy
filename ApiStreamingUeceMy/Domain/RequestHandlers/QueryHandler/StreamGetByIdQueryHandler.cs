using ApiStreamingUeceMy.Domain.Interfaces;
using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Request.Query;
using MediatR;
using OperationResult;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Domain.RequestHandlers.QueryHandler;

public class StreamGetByIdQueryHandler : IRequestHandler<StreamGetByIdQuery, Result<Stream>>
{
    private readonly IStreamRepository _streamRepository;

    public StreamGetByIdQueryHandler(IStreamRepository streamRepository)
    {
        _streamRepository = streamRepository;
    }
    public async Task<Result<Model.Stream>> Handle(StreamGetByIdQuery request, CancellationToken cancellationToken)
    {
        var result = _streamRepository.GetById(request.Id);
        if (result == null) 
            return Result.Success(new Stream());
        return result;
    }
}
