﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using loginwebapijwt.Data;

#nullable disable

namespace loginwebapijwt.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("loginwebapijwt.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "admin@devatila.com.br",
                            name = "Admin Dev Atila",
                            password = "$2a$11$Z28yNgN3.dTIvRCR3ZCXPuHX.E/LmIgt0gBQu5uk8yMj.Gx3/4Lmm",
                            role = 0
                        },
                        new
                        {
                            id = 2,
                            email = "cliente@devatila.com.br",
                            name = "Cliente Sicreno do Tal",
                            password = "$2a$11$Iq8aHyT8M8m382NgxMauIOjy8b9uyQHl7rb10QZN05wr5V185Me/C",
                            role = 1
                        },
                        new
                        {
                            id = 3,
                            email = "funcionario@devatila.com.br",
                            name = "Usuario Funcionario de Tal",
                            password = "$2a$11$x1W5HtIVJ0gg7TdIbwD0euoqXIkstqkQFrzuvc0eUDdbUeM0opJSa",
                            role = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
