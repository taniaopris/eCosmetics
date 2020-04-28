using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCosmetics.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    AllergyInformation = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsProductOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Shampoos", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Masks", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Styling & Creams", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/bain-lumiere-blond-absolu-250ml-01-kerastase.png?w=500&hash=34DC964B6C44DB8729CDFDF89DCAB35015E642E9", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/bain-lumiere-blond-absolu-250ml-01-kerastase.png?w=500&hash=34DC964B6C44DB8729CDFDF89DCAB35015E642E9", true, true, "Hydrating illuminating shampoo for faux-blonde hair to gently cleanse the fiber leaving hair light and luminous. This Hyaluronic Acid infused shampoo is a lightweight formula ideal for lightened, bleached, gray or light faux-blonde hair. The gentle cleansing formula soothes and hydrates hair from root to tip, leaving a lightweight feel and iluminating blond tones. It detoxifies hair from pollution and removes dulling agents. Enriched with a potent combination of Hyaluronic Acid and Edelweiss flower, the formula has high concentrations of antioxidants to prevent damage and protect fiber. Hyaluronic Acid deeply hydrates blonde hair, smoothing fiber for a uniform touch along hair strands. Hair is prepared to be treated, luminous with natural shine and nourished to the tip.", "Bain Lumière", null, 143m, "Hydrating illuminating shampoo for faux-blonde hair to gently cleanse the fiber leaving hair light and luminous." },
                    { 2, "", 1, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/densifique/packshots/homme/bain-densite-homme-densifique-120ml-01-kerastase.png?w=500&hash=B5B60165943921E4FA4E6849DE0DACD45C77C399", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/densifique/packshots/homme/bain-densite-homme-densifique-120ml-01-kerastase.png?w=500&hash=B5B60165943921E4FA4E6849DE0DACD45C77C399", true, true, "Bain Densité is a daily shampoo to treat thinning hair for men. Combined with biotin and texturizing polymers, this product has an instant densifying action on hair fiber, leaving a fresh and thickening effect on the hair and scalp for a light and healthy look on men.  ", "Bain Densité Homme", null, 152m, "Densifying men's shampoo that thickens and fortifies thinning hair, leaving it fuller." },
                    { 3, "", 1, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/elixir-ultime/packshots/bain-a-l-huile-subliminatrice-elixir-ultime-250ml-01-kerastase.png?w=500&hash=E9009C75A7B2A01A77AADF264C6902203C8BD443", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/elixir-ultime/packshots/bain-a-l-huile-subliminatrice-elixir-ultime-250ml-01-kerastase.png?w=500&hash=E9009C75A7B2A01A77AADF264C6902203C8BD443", true, false, "This Marula oil infused shampoo is a shine-enhancing formula ideal for lack-luster hair. The airy and rich lathering shampoo revives the hair fiber by generously nourishing it with all the nutrients it needs for a silky feeling. It purifies and eliminates residue and polution particles to eliminate dulling elements. Enriched with a subtle combination of Marula Oil and Camellia Oil, the formula is highly concentrated in vitamins C and D, and Oméga 9, a natural fatty acid for a long-lasting action. Together, these nourishers also ensure the gentle floral and leather notes from the fragrance last longer on hair. The hair fiber is prepared to be treated, luminous with shine and nourished to the tip.", "Bain Elixir Ultime", null, 123m, "A sublimating oil-infused shampoo for dull hair seeking intense shine." },
                    { 4, "", 1, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/bain-fluidealiste-discipline-250ml-01-kerastase.png?w=500&hash=DB29FADE08FC6EB2AB4A12896AC8004555962593", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/bain-fluidealiste-discipline-250ml-01-kerastase.png?w=500&hash=DB29FADE08FC6EB2AB4A12896AC8004555962593", true, false, "Bain Fluidéaliste was designed for unmanageable, undisciplined fine to normal hair that is difficult to style. This rich, white, creamy gel combines active ingredients to gently cleanse the hair to the root, while supplying just the right dose of uniform, evenly distributed care to restore the hair fiber and natural touch. Providing an ideal movement, the hair keeps a soft and supple finish.", "Bain Fluidéaliste", null, 125m, "Smoothing shampoo leaving the hair disciplined with movement and soft touch." },
                    { 5, "", 2, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/masque-ultra-violet-blond-absolu-250ml-kerastase.png?w=500&hash=7A76058B1E3D54572D4A6618F413CE845729ECD9", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/masque-ultra-violet-blond-absolu-250ml-kerastase.png?w=500&hash=7A76058B1E3D54572D4A6618F413CE845729ECD9", true, true, "Ideal for lightened, highlighted cool blonde hair in need of neutralization, this rich purple mask penetrates the fiber to remove unwanted yellow undertones and brassiness, while deeply hydrating and restoring hair strands. The powerful combination of Hyaluronic Acid and Edelweiss flower soothes hair, protecting it from daily oxidation and polution particles. This non-staining hair mask can be used once a week, or as often as needed to neutralize brassy tones and keep your blonde hair luminous & cool.  ", "Masque Ultra-Violet", null, 205m, "A rich deep purple mask that neutralizes brassiness and unwanted yellow tones while deeply nourishing and restoring sensitized, lightened hair." },
                    { 6, "", 2, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/cristalliste/packshots/masque-cristal-cristalliste-200ml-01-kerastase.png?w=500&hash=75B71F12D5A77F9F711BA4897AA989ADD7BFEE4D", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/cristalliste/packshots/masque-cristal-cristalliste-200ml-01-kerastase.png?w=500&hash=75B71F12D5A77F9F711BA4897AA989ADD7BFEE4D", true, false, "Masque Cristal is a deep-treatment for long and natural hair with a tendancy of dry lengths and ends. Smooth and purified without the feeling of hair being stripped from its natural moisture. Hair is free-flowing, with a lightweight touch for a shimmery and luminous finish. ", "Masque Cristal", null, 200m, "Luminous perfecting masque that leaves the hair smooth nourished and free flowing." },
                    { 7, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/masque-curl-ideal-discipline-200ml-01-kerastase.png?w=500&hash=31FBA6E55DF38A21838132FBE910076E210C58C1", 2, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/masque-curl-ideal-discipline-200ml-01-kerastase.png?w=500&hash=31FBA6E55DF38A21838132FBE910076E210C58C1", "", true, true, "Maskératine is a deep treatment mask designed for thick and unruly hair in need of smoothness. Its Morpho-Kératine™ Complex coats the fiber and restores its homogeneity to provide manageability and anti-frizz protection. Once this dense, smooth and luscious gel is rinsed, hair is softer, easier to detangle and replenished so that it puts up no resistance to styling. ", "Maskératine", null, 189m, "Smoothing masque providing extreme frizz control, fluidity, movement and softness." },
                    { 8, "", 2, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/chronologiste/packshots/creme-de-regeneration-chronologiste-200ml-01-kerastase.png?w=500&hash=32BFFE7B614FE14EC627EA1C4AEA97409818FB60", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/chronologiste/packshots/creme-de-regeneration-chronologiste-200ml-01-kerastase.png?w=500&hash=32BFFE7B614FE14EC627EA1C4AEA97409818FB60", true, false, "Crème de Régénération is the Kérastase masque that combines the highest concentration of active ingredients. Designed to deeply treat devitalized hair facing signs of aging, it strengthens and stimulates cellular renewal while revitalizing the scalp for a purifying effect on the hair. Hair is left lightweight and energized with a soft touch. ", "Crème de Regénération", null, 190m, "Intense masque treatment for the scalp and hair bringing in depth nutrition and shine." },
                    { 9, "", 3, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/aura-botanica/packshots/lait-de-soie-aura-botanica-150ml-01-kerastase.png?w=500&hash=ADE66CF71F6287828A824329D233B00FBA7E2AA5", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/aura-botanica/packshots/lait-de-soie-aura-botanica-150ml-01-kerastase.png?w=500&hash=ADE66CF71F6287828A824329D233B00FBA7E2AA5", true, false, "Smoothing leave-in milk in a 99% natural origin* formulae that disciplines frizz for a silky smooth finish and healthy glow. In 90% humidity conditions, hair is protected from frizz for 96 hours thanks to nourishing ingredients. Ideal for normal to thicker hair, it leaves the hair texture feeling soft with body and delivers natural movement. This versatile texturizer can be used to air dry and is also designed for use with heat stylers with up to 230°C thermo protection. No silicones, no parabens. *The remaining 1% are to ensure olfactory, sensorial, and formulaic stability.", "Lait de Soie", null, 80m, "99% natural origin smoothing leave-in milk for a soft and silky finish." },
                    { 10, "", 3, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/reflection/packshots/fluide-chromatique-reflection-125ml-01-kerastase.png?w=500&hash=55B08E66EF0E8CF0A4B5C7537B86740C0B862216", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/reflection/packshots/fluide-chromatique-reflection-125ml-01-kerastase.png?w=500&hash=55B08E66EF0E8CF0A4B5C7537B86740C0B862216", true, true, "Fluide Chromatique is a softening essence for color-treated or highlighted hair. It nourishes and protects hair while providing a perfect radiance. ", "Fluide Chromatique", null, 90m, "Leave in serum to protect colored hair for luminous radiant shine." },
                    { 11, "", 3, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/resistance/packshots/serum-extentioniste-resistance-50ml-01-kerastase.png?w=500&hash=9CB2F9CA2DEFC430A23928E49B78B1159ADFF5E6", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/resistance/packshots/serum-extentioniste-resistance-50ml-01-kerastase.png?w=500&hash=9CB2F9CA2DEFC430A23928E49B78B1159ADFF5E6", true, false, "A highly concentrated serum with key active ingredients that stimulate the growth of strong healthy hair follicles. This energizing leave-in treatment is a key step to reinforce roots and promote a healthy scalp environment. Its non-greasy formula harnesses the power of Ceramides to protect the scalp from environmental aggressors while stimulating and energizing roots. Applied with a gentle scalp massage, it’s ideal to boost and activate the growth of healthy hair to achieve strong long hair.", "Serum Extentioniste", null, 95m, "Energizing leave-in serum to stimulate and protect the scalp for healthy long hair." },
                    { 12, "", 3, "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/soleil/packshots/huile-sirene-soleil-150ml-01-kerastase.png?w=500&hash=58C8D0925DF57267CDC97FD20462F4CD0C47F3BF", "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/soleil/packshots/huile-sirene-soleil-150ml-01-kerastase.png?w=500&hash=58C8D0925DF57267CDC97FD20462F4CD0C47F3BF", true, true, "Summer's must-have bi-phase spray, this irresistible lightweight leave-in defines and enhances natural beach waves. Enriched with Vitamin E from the Babassu oil, moisturizing agents are quickly absorbed into the hair providing instant softness for a touchable no - crunch texture. It defines hair's natural shape and creates shiny luminous locks. Shake and spray on lengths to impart hair with a sensual fragrance of jasmine and solar tuberose notes.", "Huile Sirène", null, 102m, "Summer leave-in hybrid spray that provides the texture of a styling solution with the protective quality of a nourishing hair oil" }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
