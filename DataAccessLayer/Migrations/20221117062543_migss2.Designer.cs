// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221117062543_migss2")]
    partial class migss2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("blog_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("blog_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("blog_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("blog_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("blog_ID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Team", b =>
                {
                    b.Property<int>("teammate_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("teammate_Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teammate_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teammate_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teammate_Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("teammate_Salary")
                        .HasColumnType("int");

                    b.Property<string>("teammate_Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teammate_ID");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
