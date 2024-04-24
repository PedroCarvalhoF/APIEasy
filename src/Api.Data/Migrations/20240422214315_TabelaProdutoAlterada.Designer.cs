﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240422214315_TabelaProdutoAlterada")]
    partial class TabelaProdutoAlterada
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("CategoriasPrecos");
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
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataUltimaAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NumeroPedido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid?>("PontoVendaEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SituacaoPedidoEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<decimal?>("TotalItensPedido")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserIdCreatePedido")
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

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Api.Domain.Entities.Pessoa.PessoaTipo.PessoaTipoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoPessoaTipo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("PessoasTipos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a58b678c-07d4-417b-929b-600dc63858ea"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1995),
                            DescricaoPessoaTipo = "FÍSICA",
                            Habilitado = false
                        },
                        new
                        {
                            Id = new Guid("2cc73259-4063-4f20-9c21-34ff2a9cbd58"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1998),
                            DescricaoPessoaTipo = "JURÍDICA",
                            Habilitado = false
                        });
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

                    b.Property<DateTime?>("DataAlteracaoEncerrado")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PeriodoPontoVendaEnum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserIdCreatePdv")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserIdResponsavel")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("PontosVendas");
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

                    b.ToTable("PrecosProdutos");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("ProdutosMedidas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cc8119c5-7651-4708-bba4-8f350726bdac"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2038),
                            Descricao = "Litro",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2039)
                        },
                        new
                        {
                            Id = new Guid("9bbe9cc9-ba40-4bb3-9b71-74a8234133a5"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2043),
                            Descricao = "Caixa",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2043)
                        },
                        new
                        {
                            Id = new Guid("05b3382d-0940-446a-8c2c-3e27293cf77d"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2046),
                            Descricao = "Unidade",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2047)
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
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

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
                            Id = new Guid("6fb282e9-6ee8-44d9-a049-994f68bd0b27"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1212),
                            DescricaoCategoria = "Bebidas",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("7e4f4712-f87c-40cc-8298-38814b074822"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1263),
                            DescricaoCategoria = "Promoções",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("fdadcf3c-f238-40dc-86e5-130782011642"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1297),
                            DescricaoCategoria = "Executivos",
                            Habilitado = true
                        });
                });

            modelBuilder.Entity("Domain.Entities.Filial.FilialEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NomeFilial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Filiais");
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

                    b.ToTable("FormasPagamentos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("249c0c31-ee8e-487b-b4c9-1f14ced84553"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1912),
                            DescricaoFormaPg = "DINHEIRO",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("18e68a14-54b5-44b6-87ed-e8b0258d9c1d"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1916),
                            DescricaoFormaPg = "DÉBITO",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("ac336bfb-39eb-4da0-9b04-c159f0068676"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1919),
                            DescricaoFormaPg = "CRÉDITO",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("d276bcd0-e552-46d4-af7a-390a3af0eb37"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1922),
                            DescricaoFormaPg = "SODEXO",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("46152359-216e-4b2e-827c-411092ecc423"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1925),
                            DescricaoFormaPg = "TICKT ELETRON",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("cdd1b70b-5c96-472e-a983-3abdcc318c53"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1927),
                            DescricaoFormaPg = "VR",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("935f9721-bcc2-4239-88a1-2e0c9b1a75f6"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1931),
                            DescricaoFormaPg = "AMEX",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("e93ceba1-40f8-4420-8dc3-bb1b3ee6ee9f"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1940),
                            DescricaoFormaPg = "VALE SHOPPING",
                            Habilitado = true
                        },
                        new
                        {
                            Id = new Guid("7aaecde9-7290-48e7-bf31-f8dab886381f"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1943),
                            DescricaoFormaPg = "IFOOD",
                            Habilitado = true
                        });
                });

            modelBuilder.Entity("Domain.Entities.ItensPedido.ItemPedidoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ObservacaoItem")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("PedidoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProdutoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Quatidade")
                        .HasColumnType("decimal(18,3)");

                    b.Property<int>("SituacaoItemPedidoEnum")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UsuarioRestroId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoEntityId");

                    b.HasIndex("ProdutoEntityId");

                    b.ToTable("ItensPedidos");
                });

            modelBuilder.Entity("Domain.Entities.PagamentoPedido.PagamentoPedidoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("FormaPagamentoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("PedidoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FormaPagamentoEntityId");

                    b.HasIndex("PedidoEntityId");

                    b.ToTable("PagamentosPedidos");
                });

            modelBuilder.Entity("Domain.Entities.Pedido.SituacaoPedidoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoSituacaoPedido")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("SituacoesPedidos");
                });

            modelBuilder.Entity("Domain.Entities.Pessoa.Pessoas.PessoaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimentoFundacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("PessoaTipoEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("RgIE")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("SegundoNome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaTipoEntityId");

                    b.ToTable("Pessoas");
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
                            Id = new Guid("d2a0c172-e742-4e54-a806-938ddaaf8edb"),
                            CategoriaProdutoEntityId = new Guid("6fb282e9-6ee8-44d9-a049-994f68bd0b27"),
                            CodigoBarrasPersonalizado = "agua",
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1856),
                            Descricao = "agua zero sódio",
                            Habilitado = true,
                            ImgUrl = "agua.jpg",
                            NomeProduto = "Agua sem Gás",
                            Observacoes = "Vendida com ou sem gelo",
                            ProdutoMedidaEntityId = new Guid("05b3382d-0940-446a-8c2c-3e27293cf77d"),
                            ProdutoTipoEntityId = new Guid("59de4011-1ca7-4a52-833c-9672a03320ac"),
                            UpdateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(1865)
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
                            Id = new Guid("2491c7e2-10ec-48a4-8898-44e24814f23d"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2083),
                            DescricaoTipoProduto = "Venda",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2085)
                        },
                        new
                        {
                            Id = new Guid("3cca7caf-8a98-40b2-9f20-3f864f59e1c5"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2092),
                            DescricaoTipoProduto = "Materia Prima",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2093)
                        },
                        new
                        {
                            Id = new Guid("59de4011-1ca7-4a52-833c-9672a03320ac"),
                            CreateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2096),
                            DescricaoTipoProduto = "Ambos",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 22, 18, 43, 14, 581, DateTimeKind.Local).AddTicks(2097)
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.Pedido.PedidoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", "CategoriaPrecoEntity")
                        .WithMany("PedidoEntities")
                        .HasForeignKey("CategoriaPrecoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.PontoVenda.PontoVendaEntity", "PontoVendaEntity")
                        .WithMany("PedidoEntities")
                        .HasForeignKey("PontoVendaEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Pedido.SituacaoPedidoEntity", "SituacaoPedidoEntity")
                        .WithMany("PedidoEntities")
                        .HasForeignKey("SituacaoPedidoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaPrecoEntity");

                    b.Navigation("PontoVendaEntity");

                    b.Navigation("SituacaoPedidoEntity");
                });

            modelBuilder.Entity("Api.Domain.Entities.PrecoProduto.PrecoProdutoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", "CategoriaPrecoEntity")
                        .WithMany("PrecoProdutoEntities")
                        .HasForeignKey("CategoriaPrecoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Produto.ProdutoEntity", "ProdutoEntity")
                        .WithMany("PrecoProdutoEntities")
                        .HasForeignKey("ProdutoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaPrecoEntity");

                    b.Navigation("ProdutoEntity");
                });

            modelBuilder.Entity("Domain.Entities.ItensPedido.ItemPedidoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.Pedido.PedidoEntity", "PedidoEntity")
                        .WithMany("ItemPedidoEntities")
                        .HasForeignKey("PedidoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Produto.ProdutoEntity", "ProdutoEntity")
                        .WithMany("ItemPedidoEntities")
                        .HasForeignKey("ProdutoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PedidoEntity");

                    b.Navigation("ProdutoEntity");
                });

            modelBuilder.Entity("Domain.Entities.PagamentoPedido.PagamentoPedidoEntity", b =>
                {
                    b.HasOne("Domain.Entities.FormaPagamento.FormaPagamentoEntity", "FormaPagamentoEntity")
                        .WithMany("PagamentoPedidoEntities")
                        .HasForeignKey("FormaPagamentoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.Pedido.PedidoEntity", "PedidoEntity")
                        .WithMany("PagamentoPedidoEntities")
                        .HasForeignKey("PedidoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormaPagamentoEntity");

                    b.Navigation("PedidoEntity");
                });

            modelBuilder.Entity("Domain.Entities.Pessoa.Pessoas.PessoaEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.Pessoa.PessoaTipo.PessoaTipoEntity", "PessoaTipoEntity")
                        .WithMany("PessoaEntities")
                        .HasForeignKey("PessoaTipoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PessoaTipoEntity");
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
                    b.Navigation("PedidoEntities");

                    b.Navigation("PrecoProdutoEntities");
                });

            modelBuilder.Entity("Api.Domain.Entities.Pedido.PedidoEntity", b =>
                {
                    b.Navigation("ItemPedidoEntities");

                    b.Navigation("PagamentoPedidoEntities");
                });

            modelBuilder.Entity("Api.Domain.Entities.Pessoa.PessoaTipo.PessoaTipoEntity", b =>
                {
                    b.Navigation("PessoaEntities");
                });

            modelBuilder.Entity("Api.Domain.Entities.PontoVenda.PontoVendaEntity", b =>
                {
                    b.Navigation("PedidoEntities");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.CategoriaProduto.CategoriaProdutoEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.FormaPagamento.FormaPagamentoEntity", b =>
                {
                    b.Navigation("PagamentoPedidoEntities");
                });

            modelBuilder.Entity("Domain.Entities.Pedido.SituacaoPedidoEntity", b =>
                {
                    b.Navigation("PedidoEntities");
                });

            modelBuilder.Entity("Domain.Entities.Produto.ProdutoEntity", b =>
                {
                    b.Navigation("ItemPedidoEntities");

                    b.Navigation("PrecoProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.ProdutoTipo.ProdutoTipoEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
