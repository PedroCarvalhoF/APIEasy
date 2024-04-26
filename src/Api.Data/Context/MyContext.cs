using Api.Data.Mapping;
using Api.Domain.Entities.CategoriaPreco;
using Api.Domain.Entities.PrecoProduto;
using Api.Domain.Entities.ProdutoMedida;
using Data.Mapping;
using Domain.Entities.CategoriaProduto;
using Domain.Entities.PontoVendaPeriodoVenda;
using Domain.Entities.Produto;
using Domain.Entities.ProdutoTipo;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        //revisados
        public DbSet<CategoriaProdutoEntity>? CategoriasProdutos { get; set; }
        public DbSet<ProdutoTipoEntity>? TiposProdutos { get; set; }
        public DbSet<ProdutoMedidaEntity>? ProdutosMedidas { get; set; }
        public DbSet<ProdutoEntity>? Produtos { get; set; }
        public DbSet<PeriodoPontoVendaEntity>? PeriodosPontosVendas { get; set; }
        public DbSet<CategoriaPrecoEntity>? CategoriasPrecos { get; set; }

        public DbSet<CategoriaPrecoEntity>? PrecosProdutos { get; set; }


        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoriaProdutoEntity>(new CategoriaProdutoMap().Configure);
            modelBuilder.Entity<ProdutoTipoEntity>(new ProdutoTipoMap().Configure);
            modelBuilder.Entity<ProdutoMedidaEntity>(new ProdutoMedidaMap().Configure);
            modelBuilder.Entity<ProdutoEntity>(new ProdutoMap().Configure);


            modelBuilder.Entity<PeriodoPontoVendaEntity>(new PeriodoPontoVendaMap().Configure);
            modelBuilder.Entity<CategoriaPrecoEntity>(new CategoriaPrecoMap().Configure);
            modelBuilder.Entity<PrecoProdutoEntity>(new PrecoProdutoMap().Configure);

        }

    }
}
