using ApiStreamingUeceMy.Domain.Interfaces;
using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Request.Query;
using MediatR;
using OperationResult;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Domain.RequestHandlers.QueryHandler;

public class StreamGetAllQueryHandler : IRequestHandler<StreamGetAllQuery, Result<List<Stream>>>
{
    private readonly IStreamRepository _streamRepository;

    public StreamGetAllQueryHandler(IStreamRepository streamRepository)
    {
        _streamRepository = streamRepository;
    }
    public async Task<Result<List<Stream>>> Handle(StreamGetAllQuery request, CancellationToken cancellationToken)
    {
        return _streamRepository.GetAll().ToList<Stream>();
    }
}
