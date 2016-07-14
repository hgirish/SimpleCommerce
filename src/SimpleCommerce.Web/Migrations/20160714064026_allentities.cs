using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SimpleCommerce.Web.Migrations
{
    public partial class allentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_WidgetInstance_Widget_WidgetId",
                table: "WidgetInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_WidgetInstance_WidgetZone_WidgetZoneId",
                table: "WidgetInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserAddress_CurrentShippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddress_Address_AddressId",
                table: "UserAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddress_AspNetUsers_UserId",
                table: "UserAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAddress",
                table: "UserAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UrlSlug",
                table: "UrlSlug");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WidgetZone",
                table: "WidgetZone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WidgetInstance",
                table: "WidgetInstance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Widget",
                table: "Widget");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.CreateTable(
                name: "Core_Brand",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 5000, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SeoTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_Country",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_Media",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caption = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    MediaType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Media", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductAttributeGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductAttributeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductOption",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductTemplate",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_StateOrProvince",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_StateOrProvince", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_StateOrProvince_Core_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Core_Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_Product",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandId = table.Column<long>(nullable: true),
                    CreatedById = table.Column<long>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: false),
                    HasOptions = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    IsVisibleIndividually = table.Column<bool>(nullable: false),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    OldPrice = table.Column<decimal>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PublishedOn = table.Column<DateTime>(nullable: true),
                    SeoTitle = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    Specification = table.Column<string>(nullable: true),
                    ThumbnailImageId = table.Column<long>(nullable: true),
                    UpdatedById = table.Column<long>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_Product_Core_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Core_Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Core_Product_Core_User_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Core_Product_Core_Media_ThumbnailImageId",
                        column: x => x.ThumbnailImageId,
                        principalTable: "Core_Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Core_Product_Core_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductAttribute",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ProductAttribute_Core_ProductAttributeGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Core_ProductAttributeGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_District",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StateOrProvinceId = table.Column<long>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_District_Core_StateOrProvince_StateOrProvinceId",
                        column: x => x.StateOrProvinceId,
                        principalTable: "Core_StateOrProvince",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductCategory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<long>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    IsFeaturedProduct = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ProductCategory_Core_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Core_ProductCategory_Core_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Core_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductLink",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LinkType = table.Column<int>(nullable: false),
                    LinkedProductId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ProductLink_Core_Product_LinkedProductId",
                        column: x => x.LinkedProductId,
                        principalTable: "Core_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Core_ProductLink_Core_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Core_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductMedia",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisplayOrder = table.Column<int>(nullable: false),
                    MediaId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ProductMedia_Core_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Core_Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Core_ProductMedia_Core_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Core_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductOptionCombination",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OptionId = table.Column<long>(nullable: false),
                    ProducdtId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductOptionCombination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ProductOptionCombination_Core_ProductOption_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Core_ProductOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Core_ProductOptionCombination_Core_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Core_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductOptionValue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OptionId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductOptionValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ProductOptionValue_Core_ProductOption_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Core_ProductOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Core_ProductOptionValue_Core_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Core_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductAttributeValue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductAttributeValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ProductAttributeValue_Core_ProductAttribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Core_ProductAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Core_ProductAttributeValue_Core_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Core_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_ProductTemplateProductAttribute",
                columns: table => new
                {
                    ProductTemplateId = table.Column<long>(nullable: false),
                    ProductAttributeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ProductTemplateProductAttribute", x => new { x.ProductTemplateId, x.ProductAttributeId });
                    table.ForeignKey(
                        name: "FK_Core_ProductTemplateProductAttribute_Core_ProductAttribute_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "Core_ProductAttribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Core_ProductTemplateProductAttribute_Core_ProductTemplate_ProductTemplateId",
                        column: x => x.ProductTemplateId,
                        principalTable: "Core_ProductTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_UserAddress",
                table: "UserAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_User",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_UrlSlug",
                table: "UrlSlug",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_Role",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Address_CountryId",
                table: "Address",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Address_DistrictId",
                table: "Address",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Address_StateOrProvinceId",
                table: "Address",
                column: "StateOrProvinceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cms_WidgetZone",
                table: "WidgetZone",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cms_WidgetInstance",
                table: "WidgetInstance",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cms_Widget",
                table: "Widget",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_UserToken",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_UserRole",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_UserLogin",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_UserClaim",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Core_RoleClaim",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Core_District_StateOrProvinceId",
                table: "Core_District",
                column: "StateOrProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Product_BrandId",
                table: "Core_Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Product_CreatedById",
                table: "Core_Product",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Product_ThumbnailImageId",
                table: "Core_Product",
                column: "ThumbnailImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Product_UpdatedById",
                table: "Core_Product",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductAttribute_GroupId",
                table: "Core_ProductAttribute",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductAttributeValue_AttributeId",
                table: "Core_ProductAttributeValue",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductAttributeValue_ProductId",
                table: "Core_ProductAttributeValue",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductCategory_CategoryId",
                table: "Core_ProductCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductCategory_ProductId",
                table: "Core_ProductCategory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductLink_LinkedProductId",
                table: "Core_ProductLink",
                column: "LinkedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductLink_ProductId",
                table: "Core_ProductLink",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductMedia_MediaId",
                table: "Core_ProductMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductMedia_ProductId",
                table: "Core_ProductMedia",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductOptionCombination_OptionId",
                table: "Core_ProductOptionCombination",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductOptionCombination_ProductId",
                table: "Core_ProductOptionCombination",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductOptionValue_OptionId",
                table: "Core_ProductOptionValue",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductOptionValue_ProductId",
                table: "Core_ProductOptionValue",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductTemplateProductAttribute_ProductAttributeId",
                table: "Core_ProductTemplateProductAttribute",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ProductTemplateProductAttribute_ProductTemplateId",
                table: "Core_ProductTemplateProductAttribute",
                column: "ProductTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_StateOrProvince_CountryId",
                table: "Core_StateOrProvince",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Core_RoleClaim_Core_Role_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_UserClaim_Core_User_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_UserLogin_Core_User_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_UserRole_Core_Role_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_UserRole_Core_User_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cms_WidgetInstance_Cms_Widget_WidgetId",
                table: "WidgetInstance",
                column: "WidgetId",
                principalTable: "Widget",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cms_WidgetInstance_Cms_WidgetZone_WidgetZoneId",
                table: "WidgetInstance",
                column: "WidgetZoneId",
                principalTable: "WidgetZone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_Address_Core_Country_CountryId",
                table: "Address",
                column: "CountryId",
                principalTable: "Core_Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_Address_Core_District_DistrictId",
                table: "Address",
                column: "DistrictId",
                principalTable: "Core_District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_Address_Core_StateOrProvince_StateOrProvinceId",
                table: "Address",
                column: "StateOrProvinceId",
                principalTable: "Core_StateOrProvince",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_Category_Core_Category_ParentId",
                table: "Category",
                column: "ParentId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_User_Core_UserAddress_CurrentShippingAddressId",
                table: "AspNetUsers",
                column: "CurrentShippingAddressId",
                principalTable: "UserAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_UserAddress_Core_Address_AddressId",
                table: "UserAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Core_UserAddress_Core_User_UserId",
                table: "UserAddress",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress",
                newName: "IX_Core_UserAddress_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAddress_AddressId",
                table: "UserAddress",
                newName: "IX_Core_UserAddress_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CurrentShippingAddressId",
                table: "AspNetUsers",
                newName: "IX_Core_User_CurrentShippingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                newName: "IX_Core_Category_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_WidgetInstance_WidgetZoneId",
                table: "WidgetInstance",
                newName: "IX_Cms_WidgetInstance_WidgetZoneId");

            migrationBuilder.RenameIndex(
                name: "IX_WidgetInstance_WidgetId",
                table: "WidgetInstance",
                newName: "IX_Cms_WidgetInstance_WidgetId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                newName: "IX_Core_UserRole_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_Core_UserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_Core_UserLogin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_Core_UserClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_Core_RoleClaim_RoleId");

            migrationBuilder.RenameTable(
                name: "UserAddress",
                newName: "Core_UserAddress");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Core_User");

            migrationBuilder.RenameTable(
                name: "UrlSlug",
                newName: "Core_UrlSlug");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Core_Role");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Core_Category");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Core_Address");

            migrationBuilder.RenameTable(
                name: "WidgetZone",
                newName: "Cms_WidgetZone");

            migrationBuilder.RenameTable(
                name: "WidgetInstance",
                newName: "Cms_WidgetInstance");

            migrationBuilder.RenameTable(
                name: "Widget",
                newName: "Cms_Widget");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "Core_UserToken");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "Core_UserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "Core_UserLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "Core_UserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "Core_RoleClaim");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Core_RoleClaim_Core_Role_RoleId",
                table: "Core_RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_UserClaim_Core_User_UserId",
                table: "Core_UserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_UserLogin_Core_User_UserId",
                table: "Core_UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_UserRole_Core_Role_RoleId",
                table: "Core_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_UserRole_Core_User_UserId",
                table: "Core_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Cms_WidgetInstance_Cms_Widget_WidgetId",
                table: "Cms_WidgetInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_Cms_WidgetInstance_Cms_WidgetZone_WidgetZoneId",
                table: "Cms_WidgetInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_Address_Core_Country_CountryId",
                table: "Core_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_Address_Core_District_DistrictId",
                table: "Core_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_Address_Core_StateOrProvince_StateOrProvinceId",
                table: "Core_Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_Category_Core_Category_ParentId",
                table: "Core_Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_User_Core_UserAddress_CurrentShippingAddressId",
                table: "Core_User");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_UserAddress_Core_Address_AddressId",
                table: "Core_UserAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Core_UserAddress_Core_User_UserId",
                table: "Core_UserAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_UserAddress",
                table: "Core_UserAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_User",
                table: "Core_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_UrlSlug",
                table: "Core_UrlSlug");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_Role",
                table: "Core_Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_Category",
                table: "Core_Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_Address",
                table: "Core_Address");

            migrationBuilder.DropIndex(
                name: "IX_Core_Address_CountryId",
                table: "Core_Address");

            migrationBuilder.DropIndex(
                name: "IX_Core_Address_DistrictId",
                table: "Core_Address");

            migrationBuilder.DropIndex(
                name: "IX_Core_Address_StateOrProvinceId",
                table: "Core_Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cms_WidgetZone",
                table: "Cms_WidgetZone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cms_WidgetInstance",
                table: "Cms_WidgetInstance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cms_Widget",
                table: "Cms_Widget");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_UserToken",
                table: "Core_UserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_UserRole",
                table: "Core_UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_UserLogin",
                table: "Core_UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_UserClaim",
                table: "Core_UserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Core_RoleClaim",
                table: "Core_RoleClaim");

            migrationBuilder.DropTable(
                name: "Core_District");

            migrationBuilder.DropTable(
                name: "Core_ProductAttributeValue");

            migrationBuilder.DropTable(
                name: "Core_ProductCategory");

            migrationBuilder.DropTable(
                name: "Core_ProductLink");

            migrationBuilder.DropTable(
                name: "Core_ProductMedia");

            migrationBuilder.DropTable(
                name: "Core_ProductOptionCombination");

            migrationBuilder.DropTable(
                name: "Core_ProductOptionValue");

            migrationBuilder.DropTable(
                name: "Core_ProductTemplateProductAttribute");

            migrationBuilder.DropTable(
                name: "Core_StateOrProvince");

            migrationBuilder.DropTable(
                name: "Core_ProductOption");

            migrationBuilder.DropTable(
                name: "Core_Product");

            migrationBuilder.DropTable(
                name: "Core_ProductAttribute");

            migrationBuilder.DropTable(
                name: "Core_ProductTemplate");

            migrationBuilder.DropTable(
                name: "Core_Country");

            migrationBuilder.DropTable(
                name: "Core_Brand");

            migrationBuilder.DropTable(
                name: "Core_Media");

            migrationBuilder.DropTable(
                name: "Core_ProductAttributeGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAddress",
                table: "Core_UserAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "Core_User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UrlSlug",
                table: "Core_UrlSlug",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "Core_Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Core_Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Core_Address",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WidgetZone",
                table: "Cms_WidgetZone",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WidgetInstance",
                table: "Cms_WidgetInstance",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Widget",
                table: "Cms_Widget",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "Core_UserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "Core_UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "Core_UserLogin",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "Core_UserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "Core_RoleClaim",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "Core_RoleClaim",
                column: "RoleId",
                principalTable: "Core_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "Core_UserClaim",
                column: "UserId",
                principalTable: "Core_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "Core_UserLogin",
                column: "UserId",
                principalTable: "Core_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "Core_UserRole",
                column: "RoleId",
                principalTable: "Core_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "Core_UserRole",
                column: "UserId",
                principalTable: "Core_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WidgetInstance_Widget_WidgetId",
                table: "Cms_WidgetInstance",
                column: "WidgetId",
                principalTable: "Cms_Widget",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WidgetInstance_WidgetZone_WidgetZoneId",
                table: "Cms_WidgetInstance",
                column: "WidgetZoneId",
                principalTable: "Cms_WidgetZone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentId",
                table: "Core_Category",
                column: "ParentId",
                principalTable: "Core_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserAddress_CurrentShippingAddressId",
                table: "Core_User",
                column: "CurrentShippingAddressId",
                principalTable: "Core_UserAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddress_Address_AddressId",
                table: "Core_UserAddress",
                column: "AddressId",
                principalTable: "Core_Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddress_AspNetUsers_UserId",
                table: "Core_UserAddress",
                column: "UserId",
                principalTable: "Core_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_Core_UserAddress_UserId",
                table: "Core_UserAddress",
                newName: "IX_UserAddress_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_UserAddress_AddressId",
                table: "Core_UserAddress",
                newName: "IX_UserAddress_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_User_CurrentShippingAddressId",
                table: "Core_User",
                newName: "IX_AspNetUsers_CurrentShippingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_Category_ParentId",
                table: "Core_Category",
                newName: "IX_Category_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Cms_WidgetInstance_WidgetZoneId",
                table: "Cms_WidgetInstance",
                newName: "IX_WidgetInstance_WidgetZoneId");

            migrationBuilder.RenameIndex(
                name: "IX_Cms_WidgetInstance_WidgetId",
                table: "Cms_WidgetInstance",
                newName: "IX_WidgetInstance_WidgetId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_UserRole_UserId",
                table: "Core_UserRole",
                newName: "IX_AspNetUserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_UserRole_RoleId",
                table: "Core_UserRole",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_UserLogin_UserId",
                table: "Core_UserLogin",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_UserClaim_UserId",
                table: "Core_UserClaim",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Core_RoleClaim_RoleId",
                table: "Core_RoleClaim",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.RenameTable(
                name: "Core_UserAddress",
                newName: "UserAddress");

            migrationBuilder.RenameTable(
                name: "Core_User",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Core_UrlSlug",
                newName: "UrlSlug");

            migrationBuilder.RenameTable(
                name: "Core_Role",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "Core_Category",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Core_Address",
                newName: "Address");

            migrationBuilder.RenameTable(
                name: "Cms_WidgetZone",
                newName: "WidgetZone");

            migrationBuilder.RenameTable(
                name: "Cms_WidgetInstance",
                newName: "WidgetInstance");

            migrationBuilder.RenameTable(
                name: "Cms_Widget",
                newName: "Widget");

            migrationBuilder.RenameTable(
                name: "Core_UserToken",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Core_UserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Core_UserLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "Core_UserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Core_RoleClaim",
                newName: "AspNetRoleClaims");
        }
    }
}
