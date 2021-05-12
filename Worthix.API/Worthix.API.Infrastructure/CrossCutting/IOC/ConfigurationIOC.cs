using Autofac;
using Worthix.API.Application;
using Worthix.API.Application.Interfaces;
using Worthix.API.Application.Mappers;
using Worthix.API.Domain.Core.Interfaces.Repositories;
using Worthix.API.Domain.Core.Interfaces.Services;
using Worthix.API.Domain.Services;
using Worthix.API.Infrastructure.Data.Repositories;

namespace Worthix.API.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceAutor>().As<IApplicationServiceAutor>();
            builder.RegisterType<ApplicationServiceLivro>().As<IApplicationServiceLivro>();
            builder.RegisterType<ServiceAutor>().As<IServiceAutor>();
            builder.RegisterType<ServiceLivro>().As<IServiceLivro>();
            builder.RegisterType<RepositoryAutor>().As<IRepositoryAutor>();
            builder.RegisterType<RepositoryLivro>().As<IRepositoryLivro>();
            builder.RegisterType<MapperAutor>().As<IMapperAutor>();
            builder.RegisterType<MapperLivro>().As<IMapperLivro>();

            #endregion
        }
    }
}
