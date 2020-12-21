﻿// <auto-generated />
using System;
using CSharplearn.OO.Entity_FrameWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharplearn.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ArticleKeyWord", b =>
                {
                    b.Property<int>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int>("KeyWordsId")
                        .HasColumnType("int");

                    b.HasKey("ArticlesId", "KeyWordsId");

                    b.HasIndex("KeyWordsId");

                    b.ToTable("ArticleKeyWord");
                });

            modelBuilder.Entity("CSharplearn.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorName");

                    b.ToTable("Contents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Content");
                });

            modelBuilder.Entity("CSharplearn.OO.YqBang.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Captcha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("CSharplearn.ProcedureObject.Generic.Appraise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<int?>("SuggestId")
                        .HasColumnType("int");

                    b.Property<string>("VoterName")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("CommentId");

                    b.HasIndex("SuggestId");

                    b.HasIndex("VoterName");

                    b.ToTable("Appraises");
                });

            modelBuilder.Entity("CSharplearn.ProcedureObject.Generic.KeyWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KeyWords");
                });

            modelBuilder.Entity("CSharplearn.User", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("UserName");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmailId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

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

                    b.HasIndex("EmailId")
                        .IsUnique();

                    b.HasIndex("InvitedByName");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Register");

                    b.HasCheckConstraint("CK_CreateTime", "CreateTime >= '2020/1/1'");
                });

            modelBuilder.Entity("KeyWordProblem", b =>
                {
                    b.Property<int>("KeyWordsId")
                        .HasColumnType("int");

                    b.Property<int>("ProblemsId")
                        .HasColumnType("int");

                    b.HasKey("KeyWordsId", "ProblemsId");

                    b.HasIndex("ProblemsId");

                    b.ToTable("KeyWordProblem");
                });

            modelBuilder.Entity("CSharplearn.Article", b =>
                {
                    b.HasBaseType("CSharplearn.Content");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)");

                    b.HasIndex("UserName");

                    b.HasDiscriminator().HasValue("Article");
                });

            modelBuilder.Entity("CSharplearn.Problem", b =>
                {
                    b.HasBaseType("CSharplearn.Content");

                    b.Property<bool>("Audit")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LatestUpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NeedRemoteHelp")
                        .HasColumnType("bit");

                    b.Property<int>("Reward")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Problem_Title");

                    b.HasDiscriminator().HasValue("Problem");
                });

            modelBuilder.Entity("CSharplearn.ProcedureObject.Generic.Comment", b =>
                {
                    b.HasBaseType("CSharplearn.Content");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<bool>("NeedRemoteHelp")
                        .HasColumnType("bit")
                        .HasColumnName("Comment_NeedRemoteHelp");

                    b.Property<int?>("ProblemId")
                        .HasColumnType("int");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuggestId")
                        .HasColumnType("int");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ProblemId");

                    b.HasIndex("SuggestId");

                    b.HasDiscriminator().HasValue("Comment");
                });

            modelBuilder.Entity("CSharplearn.Suggest", b =>
                {
                    b.HasBaseType("CSharplearn.Content");

                    b.Property<bool>("Award")
                        .HasColumnType("bit");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Suggest_Title");

                    b.HasDiscriminator().HasValue("Suggest");
                });

            modelBuilder.Entity("CSharplearn.Summary", b =>
                {
                    b.HasBaseType("CSharplearn.Content");

                    b.HasDiscriminator().HasValue("Summary");
                });

            modelBuilder.Entity("ArticleKeyWord", b =>
                {
                    b.HasOne("CSharplearn.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharplearn.ProcedureObject.Generic.KeyWord", null)
                        .WithMany()
                        .HasForeignKey("KeyWordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CSharplearn.Content", b =>
                {
                    b.HasOne("CSharplearn.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorName");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("CSharplearn.ProcedureObject.Generic.Appraise", b =>
                {
                    b.HasOne("CSharplearn.Article", "Article")
                        .WithMany("Appraises")
                        .HasForeignKey("ArticleId");

                    b.HasOne("CSharplearn.ProcedureObject.Generic.Comment", "Comment")
                        .WithMany("Appraises")
                        .HasForeignKey("CommentId");

                    b.HasOne("CSharplearn.Suggest", "Suggest")
                        .WithMany("Appraises")
                        .HasForeignKey("SuggestId");

                    b.HasOne("CSharplearn.User", "Voter")
                        .WithMany()
                        .HasForeignKey("VoterName");

                    b.Navigation("Article");

                    b.Navigation("Comment");

                    b.Navigation("Suggest");

                    b.Navigation("Voter");
                });

            modelBuilder.Entity("CSharplearn.User", b =>
                {
                    b.HasOne("CSharplearn.OO.YqBang.Email", "Email")
                        .WithOne()
                        .HasForeignKey("CSharplearn.User", "EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharplearn.User", "InvitedBy")
                        .WithMany()
                        .HasForeignKey("InvitedByName");

                    b.Navigation("Email");

                    b.Navigation("InvitedBy");
                });

            modelBuilder.Entity("KeyWordProblem", b =>
                {
                    b.HasOne("CSharplearn.ProcedureObject.Generic.KeyWord", null)
                        .WithMany()
                        .HasForeignKey("KeyWordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharplearn.Problem", null)
                        .WithMany()
                        .HasForeignKey("ProblemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CSharplearn.Article", b =>
                {
                    b.HasOne("CSharplearn.User", "User")
                        .WithMany()
                        .HasForeignKey("UserName");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CSharplearn.ProcedureObject.Generic.Comment", b =>
                {
                    b.HasOne("CSharplearn.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId");

                    b.HasOne("CSharplearn.Problem", "Problem")
                        .WithMany("Comments")
                        .HasForeignKey("ProblemId");

                    b.HasOne("CSharplearn.Suggest", "Suggest")
                        .WithMany("Comments")
                        .HasForeignKey("SuggestId");

                    b.Navigation("Article");

                    b.Navigation("Problem");

                    b.Navigation("Suggest");
                });

            modelBuilder.Entity("CSharplearn.Article", b =>
                {
                    b.Navigation("Appraises");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CSharplearn.Problem", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CSharplearn.ProcedureObject.Generic.Comment", b =>
                {
                    b.Navigation("Appraises");
                });

            modelBuilder.Entity("CSharplearn.Suggest", b =>
                {
                    b.Navigation("Appraises");

                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
