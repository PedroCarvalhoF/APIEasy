﻿using Easy.CrossCutting.DependencyInjection.Extensions;
using Easy.Domain.Entities;
using Easy.Domain.Entities.PDV.PrecoProduto;
using Easy.Domain.Entities.PDV.UserPDV;
using Easy.Domain.Entities.Produto;
using Easy.Domain.Entities.Produto.CategoriaProduto;
using Easy.Domain.Intefaces;
using Easy.Domain.Intefaces.Repository;
using Easy.Domain.Intefaces.Repository.PDV.PrecoProduto;
using Easy.Domain.Intefaces.Repository.PDV.UserPDV;
using Easy.Domain.Intefaces.Repository.Produto;
using Easy.Domain.Intefaces.Repository.Produto.Categoria;
using Easy.Domain.Intefaces.Repository.UserMasterCliente;
using Easy.Domain.Intefaces.Repository.UserMasterUser;
using Easy.InfrastructureData.Repository;
using Easy.InfrastructureData.Repository.PDV.PrecoProduto;
using Easy.InfrastructureData.Repository.PDV.UsuarioPdv;
using Easy.InfrastructureData.Repository.Produto;
using Easy.InfrastructureData.Repository.Produto.Categoria;
using Easy.InfrastructureData.Repository.UserMasterCliente;
using Easy.InfrastructureData.Repository.UserMasterUser;
using Easy.InfrastructureData.Seeds;
using Easy.Services.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Easy.CrossCutting.DependencyInjection
{
    public static class RegisterServices
    {
        public static void ConfigureDependenciesRepository(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //seeds testes
            serviceCollection.AddTransient<ISeedsTeste, SeedsTeste>();

            IdentityConfiguration.Configurar(serviceCollection, configuration);

            serviceCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddScoped<IUserService, UserService>();

            // UnitOfWork
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            serviceCollection.AddScoped(typeof(IUserMasterClienteRepository<>), typeof(UserMasterClienteRepository<>));
            serviceCollection.AddScoped(typeof(IUserMasterUserRepository<>), typeof(UserMasterUserRepository<>));

            serviceCollection.AddScoped
                (typeof(ICategoriaProdutoRepository<CategoriaProdutoEntity, FiltroBase>),
                 typeof(CategoriaProdutoRepository<CategoriaProdutoEntity, FiltroBase>));

            serviceCollection.AddScoped
              (typeof(IProdutoRepository<ProdutoEntity, FiltroBase>),
               typeof(ProdutoRepository<ProdutoEntity, FiltroBase>));

            serviceCollection.AddScoped
            (typeof(IPrecoProdutoRepository<PrecoProdutoEntity, FiltroBase>),
             typeof(PrecoProdutoRepository<PrecoProdutoEntity, FiltroBase>));

            serviceCollection.AddScoped
           (typeof(IUsuarioPdvRepository<UsuarioPdvEntity, FiltroBase>),
            typeof( UsuarioPdvRepository<UsuarioPdvEntity, FiltroBase>));

            var myhandlers = AppDomain.CurrentDomain.Load("Easy.Services");
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(myhandlers));
        }
    }
}