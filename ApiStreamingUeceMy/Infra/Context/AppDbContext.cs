using ApiStreamingUeceMy.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Stream = ApiStreamingUeceMy.Domain.Model.Stream;

namespace ApiStreamingUeceMy.Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Stream>? Stream { get; set; }

}
