using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Domain.Validation;
using ApiStreamingUeceMy.ViewModels;
using MediatR;
using OperationResult;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Domain.Request.Command
{
    public class CreateStreamRequest : IRequest<Result<Stream>>, IValidatable
    {
        public CreateStreamViewModel _stream { get; set; }
        public CreateStreamRequest(CreateStreamViewModel stream)
        {
            _stream = stream;
        }
    }
}
