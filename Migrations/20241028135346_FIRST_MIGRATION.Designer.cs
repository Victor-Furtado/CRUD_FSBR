﻿// <auto-generated />
using System;
using CRUD_FSBR.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_FSBR.Migrations
{
    [DbContext(typeof(ProcessosDBContext))]
    [Migration("20241028135346_FIRST_MIGRATION")]
    partial class FIRST_MIGRATION
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD_FSBR.Models.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CadastradoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Npu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime>("VisualizadoEm")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Processos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CadastradoEm = new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"5300108\",\"nome\":\"Brasília\"}",
                            Nome = "Processo Teste 1",
                            Npu = "1234567-89.1234.1.56.7890",
                            UF = "DF",
                            VisualizadoEm = new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CadastradoEm = new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"3304557\",\"nome\":\"Rio de Janeiro\"}",
                            Nome = "Processo Teste 2",
                            Npu = "2345678-10.5678.2.45.1234",
                            UF = "RJ",
                            VisualizadoEm = new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CadastradoEm = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"3106200\",\"nome\":\"Belo Horizonte\"}",
                            Nome = "Processo Teste 3",
                            Npu = "3456789-12.3456.3.67.4567",
                            UF = "MG",
                            VisualizadoEm = new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CadastradoEm = new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2927408\",\"nome\":\"Salvador\"}",
                            Nome = "Processo Teste 4",
                            Npu = "4567890-14.6789.4.12.9876",
                            UF = "BA",
                            VisualizadoEm = new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CadastradoEm = new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"4314902\",\"nome\":\"Porto Alegre\"}",
                            Nome = "Processo Teste 5",
                            Npu = "5678901-16.2345.5.34.5432",
                            UF = "RS",
                            VisualizadoEm = new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CadastradoEm = new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"4106902\",\"nome\":\"Curitiba\"}",
                            Nome = "Processo Teste 6",
                            Npu = "6789012-18.5678.6.78.1234",
                            UF = "PR",
                            VisualizadoEm = new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CadastradoEm = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"4205407\",\"nome\":\"Florianópolis\"}",
                            Nome = "Processo Teste 7",
                            Npu = "7890123-20.1234.7.89.5678",
                            UF = "SC",
                            VisualizadoEm = new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CadastradoEm = new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1302603\",\"nome\":\"Manaus\"}",
                            Nome = "Processo Teste 8",
                            Npu = "8901234-21.3456.8.23.6789",
                            UF = "AM",
                            VisualizadoEm = new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CadastradoEm = new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2304400\",\"nome\":\"Fortaleza\"}",
                            Nome = "Processo Teste 9",
                            Npu = "9012345-23.6789.9.12.7890",
                            UF = "CE",
                            VisualizadoEm = new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CadastradoEm = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2611606\",\"nome\":\"Recife\"}",
                            Nome = "Processo Teste 10",
                            Npu = "1234567-25.2345.1.56.1234",
                            UF = "PE",
                            VisualizadoEm = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CadastradoEm = new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"5208707\",\"nome\":\"Goiânia\"}",
                            Nome = "Processo Teste 11",
                            Npu = "2345678-26.5678.2.45.2345",
                            UF = "GO",
                            VisualizadoEm = new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CadastradoEm = new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"3205309\",\"nome\":\"Vitória\"}",
                            Nome = "Processo Teste 12",
                            Npu = "3456789-28.1234.3.67.4567",
                            UF = "ES",
                            VisualizadoEm = new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CadastradoEm = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2704302\",\"nome\":\"Maceió\"}",
                            Nome = "Processo Teste 13",
                            Npu = "4567890-30.6789.4.12.6789",
                            UF = "AL",
                            VisualizadoEm = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            CadastradoEm = new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2507507\",\"nome\":\"João Pessoa\"}",
                            Nome = "Processo Teste 14",
                            Npu = "5678901-32.2345.5.34.7890",
                            UF = "PB",
                            VisualizadoEm = new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            CadastradoEm = new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2408102\",\"nome\":\"Natal\"}",
                            Nome = "Processo Teste 15",
                            Npu = "6789012-34.5678.6.78.8901",
                            UF = "RN",
                            VisualizadoEm = new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            CadastradoEm = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2800308\",\"nome\":\"Aracaju\"}",
                            Nome = "Processo Teste 16",
                            Npu = "7890123-36.1234.7.89.0123",
                            UF = "SE",
                            VisualizadoEm = new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            CadastradoEm = new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"5300108\",\"nome\":\"Brasília\"}",
                            Nome = "Processo Teste 17",
                            Npu = "8901234-38.3456.8.23.1234",
                            UF = "DF",
                            VisualizadoEm = new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            CadastradoEm = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2111300\",\"nome\":\"São Luís\"}",
                            Nome = "Processo Teste 18",
                            Npu = "9012345-40.6789.9.12.2345",
                            UF = "MA",
                            VisualizadoEm = new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            CadastradoEm = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"2211001\",\"nome\":\"Teresina\"}",
                            Nome = "Processo Teste 19",
                            Npu = "1234567-42.2345.1.56.3456",
                            UF = "PI",
                            VisualizadoEm = new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20,
                            CadastradoEm = new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1501402\",\"nome\":\"Belém\"}",
                            Nome = "Processo Teste 20",
                            Npu = "2345678-44.5678.2.45.4567",
                            UF = "PA",
                            VisualizadoEm = new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21,
                            CadastradoEm = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1721000\",\"nome\":\"Palmas\"}",
                            Nome = "Processo Teste 21",
                            Npu = "3456789-46.1234.3.67.5678",
                            UF = "TO",
                            VisualizadoEm = new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22,
                            CadastradoEm = new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1200401\",\"nome\":\"Rio Branco\"}",
                            Nome = "Processo Teste 22",
                            Npu = "4567890-48.6789.4.12.6789",
                            UF = "AC",
                            VisualizadoEm = new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23,
                            CadastradoEm = new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1600303\",\"nome\":\"Macapá\"}",
                            Nome = "Processo Teste 23",
                            Npu = "5678901-50.2345.5.34.7890",
                            UF = "AP",
                            VisualizadoEm = new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 24,
                            CadastradoEm = new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1400100\",\"nome\":\"Boa Vista\"}",
                            Nome = "Processo Teste 24",
                            Npu = "6789012-52.5678.6.78.8901",
                            UF = "RR",
                            VisualizadoEm = new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 25,
                            CadastradoEm = new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1302603\",\"nome\":\"Manaus\"}",
                            Nome = "Processo Teste 25",
                            Npu = "7890123-54.1234.7.89.9012",
                            UF = "AM",
                            VisualizadoEm = new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 26,
                            CadastradoEm = new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"1100205\",\"nome\":\"Porto Velho\"}",
                            Nome = "Processo Teste 26",
                            Npu = "8901234-56.3456.8.23.1234",
                            UF = "RO",
                            VisualizadoEm = new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 27,
                            CadastradoEm = new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"5103403\",\"nome\":\"Cuiabá\"}",
                            Nome = "Processo Teste 27",
                            Npu = "9012345-58.6789.9.12.2345",
                            UF = "MT",
                            VisualizadoEm = new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 28,
                            CadastradoEm = new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"5002704\",\"nome\":\"Campo Grande\"}",
                            Nome = "Processo Teste 28",
                            Npu = "1234567-60.2345.1.56.3456",
                            UF = "MS",
                            VisualizadoEm = new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 29,
                            CadastradoEm = new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"3106200\",\"nome\":\"Belo Horizonte\"}",
                            Nome = "Processo Teste 29",
                            Npu = "2345678-62.5678.2.45.4567",
                            UF = "MG",
                            VisualizadoEm = new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 30,
                            CadastradoEm = new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Municipio = "{\"id\":\"3304557\",\"nome\":\"Rio de Janeiro\"}",
                            Nome = "Processo Teste 30",
                            Npu = "3456789-64.1234.3.67.5678",
                            UF = "RJ",
                            VisualizadoEm = new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
