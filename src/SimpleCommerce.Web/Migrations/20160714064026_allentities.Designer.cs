﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SimpleCommerce.Core.Infrastructure.EntityFramework;

namespace SimpleCommerce.Web.Migrations
{
    [DbContext(typeof(SimpleDbContext))]
    [Migration("20160714064026_allentities")]
    partial class allentities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Core_RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<long>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("Core_UserToken");
                });

            modelBuilder.Entity("SimpleCommerce.Cms.Domain.Models.Widget", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateUrl");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("EditUrl");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("ViewComponentName");

                    b.HasKey("Id");

                    b.ToTable("Cms_Widget");
                });

            modelBuilder.Entity("SimpleCommerce.Cms.Domain.Models.WidgetInstance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Data");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("HtmlData");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("PublishEnd");

                    b.Property<DateTime?>("PublishStart");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<long>("WidgetId");

                    b.Property<long>("WidgetZoneId");

                    b.HasKey("Id");

                    b.HasIndex("WidgetId");

                    b.HasIndex("WidgetZoneId");

                    b.ToTable("Cms_WidgetInstance");
                });

            modelBuilder.Entity("SimpleCommerce.Cms.Domain.Models.WidgetZone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cms_WidgetZone");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("ContactName");

                    b.Property<long>("CountryId");

                    b.Property<long>("DistrictId");

                    b.Property<string>("Phone");

                    b.Property<long>("StateOrProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("StateOrProvinceId");

                    b.ToTable("Core_Address");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 5000);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("SeoTitle");

                    b.HasKey("Id");

                    b.ToTable("Core_Brand");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 5000);

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("Image");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<long?>("ParentId");

                    b.Property<string>("SeoTitle");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Core_Category");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Core_Country");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.District", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<long>("StateOrProvinceId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("StateOrProvinceId");

                    b.ToTable("Core_District");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Media", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption");

                    b.Property<string>("FileName");

                    b.Property<int>("FileSize");

                    b.Property<int>("MediaType");

                    b.HasKey("Id");

                    b.ToTable("Core_Media");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("BrandId");

                    b.Property<long?>("CreatedById");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("DisplayOrder");

                    b.Property<bool>("HasOptions");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsFeatured");

                    b.Property<bool>("IsPublished");

                    b.Property<bool>("IsVisibleIndividually");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.Property<decimal?>("OldPrice");

                    b.Property<decimal>("Price");

                    b.Property<DateTime?>("PublishedOn");

                    b.Property<string>("SeoTitle");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Sku");

                    b.Property<string>("Specification");

                    b.Property<long?>("ThumbnailImageId");

                    b.Property<long?>("UpdatedById");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ThumbnailImageId");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Core_Product");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductAttribute", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("GroupId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Core_ProductAttribute");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductAttributeGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Core_ProductAttributeGroup");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductAttributeValue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AttributeId");

                    b.Property<long>("ProductId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.HasIndex("ProductId");

                    b.ToTable("Core_ProductAttributeValue");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CategoryId");

                    b.Property<int>("DisplayOrder");

                    b.Property<bool>("IsFeaturedProduct");

                    b.Property<long>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Core_ProductCategory");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductLink", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LinkType");

                    b.Property<long>("LinkedProductId");

                    b.Property<long>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("LinkedProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Core_ProductLink");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductMedia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DisplayOrder");

                    b.Property<long>("MediaId");

                    b.Property<long>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.HasIndex("ProductId");

                    b.ToTable("Core_ProductMedia");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductOption", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Core_ProductOption");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductOptionCombination", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("OptionId");

                    b.Property<long>("ProducdtId");

                    b.Property<long?>("ProductId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("Core_ProductOptionCombination");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductOptionValue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("OptionId");

                    b.Property<long>("ProductId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("Core_ProductOptionValue");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductTemplate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Core_ProductTemplate");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductTemplateProductAttribute", b =>
                {
                    b.Property<long>("ProductTemplateId");

                    b.Property<long>("ProductAttributeId");

                    b.HasKey("ProductTemplateId", "ProductAttributeId");

                    b.HasIndex("ProductAttributeId");

                    b.HasIndex("ProductTemplateId");

                    b.ToTable("Core_ProductTemplateProductAttribute");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("Core_Role");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.StateOrProvince", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CountryId");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Core_StateOrProvince");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.UrlSlug", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("EntityId");

                    b.Property<string>("EntityName");

                    b.Property<string>("Slug");

                    b.HasKey("Id");

                    b.ToTable("Core_UrlSlug");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long?>("CurrentShippingAddressId");

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<Guid>("UserGuid");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("CurrentShippingAddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Core_User");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.UserAddress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressId");

                    b.Property<int>("AddressType");

                    b.Property<DateTime?>("LastUsedOn");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserAddress");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<long>", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Cms.Domain.Models.WidgetInstance", b =>
                {
                    b.HasOne("SimpleCommerce.Cms.Domain.Models.Widget", "Widget")
                        .WithMany()
                        .HasForeignKey("WidgetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Cms.Domain.Models.WidgetZone", "WidgetZone")
                        .WithMany()
                        .HasForeignKey("WidgetZoneId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Address", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("SimpleCommerce.Core.Domain.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("SimpleCommerce.Core.Domain.Models.StateOrProvince", "StateOrProvince")
                        .WithMany()
                        .HasForeignKey("StateOrProvinceId");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Category", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Category", "Parent")
                        .WithMany("Child")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.District", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.StateOrProvince", "StateOrProvince")
                        .WithMany()
                        .HasForeignKey("StateOrProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.Product", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("SimpleCommerce.Core.Domain.Models.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("SimpleCommerce.Core.Domain.Models.Media", "ThumbnailImage")
                        .WithMany()
                        .HasForeignKey("ThumbnailImageId");

                    b.HasOne("SimpleCommerce.Core.Domain.Models.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductAttribute", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.ProductAttributeGroup", "Group")
                        .WithMany("Attributes")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductAttributeValue", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.ProductAttribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.Product", "Product")
                        .WithMany("AttributeValues")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductCategory", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.Product", "Product")
                        .WithMany("Categories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductLink", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Product", "LinkedProduct")
                        .WithMany("LinkedProductLinks")
                        .HasForeignKey("LinkedProductId");

                    b.HasOne("SimpleCommerce.Core.Domain.Models.Product", "Product")
                        .WithMany("ProductLinks")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductMedia", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.Product", "Product")
                        .WithMany("Medias")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductOptionCombination", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.ProductOption", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.Product", "Product")
                        .WithMany("OptionCombinations")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductOptionValue", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.ProductOption", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.Product", "Product")
                        .WithMany("OptionValues")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.ProductTemplateProductAttribute", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.ProductAttribute", "ProductAttribute")
                        .WithMany("ProductTemplates")
                        .HasForeignKey("ProductAttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.ProductTemplate", "ProductTemplate")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("ProductTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.StateOrProvince", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.User", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.UserAddress", "CurrentShippingAddress")
                        .WithMany()
                        .HasForeignKey("CurrentShippingAddressId");
                });

            modelBuilder.Entity("SimpleCommerce.Core.Domain.Models.UserAddress", b =>
                {
                    b.HasOne("SimpleCommerce.Core.Domain.Models.Address", "Address")
                        .WithMany("UserAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleCommerce.Core.Domain.Models.User", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId");
                });
        }
    }
}