﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20181202110546_AddNewProjectSysEntities")]
    partial class AddNewProjectSysEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NameNormalized")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("cms_album");
                });

            modelBuilder.Entity("Core.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlbumId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int?>("PhotoHeaderId");

                    b.Property<int?>("PhotoThumbnailId");

                    b.Property<int>("ProjectId");

                    b.Property<int?>("SeoId");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Status");

                    b.Property<string>("Tags")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PhotoHeaderId");

                    b.HasIndex("PhotoThumbnailId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SeoId");

                    b.ToTable("cms_article");
                });

            modelBuilder.Entity("Core.Entities.ArticleSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AdsActive");

                    b.Property<int>("ArticleId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("Nsfw");

                    b.Property<int>("PageAdsDensity");

                    b.Property<bool>("ShowComments");

                    b.Property<bool>("ShowSocialPlugins");

                    b.Property<bool>("UpdateSlugOnTitleChange");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId")
                        .IsUnique();

                    b.ToTable("cms_article_settings");
                });

            modelBuilder.Entity("Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int?>("ParentCategoryId");

                    b.Property<int>("ProjectId");

                    b.Property<int?>("SeoId");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SeoId");

                    b.ToTable("cms_category");
                });

            modelBuilder.Entity("Core.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("MenuId");

                    b.Property<int?>("ParentMenuId");

                    b.Property<int>("ProjectId");

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Url")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("ParentMenuId");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("web_menu");
                });

            modelBuilder.Entity("Core.Entities.PageForward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("DestinationUrl")
                        .HasMaxLength(255);

                    b.Property<string>("Mask")
                        .HasMaxLength(255);

                    b.Property<int>("ProjectId");

                    b.Property<string>("SourceId")
                        .HasMaxLength(255);

                    b.Property<int>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("web_page_forward");
                });

            modelBuilder.Entity("Core.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlbumId");

                    b.Property<string>("CdnPath")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("DomainName")
                        .HasMaxLength(255);

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("Height");

                    b.Property<bool>("IsLocal");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("NameNormalized")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("OriginSource")
                        .HasMaxLength(255);

                    b.Property<string>("Protocol")
                        .HasMaxLength(10);

                    b.Property<string>("RelativePath")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("cms_photo");
                });

            modelBuilder.Entity("Core.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("DomainName")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("user_project");
                });

            modelBuilder.Entity("Core.Entities.ProjectSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArticleHeaderHeight");

                    b.Property<int?>("ArticleHeaderWidth");

                    b.Property<int?>("ArticleThumbnailHeight");

                    b.Property<int?>("ArticleThumbnailWidth");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("user_project_settings");
                });

            modelBuilder.Entity("Core.Entities.Seo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Keywords")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("seo_onpage");
                });

            modelBuilder.Entity("Core.Entities.TemplateVariable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Label");

                    b.Property<int?>("ParentTemplateVariableId");

                    b.Property<int?>("ProjectId");

                    b.Property<bool>("ShowRaw");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ParentTemplateVariableId");

                    b.HasIndex("ProjectId");

                    b.ToTable("web_template_variable");
                });

            modelBuilder.Entity("Core.Entities.Article", b =>
                {
                    b.HasOne("Core.Entities.Album", "Album")
                        .WithMany("Articles")
                        .HasForeignKey("AlbumId");

                    b.HasOne("Core.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Photo", "PhotoHeader")
                        .WithMany()
                        .HasForeignKey("PhotoHeaderId");

                    b.HasOne("Core.Entities.Photo", "PhotoThumbnail")
                        .WithMany()
                        .HasForeignKey("PhotoThumbnailId");

                    b.HasOne("Core.Entities.Project", "Project")
                        .WithMany("Articles")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Seo", "Seo")
                        .WithMany()
                        .HasForeignKey("SeoId");
                });

            modelBuilder.Entity("Core.Entities.ArticleSettings", b =>
                {
                    b.HasOne("Core.Entities.Article", "Article")
                        .WithOne("ArticleSettings")
                        .HasForeignKey("Core.Entities.ArticleSettings", "ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Category", b =>
                {
                    b.HasOne("Core.Entities.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.HasOne("Core.Entities.Project", "Project")
                        .WithMany("Categories")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Seo", "Seo")
                        .WithMany()
                        .HasForeignKey("SeoId");
                });

            modelBuilder.Entity("Core.Entities.Menu", b =>
                {
                    b.HasOne("Core.Entities.Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId");

                    b.HasOne("Core.Entities.Category", "ParentMenu")
                        .WithMany()
                        .HasForeignKey("ParentMenuId");

                    b.HasOne("Core.Entities.Project", "Project")
                        .WithOne("Menu")
                        .HasForeignKey("Core.Entities.Menu", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.PageForward", b =>
                {
                    b.HasOne("Core.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.Photo", b =>
                {
                    b.HasOne("Core.Entities.Album", "Album")
                        .WithMany("Photos")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.ProjectSettings", b =>
                {
                    b.HasOne("Core.Entities.Project", "Project")
                        .WithOne("ProjectSettings")
                        .HasForeignKey("Core.Entities.ProjectSettings", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Entities.TemplateVariable", b =>
                {
                    b.HasOne("Core.Entities.TemplateVariable", "ParentTemplateVariable")
                        .WithMany("TemplateVariables")
                        .HasForeignKey("ParentTemplateVariableId");

                    b.HasOne("Core.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
