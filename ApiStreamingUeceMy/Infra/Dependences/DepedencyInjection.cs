
using ApiStreamingUeceMy.Domain.Interfaces;
using ApiUsuariosUeceMy.Infra.Repositories;

namespace ApiStreamingUeceMy.Dependences
{
    public static class DepedencyInjection
    {
        public static void AddDepencies(this IServiceCollection services)
        {
            AddRepositoryDependency(services);
        }

        private static void AddRepositoryDependency(IServiceCollection services)
        {
            services.AddScoped<IStreamRepository, StreamRepository>();
        }
    }
}
