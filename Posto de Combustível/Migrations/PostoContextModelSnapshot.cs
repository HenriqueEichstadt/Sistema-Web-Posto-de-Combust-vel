﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Posto_de_Combustível.DAO;

namespace Posto_de_Combustivel.Migrations
{
    [DbContext(typeof(PostoContext))]
    partial class PostoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Posto_De_Combustivel.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("PessoaId");

                    b.Property<int?>("Pontos");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Complemento")
                        .HasMaxLength(50);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Descricao")
                        .HasMaxLength(200);

                    b.Property<double>("EstoqueAtual");

                    b.Property<double?>("LimiteEstoque");

                    b.Property<string>("Marca");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("PrecoCusto");

                    b.Property<double>("PrecoVenda");

                    b.Property<int?>("TrocaPontosFidelidade");

                    b.Property<DateTime?>("Validade");

                    b.HasKey("Id");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Posto_de_Combustivel.Models.FabricanteVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FabricanteVeiculoId");

                    b.Property<string>("TipoEFabricante")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("FabricanteVeiculoId");

                    b.ToTable("FabricanteVeiculos");
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo");

                    b.Property<int>("NivelAcesso");

                    b.Property<string>("NomeUsuario")
                        .HasMaxLength(30);

                    b.Property<int>("PessoaId");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfeCnpj")
                        .IsRequired()
                        .HasMaxLength(18);

                    b.Property<DateTime>("Data");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Genero")
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(50);

                    b.Property<string>("Nome");

                    b.Property<string>("NomeFantasia")
                        .HasMaxLength(50);

                    b.Property<string>("NomeRazaoSocial")
                        .HasMaxLength(50);

                    b.Property<string>("Observacoes")
                        .HasMaxLength(200);

                    b.Property<string>("Rg")
                        .HasMaxLength(15);

                    b.Property<string>("TelefoneDois")
                        .HasMaxLength(14);

                    b.Property<string>("TelefoneUm")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Ano");

                    b.Property<int?>("CategoriaDaSubCategoriaId");

                    b.Property<string>("Cor");

                    b.Property<string>("Fabricante");

                    b.Property<string>("Modelo");

                    b.Property<int>("PessoaId");

                    b.Property<string>("Placa")
                        .IsRequired();

                    b.Property<string>("TipoDeVeiculo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaDaSubCategoriaId");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Posto_de_Combustivel.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime>("Data");

                    b.Property<int>("FormaDePagamento");

                    b.Property<double>("PrecoTotal");

                    b.Property<double>("Unidades");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Posto_de_Combustivel.Models.VendaEstoque", b =>
                {
                    b.Property<int>("VendaId");

                    b.Property<int>("EstoqueId");

                    b.Property<double>("PrecoTotalItem");

                    b.Property<double>("Unidades");

                    b.HasKey("VendaId", "EstoqueId");

                    b.HasIndex("EstoqueId");

                    b.ToTable("VendaEstoque");
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Cliente", b =>
                {
                    b.HasOne("Posto_De_Combustivel.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Posto_de_Combustivel.Models.FabricanteVeiculo", b =>
                {
                    b.HasOne("Posto_de_Combustivel.Models.FabricanteVeiculo", "TipoDoFabricante")
                        .WithMany()
                        .HasForeignKey("FabricanteVeiculoId");
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Funcionario", b =>
                {
                    b.HasOne("Posto_De_Combustivel.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Pessoa", b =>
                {
                    b.HasOne("Posto_De_Combustivel.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Posto_De_Combustivel.Models.Veiculo", b =>
                {
                    b.HasOne("Posto_De_Combustivel.Models.Veiculo", "CategoriaDaSubCategoria")
                        .WithMany()
                        .HasForeignKey("CategoriaDaSubCategoriaId");

                    b.HasOne("Posto_De_Combustivel.Models.Pessoa", "Pessoa")
                        .WithOne("Veiculo")
                        .HasForeignKey("Posto_De_Combustivel.Models.Veiculo", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Posto_de_Combustivel.Models.Venda", b =>
                {
                    b.HasOne("Posto_De_Combustivel.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("Posto_de_Combustivel.Models.VendaEstoque", b =>
                {
                    b.HasOne("Posto_De_Combustivel.Models.Estoque", "Estoque")
                        .WithMany("Vendas")
                        .HasForeignKey("EstoqueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Posto_de_Combustivel.Models.Venda", "Venda")
                        .WithMany("Estoques")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
