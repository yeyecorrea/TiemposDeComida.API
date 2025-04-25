using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiemposDeComida.Data.Migrations
{
    /// <inheritdoc />
    public partial class InirtialDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstablishmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstablishmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatureRestaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureRestaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfileUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateRegistration = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileUserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_ProfileUsers_ProfileUserId",
                        column: x => x.ProfileUserId,
                        principalTable: "ProfileUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotoUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileUseId = table.Column<int>(type: "int", nullable: false),
                    ProfileUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoUsers_ProfileUsers_ProfileUserId",
                        column: x => x.ProfileUserId,
                        principalTable: "ProfileUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantCategoryId = table.Column<int>(type: "int", nullable: false),
                    Cities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationMethodId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Schedules = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EstablishmentTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_EstablishmentTypes_EstablishmentTypeId",
                        column: x => x.EstablishmentTypeId,
                        principalTable: "EstablishmentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_ReservationMethods_ReservationMethodId",
                        column: x => x.ReservationMethodId,
                        principalTable: "ReservationMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurants_RestaurantCategorys_RestaurantCategoryId",
                        column: x => x.RestaurantCategoryId,
                        principalTable: "RestaurantCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    TimeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialRequests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bookingStatus = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProfileUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_ProfileUsers_ProfileUserId",
                        column: x => x.ProfileUserId,
                        principalTable: "ProfileUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MenuCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuCategoris_MenuCategoryId",
                        column: x => x.MenuCategoryId,
                        principalTable: "MenuCategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Opiniones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calification = table.Column<int>(type: "int", nullable: false),
                    DateVisitMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhoDidYouGoWith = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProfileUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opiniones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opiniones_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Opiniones_ProfileUsers_ProfileUserId",
                        column: x => x.ProfileUserId,
                        principalTable: "ProfileUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Opiniones_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhotoRestaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoRestaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoRestaurants_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantFeatures",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    FeatureRestaurantId = table.Column<int>(type: "int", nullable: false),
                    FeatureRestaurantId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantFeatures", x => new { x.RestaurantId, x.FeatureRestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantFeatures_FeatureRestaurants_FeatureRestaurantId",
                        column: x => x.FeatureRestaurantId,
                        principalTable: "FeatureRestaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestaurantFeatures_FeatureRestaurants_FeatureRestaurantId1",
                        column: x => x.FeatureRestaurantId1,
                        principalTable: "FeatureRestaurants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantFeatures_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeFood_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypeKitchens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeKitchens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeKitchens_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhotoOpinions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpinionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoOpinions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoOpinions_Opiniones_OpinionId",
                        column: x => x.OpinionId,
                        principalTable: "Opiniones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponseOpinions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpinionId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseOpinions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponseOpinions_Opiniones_OpinionId",
                        column: x => x.OpinionId,
                        principalTable: "Opiniones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponseOpinions_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTypeFoods",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    TypeFoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTypeFoods", x => new { x.RestaurantId, x.TypeFoodId });
                    table.ForeignKey(
                        name: "FK_RestaurantTypeFoods_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestaurantTypeFoods_TypeFood_TypeFoodId",
                        column: x => x.TypeFoodId,
                        principalTable: "TypeFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTypeKitchens",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    TypeKitchenId = table.Column<int>(type: "int", nullable: false),
                    TypeFoodId = table.Column<int>(type: "int", nullable: true),
                    TypeKitchenId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTypeKitchens", x => new { x.RestaurantId, x.TypeKitchenId });
                    table.ForeignKey(
                        name: "FK_RestaurantTypeKitchens_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestaurantTypeKitchens_TypeFood_TypeFoodId",
                        column: x => x.TypeFoodId,
                        principalTable: "TypeFood",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantTypeKitchens_TypeKitchens_TypeKitchenId",
                        column: x => x.TypeKitchenId,
                        principalTable: "TypeKitchens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestaurantTypeKitchens_TypeKitchens_TypeKitchenId1",
                        column: x => x.TypeKitchenId1,
                        principalTable: "TypeKitchens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfileUserId",
                table: "AspNetUsers",
                column: "ProfileUserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ApplicationUserId1",
                table: "Bookings",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ProfileUserId",
                table: "Bookings",
                column: "ProfileUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RestaurantId",
                table: "Bookings",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuCategoryId",
                table: "MenuItems",
                column: "MenuCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_RestaurantId",
                table: "MenuItems",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Opiniones_ApplicationUserId1",
                table: "Opiniones",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Opiniones_ProfileUserId",
                table: "Opiniones",
                column: "ProfileUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Opiniones_RestaurantId",
                table: "Opiniones",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOpinions_OpinionId",
                table: "PhotoOpinions",
                column: "OpinionId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoRestaurants_RestaurantId",
                table: "PhotoRestaurants",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoUsers_ProfileUserId",
                table: "PhotoUsers",
                column: "ProfileUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseOpinions_OpinionId",
                table: "ResponseOpinions",
                column: "OpinionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResponseOpinions_RestaurantId",
                table: "ResponseOpinions",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantFeatures_FeatureRestaurantId",
                table: "RestaurantFeatures",
                column: "FeatureRestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantFeatures_FeatureRestaurantId1",
                table: "RestaurantFeatures",
                column: "FeatureRestaurantId1");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_ApplicationUserId1",
                table: "Restaurants",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_EstablishmentTypeId",
                table: "Restaurants",
                column: "EstablishmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_ReservationMethodId",
                table: "Restaurants",
                column: "ReservationMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantCategoryId",
                table: "Restaurants",
                column: "RestaurantCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTypeFoods_TypeFoodId",
                table: "RestaurantTypeFoods",
                column: "TypeFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTypeKitchens_TypeFoodId",
                table: "RestaurantTypeKitchens",
                column: "TypeFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTypeKitchens_TypeKitchenId",
                table: "RestaurantTypeKitchens",
                column: "TypeKitchenId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTypeKitchens_TypeKitchenId1",
                table: "RestaurantTypeKitchens",
                column: "TypeKitchenId1");

            migrationBuilder.CreateIndex(
                name: "IX_TypeFood_RestaurantId",
                table: "TypeFood",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeKitchens_RestaurantId",
                table: "TypeKitchens",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "PhotoOpinions");

            migrationBuilder.DropTable(
                name: "PhotoRestaurants");

            migrationBuilder.DropTable(
                name: "PhotoUsers");

            migrationBuilder.DropTable(
                name: "ResponseOpinions");

            migrationBuilder.DropTable(
                name: "RestaurantFeatures");

            migrationBuilder.DropTable(
                name: "RestaurantTypeFoods");

            migrationBuilder.DropTable(
                name: "RestaurantTypeKitchens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "MenuCategoris");

            migrationBuilder.DropTable(
                name: "Opiniones");

            migrationBuilder.DropTable(
                name: "FeatureRestaurants");

            migrationBuilder.DropTable(
                name: "TypeFood");

            migrationBuilder.DropTable(
                name: "TypeKitchens");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EstablishmentTypes");

            migrationBuilder.DropTable(
                name: "ReservationMethods");

            migrationBuilder.DropTable(
                name: "RestaurantCategorys");

            migrationBuilder.DropTable(
                name: "ProfileUsers");
        }
    }
}
