﻿// <auto-generated />
using ForumApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumApp.Infrastructure.Migrations
{
    [DbContext(typeof(ForumAppDbContext))]
    partial class ForumAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ForumApp.Infrastructure.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Post identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasComment("Post Content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Post title");

                    b.HasKey("Id");

                    b.ToTable("Posts", t =>
                        {
                            t.HasComment("Posts table");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is my first content.",
                            Title = "First post"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is my second content.",
                            Title = "Second post"
                        },
                        new
                        {
                            Id = 3,
                            Content = "This is my third content.",
                            Title = "Third post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
