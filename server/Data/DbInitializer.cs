using Microsoft.AspNetCore.Identity;
using server.Entity;

namespace server.Data
{
    public static class DbInitializer
    {
        public async static void Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var member = new User
                {
                    UserName = "member",
                    Email = "member@test.com",
                };
                await userManager.CreateAsync(member, "Pa$$w0rd");
                await userManager.AddToRoleAsync(member, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com",
                };
                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
            }

            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                new Product
    {
        Name = "Essence Mascara Lash Princess",
        Description= "The Essence Mascara Lash Princess is a popular mascara known for its volumizing and lengthening effects. Achieve dramatic lashes with this long-lasting and cruelty-free formula.",
        Category= "beauty",
        Price= 999,
        DiscountPercentage= 7.17,
        Rating= 4.94,
        QuantityInStock= 5,
        Tags= [
            "beauty",
            "mascara"
        ],
        Brand= "Essence",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/beauty/Essence%20Mascara%20Lash%20Princess/1.png"
        ],
        Thumbnail= "beauty_Essence_Mascara_Lash_Princess"
    },
    new Product
    {
        Name = "Eyeshadow Palette with Mirror",
        Description= "The Eyeshadow Palette with Mirror offers a versatile range of eyeshadow shades for creating stunning eye looks. With a built-in mirror, it's convenient for on-the-go makeup application.",
        Category= "beauty",
        Price= 1998,
        DiscountPercentage= 5.5,
        Rating= 3.28,
        QuantityInStock= 44,
        Tags= [
            "beauty",
            "eyeshadow"
        ],
        Brand= "Glamour Beauty",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/beauty/Eyeshadow%20Palette%20with%20Mirror/1.png"
        ],
        Thumbnail= "beauty_Eyeshadow_Palette_with_Mirror"
    },
    new Product
    {
        Name = "Powder Canister",
        Description= "The Powder Canister is a finely milled setting powder designed to set makeup and control shine. With a lightweight and translucent formula, it provides a smooth and matte finish.",
        Category= "beauty",
        Price= 1499,
        DiscountPercentage= 18.14,
        Rating= 3.82,
        QuantityInStock= 59,
        Tags= [
            "beauty",
            "face powder"
        ],
        Brand= "Velvet Touch",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/beauty/Powder%20Canister/1.png"
        ],
        Thumbnail= "beauty_Powder_Canister"
    },
    new Product
    {
        Name = "Red Lipstick",
        Description= "The Red Lipstick is a classic and bold choice for adding a pop of color to your lips. With a creamy and pigmented formula, it provides a vibrant and long-lasting finish.",
        Category= "beauty",
        Price= 1299,
        DiscountPercentage= 19.03,
        Rating= 2.51,
        QuantityInStock= 68,
        Tags= [
            "beauty",
            "lipstick"
        ],
        Brand= "Chic Cosmetics",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/beauty/Red%20Lipstick/1.png"
        ],
        Thumbnail= "beauty_Red_Lipstick"
    },
    new Product
    {
        Name = "Red Nail Polish",
        Description= "The Red Nail Polish offers a rich and glossy red hue for vibrant and polished nails. With a quick-drying formula, it provides a salon-quality finish at home.",
        Category= "beauty",
        Price= 899,
        DiscountPercentage= 2.46,
        Rating= 3.91,
        QuantityInStock= 71,
        Tags= [
            "beauty",
            "nail polish"
        ],
        Brand= "Nail Couture",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/beauty/Red%20Nail%20Polish/1.png"
        ],
        Thumbnail= "beauty_Red_Nail_Polish"
    },
    new Product
    {
        Name = "Calvin Klein CK One",
        Description= "CK One by Calvin Klein is a classic unisex fragrance, known for its fresh and clean scent. It's a versatile fragrance suitable for everyday wear.",
        Category= "fragrances",
        Price= 4999,
        DiscountPercentage= 0.32,
        Rating= 4.85,
        QuantityInStock= 17,
        Tags= [
            "fragrances",
            "perfumes"
        ],
        Brand= "Calvin Klein",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/fragrances/Calvin%20Klein%20CK%20One/1.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Calvin%20Klein%20CK%20One/2.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Calvin%20Klein%20CK%20One/3.png"
        ],
        Thumbnail= "fragrances_Calvin_Klein_CK_One"
    },
    new Product
    {
        Name = "Chanel Coco Noir Eau De",
        Description= "Coco Noir by Chanel is an elegant and mysterious fragrance, featuring notes of grapefruit, rose, and sandalwood. Perfect for evening occasions.",
        Category= "fragrances",
        Price= 12999,
        DiscountPercentage= 18.64,
        Rating= 2.76,
        QuantityInStock= 41,
        Tags= [
            "fragrances",
            "perfumes"
        ],
        Brand= "Chanel",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/fragrances/Chanel%20Coco%20Noir%20Eau%20De/1.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Chanel%20Coco%20Noir%20Eau%20De/2.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Chanel%20Coco%20Noir%20Eau%20De/3.png"
        ],
        Thumbnail= "fragrances_Chanel_Coco_Noir_Eau_De"
    },
    new Product
    {
        Name = "Dior J'adore",
        Description= "J'adore by Dior is a luxurious and floral fragrance, known for its blend of ylang-ylang, rose, and jasmine. It embodies femininity and sophistication.",
        Category= "fragrances",
        Price= 8999,
        DiscountPercentage= 17.44,
        Rating= 3.31,
        QuantityInStock= 91,
        Tags= [
            "fragrances",
            "perfumes"
        ],
        Brand= "Dior",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/fragrances/Dior%20J'adore/1.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Dior%20J'adore/2.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Dior%20J'adore/3.png"
        ],
        Thumbnail= "fragrances_Dior_Jadore"
    },
    new Product
    {
        Name = "Dolce Shine Eau de",
        Description= "Dolce Shine by Dolce & Gabbana is a vibrant and fruity fragrance, featuring notes of mango, jasmine, and blonde woods. It's a joyful and youthful scent.",
        Category= "fragrances",
        Price= 6998,
        DiscountPercentage= 11.47,
        Rating= 2.68,
        QuantityInStock= 3,
        Tags= [
            "fragrances",
            "perfumes"
        ],
        Brand= "Dolce & Gabbana",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/fragrances/Dolce%20Shine%20Eau%20de/1.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Dolce%20Shine%20Eau%20de/2.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Dolce%20Shine%20Eau%20de/3.png"
        ],
        Thumbnail= "fragrances_Dolce_Shine_Eau_de"
    },
    new Product
    {
        Name = "Gucci Bloom Eau de",
        Description= "Gucci Bloom by Gucci is a floral and captivating fragrance, with notes of tuberose, jasmine, and Rangoon creeper. It's a modern and romantic scent.",
        Category= "fragrances",
        Price= 7998,
        DiscountPercentage= 8.9,
        Rating= 2.69,
        QuantityInStock= 93,
        Tags= [
            "fragrances",
            "perfumes"
        ],
        Brand= "Gucci",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/fragrances/Gucci%20Bloom%20Eau%20de/1.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Gucci%20Bloom%20Eau%20de/2.png",
            "https://cdn.dummyjson.com/products/images/fragrances/Gucci%20Bloom%20Eau%20de/3.png"
        ],
        Thumbnail= "fragrances_Gucci_Bloom_Eau_de"
    },
    new Product
    {
        Name = "Annibale Colombo Bed",
        Description= "The Annibale Colombo Bed is a luxurious and elegant bed frame, crafted with high-quality materials for a comfortable and stylish bedroom.",
        Category= "furniture",
        Price= 189999,
        DiscountPercentage= 0.29,
        Rating= 4.14,
        QuantityInStock= 47,
        Tags= [
            "furniture",
            "beds"
        ],
        Brand= "Annibale Colombo",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/furniture/Annibale%20Colombo%20Bed/1.png",
            "https://cdn.dummyjson.com/products/images/furniture/Annibale%20Colombo%20Bed/2.png",
            "https://cdn.dummyjson.com/products/images/furniture/Annibale%20Colombo%20Bed/3.png"
        ],
        Thumbnail= "furniture_Annibale_Colombo_Bed"
    },
    new Product
    {
        Name = "Annibale Colombo Sofa",
        Description= "The Annibale Colombo Sofa is a sophisticated and comfortable seating option, featuring exquisite design and premium upholstery for your living room.",
        Category= "furniture",
        Price= 249998,
        DiscountPercentage= 18.54,
        Rating= 3.08,
        QuantityInStock= 16,
        Tags= [
            "furniture",
            "sofas"
        ],
        Brand= "Annibale Colombo",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/furniture/Annibale%20Colombo%20Sofa/1.png",
            "https://cdn.dummyjson.com/products/images/furniture/Annibale%20Colombo%20Sofa/2.png",
            "https://cdn.dummyjson.com/products/images/furniture/Annibale%20Colombo%20Sofa/3.png"
        ],
        Thumbnail= "furniture_Annibale_Colombo_Sofa"
    },
    new Product
    {
        Name = "Bedside Table African Cherry",
        Description= "The Bedside Table in African Cherry is a stylish and functional addition to your bedroom, providing convenient storage space and a touch of elegance.",
        Category= "furniture",
        Price= 29999,
        DiscountPercentage= 9.58,
        Rating= 4.48,
        QuantityInStock= 16,
        Tags= [
            "furniture",
            "bedside tables"
        ],
        Brand= "Furniture Co.",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/furniture/Bedside%20Table%20African%20Cherry/1.png",
            "https://cdn.dummyjson.com/products/images/furniture/Bedside%20Table%20African%20Cherry/2.png",
            "https://cdn.dummyjson.com/products/images/furniture/Bedside%20Table%20African%20Cherry/3.png"
        ],
        Thumbnail= "furniture_Bedside_Table_African_Cherry"
    },
    new Product
    {
        Name = "Knoll Saarinen Executive Conference Chair",
        Description= "The Knoll Saarinen Executive Conference Chair is a modern and ergonomic chair, perfect for your office or conference room with its timeless design.",
        Category= "furniture",
        Price= 49999,
        DiscountPercentage= 15.23,
        Rating= 4.11,
        QuantityInStock= 47,
        Tags= [
            "furniture",
            "office chairs"
        ],
        Brand= "Knoll",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/furniture/Knoll%20Saarinen%20Executive%20Conference%20Chair/1.png",
            "https://cdn.dummyjson.com/products/images/furniture/Knoll%20Saarinen%20Executive%20Conference%20Chair/2.png",
            "https://cdn.dummyjson.com/products/images/furniture/Knoll%20Saarinen%20Executive%20Conference%20Chair/3.png"
        ],
        Thumbnail= "furniture_Knoll_Saarinen_Executive_Conference_Chair"
    },
    new Product
    {
        Name = "Wooden Bathroom Sink With Mirror",
        Description= "The Wooden Bathroom Sink with Mirror is a unique and stylish addition to your bathroom, featuring a wooden sink countertop and a matching mirror.",
        Category= "furniture",
        Price= 79999,
        DiscountPercentage= 11.22,
        Rating= 3.26,
        QuantityInStock= 95,
        Tags= [
            "furniture",
            "bathroom"
        ],
        Brand= "Bath Trends",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/furniture/Wooden%20Bathroom%20Sink%20With%20Mirror/1.png",
            "https://cdn.dummyjson.com/products/images/furniture/Wooden%20Bathroom%20Sink%20With%20Mirror/2.png",
            "https://cdn.dummyjson.com/products/images/furniture/Wooden%20Bathroom%20Sink%20With%20Mirror/3.png"
        ],
        Thumbnail= "furniture_Wooden_Bathroom_Sink_With_Mirror"
    },
    new Product
    {
        Name = "Apple",
        Description= "Fresh and crisp apples, perfect for snacking or incorporating into various recipes.",
        Category= "groceries",
        Price= 199,
        DiscountPercentage= 1.97,
        Rating= 2.96,
        QuantityInStock= 9,
        Tags= [
            "fruits"
        ],
        Brand= "Richmond",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Apple/1.png"
        ],
        Thumbnail= "groceries_Apple"
    },
    new Product
    {
        Name = "Beef Steak",
        Description= "High-quality beef steak, great for grilling or cooking to your preferred level of doneness.",
        Category= "groceries",
        Price= 1299,
        DiscountPercentage= 17.99,
        Rating= 2.83,
        QuantityInStock= 96,
        Tags= [
            "meat"
        ],
        Brand="PoultryFarm",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Beef%20Steak/1.png"
        ],
        Thumbnail= "groceries_Beef_Steak"
    },
    new Product
    {
        Name = "Cat Food",
        Description= "Nutritious cat food formulated to meet the dietary needs of your feline friend.",
        Category= "groceries",
        Price= 899,
        DiscountPercentage= 9.57,
        Rating= 2.88,
        QuantityInStock= 13,
        Tags= [
            "pet supplies",
            "cat food"
        ],
        Brand="Richmond",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Cat%20Food/1.png"
        ],
        Thumbnail= "groceries_Cat_Food"
    },
    new Product
    {
        Name = "Chicken Meat",
        Description= "Fresh and tender chicken meat, suitable for various culinary preparations.",
        Category= "groceries",
        Price= 999,
        DiscountPercentage= 10.46,
        Rating= 4.61,
        QuantityInStock= 69,
        Tags= [
            "meat"
        ],
        Brand="PoultryFarm",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/1.png",
            "https://cdn.dummyjson.com/products/images/groceries/Chicken%20Meat/2.png"
        ],
        Thumbnail= "groceries_Chicken_Meat"
    },
    new Product
    {
        Name = "Cooking Oil",
        Description= "Versatile cooking oil suitable for frying, sautéing, and various culinary applications.",
        Category= "groceries",
        Price= 499,
        DiscountPercentage= 18.89,
        Rating= 4.01,
        QuantityInStock= 22,
        Tags= [
            "cooking essentials"
        ],
        Brand="Veggie",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Cooking%20Oil/1.png"
        ],
        Thumbnail= "groceries_Cooking_Oil"
    },
    new Product
    {
        Name = "Cucumber",
        Description= "Crisp and hydrating cucumbers, ideal for salads, snacks, or as a refreshing side.",
        Category= "groceries",
        Price= 149,
        DiscountPercentage= 11.44,
        Rating= 4.71,
        QuantityInStock= 22,
        Tags= [
            "vegetables"
        ],
        Brand="Veggie",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Cucumber/1.png"
        ],
        Thumbnail= "groceries_Cucumber"
    },
    new Product
    {
        Name = "Dog Food",
        Description= "Specially formulated dog food designed to provide essential nutrients for your canine companion.",
        Category= "groceries",
        Price= 1099,
        DiscountPercentage= 18.15,
        Rating= 2.74,
        QuantityInStock= 40,
        Tags= [
            "pet supplies",
            "dog food"
        ],
        Brand="Pedigree",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Dog%20Food/1.png"
        ],
        Thumbnail= "groceries_Dog_Food"
    },
    new Product
    {
        Name = "Eggs",
        Description= "Fresh eggs, a versatile ingredient for baking, cooking, or breakfast.",
        Category= "groceries",
        Price= 299,
        DiscountPercentage= 5.8,
        Rating= 4.46,
        QuantityInStock= 10,
        Tags= [
            "dairy"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Eggs/1.png"
        ],
        Thumbnail= "groceries_Eggs"
    },
    new Product
    {
        Name = "Fish Steak",
        Description= "Quality fish steak, suitable for grilling, baking, or pan-searing.",
        Category= "groceries",
        Price= 1499,
        DiscountPercentage= 7,
        Rating= 4.83,
        QuantityInStock= 99,
        Tags= [
            "seafood"
        ],
        Brand="PoultryFarm",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Fish%20Steak/1.png"
        ],
        Thumbnail= "groceries_Fish_Steak"
    },
    new Product
    {
        Name = "Green Bell Pepper",
        Description= "Fresh and vibrant green bell pepper, perfect for adding color and flavor to your dishes.",
        Category= "groceries",
        Price= 129,
        DiscountPercentage= 15.5,
        Rating= 4.28,
        QuantityInStock= 89,
        Tags= [
            "vegetables"
        ],
        Brand="Decor",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Green%20Bell%20Pepper/1.png"
        ],
        Thumbnail= "groceries_Green_Bell_Pepper"
    },
    new Product
    {
        Name = "Green Chili Pepper",
        Description= "Spicy green chili pepper, ideal for adding heat to your favorite recipes.",
        Category= "groceries",
        Price= 99,
        DiscountPercentage= 18.51,
        Rating= 4.43,
        QuantityInStock= 8,
        Tags= [
            "vegetables"
        ],
        Brand="Veggie",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Green%20Chili%20Pepper/1.png"
        ],
        Thumbnail= "groceries_Green_Chili_Pepper"
    },
    new Product
    {
        Name = "Honey Jar",
        Description= "Pure and natural honey in a convenient jar, perfect for sweetening beverages or drizzling over food.",
        Category= "groceries",
        Price= 699,
        DiscountPercentage= 1.91,
        Rating= 3.5,
        QuantityInStock= 25,
        Tags= [
            "condiments"
        ],
        Brand="Decor",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Honey%20Jar/1.png"
        ],
        Thumbnail= "groceries_Honey_Jar"
    },
    new Product
    {
        Name = "Ice Cream",
        Description= "Creamy and delicious ice cream, available in various flavors for a delightful treat.",
        Category= "groceries",
        Price= 549,
        DiscountPercentage= 7.58,
        Rating= 3.77,
        QuantityInStock= 76,
        Tags= [
            "desserts"
        ],
        Brand="Veggie",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Ice%20Cream/1.png",
            "https://cdn.dummyjson.com/products/images/groceries/Ice%20Cream/2.png",
            "https://cdn.dummyjson.com/products/images/groceries/Ice%20Cream/3.png",
            "https://cdn.dummyjson.com/products/images/groceries/Ice%20Cream/4.png"
        ],
        Thumbnail= "groceries_Ice_Cream"
    },
    new Product
    {
        Name = "Juice",
        Description= "Refreshing fruit juice, packed with vitamins and great for staying hydrated.",
        Category= "groceries",
        Price= 399,
        DiscountPercentage= 5.45,
        Rating= 3.41,
        QuantityInStock= 99,
        Tags= [
            "beverages"
        ],
        Brand="Decor",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Juice/1.png"
        ],
        Thumbnail= "groceries_Juice"
    },
    new Product
    {
        Name = "Kiwi",
        Description= "Nutrient-rich kiwi, perfect for snacking or adding a tropical twist to your dishes.",
        Category= "groceries",
        Price= 249,
        DiscountPercentage= 10.32,
        Rating= 4.37,
        QuantityInStock= 1,
        Tags= [
            "fruits"
        ],
        Brand="Veggie",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Kiwi/1.png"
        ],
        Thumbnail= "groceries_Kiwi"
    },
    new Product
    {
        Name = "Lemon",
        Description= "Zesty and tangy lemons, versatile for cooking, baking, or making refreshing beverages.",
        Category= "groceries",
        Price= 79,
        DiscountPercentage= 17.81,
        Rating= 4.25,
        QuantityInStock= 0,
        Tags= [
            "fruits"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "Out of Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Lemon/1.png"
        ],
        Thumbnail= "groceries_Lemon"
    },
    new Product
    {
        Name = "Milk",
        Description= "Fresh and nutritious milk, a staple for various recipes and daily consumption.",
        Category= "groceries",
        Price= 349,
        DiscountPercentage= 15.09,
        Rating= 3.14,
        QuantityInStock= 57,
        Tags= [
            "dairy"
        ],
        Brand="Veggie",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Milk/1.png"
        ],
        Thumbnail= "groceries_Milk"
    },
    new Product
    {
        Name = "Mulberry",
        Description= "Sweet and juicy mulberries, perfect for snacking or adding to desserts and cereals.",
        Category= "groceries",
        Price= 499,
        DiscountPercentage= 16.35,
        Rating= 3.19,
        QuantityInStock= 79,
        Tags= [
            "fruits"
        ],
        Brand="Decor",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Mulberry/1.png"
        ],
        Thumbnail= "groceries_Mulberry"
    },
    new Product
    {
        Name = "Nescafe Coffee",
        Description= "Quality coffee from Nescafe, available in various blends for a rich and satisfying cup.",
        Category= "groceries",
        Price= 799,
        DiscountPercentage= 11.65,
        Rating= 2.54,
        QuantityInStock= 22,
        Tags= [
            "beverages",
            "coffee"
        ],
        Brand="Starbucks",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Nescafe%20Coffee/1.png"
        ],
        Thumbnail= "groceries_Nescafe_Coffee"
    },
    new Product
    {
        Name = "Potatoes",
        Description= "Versatile and starchy potatoes, great for roasting, mashing, or as a side dish.",
        Category= "groceries",
        Price= 229,
        DiscountPercentage= 4.05,
        Rating= 3.82,
        QuantityInStock= 8,
        Tags= [
            "vegetables"
        ],
        Brand="Veggie",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Potatoes/1.png"
        ],
        Thumbnail= "groceries_Potatoes"
    },
    new Product
    {
        Name = "Protein Powder",
        Description= "Nutrient-packed protein powder, ideal for supplementing your diet with essential proteins.",
        Category= "groceries",
        Price= 1998,
        DiscountPercentage= 1.58,
        Rating= 3.91,
        QuantityInStock= 65,
        Tags= [
            "health supplements"
        ],
        Brand="Decor",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Protein%20Powder/1.png"
        ],
        Thumbnail= "groceries_Protein_Powder"
    },
    new Product
    {
        Name = "Red Onions",
        Description= "Flavorful and aromatic red onions, perfect for adding depth to your savory dishes.",
        Category= "groceries",
        Price= 199,
        DiscountPercentage= 17.89,
        Rating= 4.08,
        QuantityInStock= 86,
        Tags= [
            "vegetables"
        ],
        Brand="Veggie",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Red%20Onions/1.png"
        ],
        Thumbnail= "groceries_Red_Onions"
    },
    new Product
    {
        Name = "Rice",
        Description= "High-quality rice, a staple for various cuisines and a versatile base for many dishes.",
        Category= "groceries",
        Price= 599,
        DiscountPercentage= 12.02,
        Rating= 3.94,
        QuantityInStock= 49,
        Tags= [
            "grains"
        ],
        Brand="Decor",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Rice/1.png"
        ],
        Thumbnail= "groceries_Rice"
    },
    new Product
    {
        Name = "Soft Drinks",
        Description= "Assorted soft drinks in various flavors, perfect for refreshing beverages.",
        Category= "groceries",
        Price= 199,
        DiscountPercentage= 1.88,
        Rating= 4.59,
        QuantityInStock= 78,
        Tags= [
            "beverages"
        ],
        Brand="Coke",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Soft%20Drinks/1.png"
        ],
        Thumbnail= "groceries_Soft_Drinks"
    },
    new Product
    {
        Name = "Strawberry",
        Description= "Sweet and succulent strawberries, great for snacking, desserts, or blending into smoothies.",
        Category= "groceries",
        Price= 399,
        DiscountPercentage= 19.59,
        Rating= 4.5,
        QuantityInStock= 9,
        Tags= [
            "fruits"
        ],
        Brand="Veggie",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Strawberry/1.png"
        ],
        Thumbnail= "groceries_Strawberry"
    },
    new Product
    {
        Name = "Tissue Paper Box",
        Description= "Convenient tissue paper box for everyday use, providing soft and absorbent tissues.",
        Category= "groceries",
        Price= 249,
        DiscountPercentage= 15.44,
        Rating= 4.55,
        QuantityInStock= 97,
        Tags= [
            "household essentials"
        ],
        Brand="Quilton",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Tissue%20Paper%20Box/1.png",
            "https://cdn.dummyjson.com/products/images/groceries/Tissue%20Paper%20Box/2.png"
        ],
        Thumbnail= "groceries_Tissue_Paper_Box"
    },
    new Product
    {
        Name = "Water",
        Description= "Pure and refreshing bottled water, essential for staying hydrated throughout the day.",
        Category= "groceries",
        Price= 99,
        DiscountPercentage= 13.71,
        Rating= 2.93,
        QuantityInStock= 95,
        Tags= [
            "beverages"
        ],
        Brand="Coke",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/groceries/Water/1.png"
        ],
        Thumbnail= "groceries_Water"
    },
    new Product
    {
        Name = "Decoration Swing",
        Description= "The Decoration Swing is a charming addition to your home decor. Crafted with intricate details, it adds a touch of elegance and whimsy to any room.",
        Category= "home-decoration",
        Price= 5999,
        DiscountPercentage= 0.65,
        Rating= 3.56,
        QuantityInStock= 62,
        Tags= [
            "home decor",
            "swing"
        ],
        Brand="Chimpan",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/home-decoration/Decoration%20Swing/1.png",
            "https://cdn.dummyjson.com/products/images/home-decoration/Decoration%20Swing/2.png",
            "https://cdn.dummyjson.com/products/images/home-decoration/Decoration%20Swing/3.png"
        ],
        Thumbnail= "home_decoration_Decoration_Swing"
    },
    new Product
    {
        Name = "Family Tree Photo Frame",
        Description= "The Family Tree Photo Frame is a sentimental and stylish way to display your cherished family memories. With multiple photo slots, it tells the story of your loved ones.",
        Category= "home-decoration",
        Price= 2999,
        DiscountPercentage= 1.53,
        Rating= 3.84,
        QuantityInStock= 34,
        Tags= [
            "home decor",
            "photo frame"
        ],
        Brand="Decor",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/home-decoration/Family%20Tree%20Photo%20Frame/1.png"
        ],
        Thumbnail= "home_decoration_Family_Tree_Photo_Frame"
    },
    new Product
    {
        Name = "House Showpiece Plant",
        Description= "The House Showpiece Plant is an artificial plant that brings a touch of nature to your home without the need for maintenance. It adds greenery and style to any space.",
        Category= "home-decoration",
        Price= 3999,
        DiscountPercentage= 19.45,
        Rating= 3.61,
        QuantityInStock= 89,
        Tags= [
            "home decor",
            "artificial plants"
        ],
        Brand="Decor",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/home-decoration/House%20Showpiece%20Plant/1.png",
            "https://cdn.dummyjson.com/products/images/home-decoration/House%20Showpiece%20Plant/2.png",
            "https://cdn.dummyjson.com/products/images/home-decoration/House%20Showpiece%20Plant/3.png"
        ],
        Thumbnail= "home_decoration_House_Showpiece_Plant"
    },
    new Product
    {
        Name = "Plant Pot",
        Description= "The Plant Pot is a stylish container for your favorite plants. With a sleek design, it complements your indoor or outdoor garden, adding a modern touch to your plant display.",
        Category= "home-decoration",
        Price= 1499,
        DiscountPercentage= 0.19,
        Rating= 3.33,
        QuantityInStock= 70,
        Tags= [
            "home decor",
            "plant accessories"
        ],
        Brand="Decor",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/home-decoration/Plant%20Pot/1.png",
            "https://cdn.dummyjson.com/products/images/home-decoration/Plant%20Pot/2.png",
            "https://cdn.dummyjson.com/products/images/home-decoration/Plant%20Pot/3.png",
            "https://cdn.dummyjson.com/products/images/home-decoration/Plant%20Pot/4.png"
        ],
        Thumbnail= "home_decoration_Plant_Pot"
    },
    new Product
    {
        Name = "Table Lamp",
        Description= "The Table Lamp is a functional and decorative lighting solution for your living space. With a modern design, it provides both ambient and task lighting, enhancing the atmosphere.",
        Category= "home-decoration",
        Price= 4999,
        DiscountPercentage= 0.59,
        Rating= 4.56,
        QuantityInStock= 84,
        Tags= [
            "home decor",
            "lighting"
        ],
        Brand="Decor",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/home-decoration/Table%20Lamp/1.png"
        ],
        Thumbnail= "home_decoration_Table_Lamp"
    },
    new Product
    {
        Name = "Bamboo Spatula",
        Description= "The Bamboo Spatula is a versatile kitchen tool made from eco-friendly bamboo. Ideal for flipping, stirring, and serving various dishes.",
        Category= "kitchen-accessories",
        Price= 799,
        DiscountPercentage= 4.85,
        Rating= 4.4,
        QuantityInStock= 0,
        Tags= [
            "kitchen tools",
            "utensils"
        ],
        Brand="Decor",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "Out of Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Bamboo%20Spatula/1.png"
        ],
        Thumbnail= "kitchen_accessories_Bamboo_Spatula"
    },
    new Product
    {
        Name = "Black Aluminium Cup",
        Description= "The Black Aluminium Cup is a stylish and durable cup suitable for both hot and cold beverages. Its sleek black design adds a modern touch to your drinkware collection.",
        Category= "kitchen-accessories",
        Price= 599,
        DiscountPercentage= 9.22,
        Rating= 3.62,
        QuantityInStock= 42,
        Tags= [
            "drinkware",
            "cups"
        ],
        Brand="Decor",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Black%20Aluminium%20Cup/1.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Black%20Aluminium%20Cup/2.png"
        ],
        Thumbnail= "kitchen_accessories_Black_Aluminium_Cup"
    },
    new Product
    {
        Name = "Black Whisk",
        Description= "The Black Whisk is a kitchen essential for whisking and beating ingredients. Its ergonomic handle and sleek design make it a practical and stylish tool.",
        Category= "kitchen-accessories",
        Price= 999,
        DiscountPercentage= 16.87,
        Rating= 2.88,
        QuantityInStock= 17,
        Tags= [
            "kitchen tools",
            "utensils"
        ],
        Brand="Decor",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Black%20Whisk/1.png"
        ],
        Thumbnail= "kitchen_accessories_Black_Whisk"
    },
    new Product
    {
        Name = "Boxed Blender",
        Description= "The Boxed Blender is a powerful and compact blender perfect for smoothies, shakes, and more. Its convenient design and multiple functions make it a versatile kitchen appliance.",
        Category= "kitchen-accessories",
        Price= 3999,
        DiscountPercentage= 7.36,
        Rating= 2.73,
        QuantityInStock= 81,
        Tags= [
            "kitchen appliances",
            "blenders"
        ],
        Brand="Decor",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Boxed%20Blender/1.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Boxed%20Blender/2.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Boxed%20Blender/3.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Boxed%20Blender/4.png"
        ],
        Thumbnail= "kitchen_accessories_Boxed_Blender"
    },
    new Product
    {
        Name = "Carbon Steel Wok",
        Description= "The Carbon Steel Wok is a versatile cooking pan suitable for stir-frying, sautéing, and deep frying. Its sturdy construction ensures even heat distribution for delicious meals.",
        Category= "kitchen-accessories",
        Price= 2999,
        DiscountPercentage= 5.89,
        Rating= 2.94,
        QuantityInStock= 2,
        Tags= [
            "cookware",
            "woks"
        ],
        Brand="Decor",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Carbon%20Steel%20Wok/1.png"
        ],
        Thumbnail= "kitchen_accessories_Carbon_Steel_Wok"
    },
    new Product
    {
        Name = "Chopping Board",
        Description= "The Chopping Board is an essential kitchen accessory for food preparation. Made from durable material, it provides a safe and hygienic surface for cutting and chopping.",
        Category= "kitchen-accessories",
        Price= 1299,
        DiscountPercentage= 17.72,
        Rating= 4.82,
        QuantityInStock= 53,
        Tags= [
            "kitchen tools",
            "cutting boards"
        ],
        Brand="Decor",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Chopping%20Board/1.png"
        ],
        Thumbnail= "kitchen_accessories_Chopping_Board"
    },
    new Product
    {
        Name = "Citrus Squeezer Yellow",
        Description= "The Citrus Squeezer in Yellow is a handy tool for extracting juice from citrus fruits. Its vibrant color adds a cheerful touch to your kitchen gadgets.",
        Category= "kitchen-accessories",
        Price= 899,
        DiscountPercentage= 12.35,
        Rating= 4.18,
        QuantityInStock= 59,
        Tags= [
            "kitchen tools",
            "juicers"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Citrus%20Squeezer%20Yellow/1.png"
        ],
        Thumbnail= "kitchen_accessories_Citrus_Squeezer_Yellow"
    },
    new Product
    {
        Name = "Egg Slicer",
        Description= "The Egg Slicer is a convenient tool for slicing boiled eggs evenly. It's perfect for salads, sandwiches, and other dishes where sliced eggs are desired.",
        Category= "kitchen-accessories",
        Price= 699,
        DiscountPercentage= 9.6,
        Rating= 2.91,
        QuantityInStock= 30,
        Tags= [
            "kitchen tools",
            "slicers"
        ],
        Brand="Decor",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Egg%20Slicer/1.png"
        ],
        Thumbnail= "kitchen_accessories_Egg_Slicer"
    },
    new Product
    {
        Name = "Electric Stove",
        Description= "The Electric Stove provides a portable and efficient cooking solution. Ideal for small kitchens or as an additional cooking surface for various culinary needs.",
        Category= "kitchen-accessories",
        Price= 4999,
        DiscountPercentage= 16.64,
        Rating= 4.84,
        QuantityInStock= 41,
        Tags= [
            "kitchen appliances",
            "cooktops"
        ],
        Brand="Decor",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Electric%20Stove/1.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Electric%20Stove/2.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Electric%20Stove/3.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Electric%20Stove/4.png"
        ],
        Thumbnail= "kitchen_accessories_Electric_Stove"
    },
    new Product
    {
        Name = "Fine Mesh Strainer",
        Description= "The Fine Mesh Strainer is a versatile tool for straining liquids and sifting dry ingredients. Its fine mesh ensures efficient filtering for smooth cooking and baking.",
        Category= "kitchen-accessories",
        Price= 999,
        DiscountPercentage= 2.56,
        Rating= 3.7,
        QuantityInStock= 13,
        Tags= [
            "kitchen tools",
            "strainers"
        ],
        Brand="Decor",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Fine%20Mesh%20Strainer/1.png"
        ],
        Thumbnail= "kitchen_accessories_Fine_Mesh_Strainer"
    },
    new Product
    {
        Name = "Fork",
        Description= "The Fork is a classic utensil for various dining and serving purposes. Its durable and ergonomic design makes it a reliable choice for everyday use.",
        Category= "kitchen-accessories",
        Price= 399,
        DiscountPercentage= 14.36,
        Rating= 4.18,
        QuantityInStock= 10,
        Tags= [
            "kitchen tools",
            "utensils"
        ],
        Brand="Decor",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Fork/1.png"
        ],
        Thumbnail= "kitchen_accessories_Fork"
    },
    new Product
    {
        Name = "Glass",
        Description= "The Glass is a versatile and elegant drinking vessel suitable for a variety of beverages. Its clear design allows you to enjoy the colors and textures of your drinks.",
        Category= "kitchen-accessories",
        Price= 499,
        DiscountPercentage= 7.38,
        Rating= 3.06,
        QuantityInStock= 68,
        Tags= [
            "drinkware",
            "glasses"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Glass/1.png"
        ],
        Thumbnail="kitchen_accessories_Glass"
    },
    new Product
    {
        Name = "Grater Black",
        Description= "The Grater in Black is a handy kitchen tool for grating cheese, vegetables, and more. Its sleek design and sharp blades make food preparation efficient and easy.",
        Category= "kitchen-accessories",
        Price= 1099,
        DiscountPercentage= 3.29,
        Rating= 2.87,
        QuantityInStock= 80,
        Tags= [
            "kitchen tools",
            "graters"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Grater%20Black/1.png"
        ],
        Thumbnail="kitchen_accessories_Grater_Black"
    },
    new Product
    {
        Name = "Hand Blender",
        Description= "The Hand Blender is a versatile kitchen appliance for blending, pureeing, and mixing. Its compact design and powerful motor make it a convenient tool for various recipes.",
        Category= "kitchen-accessories",
        Price= 3499,
        DiscountPercentage= 6.44,
        Rating= 3.71,
        QuantityInStock= 8,
        Tags= [
            "kitchen appliances",
            "blenders"
        ],
        Brand="Decor",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Hand%20Blender/1.png"
        ],
        Thumbnail="kitchen_accessories_Hand_Blender"
    },
    new Product
    {
        Name = "Ice Cube Tray",
        Description= "The Ice Cube Tray is a practical accessory for making ice cubes in various shapes. Perfect for keeping your drinks cool and adding a fun element to your beverages.",
        Category= "kitchen-accessories",
        Price= 599,
        DiscountPercentage= 0.95,
        Rating= 3.27,
        QuantityInStock= 81,
        Tags= [
            "kitchen tools",
            "ice cube trays"
        ],
        Brand="Decor",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Ice%20Cube%20Tray/1.png"
        ],
        Thumbnail="kitchen_accessories_Ice_Cube_Tray"
    },
    new Product
    {
        Name = "Kitchen Sieve",
        Description= "The Kitchen Sieve is a versatile tool for sifting and straining dry and wet ingredients. Its fine mesh design ensures smooth results in your cooking and baking.",
        Category= "kitchen-accessories",
        Price= 799,
        DiscountPercentage= 9.23,
        Rating= 2.96,
        QuantityInStock= 33,
        Tags= [
            "kitchen tools",
            "strainers"
        ],
        Brand="Decor",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Kitchen%20Sieve/1.png"
        ],
        Thumbnail="kitchen_accessories_Kitchen_Sieve"
    },
    new Product
    {
        Name = "Knife",
        Description= "The Knife is an essential kitchen tool for chopping, slicing, and dicing. Its sharp blade and ergonomic handle make it a reliable choice for food preparation.",
        Category= "kitchen-accessories",
        Price= 1499,
        DiscountPercentage= 19.95,
        Rating= 4.31,
        QuantityInStock= 59,
        Tags= [
            "kitchen tools",
            "cutlery"
        ],
        Brand="Decor",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Knife/1.png"
        ],
        Thumbnail="kitchen_accessories_Knife"
    },
    new Product
    {
        Name = "Lunch Box",
        Description= "The Lunch Box is a convenient and portable container for packing and carrying your meals. With compartments for different foods, it's perfect for on-the-go dining.",
        Category= "kitchen-accessories",
        Price= 1299,
        DiscountPercentage= 15.33,
        Rating= 2.84,
        QuantityInStock= 26,
        Tags= [
            "kitchen tools",
            "storage"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Lunch%20Box/1.png"
        ],
        Thumbnail="kitchen_accessories_Lunch_Box"
    },
    new Product
    {
        Name = "Microwave Oven",
        Description= "The Microwave Oven is a versatile kitchen appliance for quick and efficient cooking, reheating, and defrosting. Its compact size makes it suitable for various kitchen setups.",
        Category= "kitchen-accessories",
        Price= 8999,
        DiscountPercentage= 18.73,
        Rating= 2.71,
        QuantityInStock= 27,
        Tags= [
            "kitchen appliances",
            "microwaves"
        ],
        Brand="Decor",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Microwave%20Oven/1.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Microwave%20Oven/2.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Microwave%20Oven/3.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Microwave%20Oven/4.png"
        ],
        Thumbnail="kitchen_accessories_Microwave_Oven"
    },
    new Product
    {
        Name = "Mug Tree Stand",
        Description= "The Mug Tree Stand is a stylish and space-saving solution for organizing your mugs. Keep your favorite mugs easily accessible and neatly displayed in your kitchen.",
        Category= "kitchen-accessories",
        Price= 1599,
        DiscountPercentage= 15.21,
        Rating= 4.34,
        QuantityInStock= 93,
        Tags= [
            "kitchen tools",
            "organization"
        ],
        Brand="Decor",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Mug%20Tree%20Stand/1.png",
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Mug%20Tree%20Stand/2.png"
        ],
        Thumbnail="kitchen_accessories_Mug_Tree_Stand"
    },
    new Product
    {
        Name = "Pan",
        Description= "The Pan is a versatile and essential cookware item for frying, sautéing, and cooking various dishes. Its non-stick coating ensures easy food release and cleanup.",
        Category= "kitchen-accessories",
        Price= 2499,
        DiscountPercentage= 6.55,
        Rating= 3.4,
        QuantityInStock= 40,
        Tags= [
            "cookware",
            "pans"
        ],
        Brand="Decor",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Pan/1.png"
        ],
        Thumbnail="kitchen_accessories_Pan"
    },
    new Product
    {
        Name = "Plate",
        Description= "The Plate is a classic and essential dishware item for serving meals. Its durable and stylish design makes it suitable for everyday use or special occasions.",
        Category= "kitchen-accessories",
        Price= 399,
        DiscountPercentage= 13.03,
        Rating= 3.07,
        QuantityInStock= 30,
        Tags= [
            "dinnerware",
            "plates"
        ],
        Brand="Decor",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Plate/1.png"
        ],
        Thumbnail="kitchen_accessories_Plate"
    },
    new Product
    {
        Name = "Red Tongs",
        Description= "The Red Tongs are versatile kitchen tongs suitable for various cooking and serving tasks. Their vibrant color adds a pop of excitement to your kitchen utensils.",
        Category= "kitchen-accessories",
        Price= 699,
        DiscountPercentage= 18.24,
        Rating= 3.22,
        QuantityInStock= 15,
        Tags= [
            "kitchen tools",
            "tongs"
        ],
        Brand="Decor",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Red%20Tongs/1.png"
        ],
        Thumbnail="kitchen_accessories_Red_Tongs"
    },
    new Product
    {
        Name = "Silver Pot With Glass Cap",
        Description= "The Silver Pot with Glass Cap is a stylish and functional cookware item for boiling, simmering, and preparing delicious meals. Its glass cap allows you to monitor cooking progress.",
        Category= "kitchen-accessories",
        Price= 3999,
        DiscountPercentage= 4.57,
        Rating= 3.86,
        QuantityInStock= 37,
        Tags= [
            "cookware",
            "pots"
        ],
        Brand="Decor",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Silver%20Pot%20With%20Glass%20Cap/1.png"
        ],
        Thumbnail="kitchen_accessories_Silver_Pot_With_Glass_Cap"
    },
    new Product
    {
        Name = "Slotted Turner",
        Description= "The Slotted Turner is a kitchen utensil designed for flipping and turning food items. Its slotted design allows excess liquid to drain, making it ideal for frying and sautéing.",
        Category= "kitchen-accessories",
        Price= 899,
        DiscountPercentage= 7.24,
        Rating= 3.77,
        QuantityInStock= 36,
        Tags= [
            "kitchen tools",
            "turners"
        ],
        Brand="Decor",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Slotted%20Turner/1.png"
        ],
        Thumbnail="kitchen_accessories_Slotted_Turner"
    },
    new Product
    {
        Name = "Spice Rack",
        Description= "The Spice Rack is a convenient organizer for your spices and seasonings. Keep your kitchen essentials within reach and neatly arranged with this stylish spice rack.",
        Category= "kitchen-accessories",
        Price= 1998,
        DiscountPercentage= 13.78,
        Rating= 4.05,
        QuantityInStock= 24,
        Tags= [
            "kitchen tools",
            "organization"
        ],
        Brand="Decor",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Spice%20Rack/1.png"
        ],
        Thumbnail="kitchen_accessories_Spice_Rack"
    },
    new Product
    {
        Name = "Spoon",
        Description= "The Spoon is a versatile kitchen utensil for stirring, serving, and tasting. Its ergonomic design and durable construction make it an essential tool for every kitchen.",
        Category= "kitchen-accessories",
        Price= 499,
        DiscountPercentage= 0.93,
        Rating= 3.98,
        QuantityInStock= 51,
        Tags= [
            "kitchen tools",
            "utensils"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Spoon/1.png"
        ],
        Thumbnail="kitchen_accessories_Spoon"
    },
    new Product
    {
        Name = "Tray",
        Description= "The Tray is a functional and decorative item for serving snacks, appetizers, or drinks. Its stylish design makes it a versatile accessory for entertaining guests.",
        Category= "kitchen-accessories",
        Price= 1698,
        DiscountPercentage= 9.93,
        Rating= 3.2,
        QuantityInStock= 48,
        Tags= [
            "serveware",
            "trays"
        ],
        Brand="Decor",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Tray/1.png"
        ],
        Thumbnail="kitchen_accessories_Tray"
    },
    new Product
    {
        Name = "Wooden Rolling Pin",
        Description= "The Wooden Rolling Pin is a classic kitchen tool for rolling out dough for baking. Its smooth surface and sturdy handles make it easy to achieve uniform thickness.",
        Category= "kitchen-accessories",
        Price= 1199,
        DiscountPercentage= 16.94,
        Rating= 4.99,
        QuantityInStock= 80,
        Tags= [
            "kitchen tools",
            "baking"
        ],
        Brand="Decor",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Wooden%20Rolling%20Pin/1.png"
        ],
        Thumbnail="kitchen_accessories_Wooden_Rolling_Pin"
    },
    new Product
    {
        Name = "Yellow Peeler",
        Description= "The Yellow Peeler is a handy tool for peeling fruits and vegetables with ease. Its bright yellow color adds a cheerful touch to your kitchen gadgets.",
        Category= "kitchen-accessories",
        Price= 599,
        DiscountPercentage= 17.09,
        Rating= 4.41,
        QuantityInStock= 86,
        Tags= [
            "kitchen tools",
            "peelers"
        ],
        Brand="Decor",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/kitchen-accessories/Yellow%20Peeler/1.png"
        ],
        Thumbnail="kitchen_accessories_Yellow_Peeler"
    },
    new Product
    {
        Name = "Apple MacBook Pro 14 Inch Space Grey",
        Description= "The MacBook Pro 14 Inch in Space Grey is a powerful and sleek laptop, featuring Apple's M1 Pro chip for exceptional performance and a stunning Retina display.",
        Category= "laptops",
        Price= 199999,
        DiscountPercentage= 9.25,
        Rating= 3.13,
        QuantityInStock= 39,
        Tags= [
            "laptops",
            "apple"
        ],
        Brand= "Apple",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/laptops/Apple%20MacBook%20Pro%2014%20Inch%20Space%20Grey/1.png",
            "https://cdn.dummyjson.com/products/images/laptops/Apple%20MacBook%20Pro%2014%20Inch%20Space%20Grey/2.png",
            "https://cdn.dummyjson.com/products/images/laptops/Apple%20MacBook%20Pro%2014%20Inch%20Space%20Grey/3.png"
        ],
        Thumbnail="laptops_Apple_MacBook_Pro_14_Inch_Space_Grey"
    },
    new Product
    {
        Name = "Asus Zenbook Pro Dual Screen Laptop",
        Description= "The Asus Zenbook Pro Dual Screen Laptop is a high-performance device with dual screens, providing productivity and versatility for creative professionals.",
        Category= "laptops",
        Price= 179999,
        DiscountPercentage= 9.21,
        Rating= 3.14,
        QuantityInStock= 38,
        Tags= [
            "laptops"
        ],
        Brand= "Asus",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/laptops/Asus%20Zenbook%20Pro%20Dual%20Screen%20Laptop/1.png",
            "https://cdn.dummyjson.com/products/images/laptops/Asus%20Zenbook%20Pro%20Dual%20Screen%20Laptop/2.png",
            "https://cdn.dummyjson.com/products/images/laptops/Asus%20Zenbook%20Pro%20Dual%20Screen%20Laptop/3.png"
        ],
        Thumbnail="laptops_Asus_Zenbook_Pro_Dual_Screen_Laptop"
    },
    new Product
    {
        Name = "Huawei Matebook X Pro",
        Description= "The Huawei Matebook X Pro is a slim and stylish laptop with a high-resolution touchscreen display, offering a premium experience for users on the go.",
        Category= "laptops",
        Price= 139999,
        DiscountPercentage= 15.25,
        Rating= 4.62,
        QuantityInStock= 34,
        Tags= [
            "laptops"
        ],
        Brand= "Huawei",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/laptops/Huawei%20Matebook%20X%20Pro/1.png",
            "https://cdn.dummyjson.com/products/images/laptops/Huawei%20Matebook%20X%20Pro/2.png",
            "https://cdn.dummyjson.com/products/images/laptops/Huawei%20Matebook%20X%20Pro/3.png"
        ],
        Thumbnail="laptops_Huawei_Matebook_X_Pro"
    },
    new Product
    {
        Name = "Lenovo Yoga 920",
        Description= "The Lenovo Yoga 920 is a 2-in-1 convertible laptop with a flexible hinge, allowing you to use it as a laptop or tablet, offering versatility and portability.",
        Category= "laptops",
        Price= 109999,
        DiscountPercentage= 7.77,
        Rating= 2.98,
        QuantityInStock= 71,
        Tags= [
            "laptops"
        ],
        Brand= "Lenovo",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/laptops/Lenovo%20Yoga%20920/1.png",
            "https://cdn.dummyjson.com/products/images/laptops/Lenovo%20Yoga%20920/2.png",
            "https://cdn.dummyjson.com/products/images/laptops/Lenovo%20Yoga%20920/3.png"
        ],
        Thumbnail="laptops_Lenovo_Yoga_920"
    },
    new Product
    {
        Name = "New DELL XPS 13 9300 Laptop",
        Description= "The New DELL XPS 13 9300 Laptop is a compact and powerful device, featuring a virtually borderless InfinityEdge display and high-end performance for various tasks.",
        Category= "laptops",
        Price= 149999,
        DiscountPercentage= 11.7,
        Rating= 2.98,
        QuantityInStock= 18,
        Tags= [
            "laptops"
        ],
        Brand= "Dell",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/laptops/New%20DELL%20XPS%2013%209300%20Laptop/1.png",
            "https://cdn.dummyjson.com/products/images/laptops/New%20DELL%20XPS%2013%209300%20Laptop/2.png",
            "https://cdn.dummyjson.com/products/images/laptops/New%20DELL%20XPS%2013%209300%20Laptop/3.png"
        ],
        Thumbnail="laptops_New_DELL_XPS_13_9300_Laptop"
    },
    new Product
    {
        Name = "Blue & Black Check Shirt",
        Description= "The Blue & Black Check Shirt is a stylish and comfortable men's shirt featuring a classic check pattern. Made from high-quality fabric, it's suitable for both casual and semi-formal occasions.",
        Category= "mens-shirts",
        Price= 2999,
        DiscountPercentage= 1.41,
        Rating= 4.19,
        QuantityInStock= 44,
        Tags= [
            "clothing",
            "men's shirts"
        ],
        Brand= "Fashion Trends",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shirts/Blue%20&%20Black%20Check%20Shirt/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Blue%20&%20Black%20Check%20Shirt/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Blue%20&%20Black%20Check%20Shirt/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Blue%20&%20Black%20Check%20Shirt/4.png"
        ],
        Thumbnail="mens_shirts_Blue_&_Black_Check_Shirt"
    },
    new Product
    {
        Name = "Gigabyte Aorus Men Tshirt",
        Description= "The Gigabyte Aorus Men Tshirt is a cool and casual shirt for gaming enthusiasts. With the Aorus logo and sleek design, it's perfect for expressing your gaming style.",
        Category= "mens-shirts",
        Price= 2499,
        DiscountPercentage= 12.6,
        Rating= 4.95,
        QuantityInStock= 64,
        Tags= [
            "clothing",
            "men's t-shirts"
        ],
        Brand= "Gigabyte",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shirts/Gigabyte%20Aorus%20Men%20Tshirt/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Gigabyte%20Aorus%20Men%20Tshirt/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Gigabyte%20Aorus%20Men%20Tshirt/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Gigabyte%20Aorus%20Men%20Tshirt/4.png"
        ],
        Thumbnail="mens_shirts_Gigabyte_Aorus_Men_Tshirt"
    },
    new Product
    {
        Name = "Man Plaid Shirt",
        Description= "The Man Plaid Shirt is a timeless and versatile men's shirt with a classic plaid pattern. Its comfortable fit and casual style make it a wardrobe essential for various occasions.",
        Category= "mens-shirts",
        Price= 3499,
        DiscountPercentage= 17.53,
        Rating= 3.66,
        QuantityInStock= 65,
        Tags= [
            "clothing",
            "men's shirts"
        ],
        Brand= "Classic Wear",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Plaid%20Shirt/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Plaid%20Shirt/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Plaid%20Shirt/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Plaid%20Shirt/4.png"
        ],
        Thumbnail="mens_shirts_Man_Plaid_Shirt"
    },
    new Product
    {
        Name = "Man Short Sleeve Shirt",
        Description= "The Man Short Sleeve Shirt is a breezy and stylish option for warm days. With a comfortable fit and short sleeves, it's perfect for a laid-back yet polished look.",
        Category= "mens-shirts",
        Price= 1998,
        DiscountPercentage= 8.65,
        Rating= 4.62,
        QuantityInStock= 20,
        Tags= [
            "clothing",
            "men's shirts"
        ],
        Brand= "Casual Comfort",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Short%20Sleeve%20Shirt/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Short%20Sleeve%20Shirt/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Short%20Sleeve%20Shirt/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Man%20Short%20Sleeve%20Shirt/4.png"
        ],
        Thumbnail="mens_shirts_Man_Short_Sleeve_Shirt"
    },
    new Product
    {
        Name = "Men Check Shirt",
        Description= "The Men Check Shirt is a classic and versatile shirt featuring a stylish check pattern. Suitable for various occasions, it adds a smart and polished touch to your wardrobe.",
        Category= "mens-shirts",
        Price= 2799,
        DiscountPercentage= 14.21,
        Rating= 2.9,
        QuantityInStock= 69,
        Tags= [
            "clothing",
            "men's shirts"
        ],
        Brand= "Urban Chic",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shirts/Men%20Check%20Shirt/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Men%20Check%20Shirt/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Men%20Check%20Shirt/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shirts/Men%20Check%20Shirt/4.png"
        ],
        Thumbnail="mens_shirts_Men_Check_Shirt"
    },
    new Product
    {
        Name = "Nike Air Jordan 1 Red And Black",
        Description= "The Nike Air Jordan 1 in Red and Black is an iconic basketball sneaker known for its stylish design and high-performance features, making it a favorite among sneaker enthusiasts and athletes.",
        Category= "mens-shoes",
        Price= 14999,
        DiscountPercentage= 15.82,
        Rating= 2.77,
        QuantityInStock= 15,
        Tags= [
            "footwear",
            "athletic shoes"
        ],
        Brand= "Nike",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Air%20Jordan%201%20Red%20And%20Black/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Air%20Jordan%201%20Red%20And%20Black/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Air%20Jordan%201%20Red%20And%20Black/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Air%20Jordan%201%20Red%20And%20Black/4.png"
        ],
        Thumbnail="mens_shoes_Nike_Air_Jordan_1_Red_And_Black"
    },
    new Product
    {
        Name = "Nike Baseball Cleats",
        Description= "Nike Baseball Cleats are designed for maximum traction and performance on the baseball field. They provide stability and support for players during games and practices.",
        Category= "mens-shoes",
        Price= 7998,
        DiscountPercentage= 11.4,
        Rating= 4.01,
        QuantityInStock= 14,
        Tags= [
            "footwear",
            "sports cleats"
        ],
        Brand= "Nike",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Baseball%20Cleats/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Baseball%20Cleats/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Baseball%20Cleats/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Nike%20Baseball%20Cleats/4.png"
        ],
        Thumbnail="mens_shoes_Nike_Baseball_Cleats"
    },
    new Product
    {
        Name = "Puma Future Rider Trainers",
        Description= "The Puma Future Rider Trainers offer a blend of retro style and modern comfort. Perfect for casual wear, these trainers provide a fashionable and comfortable option for everyday use.",
        Category= "mens-shoes",
        Price= 8999,
        DiscountPercentage= 3.64,
        Rating= 4.85,
        QuantityInStock= 10,
        Tags= [
            "footwear",
            "casual shoes"
        ],
        Brand= "Puma",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shoes/Puma%20Future%20Rider%20Trainers/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Puma%20Future%20Rider%20Trainers/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Puma%20Future%20Rider%20Trainers/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Puma%20Future%20Rider%20Trainers/4.png"
        ],
        Thumbnail="mens_shoes_Puma_Future_Rider_Trainers"
    },
    new Product
    {
        Name = "Sports Sneakers Off White & Red",
        Description= "The Sports Sneakers in Off White and Red combine style and functionality, making them a fashionable choice for sports enthusiasts. The red and off-white color combination adds a bold and energetic touch.",
        Category= "mens-shoes",
        Price= 11999,
        DiscountPercentage= 11.69,
        Rating= 4.92,
        QuantityInStock= 73,
        Tags= [
            "footwear",
            "athletic shoes"
        ],
        Brand= "Off White",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20&%20Red/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20&%20Red/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20&%20Red/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20&%20Red/4.png"
        ],
        Thumbnail="mens_shoes_Sports_Sneakers_Off_White_&_Red"
    },
    new Product
    {
        Name = "Sports Sneakers Off White Red",
        Description= "Another variant of the Sports Sneakers in Off White Red, featuring a unique design. These sneakers offer style and comfort for casual occasions.",
        Category= "mens-shoes",
        Price= 10999,
        DiscountPercentage= 17.22,
        Rating= 2.95,
        QuantityInStock= 75,
        Tags= [
            "footwear",
            "casual shoes"
        ],
        Brand= "Off White",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20Red/1.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20Red/2.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20Red/3.png",
            "https://cdn.dummyjson.com/products/images/mens-shoes/Sports%20Sneakers%20Off%20White%20Red/4.png"
        ],
        Thumbnail="mens_shoes_Sports_Sneakers_Off_White_Red"
    },
    new Product
    {
        Name = "Brown Leather Belt Watch",
        Description= "The Brown Leather Belt Watch is a stylish timepiece with a classic design. Featuring a genuine leather strap and a sleek dial, it adds a touch of sophistication to your look.",
        Category= "mens-watches",
        Price= 8999,
        DiscountPercentage= 15.01,
        Rating= 4.47,
        QuantityInStock= 69,
        Tags= [
            "watches",
            "leather watches"
        ],
        Brand= "Fashion Timepieces",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-watches/Brown%20Leather%20Belt%20Watch/1.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Brown%20Leather%20Belt%20Watch/2.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Brown%20Leather%20Belt%20Watch/3.png"
        ],
        Thumbnail="mens_watches_Brown_Leather_Belt_Watch"
    },
    new Product
    {
        Name = "Longines Master Collection",
        Description= "The Longines Master Collection is an elegant and refined watch known for its precision and craftsmanship. With a timeless design, it's a symbol of luxury and sophistication.",
        Category= "mens-watches",
        Price= 149999,
        DiscountPercentage= 0.64,
        Rating= 2.64,
        QuantityInStock= 65,
        Tags= [
            "watches",
            "luxury watches"
        ],
        Brand= "Longines",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-watches/Longines%20Master%20Collection/1.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Longines%20Master%20Collection/2.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Longines%20Master%20Collection/3.png"
        ],
        Thumbnail="mens_watches_Longines_Master_Collection"
    },
    new Product
    {
        Name = "Rolex Cellini Date Black Dial",
        Description= "The Rolex Cellini Date with Black Dial is a classic and prestigious watch. With a black dial and date complication, it exudes sophistication and is a symbol of Rolex's heritage.",
        Category= "mens-watches",
        Price= 899999,
        DiscountPercentage= 14.28,
        Rating= 3.61,
        QuantityInStock= 84,
        Tags= [
            "watches",
            "luxury watches"
        ],
        Brand= "Rolex",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Cellini%20Date%20Black%20Dial/1.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Cellini%20Date%20Black%20Dial/2.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Cellini%20Date%20Black%20Dial/3.png"
        ],
        Thumbnail="mens_watches_Rolex_Cellini_Date_Black_Dial"
    },
    new Product
    {
        Name = "Rolex Cellini Moonphase",
        Description= "The Rolex Cellini Moonphase is a masterpiece of horology, featuring a moon phase complication and exquisite design. It reflects Rolex's commitment to precision and elegance.",
        Category= "mens-watches",
        Price= 1299999,
        DiscountPercentage= 5.7,
        Rating= 4.52,
        QuantityInStock= 33,
        Tags= [
            "watches",
            "luxury watches"
        ],
        Brand= "Rolex",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Cellini%20Moonphase/1.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Cellini%20Moonphase/2.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Cellini%20Moonphase/3.png"
        ],
        Thumbnail="mens_watches_Rolex_Cellini_Moonphase"
    },
    new Product
    {
        Name = "Rolex Datejust",
        Description= "The Rolex Datejust is an iconic and versatile timepiece with a date window. Known for its timeless design and reliability, it's a symbol of Rolex's watchmaking excellence.",
        Category= "mens-watches",
        Price= 1099999,
        DiscountPercentage= 9.69,
        Rating= 4.94,
        QuantityInStock= 11,
        Tags= [
            "watches",
            "luxury watches"
        ],
        Brand= "Rolex",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Datejust/1.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Datejust/2.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Datejust/3.png"
        ],
        Thumbnail="mens_watches_Rolex_Datejust"
    },
    new Product
    {
        Name = "Rolex Submariner Watch",
        Description= "The Rolex Submariner is a legendary dive watch with a rich history. Known for its durability and water resistance, it's a symbol of adventure and exploration.",
        Category= "mens-watches",
        Price= 1399999,
        DiscountPercentage= 0.82,
        Rating= 2.97,
        QuantityInStock= 35,
        Tags= [
            "watches",
            "luxury watches"
        ],
        Brand= "Rolex",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Submariner%20Watch/1.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Submariner%20Watch/2.png",
            "https://cdn.dummyjson.com/products/images/mens-watches/Rolex%20Submariner%20Watch/3.png"
        ],
        Thumbnail="mens_watches_Rolex_Submariner_Watch"
    },
    new Product
    {
        Name = "Amazon Echo Plus",
        Description= "The Amazon Echo Plus is a smart speaker with built-in Alexa voice control. It features premium sound quality and serves as a hub for controlling smart home devices.",
        Category= "mobile-accessories",
        Price= 9999,
        DiscountPercentage= 16.3,
        Rating= 3.52,
        QuantityInStock= 50,
        Tags= [
            "electronics",
            "smart speakers"
        ],
        Brand= "Amazon",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Amazon%20Echo%20Plus/1.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Amazon%20Echo%20Plus/2.png"
        ],
        Thumbnail="mobile_accessories_Amazon_Echo_Plus"
    },
    new Product
    {
        Name = "Apple Airpods",
        Description= "The Apple Airpods offer a seamless wireless audio experience. With easy pairing, high-quality sound, and Siri integration, they are perfect for on-the-go listening.",
        Category= "mobile-accessories",
        Price= 12999,
        DiscountPercentage= 4.82,
        Rating= 4.38,
        QuantityInStock= 93,
        Tags= [
            "electronics",
            "wireless earphones"
        ],
        Brand= "Apple",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20Airpods/1.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20Airpods/2.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20Airpods/3.png"
        ],
        Thumbnail="mobile_accessories_Apple_AirPods_Max_Silver"
    },
    new Product
    {
        Name = "Apple AirPods Max Silver",
        Description= "The Apple AirPods Max in Silver are premium over-ear headphones with high-fidelity audio, adaptive EQ, and active noise cancellation. Experience immersive sound in style.",
        Category= "mobile-accessories",
        Price= 54999,
        DiscountPercentage= 11.7,
        Rating= 3.11,
        QuantityInStock= 7,
        Tags= [
            "electronics",
            "over-ear headphones"
        ],
        Brand= "Apple",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20AirPods%20Max%20Silver/1.png"
        ],
        Thumbnail="mobile_accessories_Apple_Airpods"
    },
    new Product
    {
        Name = "Apple Airpower Wireless Charger",
        Description= "The Apple AirPower Wireless Charger provides a convenient way to charge your compatible Apple devices wirelessly. Simply place your devices on the charging mat for effortless charging.",
        Category= "mobile-accessories",
        Price= 7998,
        DiscountPercentage= 6.54,
        Rating= 4.51,
        QuantityInStock= 78,
        Tags= [
            "electronics",
            "wireless chargers"
        ],
        Brand= "Apple",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20Airpower%20Wireless%20Charger/1.png"
        ],
        Thumbnail="mobile_accessories_Apple_Airpower_Wireless_Charger"
    },
    new Product
    {
        Name = "Apple HomePod Mini Cosmic Grey",
        Description= "The Apple HomePod Mini in Cosmic Grey is a compact smart speaker that delivers impressive audio and integrates seamlessly with the Apple ecosystem for a smart home experience.",
        Category= "mobile-accessories",
        Price= 9999,
        DiscountPercentage= 3.7,
        Rating= 4.51,
        QuantityInStock= 65,
        Tags= [
            "electronics",
            "smart speakers"
        ],
        Brand= "Apple",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20HomePod%20Mini%20Cosmic%20Grey/1.png"
        ],
        Thumbnail="mobile_accessories_Apple_HomePod_Mini_Cosmic_Grey"
    },
    new Product
    {
        Name = "Apple iPhone Charger",
        Description= "The Apple iPhone Charger is a high-quality charger designed for fast and efficient charging of your iPhone. Ensure your device stays powered up and ready to go.",
        Category= "mobile-accessories",
        Price= 1998,
        DiscountPercentage= 1.01,
        Rating= 3.03,
        QuantityInStock= 4,
        Tags= [
            "electronics",
            "chargers"
        ],
        Brand= "Apple",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20iPhone%20Charger/1.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20iPhone%20Charger/2.png"
        ],
        Thumbnail="mobile_accessories_Apple_iPhone_Charger"
    },
    new Product
    {
        Name = "Apple MagSafe Battery Pack",
        Description= "The Apple MagSafe Battery Pack is a portable and convenient way to add extra battery life to your MagSafe-compatible iPhone. Attach it magnetically for a secure connection.",
        Category= "mobile-accessories",
        Price= 9999,
        DiscountPercentage= 10.27,
        Rating= 2.61,
        QuantityInStock= 80,
        Tags= [
            "electronics",
            "power banks"
        ],
        Brand= "Apple",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20MagSafe%20Battery%20Pack/1.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20MagSafe%20Battery%20Pack/2.png"
        ],
        Thumbnail="mobile_accessories_Apple_MagSafe_Battery_Pack"
    },
    new Product
    {
        Name = "Apple Watch Series 4 Gold",
        Description= "The Apple Watch Series 4 in Gold is a stylish and advanced smartwatch with features like heart rate monitoring, fitness tracking, and a beautiful Retina display.",
        Category= "mobile-accessories",
        Price= 34999,
        DiscountPercentage= 5.14,
        Rating= 4.42,
        QuantityInStock= 68,
        Tags= [
            "electronics",
            "smartwatches"
        ],
        Brand= "Apple",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20Watch%20Series%204%20Gold/1.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20Watch%20Series%204%20Gold/2.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Apple%20Watch%20Series%204%20Gold/3.png"
        ],
        Thumbnail="mobile_accessories_Apple_Watch_Series_4_Gold"
    },
    new Product
    {
        Name = "Beats Flex Wireless Earphones",
        Description= "The Beats Flex Wireless Earphones offer a comfortable and versatile audio experience. With magnetic earbuds and up to 12 hours of battery life, they are ideal for everyday use.",
        Category= "mobile-accessories",
        Price= 4999,
        DiscountPercentage= 8.27,
        Rating= 4.17,
        QuantityInStock= 49,
        Tags= [
            "electronics",
            "wireless earphones"
        ],
        Brand= "Beats",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Beats%20Flex%20Wireless%20Earphones/1.png"
        ],
        Thumbnail="mobile_accessories_Beats_Flex_Wireless_Earphones"
    },
    new Product
    {
        Name = "iPhone 12 Silicone Case with MagSafe Plum",
        Description= "The iPhone 12 Silicone Case with MagSafe in Plum is a stylish and protective case designed for the iPhone 12. It features MagSafe technology for easy attachment of accessories.",
        Category= "mobile-accessories",
        Price= 2999,
        DiscountPercentage= 14.35,
        Rating= 4.41,
        QuantityInStock= 51,
        Tags= [
            "electronics",
            "phone accessories"
        ],
        Brand= "Apple",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/iPhone%2012%20Silicone%20Case%20with%20MagSafe%20Plum/1.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/iPhone%2012%20Silicone%20Case%20with%20MagSafe%20Plum/2.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/iPhone%2012%20Silicone%20Case%20with%20MagSafe%20Plum/3.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/iPhone%2012%20Silicone%20Case%20with%20MagSafe%20Plum/4.png"
        ],
        Thumbnail="mobile_accessories_iPhone_12_Silicone_Case_with_MagSafe_Plum"
    },
    new Product
    {
        Name = "Monopod",
        Description= "The Monopod is a versatile camera accessory for stable and adjustable shooting. Perfect for capturing selfies, group photos, and videos with ease.",
        Category= "mobile-accessories",
        Price= 1998,
        DiscountPercentage= 11.62,
        Rating= 2.99,
        QuantityInStock= 96,
        Tags= [
            "electronics",
            "camera accessories"
        ],
        Brand= "TechGear",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Monopod/1.png",
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Monopod/2.png"
        ],
        Thumbnail="mobile_accessories_Monopod"
    },
    new Product
    {
        Name = "Selfie Lamp with iPhone",
        Description= "The Selfie Lamp with iPhone is a portable and adjustable LED light designed to enhance your selfies and video calls. Attach it to your iPhone for well-lit photos.",
        Category= "mobile-accessories",
        Price= 1499,
        DiscountPercentage= 13.86,
        Rating= 2.84,
        QuantityInStock= 89,
        Tags= [
            "electronics",
            "selfie accessories"
        ],
        Brand= "GadgetMaster",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Selfie%20Lamp%20with%20iPhone/1.png"
        ],
        Thumbnail="mobile_accessories_Selfie_Lamp_with_iPhone"
    },
    new Product
    {
        Name = "Selfie Stick Monopod",
        Description= "The Selfie Stick Monopod is a extendable and foldable device for capturing the perfect selfie or group photo. Compatible with smartphones and cameras.",
        Category= "mobile-accessories",
        Price= 1299,
        DiscountPercentage= 15.29,
        Rating= 2.93,
        QuantityInStock= 33,
        Tags= [
            "electronics",
            "selfie accessories"
        ],
        Brand= "SnapTech",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/Selfie%20Stick%20Monopod/1.png"
        ],
        Thumbnail="mobile_accessories_Selfie_Stick_Monopod"
    },
    new Product
    {
        Name = "TV Studio Camera Pedestal",
        Description= "The TV Studio Camera Pedestal is a professional-grade camera support system for smooth and precise camera movements in a studio setting. Ideal for broadcast and production.",
        Category= "mobile-accessories",
        Price= 49999,
        DiscountPercentage= 10.28,
        Rating= 4.05,
        QuantityInStock= 45,
        Tags= [
            "electronics",
            "camera accessories"
        ],
        Brand= "ProVision",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/mobile-accessories/TV%20Studio%20Camera%20Pedestal/1.png"
        ],
        Thumbnail="mobile_accessories_TV_Studio_Camera_Pedestal"
    },
    new Product
    {
        Name = "Generic Motorcycle",
        Description= "The Generic Motorcycle is a versatile and reliable bike suitable for various riding preferences. With a balanced design, it provides a comfortable and efficient riding experience.",
        Category= "motorcycle",
        Price= 399999,
        DiscountPercentage= 2.89,
        Rating= 4.85,
        QuantityInStock= 63,
        Tags= [
            "motorcycles"
        ],
        Brand= "Generic Motors",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/motorcycle/Generic%20Motorcycle/1.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Generic%20Motorcycle/2.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Generic%20Motorcycle/3.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Generic%20Motorcycle/4.png"
        ],
        Thumbnail="motorcycle_Generic_Motorcycle"
    },
    new Product
    {
        Name = "Kawasaki Z800",
        Description= "The Kawasaki Z800 is a powerful and agile sportbike known for its striking design and performance. It's equipped with advanced features, making it a favorite among motorcycle enthusiasts.",
        Category= "motorcycle",
        Price= 899999,
        DiscountPercentage= 15.07,
        Rating= 4.06,
        QuantityInStock= 88,
        Tags= [
            "motorcycles",
            "sportbikes"
        ],
        Brand= "Kawasaki",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/motorcycle/Kawasaki%20Z800/1.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Kawasaki%20Z800/2.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Kawasaki%20Z800/3.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Kawasaki%20Z800/4.png"
        ],
        Thumbnail="motorcycle_Kawasaki_Z800"
    },
    new Product
    {
        Name = "MotoGP CI.H1",
        Description= "The MotoGP CI.H1 is a high-performance motorcycle inspired by MotoGP racing technology. It offers cutting-edge features and precision engineering for an exhilarating riding experience.",
        Category= "motorcycle",
        Price= 1499999,
        DiscountPercentage= 17,
        Rating= 4.15,
        QuantityInStock= 85,
        Tags= [
            "motorcycles",
            "sportbikes"
        ],
        Brand= "MotoGP",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/motorcycle/MotoGP%20CI.H1/1.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/MotoGP%20CI.H1/2.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/MotoGP%20CI.H1/3.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/MotoGP%20CI.H1/4.png"
        ],
        Thumbnail="motorcycle_MotoGP_CI.H1"
    },
    new Product
    {
        Name = "Scooter Motorcycle",
        Description= "The Scooter Motorcycle is a practical and fuel-efficient bike ideal for urban commuting. It features a step-through design and user-friendly controls for easy maneuverability.",
        Category= "motorcycle",
        Price= 299999,
        DiscountPercentage= 19.19,
        Rating= 3.33,
        QuantityInStock= 11,
        Tags= [
            "motorcycles",
            "scooters"
        ],
        Brand= "ScootMaster",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/motorcycle/Scooter%20Motorcycle/1.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Scooter%20Motorcycle/2.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Scooter%20Motorcycle/3.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Scooter%20Motorcycle/4.png"
        ],
        Thumbnail="motorcycle_Scooter_Motorcycle"
    },
    new Product
    {
        Name = "Sportbike Motorcycle",
        Description= "The Sportbike Motorcycle is designed for speed and agility, with a sleek and aerodynamic profile. It's suitable for riders looking for a dynamic and thrilling riding experience.",
        Category= "motorcycle",
        Price= 749999,
        DiscountPercentage= 18.07,
        Rating= 2.97,
        QuantityInStock= 12,
        Tags= [
            "motorcycles",
            "sportbikes"
        ],
        Brand= "SpeedMaster",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/motorcycle/Sportbike%20Motorcycle/1.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Sportbike%20Motorcycle/2.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Sportbike%20Motorcycle/3.png",
            "https://cdn.dummyjson.com/products/images/motorcycle/Sportbike%20Motorcycle/4.png"
        ],
        Thumbnail="motorcycle_Sportbike_Motorcycle"
    },
    new Product
    {
        Name = "Attitude Super Leaves Hand Soap",
        Description= "Attitude Super Leaves Hand Soap is a natural and nourishing hand soap enriched with the goodness of super leaves. It cleanses and moisturizes your hands, leaving them feeling fresh and soft.",
        Category= "skin-care",
        Price= 899,
        DiscountPercentage= 17.42,
        Rating= 4.68,
        QuantityInStock= 98,
        Tags= [
            "personal care",
            "hand soap"
        ],
        Brand= "Attitude",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/skin-care/Attitude%20Super%20Leaves%20Hand%20Soap/1.png",
            "https://cdn.dummyjson.com/products/images/skin-care/Attitude%20Super%20Leaves%20Hand%20Soap/2.png",
            "https://cdn.dummyjson.com/products/images/skin-care/Attitude%20Super%20Leaves%20Hand%20Soap/3.png"
        ],
        Thumbnail="skin_care_Attitude_Super_Leaves_Hand_Soap"
    },
    new Product
    {
        Name = "Olay Ultra Moisture Shea Butter Body Wash",
        Description= "Olay Ultra Moisture Shea Butter Body Wash is a luxurious body wash that hydrates and nourishes your skin with the moisturizing power of shea butter. Enjoy a rich lather and silky-smooth skin.",
        Category= "skin-care",
        Price= 1299,
        DiscountPercentage= 16.95,
        Rating= 4.81,
        QuantityInStock= 43,
        Tags= [
            "personal care",
            "body wash"
        ],
        Brand= "Olay",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/skin-care/Olay%20Ultra%20Moisture%20Shea%20Butter%20Body%20Wash/1.png",
            "https://cdn.dummyjson.com/products/images/skin-care/Olay%20Ultra%20Moisture%20Shea%20Butter%20Body%20Wash/2.png",
            "https://cdn.dummyjson.com/products/images/skin-care/Olay%20Ultra%20Moisture%20Shea%20Butter%20Body%20Wash/3.png"
        ],
        Thumbnail="skin_care_Olay_Ultra_Moisture_Shea_Butter_Body_Wash"
    },
    new Product
    {
        Name = "Vaseline Men Body and Face Lotion",
        Description= "Vaseline Men Body and Face Lotion is a specially formulated lotion designed to provide long-lasting moisture to men's skin. It absorbs quickly and helps keep the skin hydrated and healthy.",
        Category= "skin-care",
        Price= 999,
        DiscountPercentage= 11.63,
        Rating= 3.97,
        QuantityInStock= 54,
        Tags= [
            "personal care",
            "body lotion"
        ],
        Brand= "Vaseline",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/skin-care/Vaseline%20Men%20Body%20and%20Face%20Lotion/1.png",
            "https://cdn.dummyjson.com/products/images/skin-care/Vaseline%20Men%20Body%20and%20Face%20Lotion/2.png",
            "https://cdn.dummyjson.com/products/images/skin-care/Vaseline%20Men%20Body%20and%20Face%20Lotion/3.png"
        ],
        Thumbnail="skin_care_Vaseline_Men_Body_and_Face_Lotion"
    },
    new Product
    {
        Name = "iPhone 5s",
        Description= "The iPhone 5s is a classic smartphone known for its compact design and advanced features during its release. While it's an older model, it still provides a reliable user experience.",
        Category= "smartphones",
        Price= 19999,
        DiscountPercentage= 11.85,
        Rating= 3.92,
        QuantityInStock= 65,
        Tags= [
            "smartphones",
            "apple"
        ],
        Brand= "Apple",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%205s/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%205s/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%205s/3.png"
        ],
        Thumbnail="smartphones_iPhone_13_Pro"
    },
    new Product
    {
        Name = "iPhone 6",
        Description= "The iPhone 6 is a stylish and capable smartphone with a larger display and improved performance. It introduced new features and design elements, making it a popular choice in its time.",
        Category= "smartphones",
        Price= 29999,
        DiscountPercentage= 4.54,
        Rating= 3.76,
        QuantityInStock= 99,
        Tags= [
            "smartphones",
            "apple"
        ],
        Brand= "Apple",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%206/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%206/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%206/3.png"
        ],
        Thumbnail="smartphones_iPhone_5s"
    },
    new Product
    {
        Name = "iPhone 13 Pro",
        Description= "The iPhone 13 Pro is a cutting-edge smartphone with a powerful camera system, high-performance chip, and stunning display. It offers advanced features for users who demand top-notch technology.",
        Category= "smartphones",
        Price= 109999,
        DiscountPercentage= 18.3,
        Rating= 3.42,
        QuantityInStock= 26,
        Tags= [
            "smartphones",
            "apple"
        ],
        Brand= "Apple",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%2013%20Pro/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%2013%20Pro/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%2013%20Pro/3.png"
        ],
        Thumbnail="smartphones_iPhone_6"
    },
    new Product
    {
        Name = "iPhone X",
        Description= "The iPhone X is a flagship smartphone featuring a bezel-less OLED display, facial recognition technology (Face ID), and impressive performance. It represents a milestone in iPhone design and innovation.",
        Category= "smartphones",
        Price= 89999,
        DiscountPercentage= 14.19,
        Rating= 4.96,
        QuantityInStock= 99,
        Tags= [
            "smartphones",
            "apple"
        ],
        Brand= "Apple",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%20X/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%20X/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/iPhone%20X/3.png"
        ],
        Thumbnail="smartphones_iPhone_X"
    },
    new Product
    {
        Name = "Oppo A57",
        Description= "The Oppo A57 is a mid-range smartphone known for its sleek design and capable features. It offers a balance of performance and affordability, making it a popular choice.",
        Category= "smartphones",
        Price= 24999,
        DiscountPercentage= 12.17,
        Rating= 3.1,
        QuantityInStock= 76,
        Tags= [
            "smartphones",
            "oppo"
        ],
        Brand= "Oppo",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20A57/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20A57/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20A57/3.png"
        ],
        Thumbnail="smartphones_Oppo_A57"
    },
    new Product
    {
        Name = "Oppo F19 Pro Plus",
        Description= "The Oppo F19 Pro Plus is a feature-rich smartphone with a focus on camera capabilities. It boasts advanced photography features and a powerful performance for a premium user experience.",
        Category= "smartphones",
        Price= 39999,
        DiscountPercentage= 15.62,
        Rating= 2.57,
        QuantityInStock= 92,
        Tags= [
            "smartphones",
            "oppo"
        ],
        Brand= "Oppo",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20F19%20Pro%20Plus/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20F19%20Pro%20Plus/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20F19%20Pro%20Plus/3.png"
        ],
        Thumbnail="smartphones_Oppo_F19_Pro_Plus"
    },
    new Product
    {
        Name = "Oppo K1",
        Description= "The Oppo K1 series offers a range of smartphones with various features and specifications. Known for their stylish design and reliable performance, the Oppo K1 series caters to diverse user preferences.",
        Category= "smartphones",
        Price= 29999,
        DiscountPercentage= 14.58,
        Rating= 3.39,
        QuantityInStock= 61,
        Tags= [
            "smartphones",
            "oppo"
        ],
        Brand= "Oppo",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20K1/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20K1/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20K1/3.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Oppo%20K1/4.png"
        ],
        Thumbnail="smartphones_Oppo_K1"
    },
    new Product
    {
        Name = "Realme C35",
        Description= "The Realme C35 is a budget-friendly smartphone with a focus on providing essential features for everyday use. It offers a reliable performance and user-friendly experience.",
        Category= "smartphones",
        Price= 14999,
        DiscountPercentage= 16.47,
        Rating= 2.56,
        QuantityInStock= 81,
        Tags= [
            "smartphones",
            "realme"
        ],
        Brand= "Realme",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20C35/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20C35/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20C35/3.png"
        ],
        Thumbnail="smartphones_Realme_C35"
    },
    new Product
    {
        Name = "Realme X",
        Description= "The Realme X is a mid-range smartphone known for its sleek design and impressive display. It offers a good balance of performance and camera capabilities for users seeking a quality device.",
        Category= "smartphones",
        Price= 29999,
        DiscountPercentage= 2.39,
        Rating= 4.42,
        QuantityInStock= 87,
        Tags= [
            "smartphones",
            "realme"
        ],
        Brand= "Realme",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20X/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20X/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20X/3.png"
        ],
        Thumbnail="smartphones_Realme_XT"
    },
    new Product
    {
        Name = "Realme XT",
        Description= "The Realme XT is a feature-rich smartphone with a focus on camera technology. It comes equipped with advanced camera sensors, delivering high-quality photos and videos for photography enthusiasts.",
        Category= "smartphones",
        Price= 34999,
        DiscountPercentage= 3.03,
        Rating= 4.14,
        QuantityInStock= 53,
        Tags= [
            "smartphones",
            "realme"
        ],
        Brand= "Realme",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20XT/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20XT/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Realme%20XT/3.png"
        ],
        Thumbnail="smartphones_Realme_X"
    },
    new Product
    {
        Name = "Samsung Galaxy S7",
        Description= "The Samsung Galaxy S7 is a flagship smartphone known for its sleek design and advanced features. It features a high-resolution display, powerful camera, and robust performance.",
        Category= "smartphones",
        Price= 29999,
        DiscountPercentage= 8.83,
        Rating= 4.9,
        QuantityInStock= 55,
        Tags= [
            "smartphones",
            "samsung galaxy"
        ],
        Brand= "Samsung",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S7/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S7/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S7/3.png"
        ],
        Thumbnail="smartphones_Samsung_Galaxy_S10"
    },
    new Product
    {
        Name = "Samsung Galaxy S8",
        Description= "The Samsung Galaxy S8 is a premium smartphone with an Infinity Display, offering a stunning visual experience. It boasts advanced camera capabilities and cutting-edge technology.",
        Category= "smartphones",
        Price= 49999,
        DiscountPercentage= 2.69,
        Rating= 3.69,
        QuantityInStock= 75,
        Tags= [
            "smartphones",
            "samsung galaxy"
        ],
        Brand= "Samsung",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S8/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S8/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S8/3.png"
        ],
        Thumbnail="smartphones_Samsung_Galaxy_S7"
    },
    new Product
    {
        Name = "Samsung Galaxy S10",
        Description= "The Samsung Galaxy S10 is a flagship device featuring a dynamic AMOLED display, versatile camera system, and powerful performance. It represents innovation and excellence in smartphone technology.",
        Category= "smartphones",
        Price= 69999,
        DiscountPercentage= 0.97,
        Rating= 2.81,
        QuantityInStock= 40,
        Tags= [
            "smartphones",
            "samsung galaxy"
        ],
        Brand= "Samsung",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S10/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S10/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Samsung%20Galaxy%20S10/3.png"
        ],
        Thumbnail="smartphones_Samsung_Galaxy_S8"
    },
    new Product
    {
        Name = "Vivo S1",
        Description= "The Vivo S1 is a stylish and mid-range smartphone offering a blend of design and performance. It features a vibrant display, capable camera system, and reliable functionality.",
        Category= "smartphones",
        Price= 24999,
        DiscountPercentage= 4.25,
        Rating= 2.83,
        QuantityInStock= 13,
        Tags= [
            "smartphones",
            "vivo"
        ],
        Brand= "Vivo",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20S1/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20S1/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20S1/3.png"
        ],
        Thumbnail="smartphones_Vivo_S1"
    },
    new Product
    {
        Name = "Vivo V9",
        Description= "The Vivo V9 is a smartphone known for its sleek design and emphasis on capturing high-quality selfies. It features a notch display, dual-camera setup, and a modern design.",
        Category= "smartphones",
        Price= 29999,
        DiscountPercentage= 14.57,
        Rating= 3.1,
        QuantityInStock= 19,
        Tags= [
            "smartphones",
            "vivo"
        ],
        Brand= "Vivo",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20V9/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20V9/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20V9/3.png"
        ],
        Thumbnail="smartphones_Vivo_V9"
    },
    new Product
    {
        Name = "Vivo X21",
        Description= "The Vivo X21 is a premium smartphone with a focus on cutting-edge technology. It features an in-display fingerprint sensor, a high-resolution display, and advanced camera capabilities.",
        Category= "smartphones",
        Price= 49999,
        DiscountPercentage= 7.32,
        Rating= 2.75,
        QuantityInStock= 0,
        Tags= [
            "smartphones",
            "vivo"
        ],
        Brand= "Vivo",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "Out of Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20X21/1.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20X21/2.png",
            "https://cdn.dummyjson.com/products/images/smartphones/Vivo%20X21/3.png"
        ],
        Thumbnail="smartphones_Vivo_X21"
    },
    new Product
    {
        Name = "American Football",
        Description= "The American Football is a classic ball used in American football games. It is designed for throwing and catching, making it an essential piece of equipment for the sport.",
        Category= "sports-accessories",
        Price= 1998,
        DiscountPercentage= 10.28,
        Rating= 3.78,
        QuantityInStock= 48,
        Tags= [
            "sports equipment",
            "american football"
        ],
        Brand="MIKASA",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/American%20Football/1.png"
        ],
        Thumbnail="sports_accessories_American_Football"
    },
    new Product
    {
        Name = "Baseball Ball",
        Description= "The Baseball Ball is a standard baseball used in baseball games. It features a durable leather cover and is designed for pitching, hitting, and fielding in the game of baseball.",
        Category= "sports-accessories",
        Price= 899,
        DiscountPercentage= 13.72,
        Rating= 4.76,
        QuantityInStock= 71,
        Tags= [
            "sports equipment",
            "baseball"
        ],
        Brand="MIKASA",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Baseball%20Ball/1.png"
        ],
        Thumbnail="sports_accessories_Baseball_Ball"
    },
    new Product
    {
        Name = "Baseball Glove",
        Description= "The Baseball Glove is a protective glove worn by baseball players. It is designed to catch and field the baseball, providing players with comfort and control during the game.",
        Category= "sports-accessories",
        Price= 2499,
        DiscountPercentage= 16.27,
        Rating= 2.72,
        QuantityInStock= 43,
        Tags= [
            "sports equipment",
            "baseball"
        ],
        Brand="MIKASA",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Baseball%20Glove/1.png",
            "https://cdn.dummyjson.com/products/images/sports-accessories/Baseball%20Glove/2.png",
            "https://cdn.dummyjson.com/products/images/sports-accessories/Baseball%20Glove/3.png"
        ],
        Thumbnail="sports_accessories_Baseball_Glove"
    },
    new Product
    {
        Name = "Basketball",
        Description= "The Basketball is a standard ball used in basketball games. It is designed for dribbling, shooting, and passing in the game of basketball, suitable for both indoor and outdoor play.",
        Category= "sports-accessories",
        Price= 1499,
        DiscountPercentage= 18.05,
        Rating= 4.15,
        QuantityInStock= 100,
        Tags= [
            "sports equipment",
            "basketball"
        ],
        Brand="MIKASA",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Basketball/1.png"
        ],
        Thumbnail="sports_accessories_Basketball"
    },
    new Product
    {
        Name = "Basketball Rim",
        Description= "The Basketball Rim is a sturdy hoop and net assembly mounted on a basketball backboard. It provides a target for shooting and scoring in the game of basketball.",
        Category= "sports-accessories",
        Price= 3999,
        DiscountPercentage= 6.02,
        Rating= 4.98,
        QuantityInStock= 57,
        Tags= [
            "sports equipment",
            "basketball"
        ],
        Brand="MIKASA",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Basketball%20Rim/1.png"
        ],
        Thumbnail="sports_accessories_Basketball_Rim"
    },
    new Product
    {
        Name = "Cricket Ball",
        Description= "The Cricket Ball is a hard leather ball used in the sport of cricket. It is bowled and batted in the game, and its hardness and seam contribute to the dynamics of cricket play.",
        Category= "sports-accessories",
        Price= 1299,
        DiscountPercentage= 12.93,
        Rating= 4.43,
        QuantityInStock= 42,
        Tags= [
            "sports equipment",
            "cricket"
        ],
        Brand="MRF",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Cricket%20Ball/1.png"
        ],
        Thumbnail="sports_accessories_Cricket_Ball"
    },
    new Product
    {
        Name = "Cricket Bat",
        Description= "The Cricket Bat is an essential piece of cricket equipment used by batsmen to hit the cricket ball. It is made of wood and comes in various sizes and designs.",
        Category= "sports-accessories",
        Price= 2999,
        DiscountPercentage= 9.03,
        Rating= 3.07,
        QuantityInStock= 3,
        Tags= [
            "sports equipment",
            "cricket"
        ],
        Brand="MRF",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Cricket%20Bat/1.png"
        ],
        Thumbnail="sports_accessories_Cricket_Bat"
    },
    new Product
    {
        Name = "Cricket Helmet",
        Description= "The Cricket Helmet is a protective headgear worn by cricket players, especially batsmen and wicketkeepers. It provides protection against fast bowling and bouncers.",
        Category= "sports-accessories",
        Price= 4499,
        DiscountPercentage= 10.75,
        Rating= 3.34,
        QuantityInStock= 31,
        Tags= [
            "sports equipment",
            "cricket"
        ],
        Brand="MRF",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Cricket%20Helmet/1.png",
            "https://cdn.dummyjson.com/products/images/sports-accessories/Cricket%20Helmet/2.png",
            "https://cdn.dummyjson.com/products/images/sports-accessories/Cricket%20Helmet/3.png",
            "https://cdn.dummyjson.com/products/images/sports-accessories/Cricket%20Helmet/4.png"
        ],
        Thumbnail="sports_accessories_Cricket_Helmet"
    },
    new Product
    {
        Name = "Cricket Wicket",
        Description= "The Cricket Wicket is a set of three stumps and two bails, forming a wicket used in the sport of cricket. Batsmen aim to protect the wicket while scoring runs.",
        Category= "sports-accessories",
        Price= 2999,
        DiscountPercentage= 8.79,
        Rating= 4.16,
        QuantityInStock= 31,
        Tags= [
            "sports equipment",
            "cricket"
        ],
        Brand="MRF",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Cricket%20Wicket/1.png"
        ],
        Thumbnail="sports_accessories_Cricket_Wicket"
    },
    new Product
    {
        Name = "Feather Shuttlecock",
        Description= "The Feather Shuttlecock is used in the sport of badminton. It features natural feathers and is designed for high-speed play, providing stability and accuracy during matches.",
        Category= "sports-accessories",
        Price= 599,
        DiscountPercentage= 10.24,
        Rating= 3.95,
        QuantityInStock= 17,
        Tags= [
            "sports equipment",
            "badminton"
        ],
        Brand="MRF",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Feather%20Shuttlecock/1.png"
        ],
        Thumbnail="sports_accessories_Feather_Shuttlecock"
    },
    new Product
    {
        Name = "Football",
        Description= "The Football, also known as a soccer ball, is the standard ball used in the sport of football (soccer). It is designed for kicking and passing in the game.",
        Category= "sports-accessories",
        Price= 1798,
        DiscountPercentage= 0.59,
        Rating= 3.94,
        QuantityInStock= 66,
        Tags= [
            "sports equipment",
            "football"
        ],
        Brand="MRF",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Football/1.png"
        ],
        Thumbnail="sports_accessories_Football"
    },
    new Product
    {
        Name = "Golf Ball",
        Description= "The Golf Ball is a small ball used in the sport of golf. It features dimples on its surface, providing aerodynamic lift and distance when struck by a golf club.",
        Category= "sports-accessories",
        Price= 999,
        DiscountPercentage= 19.38,
        Rating= 4.84,
        QuantityInStock= 45,
        Tags= [
            "sports equipment",
            "golf"
        ],
        Brand="MRF",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Golf%20Ball/1.png"
        ],
        Thumbnail="sports_accessories_Golf_Ball"
    },
    new Product
    {
        Name = "Iron Golf",
        Description= "The Iron Golf is a type of golf club designed for various golf shots. It features a solid metal head and is used for approach shots, chipping, and other golfing techniques.",
        Category= "sports-accessories",
        Price= 4999,
        DiscountPercentage= 3.32,
        Rating= 4.87,
        QuantityInStock= 7,
        Tags= [
            "sports equipment",
            "golf"
        ],
        Brand="MRF",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Iron%20Golf/1.png"
        ],
        Thumbnail="sports_accessories_Iron_Golf"
    },
    new Product
    {
        Name = "Metal Baseball Bat",
        Description= "The Metal Baseball Bat is a durable and lightweight baseball bat made from metal alloys. It is commonly used in baseball games for hitting and batting practice.",
        Category= "sports-accessories",
        Price= 2999,
        DiscountPercentage= 2.55,
        Rating= 4.11,
        QuantityInStock= 37,
        Tags= [
            "sports equipment",
            "baseball"
        ],
        Brand="MIKASA",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Metal%20Baseball%20Bat/1.png"
        ],
        Thumbnail="sports_accessories_Metal_Baseball_Bat"
    },
    new Product
    {
        Name = "Tennis Ball",
        Description= "The Tennis Ball is a standard ball used in the sport of tennis. It is designed for bouncing and hitting with tennis rackets during matches or practice sessions.",
        Category= "sports-accessories",
        Price= 699,
        DiscountPercentage= 0.14,
        Rating= 4.77,
        QuantityInStock= 99,
        Tags= [
            "sports equipment",
            "tennis"
        ],
        Brand="MIKASA",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Tennis%20Ball/1.png"
        ],
        Thumbnail="sports_accessories_Tennis_Ball"
    },
    new Product
    {
        Name = "Tennis Racket",
        Description= "The Tennis Racket is an essential piece of equipment used in the sport of tennis. It features a frame with strings and a grip, allowing players to hit the tennis ball.",
        Category= "sports-accessories",
        Price= 4999,
        DiscountPercentage= 15.8,
        Rating= 3.82,
        QuantityInStock= 86,
        Tags= [
            "sports equipment",
            "tennis"
        ],
        Brand="MIKASA",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Tennis%20Racket/1.png"
        ],
        Thumbnail="sports_accessories_Tennis_Racket"
    },
    new Product
    {
        Name = "Volleyball",
        Description= "The Volleyball is a standard ball used in the sport of volleyball. It is designed for passing, setting, and spiking over the net during volleyball matches.",
        Category= "sports-accessories",
        Price= 1199,
        DiscountPercentage= 2.2,
        Rating= 4.08,
        QuantityInStock= 0,
        Tags= [
            "sports equipment",
            "volleyball"
        ],
        Brand="MIKASA",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "Out of Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sports-accessories/Volleyball/1.png"
        ],
        Thumbnail="sports_accessories_Volleyball"
    },
    new Product
    {
        Name = "Black Sun Glasses",
        Description= "The Black Sun Glasses are a classic and stylish choice, featuring a sleek black frame and tinted lenses. They provide both UV protection and a fashionable look.",
        Category= "sunglasses",
        Price= 2999,
        DiscountPercentage= 14.22,
        Rating= 3.23,
        QuantityInStock= 100,
        Tags= [
            "eyewear",
            "sunglasses"
        ],
        Brand= "Fashion Shades",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sunglasses/Black%20Sun%20Glasses/1.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Black%20Sun%20Glasses/2.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Black%20Sun%20Glasses/3.png"
        ],
        Thumbnail="sunglasses_Black_Sun_Glasses"
    },
    new Product
    {
        Name = "Classic Sun Glasses",
        Description= "The Classic Sun Glasses offer a timeless design with a neutral frame and UV-protected lenses. These sunglasses are versatile and suitable for various occasions.",
        Category= "sunglasses",
        Price= 2499,
        DiscountPercentage= 15.67,
        Rating= 2.99,
        QuantityInStock= 100,
        Tags= [
            "eyewear",
            "sunglasses"
        ],
        Brand= "Fashion Shades",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sunglasses/Classic%20Sun%20Glasses/1.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Classic%20Sun%20Glasses/2.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Classic%20Sun%20Glasses/3.png"
        ],
        Thumbnail="sunglasses_Classic_Sun_Glasses"
    },
    new Product
    {
        Name = "Green and Black Glasses",
        Description= "The Green and Black Glasses feature a bold combination of green and black colors, adding a touch of vibrancy to your eyewear collection. They are both stylish and eye-catching.",
        Category= "sunglasses",
        Price= 3499,
        DiscountPercentage= 10.75,
        Rating= 2.84,
        QuantityInStock= 74,
        Tags= [
            "eyewear",
            "sunglasses"
        ],
        Brand= "Fashion Shades",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sunglasses/Green%20and%20Black%20Glasses/1.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Green%20and%20Black%20Glasses/2.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Green%20and%20Black%20Glasses/3.png"
        ],
        Thumbnail="sunglasses_Green_and_Black_Glasses"
    },
    new Product
    {
        Name = "Party Glasses",
        Description= "The Party Glasses are designed to add flair to your party outfit. With unique shapes or colorful frames, they're perfect for adding a playful touch to your look during celebrations.",
        Category= "sunglasses",
        Price= 1998,
        DiscountPercentage= 19.52,
        Rating= 3.21,
        QuantityInStock= 35,
        Tags= [
            "eyewear",
            "party glasses"
        ],
        Brand= "Fashion Fun",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sunglasses/Party%20Glasses/1.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Party%20Glasses/2.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Party%20Glasses/3.png"
        ],
        Thumbnail="sunglasses_Party_Glasses"
    },
    new Product
    {
        Name = "Sunglasses",
        Description= "The Sunglasses offer a classic and simple design with a focus on functionality. These sunglasses provide essential UV protection while maintaining a timeless look.",
        Category= "sunglasses",
        Price= 2299,
        DiscountPercentage= 4.87,
        Rating= 2.58,
        QuantityInStock= 59,
        Tags= [
            "eyewear",
            "sunglasses"
        ],
        Brand= "Fashion Shades",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/sunglasses/Sunglasses/1.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Sunglasses/2.png",
            "https://cdn.dummyjson.com/products/images/sunglasses/Sunglasses/3.png"
        ],
        Thumbnail="sunglasses_Sunglasses"
    },
    new Product
    {
        Name = "iPad Mini 2021 Starlight",
        Description= "The iPad Mini 2021 in Starlight is a compact and powerful tablet from Apple. Featuring a stunning Retina display, powerful A-series chip, and a sleek design, it offers a premium tablet experience.",
        Category= "tablets",
        Price= 49999,
        DiscountPercentage= 19.48,
        Rating= 3.87,
        QuantityInStock= 32,
        Tags= [
            "electronics",
            "tablets"
        ],
        Brand= "Apple",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tablets/iPad%20Mini%202021%20Starlight/1.png",
            "https://cdn.dummyjson.com/products/images/tablets/iPad%20Mini%202021%20Starlight/2.png",
            "https://cdn.dummyjson.com/products/images/tablets/iPad%20Mini%202021%20Starlight/3.png",
            "https://cdn.dummyjson.com/products/images/tablets/iPad%20Mini%202021%20Starlight/4.png"
        ],
        Thumbnail="tablets_iPad_Mini_2021_Starlight"
    },
    new Product
    {
        Name = "Samsung Galaxy Tab S8 Plus Grey",
        Description= "The Samsung Galaxy Tab S8 Plus in Grey is a high-performance Android tablet by Samsung. With a large AMOLED display, powerful processor, and S Pen support, it's ideal for productivity and entertainment.",
        Category= "tablets",
        Price= 59999,
        DiscountPercentage= 8.11,
        Rating= 3.43,
        QuantityInStock= 76,
        Tags= [
            "electronics",
            "tablets"
        ],
        Brand= "Samsung",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20S8%20Plus%20Grey/1.png",
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20S8%20Plus%20Grey/2.png",
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20S8%20Plus%20Grey/3.png",
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20S8%20Plus%20Grey/4.png"
        ],
        Thumbnail="tablets_Samsung_Galaxy_Tab_S8_Plus_Grey"
    },
    new Product
    {
        Name = "Samsung Galaxy Tab White",
        Description= "The Samsung Galaxy Tab in White is a sleek and versatile Android tablet. With a vibrant display, long-lasting battery, and a range of features, it offers a great user experience for various tasks.",
        Category= "tablets",
        Price= 34999,
        DiscountPercentage= 4.82,
        Rating= 3.7,
        QuantityInStock= 0,
        Tags= [
            "electronics",
            "tablets"
        ],
        Brand= "Samsung",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "Out of Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20White/1.png",
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20White/2.png",
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20White/3.png",
            "https://cdn.dummyjson.com/products/images/tablets/Samsung%20Galaxy%20Tab%20White/4.png"
        ],
        Thumbnail="tablets_Samsung_Galaxy_Tab_White"
    },
    new Product
    {
        Name = "Blue Frock",
        Description= "The Blue Frock is a charming and stylish dress for various occasions. With a vibrant blue color and a comfortable design, it adds a touch of elegance to your wardrobe.",
        Category= "tops",
        Price= 2999,
        DiscountPercentage= 9.37,
        Rating= 3.57,
        QuantityInStock= 37,
        Tags= [
            "clothing",
            "dresses"
        ],
        Brand="Decor",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tops/Blue%20Frock/1.png",
            "https://cdn.dummyjson.com/products/images/tops/Blue%20Frock/2.png",
            "https://cdn.dummyjson.com/products/images/tops/Blue%20Frock/3.png",
            "https://cdn.dummyjson.com/products/images/tops/Blue%20Frock/4.png"
        ],
        Thumbnail="tops_Blue_Frock"
    },
    new Product
    {
        Name = "Girl Summer Dress",
        Description= "The Girl Summer Dress is a cute and breezy dress designed for warm weather. With playful patterns and lightweight fabric, it's perfect for keeping cool and stylish during the summer.",
        Category= "tops",
        Price= 1998,
        DiscountPercentage= 6.42,
        Rating= 2.67,
        QuantityInStock= 20,
        Tags= [
            "clothing",
            "girls' dresses"
        ],
        Brand="Decor",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tops/Girl%20Summer%20Dress/1.png",
            "https://cdn.dummyjson.com/products/images/tops/Girl%20Summer%20Dress/2.png",
            "https://cdn.dummyjson.com/products/images/tops/Girl%20Summer%20Dress/3.png",
            "https://cdn.dummyjson.com/products/images/tops/Girl%20Summer%20Dress/4.png"
        ],
        Thumbnail="tops_Girl_Summer_Dress"
    },
    new Product
    {
        Name = "Gray Dress",
        Description= "The Gray Dress is a versatile and chic option for various occasions. With a neutral gray color, it can be dressed up or down, making it a wardrobe staple for any fashion-forward individual.",
        Category= "tops",
        Price= 3499,
        DiscountPercentage= 9.32,
        Rating= 3.49,
        QuantityInStock= 81,
        Tags= [
            "clothing",
            "dresses"
        ],
        Brand="Decor",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tops/Gray%20Dress/1.png",
            "https://cdn.dummyjson.com/products/images/tops/Gray%20Dress/2.png",
            "https://cdn.dummyjson.com/products/images/tops/Gray%20Dress/3.png",
            "https://cdn.dummyjson.com/products/images/tops/Gray%20Dress/4.png"
        ],
        Thumbnail="tops_Gray_Dress"
    },
    new Product
    {
        Name = "Short Frock",
        Description= "The Short Frock is a playful and trendy dress with a shorter length. Ideal for casual outings or special occasions, it combines style and comfort for a fashionable look.",
        Category= "tops",
        Price= 2499,
        DiscountPercentage= 9.47,
        Rating= 4.63,
        QuantityInStock= 19,
        Tags= [
            "clothing",
            "dresses"
        ],
        Brand="Decor",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tops/Short%20Frock/1.png",
            "https://cdn.dummyjson.com/products/images/tops/Short%20Frock/2.png",
            "https://cdn.dummyjson.com/products/images/tops/Short%20Frock/3.png",
            "https://cdn.dummyjson.com/products/images/tops/Short%20Frock/4.png"
        ],
        Thumbnail="tops_Short_Frock"
    },
    new Product
    {
        Name = "Tartan Dress",
        Description= "The Tartan Dress features a classic tartan pattern, bringing a timeless and sophisticated touch to your wardrobe. Perfect for fall and winter, it adds a hint of traditional charm.",
        Category= "tops",
        Price= 3999,
        DiscountPercentage= 2.08,
        Rating= 2.82,
        QuantityInStock= 100,
        Tags= [
            "clothing",
            "dresses"
        ],
        Brand="Decor",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/tops/Tartan%20Dress/1.png",
            "https://cdn.dummyjson.com/products/images/tops/Tartan%20Dress/2.png",
            "https://cdn.dummyjson.com/products/images/tops/Tartan%20Dress/3.png",
            "https://cdn.dummyjson.com/products/images/tops/Tartan%20Dress/4.png"
        ],
        Thumbnail="tops_Tartan_Dress"
    },
    new Product
    {
        Name = "300 Touring",
        Description= "The 300 Touring is a stylish and comfortable sedan, known for its luxurious features and smooth performance.",
        Category= "vehicle",
        Price= 2899999,
        DiscountPercentage= 7.15,
        Rating= 4.56,
        QuantityInStock= 53,
        Tags= [
            "sedans",
            "vehicles"
        ],
        Brand= "Chrysler",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/vehicle/300%20Touring/1.png",
            "https://cdn.dummyjson.com/products/images/vehicle/300%20Touring/2.png",
            "https://cdn.dummyjson.com/products/images/vehicle/300%20Touring/3.png",
            "https://cdn.dummyjson.com/products/images/vehicle/300%20Touring/4.png",
            "https://cdn.dummyjson.com/products/images/vehicle/300%20Touring/5.png",
            "https://cdn.dummyjson.com/products/images/vehicle/300%20Touring/6.png"
        ],
        Thumbnail="vehicle_300_Touring"
    },
    new Product
    {
        Name = "Charger SXT RWD",
        Description= "The Charger SXT RWD is a powerful and sporty rear-wheel-drive sedan, offering a blend of performance and practicality.",
        Category= "vehicle",
        Price= 3299999,
        DiscountPercentage= 2.27,
        Rating= 2.92,
        QuantityInStock= 85,
        Tags= [
            "sedans",
            "sports cars",
            "vehicles"
        ],
        Brand= "Dodge",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/vehicle/Charger%20SXT%20RWD/1.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Charger%20SXT%20RWD/2.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Charger%20SXT%20RWD/3.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Charger%20SXT%20RWD/4.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Charger%20SXT%20RWD/5.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Charger%20SXT%20RWD/6.png"
        ],
        Thumbnail="vehicle_Charger_SXT_RWD"
    },
    new Product
    {
        Name = "Dodge Hornet GT Plus",
        Description= "The Dodge Hornet GT Plus is a compact and agile hatchback, perfect for urban driving with a touch of sportiness.",
        Category= "vehicle",
        Price= 2499999,
        DiscountPercentage= 14.26,
        Rating= 3.93,
        QuantityInStock= 81,
        Tags= [
            "hatchbacks",
            "compact cars",
            "vehicles"
        ],
        Brand= "Dodge",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/vehicle/Dodge%20Hornet%20GT%20Plus/1.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Dodge%20Hornet%20GT%20Plus/2.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Dodge%20Hornet%20GT%20Plus/3.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Dodge%20Hornet%20GT%20Plus/4.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Dodge%20Hornet%20GT%20Plus/5.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Dodge%20Hornet%20GT%20Plus/6.png"
        ],
        Thumbnail="vehicle_Dodge_Hornet_GT_Plus"
    },
    new Product
    {
        Name = "Durango SXT RWD",
        Description= "The Durango SXT RWD is a spacious and versatile SUV, known for its strong performance and family-friendly features.",
        Category= "vehicle",
        Price= 3699999,
        DiscountPercentage= 9.21,
        Rating= 3.47,
        QuantityInStock= 0,
        Tags= [
            "suvs",
            "vehicles"
        ],
        Brand= "Dodge",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "Out of Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/vehicle/Durango%20SXT%20RWD/1.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Durango%20SXT%20RWD/2.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Durango%20SXT%20RWD/3.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Durango%20SXT%20RWD/4.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Durango%20SXT%20RWD/5.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Durango%20SXT%20RWD/6.png"
        ],
        Thumbnail="vehicle_Durango_SXT_RWD"
    },
    new Product
    {
        Name = "Pacifica Touring",
        Description= "The Pacifica Touring is a stylish and well-equipped minivan, offering comfort and convenience for family journeys.",
        Category= "vehicle",
        Price= 3199999,
        DiscountPercentage= 6.89,
        Rating= 2.96,
        QuantityInStock= 22,
        Tags= [
            "minivans",
            "vehicles"
        ],
        Brand= "Chrysler",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/vehicle/Pacifica%20Touring/1.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Pacifica%20Touring/2.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Pacifica%20Touring/3.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Pacifica%20Touring/4.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Pacifica%20Touring/5.png",
            "https://cdn.dummyjson.com/products/images/vehicle/Pacifica%20Touring/6.png"
        ],
        Thumbnail="vehicle_Pacifica_Touring"
    },
    new Product
    {
        Name = "Blue Women's Handbag",
        Description= "The Blue Women's Handbag is a stylish and spacious accessory for everyday use. With a vibrant blue color and multiple compartments, it combines fashion and functionality.",
        Category= "womens-bags",
        Price= 4999,
        DiscountPercentage= 5.24,
        Rating= 3.37,
        QuantityInStock= 76,
        Tags= [
            "fashion accessories",
            "handbags"
        ],
        Brand= "Fashionista",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-bags/Blue%20Women's%20Handbag/1.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Blue%20Women's%20Handbag/2.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Blue%20Women's%20Handbag/3.png"
        ],
        Thumbnail="womens_bags_Blue_Womens_Handbag"
    },
    new Product
    {
        Name = "Heshe Women's Leather Bag",
        Description= "The Heshe Women's Leather Bag is a luxurious and high-quality leather bag for the sophisticated woman. With a timeless design and durable craftsmanship, it's a versatile accessory.",
        Category= "womens-bags",
        Price= 12999,
        DiscountPercentage= 7.74,
        Rating= 2.62,
        QuantityInStock= 9,
        Tags= [
            "fashion accessories",
            "leather bags"
        ],
        Brand= "Heshe",
        WarrantyInformation= "1 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-bags/Heshe%20Women's%20Leather%20Bag/1.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Heshe%20Women's%20Leather%20Bag/2.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Heshe%20Women's%20Leather%20Bag/3.png"
        ],
        Thumbnail="womens_bags_Heshe_Womens_Leather_Bag"
    },
    new Product
    {
        Name = "Prada Women Bag",
        Description= "The Prada Women Bag is an iconic designer bag that exudes elegance and luxury. Crafted with precision and featuring the Prada logo, it's a statement piece for fashion enthusiasts.",
        Category= "womens-bags",
        Price= 59999,
        DiscountPercentage= 18.3,
        Rating= 3.52,
        QuantityInStock= 43,
        Tags= [
            "fashion accessories",
            "designer bags"
        ],
        Brand= "Prada",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-bags/Prada%20Women%20Bag/1.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Prada%20Women%20Bag/2.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Prada%20Women%20Bag/3.png"
        ],
        Thumbnail="womens_bags_Prada_Women_Bag"
    },
    new Product
    {
        Name = "White Faux Leather Backpack",
        Description= "The White Faux Leather Backpack is a trendy and practical backpack for the modern woman. With a sleek white design and ample storage space, it's perfect for both casual and on-the-go styles.",
        Category= "womens-bags",
        Price= 3999,
        DiscountPercentage= 7.76,
        Rating= 4.91,
        QuantityInStock= 89,
        Tags= [
            "fashion accessories",
            "backpacks"
        ],
        Brand= "Urban Chic",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-bags/White%20Faux%20Leather%20Backpack/1.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/White%20Faux%20Leather%20Backpack/2.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/White%20Faux%20Leather%20Backpack/3.png"
        ],
        Thumbnail="womens_bags_White_Faux_Leather_Backpack"
    },
    new Product
    {
        Name = "Women Handbag Black",
        Description= "The Women Handbag in Black is a classic and versatile accessory that complements various outfits. With a timeless black color and functional design, it's a must-have in every woman's wardrobe.",
        Category= "womens-bags",
        Price= 5999,
        DiscountPercentage= 3.08,
        Rating= 4.94,
        QuantityInStock= 24,
        Tags= [
            "fashion accessories",
            "handbags"
        ],
        Brand= "Elegance Collection",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-bags/Women%20Handbag%20Black/1.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Women%20Handbag%20Black/2.png",
            "https://cdn.dummyjson.com/products/images/womens-bags/Women%20Handbag%20Black/3.png"
        ],
        Thumbnail="womens_bags_Women_Handbag_Black"
    },
    new Product
    {
        Name = "Black Women's Gown",
        Description= "The Black Women's Gown is an elegant and timeless evening gown. With a sleek black design, it's perfect for formal events and special occasions, exuding sophistication and style.",
        Category= "womens-dresses",
        Price= 12999,
        DiscountPercentage= 5.86,
        Rating= 4.77,
        QuantityInStock= 59,
        Tags= [
            "clothing",
            "gowns"
        ],
        Brand="Decor",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "7 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-dresses/Black%20Women's%20Gown/1.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Black%20Women's%20Gown/2.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Black%20Women's%20Gown/3.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Black%20Women's%20Gown/4.png"
        ],
        Thumbnail="womens_dresses_Black_Womens_Gown"
    },
    new Product
    {
        Name = "Corset Leather With Skirt",
        Description= "The Corset Leather With Skirt is a bold and edgy ensemble that combines a stylish corset with a matching skirt. Ideal for fashion-forward individuals, it makes a statement at any event.",
        Category= "womens-dresses",
        Price= 8999,
        DiscountPercentage= 19.26,
        Rating= 2.52,
        QuantityInStock= 59,
        Tags= [
            "clothing",
            "corsets",
            "skirts"
        ],
        Brand="Decor",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20Leather%20With%20Skirt/1.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20Leather%20With%20Skirt/2.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20Leather%20With%20Skirt/3.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20Leather%20With%20Skirt/4.png"
        ],
        Thumbnail="womens_dresses_Corset_Leather_With_Skirt"
    },
    new Product
    {
        Name = "Corset With Black Skirt",
        Description= "The Corset With Black Skirt is a chic and versatile outfit that pairs a fashionable corset with a classic black skirt. It offers a trendy and coordinated look for various occasions.",
        Category= "womens-dresses",
        Price= 7998,
        DiscountPercentage= 14.61,
        Rating= 3,
        QuantityInStock= 67,
        Tags= [
            "clothing",
            "corsets",
            "skirts"
        ],
        Brand="Decor",
        WarrantyInformation= "Lifetime warranty",
        ShippingInformation= "Ships in 2 weeks",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20With%20Black%20Skirt/1.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20With%20Black%20Skirt/2.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20With%20Black%20Skirt/3.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Corset%20With%20Black%20Skirt/4.png"
        ],
        Thumbnail="womens_dresses_Corset_With_Black_Skirt"
    },
    new Product
    {
        Name = "Dress Pea",
        Description= "The Dress Pea is a stylish and comfortable dress with a pea pattern. Perfect for casual outings, it adds a playful and fun element to your wardrobe, making it a great choice for day-to-day wear.",
        Category= "womens-dresses",
        Price= 4999,
        DiscountPercentage= 9.81,
        Rating= 2.92,
        QuantityInStock= 29,
        Tags= [
            "clothing",
            "dresses"
        ],
        Brand="Decor",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-dresses/Dress%20Pea/1.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Dress%20Pea/2.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Dress%20Pea/3.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Dress%20Pea/4.png"
        ],
        Thumbnail="womens_dresses_Dress_Pea"
    },
    new Product
    {
        Name = "Marni Red & Black Suit",
        Description= "The Marni Red & Black Suit is a sophisticated and fashion-forward suit ensemble. With a combination of red and black tones, it showcases a modern design for a bold and confident look.",
        Category= "womens-dresses",
        Price= 17999,
        DiscountPercentage= 15.4,
        Rating= 4.17,
        QuantityInStock= 15,
        Tags= [
            "clothing",
            "suits"
        ],
        Brand="Decor",
        WarrantyInformation= "No warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-dresses/Marni%20Red%20&%20Black%20Suit/1.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Marni%20Red%20&%20Black%20Suit/2.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Marni%20Red%20&%20Black%20Suit/3.png",
            "https://cdn.dummyjson.com/products/images/womens-dresses/Marni%20Red%20&%20Black%20Suit/4.png"
        ],
        Thumbnail="womens_dresses_Marni_Red_&_Black_Suit"
    },
    new Product
    {
        Name = "Green Crystal Earring",
        Description= "The Green Crystal Earring is a dazzling accessory that features a vibrant green crystal. With a classic design, it adds a touch of elegance to your ensemble, perfect for formal or special occasions.",
        Category= "womens-jewellery",
        Price= 2999,
        DiscountPercentage= 2.58,
        Rating= 2.94,
        QuantityInStock= 1,
        Tags= [
            "fashion accessories",
            "earrings"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "Low Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Green%20Crystal%20Earring/1.png",
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Green%20Crystal%20Earring/2.png",
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Green%20Crystal%20Earring/3.png"
        ],
        Thumbnail="womens_jewellery_Green_Crystal_Earring"
    },
    new Product
    {
        Name = "Green Oval Earring",
        Description= "The Green Oval Earring is a stylish and versatile accessory with a unique oval shape. Whether for casual or dressy occasions, its green hue and contemporary design make it a standout piece.",
        Category= "womens-jewellery",
        Price= 2499,
        DiscountPercentage= 0.64,
        Rating= 2.54,
        QuantityInStock= 89,
        Tags= [
            "fashion accessories",
            "earrings"
        ],
        Brand="Decor",
        WarrantyInformation= "3 months warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Green%20Oval%20Earring/1.png",
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Green%20Oval%20Earring/2.png",
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Green%20Oval%20Earring/3.png"
        ],
        Thumbnail="womens_jewellery_Green_Oval_Earring"
    },
    new Product
    {
        Name = "Tropical Earring",
        Description= "The Tropical Earring is a fun and playful accessory inspired by tropical elements. Featuring vibrant colors and a lively design, it's perfect for adding a touch of summer to your look.",
        Category= "womens-jewellery",
        Price= 1998,
        DiscountPercentage= 12.31,
        Rating= 3.32,
        QuantityInStock= 76,
        Tags= [
            "fashion accessories",
            "earrings"
        ],
        Brand="Decor",
        WarrantyInformation= "3 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Tropical%20Earring/1.png",
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Tropical%20Earring/2.png",
            "https://cdn.dummyjson.com/products/images/womens-jewellery/Tropical%20Earring/3.png"
        ],
        Thumbnail="womens_jewellery_Tropical_Earring"
    },
    new Product
    {
        Name = "Black & Brown Slipper",
        Description= "The Black & Brown Slipper is a comfortable and stylish choice for casual wear. Featuring a blend of black and brown colors, it adds a touch of sophistication to your relaxation.",
        Category= "womens-shoes",
        Price= 1998,
        DiscountPercentage= 13.62,
        Rating= 4.13,
        QuantityInStock= 80,
        Tags= [
            "footwear",
            "slippers"
        ],
        Brand= "Comfort Trends",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-shoes/Black%20&%20Brown%20Slipper/1.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Black%20&%20Brown%20Slipper/2.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Black%20&%20Brown%20Slipper/3.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Black%20&%20Brown%20Slipper/4.png"
        ],
        Thumbnail="womens_shoes_Black_&_Brown_Slipper"
    },
    new Product
    {
        Name = "Calvin Klein Heel Shoes",
        Description= "Calvin Klein Heel Shoes are elegant and sophisticated, designed for formal occasions. With a classic design and high-quality materials, they complement your stylish ensemble.",
        Category= "womens-shoes",
        Price= 7998,
        DiscountPercentage= 11.39,
        Rating= 4.06,
        QuantityInStock= 99,
        Tags= [
            "footwear",
            "heel shoes"
        ],
        Brand= "Calvin Klein",
        WarrantyInformation= "1 week warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-shoes/Calvin%20Klein%20Heel%20Shoes/1.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Calvin%20Klein%20Heel%20Shoes/2.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Calvin%20Klein%20Heel%20Shoes/3.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Calvin%20Klein%20Heel%20Shoes/4.png"
        ],
        Thumbnail="womens_shoes_Calvin_Klein_Heel_Shoes"
    },
    new Product
    {
        Name = "Golden Shoes Woman",
        Description= "The Golden Shoes for Women are a glamorous choice for special occasions. Featuring a golden hue and stylish design, they add a touch of luxury to your outfit.",
        Category= "womens-shoes",
        Price= 4999,
        DiscountPercentage= 14.93,
        Rating= 4.82,
        QuantityInStock= 99,
        Tags= [
            "footwear",
            "women's shoes"
        ],
        Brand= "Fashion Diva",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-shoes/Golden%20Shoes%20Woman/1.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Golden%20Shoes%20Woman/2.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Golden%20Shoes%20Woman/3.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Golden%20Shoes%20Woman/4.png"
        ],
        Thumbnail="womens_shoes_Golden_Shoes_Woman"
    },
    new Product
    {
        Name = "Pampi Shoes",
        Description= "Pampi Shoes offer a blend of comfort and style for everyday use. With a versatile design, they are suitable for various casual occasions, providing a trendy and relaxed look.",
        Category= "womens-shoes",
        Price= 2999,
        DiscountPercentage= 0.3,
        Rating= 3.01,
        QuantityInStock= 36,
        Tags= [
            "footwear",
            "casual shoes"
        ],
        Brand= "Pampi",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-shoes/Pampi%20Shoes/1.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Pampi%20Shoes/2.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Pampi%20Shoes/3.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Pampi%20Shoes/4.png"
        ],
        Thumbnail="womens_shoes_Pampi_Shoes"
    },
    new Product
    {
        Name = "Red Shoes",
        Description= "The Red Shoes make a bold statement with their vibrant red color. Whether for a party or a casual outing, these shoes add a pop of color and style to your wardrobe.",
        Category= "womens-shoes",
        Price= 3499,
        DiscountPercentage= 0.01,
        Rating= 4.23,
        QuantityInStock= 53,
        Tags= [
            "footwear",
            "women's shoes"
        ],
        Brand= "Fashion Express",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships overnight",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "30 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-shoes/Red%20Shoes/1.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Red%20Shoes/2.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Red%20Shoes/3.png",
            "https://cdn.dummyjson.com/products/images/womens-shoes/Red%20Shoes/4.png"
        ],
        Thumbnail="womens_shoes_Red_Shoes"
    },
    new Product
    {
        Name = "IWC Ingenieur Automatic Steel",
        Description= "The IWC Ingenieur Automatic Steel watch is a durable and sophisticated timepiece. With a stainless steel case and automatic movement, it combines precision and style for watch enthusiasts.",
        Category= "womens-watches",
        Price= 499999,
        DiscountPercentage= 5.76,
        Rating= 2.58,
        QuantityInStock= 85,
        Tags= [
            "watches",
            "luxury watches"
        ],
        Brand= "IWC",
        WarrantyInformation= "5 year warranty",
        ShippingInformation= "Ships in 1 week",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-watches/IWC%20Ingenieur%20Automatic%20Steel/1.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/IWC%20Ingenieur%20Automatic%20Steel/2.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/IWC%20Ingenieur%20Automatic%20Steel/3.png"
        ],
        Thumbnail="womens_watches_IWC_Ingenieur_Automatic_Steel"
    },
    new Product
    {
        Name = "Rolex Cellini Moonphase",
        Description= "The Rolex Cellini Moonphase watch is a masterpiece of horology. Featuring a moon phase complication, it showcases the craftsmanship and elegance that Rolex is renowned for.",
        Category= "womens-watches",
        Price= 1599999,
        DiscountPercentage= 18.76,
        Rating= 3.41,
        QuantityInStock= 66,
        Tags= [
            "watches",
            "luxury watches"
        ],
        Brand= "Rolex",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1-2 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "60 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-watches/Rolex%20Cellini%20Moonphase/1.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Rolex%20Cellini%20Moonphase/2.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Rolex%20Cellini%20Moonphase/3.png"
        ],
        Thumbnail="womens_watches_Rolex_Cellini_Moonphase"
    },
    new Product
    {
        Name = "Rolex Datejust Women",
        Description= "The Rolex Datejust Women's watch is an iconic timepiece designed for women. With a timeless design and a date complication, it offers both elegance and functionality.",
        Category= "womens-watches",
        Price= 1099999,
        DiscountPercentage= 17.72,
        Rating= 3.53,
        QuantityInStock= 31,
        Tags= [
            "watches",
            "luxury watches",
            "women's watches"
        ],
        Brand= "Rolex",
        WarrantyInformation= "6 months warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-watches/Rolex%20Datejust%20Women/1.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Rolex%20Datejust%20Women/2.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Rolex%20Datejust%20Women/3.png"
        ],
        Thumbnail="womens_watches_Rolex_Datejust_Women"
    },
    new Product
    {
        Name = "Watch Gold for Women",
        Description= "The Gold Women's Watch is a stunning accessory that combines luxury and style. Featuring a gold-plated case and a chic design, it adds a touch of glamour to any outfit.",
        Category= "womens-watches",
        Price= 79999,
        DiscountPercentage= 6.37,
        Rating= 3.03,
        QuantityInStock= 94,
        Tags= [
            "watches",
            "women's watches"
        ],
        Brand= "Fashion Gold",
        WarrantyInformation= "2 year warranty",
        ShippingInformation= "Ships in 1 month",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "No return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-watches/Watch%20Gold%20for%20Women/1.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Watch%20Gold%20for%20Women/2.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Watch%20Gold%20for%20Women/3.png"
        ],
        Thumbnail="womens_watches_Watch_Gold_for_Women"
    },
    new Product
    {
        Name = "Women's Wrist Watch",
        Description= "The Women's Wrist Watch is a versatile and fashionable timepiece for everyday wear. With a comfortable strap and a simple yet elegant design, it complements various styles.",
        Category= "womens-watches",
        Price= 12999,
        DiscountPercentage= 17.34,
        Rating= 2.93,
        QuantityInStock= 55,
        Tags= [
            "watches",
            "women's watches"
        ],
        Brand= "Fashion Co.",
        WarrantyInformation= "1 month warranty",
        ShippingInformation= "Ships in 3-5 business days",
        AvailabilityStatus= "In Stock",

ReturnPolicy= "90 days return policy",
        Images= [
            "https://cdn.dummyjson.com/products/images/womens-watches/Women's%20Wrist%20Watch/1.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Women's%20Wrist%20Watch/2.png",
            "https://cdn.dummyjson.com/products/images/womens-watches/Women's%20Wrist%20Watch/3.png"
        ],
        Thumbnail="womens_watches_Womens_Wrist_Watch"
    }
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            await context.SaveChangesAsync();

        }
    }
}