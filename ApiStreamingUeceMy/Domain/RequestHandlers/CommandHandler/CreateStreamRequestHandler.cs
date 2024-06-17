using ApiStreamingUeceMy.Domain.Interfaces;
using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Request.Command;
using MediatR;
using OperationResult;
using System.Buffers.Text;
using System.Text;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Domain.RequestHandlers.CommandHandler;

public class CreateStreamRequestHandler : IRequestHandler<CreateStreamRequest, Result<Stream>>
{
    private readonly IStreamRepository _streamRepository;

    public CreateStreamRequestHandler(IStreamRepository streamRepository)
    {
        _streamRepository = streamRepository;
    }

    public async Task<Result<Model.Stream>> Handle(CreateStreamRequest request, CancellationToken cancellationToken)
    {
        Stream entity = new Stream()
        {
            Link =  request._stream.Link,
            Tipo = request._stream.Tipo,
            Arquivo = request._stream.Tipo.ToLower() == "video"? null: Encoding.ASCII.GetBytes(request._stream.Arquivo), 
        };
        _streamRepository.Create(entity).ConfigureAwait(false);
        var result = _streamRepository.GetById(entity.Id);

        return result;
    }
}
