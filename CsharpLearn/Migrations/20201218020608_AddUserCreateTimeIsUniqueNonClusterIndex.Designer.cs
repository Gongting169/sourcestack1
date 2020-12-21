﻿// <auto-generated />
using System;
using CSharplearn.OO.Entity_FrameWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharplearn.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20201218020608_AddUserCreateTimeIsUniqueNonClusterIndex")]
    partial class AddUserCreateTimeIsUniqueNonClusterIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CSharplearn.User", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("UserName");

                    b.Property<int>("BCredit")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvitedByName")
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("InvitedCode")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reward")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("InvitedByName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Register");

                    b.HasCheckConstraint("CK_CreateTime", "CreateTime >= '2020/1/1'");
                });

            modelBuilder.Entity("CSharplearn.User", b =>
                {
                    b.HasOne("CSharplearn.User", "InvitedBy")
                        .WithMany()
                        .HasForeignKey("InvitedByName");

                    b.Navigation("InvitedBy");
                });
#pragma warning restore 612, 618
        }
    }
}