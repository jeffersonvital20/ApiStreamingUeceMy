﻿using ApiStreamingUeceMy.Domain.Request.Command;

namespace AppChurch.Ioc.Dependences
{
    public static class MediatrExtension
    {
        public static void AddMediatRApi(this IServiceCollection services)
        {
            //services.AddMediatR(typeof(CreateMembroRequest).Assembly);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateStreamRequest).Assembly));
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AutorizarUsuarioRequest).Assembly));
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UpdateMembroRequest).Assembly));
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(UsuarioGetByIdQuery).Assembly));
        }
    }
}
