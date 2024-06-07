using ApiStreamingUeceMy.Domain.Interfaces;
using ApiStreamingUeceMy.Domain.Model;
using ApiStreamingUeceMy.Infra.Context;
using ApiStreamingUeceMy.Infra.Repositories;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiUsuariosUeceMy.Infra.Repositories;

public class StreamRepository : BaseRepository<Stream>, IStreamRepository
{
    public StreamRepository(AppDbContext context) : base(context)
    {
    }

}
