using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RedditBackend.Entities;
using System.ComponentModel.DataAnnotations;

namespace RedditBackend.Migrations
{
    [DbContext(typeof(RedditContext))]
    [Migration("20171109150715_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RedditBackend.Entities.Post", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("score");

                    b.Property<int>("timestamp");

                    b.Property<string>("title");

                    b.HasKey("id");

                    b.ToTable("Posts");
                });
        }
    }
}
