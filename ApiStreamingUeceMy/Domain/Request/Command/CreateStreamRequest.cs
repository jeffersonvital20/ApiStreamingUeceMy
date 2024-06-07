using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Validation;
using MediatR;
using OperationResult;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Domain.Request.Command
{
    public class CreateStreamRequest : IRequest<Result<Stream>>, IValidatable
    {
        public Stream _stream { get; set; }
        public CreateStreamRequest(Stream stream)
        {
            _stream = stream;
        }
    }
}
