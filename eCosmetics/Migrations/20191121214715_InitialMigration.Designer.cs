﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCosmetics.Models;

namespace eCosmetics.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191121214715_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("eCosmetics.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Shampoos"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Masks"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Styling & Creams"
                        });
                });

            modelBuilder.Entity("eCosmetics.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eCosmetics.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("eCosmetics.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/bain-lumiere-blond-absolu-250ml-01-kerastase.png?w=500&hash=34DC964B6C44DB8729CDFDF89DCAB35015E642E9",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/bain-lumiere-blond-absolu-250ml-01-kerastase.png?w=500&hash=34DC964B6C44DB8729CDFDF89DCAB35015E642E9",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "Hydrating illuminating shampoo for faux-blonde hair to gently cleanse the fiber leaving hair light and luminous. This Hyaluronic Acid infused shampoo is a lightweight formula ideal for lightened, bleached, gray or light faux-blonde hair. The gentle cleansing formula soothes and hydrates hair from root to tip, leaving a lightweight feel and iluminating blond tones. It detoxifies hair from pollution and removes dulling agents. Enriched with a potent combination of Hyaluronic Acid and Edelweiss flower, the formula has high concentrations of antioxidants to prevent damage and protect fiber. Hyaluronic Acid deeply hydrates blonde hair, smoothing fiber for a uniform touch along hair strands. Hair is prepared to be treated, luminous with natural shine and nourished to the tip.",
                            Name = "Bain Lumière",
                            Price = 143m,
                            ShortDescription = "Hydrating illuminating shampoo for faux-blonde hair to gently cleanse the fiber leaving hair light and luminous."
                        },
                        new
                        {
                            ProductId = 2,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/densifique/packshots/homme/bain-densite-homme-densifique-120ml-01-kerastase.png?w=500&hash=B5B60165943921E4FA4E6849DE0DACD45C77C399",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/densifique/packshots/homme/bain-densite-homme-densifique-120ml-01-kerastase.png?w=500&hash=B5B60165943921E4FA4E6849DE0DACD45C77C399",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "Bain Densité is a daily shampoo to treat thinning hair for men. Combined with biotin and texturizing polymers, this product has an instant densifying action on hair fiber, leaving a fresh and thickening effect on the hair and scalp for a light and healthy look on men.  ",
                            Name = "Bain Densité Homme",
                            Price = 152m,
                            ShortDescription = "Densifying men's shampoo that thickens and fortifies thinning hair, leaving it fuller."
                        },
                        new
                        {
                            ProductId = 3,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/elixir-ultime/packshots/bain-a-l-huile-subliminatrice-elixir-ultime-250ml-01-kerastase.png?w=500&hash=E9009C75A7B2A01A77AADF264C6902203C8BD443",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/elixir-ultime/packshots/bain-a-l-huile-subliminatrice-elixir-ultime-250ml-01-kerastase.png?w=500&hash=E9009C75A7B2A01A77AADF264C6902203C8BD443",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "This Marula oil infused shampoo is a shine-enhancing formula ideal for lack-luster hair. The airy and rich lathering shampoo revives the hair fiber by generously nourishing it with all the nutrients it needs for a silky feeling. It purifies and eliminates residue and polution particles to eliminate dulling elements. Enriched with a subtle combination of Marula Oil and Camellia Oil, the formula is highly concentrated in vitamins C and D, and Oméga 9, a natural fatty acid for a long-lasting action. Together, these nourishers also ensure the gentle floral and leather notes from the fragrance last longer on hair. The hair fiber is prepared to be treated, luminous with shine and nourished to the tip.",
                            Name = "Bain Elixir Ultime",
                            Price = 123m,
                            ShortDescription = "A sublimating oil-infused shampoo for dull hair seeking intense shine."
                        },
                        new
                        {
                            ProductId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/bain-fluidealiste-discipline-250ml-01-kerastase.png?w=500&hash=DB29FADE08FC6EB2AB4A12896AC8004555962593",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/bain-fluidealiste-discipline-250ml-01-kerastase.png?w=500&hash=DB29FADE08FC6EB2AB4A12896AC8004555962593",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Bain Fluidéaliste was designed for unmanageable, undisciplined fine to normal hair that is difficult to style. This rich, white, creamy gel combines active ingredients to gently cleanse the hair to the root, while supplying just the right dose of uniform, evenly distributed care to restore the hair fiber and natural touch. Providing an ideal movement, the hair keeps a soft and supple finish.",
                            Name = "Bain Fluidéaliste",
                            Price = 125m,
                            ShortDescription = "Smoothing shampoo leaving the hair disciplined with movement and soft touch."
                        },
                        new
                        {
                            ProductId = 5,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/masque-ultra-violet-blond-absolu-250ml-kerastase.png?w=500&hash=7A76058B1E3D54572D4A6618F413CE845729ECD9",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/masque-ultra-violet-blond-absolu-250ml-kerastase.png?w=500&hash=7A76058B1E3D54572D4A6618F413CE845729ECD9",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "Ideal for lightened, highlighted cool blonde hair in need of neutralization, this rich purple mask penetrates the fiber to remove unwanted yellow undertones and brassiness, while deeply hydrating and restoring hair strands. The powerful combination of Hyaluronic Acid and Edelweiss flower soothes hair, protecting it from daily oxidation and polution particles. This non-staining hair mask can be used once a week, or as often as needed to neutralize brassy tones and keep your blonde hair luminous & cool.  ",
                            Name = "Masque Ultra-Violet",
                            Price = 205m,
                            ShortDescription = "A rich deep purple mask that neutralizes brassiness and unwanted yellow tones while deeply nourishing and restoring sensitized, lightened hair."
                        },
                        new
                        {
                            ProductId = 6,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/cristalliste/packshots/masque-cristal-cristalliste-200ml-01-kerastase.png?w=500&hash=75B71F12D5A77F9F711BA4897AA989ADD7BFEE4D",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/cristalliste/packshots/masque-cristal-cristalliste-200ml-01-kerastase.png?w=500&hash=75B71F12D5A77F9F711BA4897AA989ADD7BFEE4D",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Masque Cristal is a deep-treatment for long and natural hair with a tendancy of dry lengths and ends. Smooth and purified without the feeling of hair being stripped from its natural moisture. Hair is free-flowing, with a lightweight touch for a shimmery and luminous finish. ",
                            Name = "Masque Cristal",
                            Price = 200m,
                            ShortDescription = "Luminous perfecting masque that leaves the hair smooth nourished and free flowing."
                        },
                        new
                        {
                            ProductId = 7,
                            AllergyInformation = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/masque-curl-ideal-discipline-200ml-01-kerastase.png?w=500&hash=31FBA6E55DF38A21838132FBE910076E210C58C1",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/masque-curl-ideal-discipline-200ml-01-kerastase.png?w=500&hash=31FBA6E55DF38A21838132FBE910076E210C58C1",
                            ImageUrl = "",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "Maskératine is a deep treatment mask designed for thick and unruly hair in need of smoothness. Its Morpho-Kératine™ Complex coats the fiber and restores its homogeneity to provide manageability and anti-frizz protection. Once this dense, smooth and luscious gel is rinsed, hair is softer, easier to detangle and replenished so that it puts up no resistance to styling. ",
                            Name = "Maskératine",
                            Price = 189m,
                            ShortDescription = "Smoothing masque providing extreme frizz control, fluidity, movement and softness."
                        },
                        new
                        {
                            ProductId = 8,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/chronologiste/packshots/creme-de-regeneration-chronologiste-200ml-01-kerastase.png?w=500&hash=32BFFE7B614FE14EC627EA1C4AEA97409818FB60",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/chronologiste/packshots/creme-de-regeneration-chronologiste-200ml-01-kerastase.png?w=500&hash=32BFFE7B614FE14EC627EA1C4AEA97409818FB60",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Crème de Régénération is the Kérastase masque that combines the highest concentration of active ingredients. Designed to deeply treat devitalized hair facing signs of aging, it strengthens and stimulates cellular renewal while revitalizing the scalp for a purifying effect on the hair. Hair is left lightweight and energized with a soft touch. ",
                            Name = "Crème de Regénération",
                            Price = 190m,
                            ShortDescription = "Intense masque treatment for the scalp and hair bringing in depth nutrition and shine."
                        },
                        new
                        {
                            ProductId = 9,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/aura-botanica/packshots/lait-de-soie-aura-botanica-150ml-01-kerastase.png?w=500&hash=ADE66CF71F6287828A824329D233B00FBA7E2AA5",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/aura-botanica/packshots/lait-de-soie-aura-botanica-150ml-01-kerastase.png?w=500&hash=ADE66CF71F6287828A824329D233B00FBA7E2AA5",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Smoothing leave-in milk in a 99% natural origin* formulae that disciplines frizz for a silky smooth finish and healthy glow. In 90% humidity conditions, hair is protected from frizz for 96 hours thanks to nourishing ingredients. Ideal for normal to thicker hair, it leaves the hair texture feeling soft with body and delivers natural movement. This versatile texturizer can be used to air dry and is also designed for use with heat stylers with up to 230°C thermo protection. No silicones, no parabens. *The remaining 1% are to ensure olfactory, sensorial, and formulaic stability.",
                            Name = "Lait de Soie",
                            Price = 80m,
                            ShortDescription = "99% natural origin smoothing leave-in milk for a soft and silky finish."
                        },
                        new
                        {
                            ProductId = 10,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/reflection/packshots/fluide-chromatique-reflection-125ml-01-kerastase.png?w=500&hash=55B08E66EF0E8CF0A4B5C7537B86740C0B862216",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/reflection/packshots/fluide-chromatique-reflection-125ml-01-kerastase.png?w=500&hash=55B08E66EF0E8CF0A4B5C7537B86740C0B862216",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "Fluide Chromatique is a softening essence for color-treated or highlighted hair. It nourishes and protects hair while providing a perfect radiance. ",
                            Name = "Fluide Chromatique",
                            Price = 90m,
                            ShortDescription = "Leave in serum to protect colored hair for luminous radiant shine."
                        },
                        new
                        {
                            ProductId = 11,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/resistance/packshots/serum-extentioniste-resistance-50ml-01-kerastase.png?w=500&hash=9CB2F9CA2DEFC430A23928E49B78B1159ADFF5E6",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/resistance/packshots/serum-extentioniste-resistance-50ml-01-kerastase.png?w=500&hash=9CB2F9CA2DEFC430A23928E49B78B1159ADFF5E6",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "A highly concentrated serum with key active ingredients that stimulate the growth of strong healthy hair follicles. This energizing leave-in treatment is a key step to reinforce roots and promote a healthy scalp environment. Its non-greasy formula harnesses the power of Ceramides to protect the scalp from environmental aggressors while stimulating and energizing roots. Applied with a gentle scalp massage, it’s ideal to boost and activate the growth of healthy hair to achieve strong long hair.",
                            Name = "Serum Extentioniste",
                            Price = 95m,
                            ShortDescription = "Energizing leave-in serum to stimulate and protect the scalp for healthy long hair."
                        },
                        new
                        {
                            ProductId = 12,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/soleil/packshots/huile-sirene-soleil-150ml-01-kerastase.png?w=500&hash=58C8D0925DF57267CDC97FD20462F4CD0C47F3BF",
                            ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/soleil/packshots/huile-sirene-soleil-150ml-01-kerastase.png?w=500&hash=58C8D0925DF57267CDC97FD20462F4CD0C47F3BF",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            LongDescription = "Summer's must-have bi-phase spray, this irresistible lightweight leave-in defines and enhances natural beach waves. Enriched with Vitamin E from the Babassu oil, moisturizing agents are quickly absorbed into the hair providing instant softness for a touchable no - crunch texture. It defines hair's natural shape and creates shiny luminous locks. Shake and spray on lengths to impart hair with a sensual fragrance of jasmine and solar tuberose notes.",
                            Name = "Huile Sirène",
                            Price = 102m,
                            ShortDescription = "Summer leave-in hybrid spray that provides the texture of a styling solution with the protective quality of a nourishing hair oil"
                        });
                });

            modelBuilder.Entity("eCosmetics.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCosmetics.Models.OrderDetail", b =>
                {
                    b.HasOne("eCosmetics.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCosmetics.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCosmetics.Models.Product", b =>
                {
                    b.HasOne("eCosmetics.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCosmetics.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("eCosmetics.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
