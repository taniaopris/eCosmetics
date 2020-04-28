using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCosmetics.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Shampoos" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Masks" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Styling & Creams" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Bain Lumière",
                Price = 143M,
                ShortDescription = "Hydrating illuminating shampoo for faux-blonde hair to gently cleanse the fiber leaving hair light and luminous.",
                LongDescription =
                    "Hydrating illuminating shampoo for faux-blonde hair to gently cleanse the fiber leaving hair light and luminous. This Hyaluronic Acid infused shampoo is a lightweight formula ideal for lightened, bleached, gray or light faux-blonde hair. The gentle cleansing formula soothes and hydrates hair from root to tip, leaving a lightweight feel and iluminating blond tones. It detoxifies hair from pollution and removes dulling agents. Enriched with a potent combination of Hyaluronic Acid and Edelweiss flower, the formula has high concentrations of antioxidants to prevent damage and protect fiber. Hyaluronic Acid deeply hydrates blonde hair, smoothing fiber for a uniform touch along hair strands. Hair is prepared to be treated, luminous with natural shine and nourished to the tip.",
                CategoryId = 1,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/bain-lumiere-blond-absolu-250ml-01-kerastase.png?w=500&hash=34DC964B6C44DB8729CDFDF89DCAB35015E642E9",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/bain-lumiere-blond-absolu-250ml-01-kerastase.png?w=500&hash=34DC964B6C44DB8729CDFDF89DCAB35015E642E9",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Bain Densité Homme",
                Price = 152M,
                ShortDescription = "Densifying men's shampoo that thickens and fortifies thinning hair, leaving it fuller.",
                LongDescription =
        "Bain Densité is a daily shampoo to treat thinning hair for men. Combined with biotin and texturizing polymers, this product has an instant densifying action on hair fiber, leaving a fresh and thickening effect on the hair and scalp for a light and healthy look on men.  ",
                CategoryId = 1,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/densifique/packshots/homme/bain-densite-homme-densifique-120ml-01-kerastase.png?w=500&hash=B5B60165943921E4FA4E6849DE0DACD45C77C399",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/densifique/packshots/homme/bain-densite-homme-densifique-120ml-01-kerastase.png?w=500&hash=B5B60165943921E4FA4E6849DE0DACD45C77C399",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Bain Elixir Ultime",
                Price = 123M,
                ShortDescription = "A sublimating oil-infused shampoo for dull hair seeking intense shine.",
                LongDescription =
        "This Marula oil infused shampoo is a shine-enhancing formula ideal for lack-luster hair. The airy and rich lathering shampoo revives the hair fiber by generously nourishing it with all the nutrients it needs for a silky feeling. It purifies and eliminates residue and polution particles to eliminate dulling elements. Enriched with a subtle combination of Marula Oil and Camellia Oil, the formula is highly concentrated in vitamins C and D, and Oméga 9, a natural fatty acid for a long-lasting action. Together, these nourishers also ensure the gentle floral and leather notes from the fragrance last longer on hair. The hair fiber is prepared to be treated, luminous with shine and nourished to the tip.",
                CategoryId = 1,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/elixir-ultime/packshots/bain-a-l-huile-subliminatrice-elixir-ultime-250ml-01-kerastase.png?w=500&hash=E9009C75A7B2A01A77AADF264C6902203C8BD443",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/elixir-ultime/packshots/bain-a-l-huile-subliminatrice-elixir-ultime-250ml-01-kerastase.png?w=500&hash=E9009C75A7B2A01A77AADF264C6902203C8BD443",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Bain Fluidéaliste",
                Price = 125M,
                ShortDescription = "Smoothing shampoo leaving the hair disciplined with movement and soft touch.",
                LongDescription =
        "Bain Fluidéaliste was designed for unmanageable, undisciplined fine to normal hair that is difficult to style. This rich, white, creamy gel combines active ingredients to gently cleanse the hair to the root, while supplying just the right dose of uniform, evenly distributed care to restore the hair fiber and natural touch. Providing an ideal movement, the hair keeps a soft and supple finish.",
                CategoryId = 1,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/bain-fluidealiste-discipline-250ml-01-kerastase.png?w=500&hash=DB29FADE08FC6EB2AB4A12896AC8004555962593",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/bain-fluidealiste-discipline-250ml-01-kerastase.png?w=500&hash=DB29FADE08FC6EB2AB4A12896AC8004555962593",
                AllergyInformation = ""
            });



            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Masque Ultra-Violet",
                Price = 205M,
                ShortDescription = "A rich deep purple mask that neutralizes brassiness and unwanted yellow tones while deeply nourishing and restoring sensitized, lightened hair.",
                LongDescription =
        "Ideal for lightened, highlighted cool blonde hair in need of neutralization, this rich purple mask penetrates the fiber to remove unwanted yellow undertones and brassiness, while deeply hydrating and restoring hair strands. The powerful combination of Hyaluronic Acid and Edelweiss flower soothes hair, protecting it from daily oxidation and polution particles. This non-staining hair mask can be used once a week, or as often as needed to neutralize brassy tones and keep your blonde hair luminous & cool.  ",
                CategoryId = 2,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/masque-ultra-violet-blond-absolu-250ml-kerastase.png?w=500&hash=7A76058B1E3D54572D4A6618F413CE845729ECD9",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl =
        "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/blond-absolu/packshots/masque-ultra-violet-blond-absolu-250ml-kerastase.png?w=500&hash=7A76058B1E3D54572D4A6618F413CE845729ECD9",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Masque Cristal",
                Price = 200M,
                ShortDescription = "Luminous perfecting masque that leaves the hair smooth nourished and free flowing.",
                LongDescription =
        "Masque Cristal is a deep-treatment for long and natural hair with a tendancy of dry lengths and ends. Smooth and purified without the feeling of hair being stripped from its natural moisture. Hair is free-flowing, with a lightweight touch for a shimmery and luminous finish. ",
                CategoryId = 2,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/cristalliste/packshots/masque-cristal-cristalliste-200ml-01-kerastase.png?w=500&hash=75B71F12D5A77F9F711BA4897AA989ADD7BFEE4D",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
        "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/cristalliste/packshots/masque-cristal-cristalliste-200ml-01-kerastase.png?w=500&hash=75B71F12D5A77F9F711BA4897AA989ADD7BFEE4D",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Maskératine",
                Price = 189M,
                ShortDescription = "Smoothing masque providing extreme frizz control, fluidity, movement and softness.",
                LongDescription =
        "Maskératine is a deep treatment mask designed for thick and unruly hair in need of smoothness. Its Morpho-Kératine™ Complex coats the fiber and restores its homogeneity to provide manageability and anti-frizz protection. Once this dense, smooth and luscious gel is rinsed, hair is softer, easier to detangle and replenished so that it puts up no resistance to styling. ",
                CategoryId = 2,
                ImageUrl = "",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl =
        "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/masque-curl-ideal-discipline-200ml-01-kerastase.png?w=500&hash=31FBA6E55DF38A21838132FBE910076E210C58C1",
                AllergyInformation = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/discipline/packshots/masque-curl-ideal-discipline-200ml-01-kerastase.png?w=500&hash=31FBA6E55DF38A21838132FBE910076E210C58C1"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Crème de Regénération",
                Price = 190M,
                ShortDescription = "Intense masque treatment for the scalp and hair bringing in depth nutrition and shine.",
                LongDescription =
        "Crème de Régénération is the Kérastase masque that combines the highest concentration of active ingredients. Designed to deeply treat devitalized hair facing signs of aging, it strengthens and stimulates cellular renewal while revitalizing the scalp for a purifying effect on the hair. Hair is left lightweight and energized with a soft touch. ",
                CategoryId = 2,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/chronologiste/packshots/creme-de-regeneration-chronologiste-200ml-01-kerastase.png?w=500&hash=32BFFE7B614FE14EC627EA1C4AEA97409818FB60",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
        "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/chronologiste/packshots/creme-de-regeneration-chronologiste-200ml-01-kerastase.png?w=500&hash=32BFFE7B614FE14EC627EA1C4AEA97409818FB60",
                AllergyInformation = ""
            });



            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Lait de Soie",
                Price = 80M,
                ShortDescription = "99% natural origin smoothing leave-in milk for a soft and silky finish.",
                LongDescription =
        "Smoothing leave-in milk in a 99% natural origin* formulae that disciplines frizz for a silky smooth finish and healthy glow. In 90% humidity conditions, hair is protected from frizz for 96 hours thanks to nourishing ingredients. Ideal for normal to thicker hair, it leaves the hair texture feeling soft with body and delivers natural movement. This versatile texturizer can be used to air dry and is also designed for use with heat stylers with up to 230°C thermo protection. No silicones, no parabens. *The remaining 1% are to ensure olfactory, sensorial, and formulaic stability.",
                CategoryId = 3,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/aura-botanica/packshots/lait-de-soie-aura-botanica-150ml-01-kerastase.png?w=500&hash=ADE66CF71F6287828A824329D233B00FBA7E2AA5",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
        "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/aura-botanica/packshots/lait-de-soie-aura-botanica-150ml-01-kerastase.png?w=500&hash=ADE66CF71F6287828A824329D233B00FBA7E2AA5",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Fluide Chromatique",
                Price = 90M,
                ShortDescription = "Leave in serum to protect colored hair for luminous radiant shine.",
                LongDescription =
"Fluide Chromatique is a softening essence for color-treated or highlighted hair. It nourishes and protects hair while providing a perfect radiance. ",
                CategoryId = 3,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/reflection/packshots/fluide-chromatique-reflection-125ml-01-kerastase.png?w=500&hash=55B08E66EF0E8CF0A4B5C7537B86740C0B862216",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl =
"https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/reflection/packshots/fluide-chromatique-reflection-125ml-01-kerastase.png?w=500&hash=55B08E66EF0E8CF0A4B5C7537B86740C0B862216",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Serum Extentioniste",
                Price = 95M,
                ShortDescription = "Energizing leave-in serum to stimulate and protect the scalp for healthy long hair.",
                LongDescription =
"A highly concentrated serum with key active ingredients that stimulate the growth of strong healthy hair follicles. This energizing leave-in treatment is a key step to reinforce roots and promote a healthy scalp environment. Its non-greasy formula harnesses the power of Ceramides to protect the scalp from environmental aggressors while stimulating and energizing roots. Applied with a gentle scalp massage, it’s ideal to boost and activate the growth of healthy hair to achieve strong long hair.",
                CategoryId = 3,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/resistance/packshots/serum-extentioniste-resistance-50ml-01-kerastase.png?w=500&hash=9CB2F9CA2DEFC430A23928E49B78B1159ADFF5E6",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
"https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/resistance/packshots/serum-extentioniste-resistance-50ml-01-kerastase.png?w=500&hash=9CB2F9CA2DEFC430A23928E49B78B1159ADFF5E6",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Huile Sirène",
                Price = 102M,
                ShortDescription = "Summer leave-in hybrid spray that provides the texture of a styling solution with the protective quality of a nourishing hair oil",
                LongDescription =
"Summer's must-have bi-phase spray, this irresistible lightweight leave-in defines and enhances natural beach waves. Enriched with Vitamin E from the Babassu oil, moisturizing agents are quickly absorbed into the hair providing instant softness for a touchable no - crunch texture. It defines hair's natural shape and creates shiny luminous locks. Shake and spray on lengths to impart hair with a sensual fragrance of jasmine and solar tuberose notes.",
                CategoryId = 3,
                ImageUrl = "https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/soleil/packshots/huile-sirene-soleil-150ml-01-kerastase.png?w=500&hash=58C8D0925DF57267CDC97FD20462F4CD0C47F3BF",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl =
"https://www.kerastase.com/-/media/project/loreal/brand-sites/kerastase/emea/inter/products/soleil/packshots/huile-sirene-soleil-150ml-01-kerastase.png?w=500&hash=58C8D0925DF57267CDC97FD20462F4CD0C47F3BF",
                AllergyInformation = ""
            });


        }
    }
}

