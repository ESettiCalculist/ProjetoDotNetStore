﻿// <auto-generated />
using DotNetStoreDurableFunction.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetStoreDurableFunction.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240105203739_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FiapStoreFunctions.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("SKU")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("FiapStoreFunctions.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("FiapStoreFunctions.Models.Usuario", b =>
                {
                    b.OwnsOne("FiapStoreFunctions.Models.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("UsuarioId")
                                .HasColumnType("int");

                            b1.Property<string>("Bairro")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("CEP")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Cidade")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Complemento")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Logradouro")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Numero")
                                .HasColumnType("int");

                            b1.Property<string>("UF")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<decimal>("ValorFrete")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("Enderecos");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
