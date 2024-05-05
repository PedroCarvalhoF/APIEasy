﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoCategoria")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoCategoria")
                        .IsUnique();

                    b.ToTable("CategoriasPrecos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("710bd8dd-1853-43a1-8708-ca1f259d71ad"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(6193),
                            DescricaoCategoria = "Balcão",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(6205)
                        },
                        new
                        {
                            Id = new Guid("5533b87c-72d5-4033-85c4-ae44f5a3210c"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(6208),
                            DescricaoCategoria = "IFood",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(6211)
                        },
                        new
                        {
                            Id = new Guid("ed65a4e3-a0b0-40a7-b7ae-3397a965d924"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(6213),
                            DescricaoCategoria = "Lojista",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(6215)
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.Pedido.PedidoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CategoriaPrecoEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NumeroPedido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("PontoVendaEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SituacaoPedidoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime");

                    b.Property<Guid>("UserCreatePedidoId")
                        .HasColumnType("char(36)");

                    b.Property<decimal?>("ValorDesconto")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ValorPedido")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaPrecoEntityId");

                    b.HasIndex("PontoVendaEntityId");

                    b.HasIndex("SituacaoPedidoEntityId");

                    b.HasIndex("UserCreatePedidoId");

                    b.ToTable("Pedidos", (string)null);
                });

            modelBuilder.Entity("Api.Domain.Entities.PontoVenda.PontoVendaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("AbertoFechado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("IdPerfilAbriuPDV")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdPerfilUtilizarPDV")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PeriodoPontoVendaEntityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("IdPerfilAbriuPDV");

                    b.HasIndex("IdPerfilUtilizarPDV");

                    b.HasIndex("PeriodoPontoVendaEntityId");

                    b.ToTable("PontosVendas", (string)null);
                });

            modelBuilder.Entity("Api.Domain.Entities.PrecoProduto.PrecoProdutoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoriaPrecoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PrecoProduto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProdutoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaPrecoEntityId");

                    b.HasIndex("ProdutoEntityId");

                    b.ToTable("PrecosProdutos", (string)null);
                });

            modelBuilder.Entity("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Descricao")
                        .IsUnique();

                    b.ToTable("ProdutosMedidas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("414a646f-1146-4b6d-bbfc-39a26e74a091"),
                            CreateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(2295),
                            Descricao = "Unidade",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(2293)
                        },
                        new
                        {
                            Id = new Guid("2f943e86-f06f-4f7d-babf-48d0d2d8f3ac"),
                            CreateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(2304),
                            Descricao = "Caixa",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(2303)
                        });
                });

            modelBuilder.Entity("Domain.Entities.CategoriaProduto.CategoriaProdutoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoCategoria")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoCategoria")
                        .IsUnique();

                    b.ToTable("CategoriasProdutos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a9b05f16-71f0-4f77-a653-52c1a15b36bc"),
                            CreateAt = new DateTime(2024, 5, 4, 20, 3, 3, 979, DateTimeKind.Utc).AddTicks(9488),
                            DescricaoCategoria = "Executivos",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 20, 3, 3, 979, DateTimeKind.Utc).AddTicks(9484)
                        },
                        new
                        {
                            Id = new Guid("d9d229c4-9a64-4836-af41-2f111f229c46"),
                            CreateAt = new DateTime(2024, 5, 4, 20, 3, 3, 979, DateTimeKind.Utc).AddTicks(9514),
                            DescricaoCategoria = "Bebidas",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 20, 3, 3, 979, DateTimeKind.Utc).AddTicks(9513)
                        });
                });

            modelBuilder.Entity("Domain.Entities.FormaPagamento.FormaPagamentoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoFormaPg")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoFormaPg")
                        .IsUnique();

                    b.ToTable("FormasPagamentos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("92008957-f185-4563-9d9e-7b71f4ea2691"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(173),
                            DescricaoFormaPg = "Dinheiro",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(216)
                        });
                });

            modelBuilder.Entity("Domain.Entities.PedidoSituacao.SituacaoPedidoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoSituacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoSituacao")
                        .IsUnique();

                    b.ToTable("SituacoesPedidos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("abc0f0f9-3295-439c-a468-795b071b7f22"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(1278),
                            DescricaoSituacao = "Aberto",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(1283)
                        },
                        new
                        {
                            Id = new Guid("185b07da-7e82-43d1-b61f-912d8b29a34c"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(1287),
                            DescricaoSituacao = "Fechado",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(1288)
                        },
                        new
                        {
                            Id = new Guid("11b17cc5-c8b1-48f9-b9fd-886339441328"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(1292),
                            DescricaoSituacao = "Cancelado",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 987, DateTimeKind.Local).AddTicks(1293)
                        });
                });

            modelBuilder.Entity("Domain.Entities.PontoVendaPeriodoVenda.PeriodoPontoVendaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoPeriodo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoPeriodo")
                        .IsUnique();

                    b.ToTable("PeriodosPontosVendas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("567906bb-6eb4-42e9-b890-10e6da214766"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4668),
                            DescricaoPeriodo = "Almoço",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4676)
                        },
                        new
                        {
                            Id = new Guid("fc6a5d67-8356-4270-b9e6-7749b553dcf3"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4680),
                            DescricaoPeriodo = "Janta",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4681)
                        },
                        new
                        {
                            Id = new Guid("f14c83df-1fa4-4a83-8070-b16ecb19aa77"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4684),
                            DescricaoPeriodo = "Dia Todo",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4685)
                        },
                        new
                        {
                            Id = new Guid("7e107de8-c97a-435b-9976-7a689ca28bb7"),
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4688),
                            DescricaoPeriodo = "Noturno",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(4690)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Produto.ProdutoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CategoriaProdutoEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<string>("CodigoBarrasPersonalizado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("ProdutoMedidaEntityId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProdutoTipoEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaProdutoEntityId");

                    b.HasIndex("CodigoBarrasPersonalizado")
                        .IsUnique();

                    b.HasIndex("NomeProduto")
                        .IsUnique();

                    b.HasIndex("ProdutoMedidaEntityId");

                    b.HasIndex("ProdutoTipoEntityId");

                    b.ToTable("Produtos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0e75a80-0b64-4b2b-9f53-f3dce3f6d126"),
                            CategoriaProdutoEntityId = new Guid("a9b05f16-71f0-4f77-a653-52c1a15b36bc"),
                            CodigoBarrasPersonalizado = "01",
                            CreateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(3323),
                            Descricao = "",
                            Habilitado = true,
                            ImgUrl = "",
                            NomeProduto = "Agua sem gas",
                            Observacoes = "",
                            ProdutoMedidaEntityId = new Guid("414a646f-1146-4b6d-bbfc-39a26e74a091"),
                            ProdutoTipoEntityId = new Guid("edddccfa-a4af-4831-b9ee-29bdd5f755af"),
                            UpdateAt = new DateTime(2024, 5, 4, 17, 3, 3, 981, DateTimeKind.Local).AddTicks(3336)
                        });
                });

            modelBuilder.Entity("Domain.Entities.ProdutoTipo.ProdutoTipoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoTipoProduto")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoTipoProduto")
                        .IsUnique();

                    b.ToTable("TiposProdutos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("edddccfa-a4af-4831-b9ee-29bdd5f755af"),
                            CreateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(1240),
                            DescricaoTipoProduto = "Venda",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(1250)
                        },
                        new
                        {
                            Id = new Guid("1e11b25a-8bf5-4d57-80b7-396d09cbfcf1"),
                            CreateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(1252),
                            DescricaoTipoProduto = "Materia Prima",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 5, 4, 20, 3, 3, 980, DateTimeKind.Utc).AddTicks(1255)
                        });
                });

            modelBuilder.Entity("Domain.Entities.UsuarioSistema.PerfilUsuarioEntity", b =>
                {
                    b.Property<Guid>("IdentityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("IdentityId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("PerfisUsuarios", (string)null);
                });

            modelBuilder.Entity("Api.Domain.Entities.Pedido.PedidoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", "CategoriaPrecoEntity")
                        .WithMany()
                        .HasForeignKey("CategoriaPrecoEntityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.PontoVenda.PontoVendaEntity", "PontoVendaEntity")
                        .WithMany()
                        .HasForeignKey("PontoVendaEntityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PedidoSituacao.SituacaoPedidoEntity", "SituacaoPedidoEntity")
                        .WithMany()
                        .HasForeignKey("SituacaoPedidoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UsuarioSistema.PerfilUsuarioEntity", "UserCreatePedido")
                        .WithMany()
                        .HasForeignKey("UserCreatePedidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CategoriaPrecoEntity");

                    b.Navigation("PontoVendaEntity");

                    b.Navigation("SituacaoPedidoEntity");

                    b.Navigation("UserCreatePedido");
                });

            modelBuilder.Entity("Api.Domain.Entities.PontoVenda.PontoVendaEntity", b =>
                {
                    b.HasOne("Domain.Entities.UsuarioSistema.PerfilUsuarioEntity", "PerfilUsuarioEntityAbrilPDV")
                        .WithMany("PontoVendaEntitiesAbriu")
                        .HasForeignKey("IdPerfilAbriuPDV")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UsuarioSistema.PerfilUsuarioEntity", "PerfilUsuarioEntityUtilizarPDV")
                        .WithMany("PontoVendaEntitiesUtilizar")
                        .HasForeignKey("IdPerfilUtilizarPDV")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PontoVendaPeriodoVenda.PeriodoPontoVendaEntity", "PeriodoPontoVendaEntity")
                        .WithMany()
                        .HasForeignKey("PeriodoPontoVendaEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PerfilUsuarioEntityAbrilPDV");

                    b.Navigation("PerfilUsuarioEntityUtilizarPDV");

                    b.Navigation("PeriodoPontoVendaEntity");
                });

            modelBuilder.Entity("Api.Domain.Entities.PrecoProduto.PrecoProdutoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", "CategoriaPrecoEntity")
                        .WithMany("PrecoProdutoEntities")
                        .HasForeignKey("CategoriaPrecoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Produto.ProdutoEntity", "ProdutoEntity")
                        .WithMany("PrecoProdutoEntities")
                        .HasForeignKey("ProdutoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CategoriaPrecoEntity");

                    b.Navigation("ProdutoEntity");
                });

            modelBuilder.Entity("Domain.Entities.Produto.ProdutoEntity", b =>
                {
                    b.HasOne("Domain.Entities.CategoriaProduto.CategoriaProdutoEntity", "CategoriaProdutoEntity")
                        .WithMany("ProdutoEntities")
                        .HasForeignKey("CategoriaProdutoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", "ProdutoMedidaEntity")
                        .WithMany("ProdutoEntities")
                        .HasForeignKey("ProdutoMedidaEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ProdutoTipo.ProdutoTipoEntity", "ProdutoTipoEntity")
                        .WithMany("ProdutoEntities")
                        .HasForeignKey("ProdutoTipoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CategoriaProdutoEntity");

                    b.Navigation("ProdutoMedidaEntity");

                    b.Navigation("ProdutoTipoEntity");
                });

            modelBuilder.Entity("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", b =>
                {
                    b.Navigation("PrecoProdutoEntities");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.CategoriaProduto.CategoriaProdutoEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.Produto.ProdutoEntity", b =>
                {
                    b.Navigation("PrecoProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.ProdutoTipo.ProdutoTipoEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.UsuarioSistema.PerfilUsuarioEntity", b =>
                {
                    b.Navigation("PontoVendaEntitiesAbriu");

                    b.Navigation("PontoVendaEntitiesUtilizar");
                });
#pragma warning restore 612, 618
        }
    }
}
