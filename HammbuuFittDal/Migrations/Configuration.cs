namespace HammbuuFittDal.Migrations
{
    using HammbuuFittData;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HammbuuFittDal.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HammbuuFittDal.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            User newUser1 = new User()
            {
                FirstName = "Admin",
                LastName = "Admin",
                Age = 27,
                Gender = true,
                BasalMetabolismRate = 1000,
                BodyMassIndex = 15,
                MailAddress = "admin@admin.com",
                UserName = "admin",
                Password = "admin",
                IsActive = true,
                IsSportsman = true,
            };

            User newUser2 = new User()
            {
                FirstName = "Muhammed",
                LastName = "KOÇ",
                Age = 27,
                Gender = true,
                BasalMetabolismRate = 3000,
                BodyMassIndex = 23,
                MailAddress = "Mami_koc@gmail.com",
                UserName = "Mami17",
                Password = "Mami_17",
                IsActive = true,
                IsSportsman = true,
            };

            User newUser3 = new User()
            {
                FirstName = "Avnullah Mansur",
                LastName = "ATEŞ",
                Age = 27,
                Gender = true,
                BasalMetabolismRate = 1500,
                BodyMassIndex = 23,
                MailAddress = "Avnullah_ates@gmail.com",
                UserName = "Ates34",
                Password = "Ates@34",
                IsActive = true,
                IsSportsman = false,
            };

            User newUser4 = new User()
            {
                FirstName = "Burak",
                LastName = "ALPASLAN",
                Age = 32,
                Gender = true,
                BasalMetabolismRate = 1600,
                BodyMassIndex = 25,
                MailAddress = "Burak_alpaslan@gmail.com",
                UserName = "Burak34",
                Password = "Burak_34",
                IsActive = true,
                IsSportsman = false,
            };
            User newUser5 = new User()
            {
                FirstName = "Hüseyin",
                LastName = "KILIÇ",
                Age = 26,
                Gender = true,
                BasalMetabolismRate = 1800,
                BodyMassIndex = 20,
                MailAddress = "Hüso_klc@gmail.com",
                UserName = "Klc34",
                Password = "Klc@34",
                IsActive = true,
                IsSportsman = false,
            };

            context.Users.Add(newUser1);
            context.Users.Add(newUser2);
            context.Users.Add(newUser3);
            context.Users.Add(newUser4);
            context.Users.Add(newUser5);



            Category newCategory1 = new Category() { CategoryName = "Fırın Ürünleri", IsActive = true };
            Category newCategory2 = new Category() { CategoryName = "Et ve Tavuk Ürünleri", IsActive = true };
            Category newCategory3 = new Category() { CategoryName = "İçecekler", IsActive = true };
            Category newCategory4 = new Category() { CategoryName = "Kahvaltık ve Tahıl Ürünleri ", IsActive = true };
            Category newCategory5 = new Category() { CategoryName = "Süt ve Yumurta Ürünleri", IsActive = true };
            Category newCategory6 = new Category() { CategoryName = "Balık ve Deniz Ürünleri", IsActive = true };
            Category newCategory7 = new Category() { CategoryName = "Baklagiller ve Kuruyemişler", IsActive = true };
            Category newCategory8 = new Category() { CategoryName = "Atıştırmalıklar", IsActive = true };
            Category newCategory9 = new Category() { CategoryName = "Çorbalar", IsActive = true };
            Category newCategory10 = new Category() { CategoryName = "Baharatlar", IsActive = true };
            Category newCategory11 = new Category() { CategoryName = "Takviye Gıdalar", IsActive = true };
            Category newCategory12 = new Category() { CategoryName = "Tatlılar", IsActive = true };
            Category newCategory13 = new Category() { CategoryName = "Sebze ve Sebze Ürünleri", IsActive = true };
            Category newCategory14 = new Category() { CategoryName = "Meyveler", IsActive = true };
            Category newCategory15 = new Category() { CategoryName = "Fast Foods", IsActive = true };

            context.Categories.Add(newCategory1);
            context.Categories.Add(newCategory2);
            context.Categories.Add(newCategory3);
            context.Categories.Add(newCategory4);
            context.Categories.Add(newCategory5);
            context.Categories.Add(newCategory6);
            context.Categories.Add(newCategory7);
            context.Categories.Add(newCategory8);
            context.Categories.Add(newCategory9);
            context.Categories.Add(newCategory10);
            context.Categories.Add(newCategory11);
            context.Categories.Add(newCategory12);
            context.Categories.Add(newCategory13);
            context.Categories.Add(newCategory14);
            context.Categories.Add(newCategory15);


            Food newFood1 = new Food() { CategoryID = 1, FoodName = "Ekmek, Tam Buğday", Calories = 252, IsActive = true };
            Food newFood2 = new Food() { CategoryID = 1, FoodName = "Ekmek, Beyaz", Calories = 266, IsActive = true };
            Food newFood3 = new Food() { CategoryID = 1, FoodName = "Buğday Krakeri", Calories = 455, IsActive = true };
            Food newFood4 = new Food() { CategoryID = 1, FoodName = "Gözleme, Ev Yapimi", Calories = 261, IsActive = true };
            Food newFood5 = new Food() { CategoryID = 2, FoodName = "Dana Biftek", Calories = 160, IsActive = true };
            Food newFood6 = new Food() { CategoryID = 2, FoodName = "Kıyma, %85 Yağsız", Calories = 240, IsActive = true };
            Food newFood7 = new Food() { CategoryID = 2, FoodName = "Kıyma, %90 Yağsız", Calories = 214, IsActive = true };
            Food newFood8 = new Food() { CategoryID = 2, FoodName = "Dana Biftek", Calories = 250, IsActive = true };
            Food newFood9 = new Food() { CategoryID = 3, FoodName = "Su", Calories = 0, IsActive = true };
            Food newFood10 = new Food() { CategoryID = 3, FoodName = "Coca-Cola", Calories = 37, IsActive = true };
            Food newFood11 = new Food() { CategoryID = 3, FoodName = "Diet Coke", Calories = 1, IsActive = true };
            Food newFood12 = new Food() { CategoryID = 3, FoodName = "Cappuccino", Calories = 40, IsActive = true };
            Food newFood13 = new Food() { CategoryID = 3, FoodName = "Kahve, Kafeinsiz", Calories = 4, IsActive = true };
            Food newFood14 = new Food() { CategoryID = 3, FoodName = "Yeşil çay", Calories = 1, IsActive = true };
            Food newFood15 = new Food() { CategoryID = 4, FoodName = "Peyir", Calories = 402, IsActive = true };
            Food newFood16 = new Food() { CategoryID = 4, FoodName = "Zeytin", Calories = 115, IsActive = true };
            Food newFood17 = new Food() { CategoryID = 4, FoodName = "Çilek reçeli", Calories = 214, IsActive = true };
            Food newFood18 = new Food() { CategoryID = 4, FoodName = "Salam", Calories = 363, IsActive = true };
            Food newFood19 = new Food() { CategoryID = 5, FoodName = "Yumurta, Bütün-Pişmiş", Calories = 155, IsActive = true };
            Food newFood20 = new Food() { CategoryID = 5, FoodName = "Yoğun krema", Calories = 340, IsActive = true };
            Food newFood21 = new Food() { CategoryID = 5, FoodName = "Haşlanmış yumurta", Calories = 154, IsActive = true };
            Food newFood22 = new Food() { CategoryID = 5, FoodName = "Çikolatalı Süt, Bütün", Calories = 83, IsActive = true };
            Food newFood23 = new Food() { CategoryID = 6, FoodName = "Sardalya, Pişmiş", Calories = 195, IsActive = true };
            Food newFood24 = new Food() { CategoryID = 6, FoodName = "Ton Balığı, Konserve, Hafif Yağ", Calories = 198, IsActive = true };
            Food newFood25 = new Food() { CategoryID = 6, FoodName = "Somon, Konserve", Calories = 138, IsActive = true };
            Food newFood26 = new Food() { CategoryID = 6, FoodName = "Istakoz, Pişmiş", Calories = 89, IsActive = true };
            Food newFood27 = new Food() { CategoryID = 7, FoodName = "Çam Fıstığı, Pinyon", Calories = 629, IsActive = true };
            Food newFood28 = new Food() { CategoryID = 7, FoodName = "Badem, Beyazlatılmış", Calories = 590, IsActive = true };
            Food newFood29 = new Food() { CategoryID = 7, FoodName = "Haşhaş tohumları", Calories = 525, IsActive = true };
            Food newFood30 = new Food() { CategoryID = 7, FoodName = "Hindistan Cevizi Eti, Çiğ", Calories = 354, IsActive = true };
            Food newFood31 = new Food() { CategoryID = 7, FoodName = "Ayçekirdeği, Kuru Kavrulmuş, Tuzlu", Calories = 582, IsActive = true };
            Food newFood32 = new Food() { CategoryID = 7, FoodName = "Fıstık, Kuru Kavrulmuş, Tuzlu", Calories = 587, IsActive = true };
            Food newFood33 = new Food() { CategoryID = 8, FoodName = "Patlamış Mısır, Evde Patlamış", Calories = 387, IsActive = true };
            Food newFood34 = new Food() { CategoryID = 8, FoodName = "Patates Cipsi, Tuzlu", Calories = 531, IsActive = true };
            Food newFood35 = new Food() { CategoryID = 8, FoodName = "Doritos, Tortilla Cips, Nacho Peyniri", Calories = 496, IsActive = true };
            Food newFood36 = new Food() { CategoryID = 8, FoodName = "Cheetos, Gevrek, Acı", Calories = 55, IsActive = true };
            Food newFood37 = new Food() { CategoryID = 8, FoodName = "Clif Bar, Çikolata Parçalı", Calories = 368, IsActive = true };
            Food newFood38 = new Food() { CategoryID = 8, FoodName = "Bitter Kare Çikolata %80 Kakaolu", Calories = 564, IsActive = true };
            Food newFood39 = new Food() { CategoryID = 8, FoodName = "Çikolatalı Gofret", Calories = 565, IsActive = true };
            Food newFood40 = new Food() { CategoryID = 8, FoodName = "Susamlı Çubuk Kraker", Calories = 466, IsActive = true };
            Food newFood41 = new Food() { CategoryID = 8, FoodName = "Burçak Yulaflı Bisküvi", Calories = 458, IsActive = true };
            Food newFood42 = new Food() { CategoryID = 9, FoodName = "Bone Broth", Calories = 17, IsActive = true };
            Food newFood43 = new Food() { CategoryID = 9, FoodName = "Mercimek Çorbası, Ev Yapımı", Calories = 70, IsActive = true };
            Food newFood44 = new Food() { CategoryID = 9, FoodName = "Tavuk Suyu, Bulyon, Ev Yapımı", Calories = 35, IsActive = true };
            Food newFood45 = new Food() { CategoryID = 9, FoodName = "Sebze Suyu, Bulyon", Calories = 35, IsActive = true };
            Food newFood46 = new Food() { CategoryID = 9, FoodName = "Bezelye Çorbası", Calories = 75, IsActive = true };
            Food newFood47 = new Food() { CategoryID = 9, FoodName = "Domates Çorbası", Calories = 30, IsActive = true };
            Food newFood48 = new Food() { CategoryID = 9, FoodName = "Etli Kuru Fasulye çorbası", Calories = 133, IsActive = true };
            Food newFood49 = new Food() { CategoryID = 9, FoodName = "Tavuklu Sebze Çorbası", Calories = 31, IsActive = true };
            Food newFood50 = new Food() { CategoryID = 10, FoodName = "Tarçın", Calories = 247, IsActive = true };
            Food newFood51 = new Food() { CategoryID = 10, FoodName = "Tuz", Calories = 0, IsActive = true };
            Food newFood52 = new Food() { CategoryID = 10, FoodName = "Karabiber", Calories = 254, IsActive = true };
            Food newFood53 = new Food() { CategoryID = 10, FoodName = "Zencefil", Calories = 335, IsActive = true };
            Food newFood54 = new Food() { CategoryID = 10, FoodName = "Kırmızı biber", Calories = 282, IsActive = true };
            Food newFood55 = new Food() { CategoryID = 10, FoodName = "Kimyon", Calories = 375, IsActive = true };
            Food newFood56 = new Food() { CategoryID = 10, FoodName = "Kekik", Calories = 265, IsActive = true };
            Food newFood57 = new Food() { CategoryID = 10, FoodName = "Reyhan", Calories = 233, IsActive = true };
            Food newFood58 = new Food() { CategoryID = 10, FoodName = "Maydanoz", Calories = 292, IsActive = true };
            Food newFood59 = new Food() { CategoryID = 10, FoodName = "Biber tozu", Calories = 282, IsActive = true };
            Food newFood60 = new Food() { CategoryID = 10, FoodName = "Soğan tozu", Calories = 282, IsActive = true };
            Food newFood61 = new Food() { CategoryID = 10, FoodName = "Karbonat", Calories = 0, IsActive = true };
            Food newFood62 = new Food() { CategoryID = 11, FoodName = "Atkins Protein Shake, Çilek", Calories = 45, IsActive = true };
            Food newFood63 = new Food() { CategoryID = 11, FoodName = "Body Fortress 40g  Protein, Çikolata", Calories = 45, IsActive = true };
            Food newFood64 = new Food() { CategoryID = 11, FoodName = "Glucerna Shake, Tüm tatlar", Calories = 72, IsActive = true };
            Food newFood65 = new Food() { CategoryID = 11, FoodName = "Karanfil Hazır Kahvaltı Temelleri, Çikolata", Calories = 76, IsActive = true };
            Food newFood66 = new Food() { CategoryID = 11, FoodName = "Enerji İçeceği, Şekersiz", Calories = 5, IsActive = true };
            Food newFood67 = new Food() { CategoryID = 11, FoodName = "Vitamin Suyu, Diğer Markalar", Calories = 0, IsActive = true };
            Food newFood68 = new Food() { CategoryID = 12, FoodName = "Sütlaç", Calories = 99, IsActive = true };
            Food newFood69 = new Food() { CategoryID = 12, FoodName = "Çikolata", Calories = 600, IsActive = true };
            Food newFood70 = new Food() { CategoryID = 12, FoodName = "Fıstıklı Baklava", Calories = 329, IsActive = true };
            Food newFood71 = new Food() { CategoryID = 12, FoodName = "Dondurma", Calories = 201, IsActive = true };
            Food newFood72 = new Food() { CategoryID = 12, FoodName = "Çikolatalı Kek", Calories = 379, IsActive = true };
            Food newFood73 = new Food() { CategoryID = 12, FoodName = "Islak Kek", Calories = 360, IsActive = true };
            Food newFood74 = new Food() { CategoryID = 12, FoodName = "Kadayıf", Calories = 310, IsActive = true };
            Food newFood75 = new Food() { CategoryID = 12, FoodName = "Kadayıf", Calories = 310, IsActive = true };
            Food newFood76 = new Food() { CategoryID = 12, FoodName = "Tavuk Göğsü Tatlısı", Calories = 217, IsActive = true };
            Food newFood77 = new Food() { CategoryID = 12, FoodName = "İrmik Helvası", Calories = 296, IsActive = true };
            Food newFood78 = new Food() { CategoryID = 12, FoodName = "Tatlı Kurabiye", Calories = 546, IsActive = true };
            Food newFood79 = new Food() { CategoryID = 13, FoodName = "Domates", Calories = 18, IsActive = true };
            Food newFood80 = new Food() { CategoryID = 13, FoodName = "Ispanak", Calories = 23, IsActive = true };
            Food newFood81 = new Food() { CategoryID = 13, FoodName = "Havuç", Calories = 41, IsActive = true };
            Food newFood82 = new Food() { CategoryID = 13, FoodName = "Brokoli", Calories = 35, IsActive = true };
            Food newFood83 = new Food() { CategoryID = 13, FoodName = "Brokoli", Calories = 34, IsActive = true };
            Food newFood84 = new Food() { CategoryID = 13, FoodName = "Marul", Calories = 17, IsActive = true };
            Food newFood85 = new Food() { CategoryID = 13, FoodName = "Patates", Calories = 22, IsActive = true };
            Food newFood86 = new Food() { CategoryID = 13, FoodName = "Mantar", Calories = 22, IsActive = true };
            Food newFood87 = new Food() { CategoryID = 13, FoodName = "Sarımsak", Calories = 149, IsActive = true };
            Food newFood88 = new Food() { CategoryID = 13, FoodName = "Karnabahar", Calories = 23, IsActive = true };
            Food newFood89 = new Food() { CategoryID = 13, FoodName = "Salatalık", Calories = 10, IsActive = true };
            Food newFood90 = new Food() { CategoryID = 13, FoodName = "Mısır", Calories = 67, IsActive = true };
            Food newFood91 = new Food() { CategoryID = 14, FoodName = "Muz", Calories = 89, IsActive = true };
            Food newFood92 = new Food() { CategoryID = 14, FoodName = "Avokado", Calories = 167, IsActive = true };
            Food newFood93 = new Food() { CategoryID = 14, FoodName = "Elma", Calories = 52, IsActive = true };
            Food newFood94 = new Food() { CategoryID = 14, FoodName = "Çilek", Calories = 32, IsActive = true };
            Food newFood95 = new Food() { CategoryID = 14, FoodName = "Portakal", Calories = 47, IsActive = true };
            Food newFood96 = new Food() { CategoryID = 14, FoodName = "Limon", Calories = 22, IsActive = true };
            Food newFood97 = new Food() { CategoryID = 14, FoodName = "Karpuz", Calories = 30, IsActive = true };
            Food newFood98 = new Food() { CategoryID = 14, FoodName = "Üzüm", Calories = 30, IsActive = true };
            Food newFood99 = new Food() { CategoryID = 14, FoodName = "Mango", Calories = 60, IsActive = true };
            Food newFood100 = new Food() { CategoryID = 14, FoodName = "Ahududu", Calories = 52, IsActive = true };
            Food newFood101 = new Food() { CategoryID = 14, FoodName = "Yaban mersini", Calories = 57, IsActive = true };
            Food newFood102 = new Food() { CategoryID = 15, FoodName = "McDonald's, Big Mac", Calories = 261, IsActive = true };
            Food newFood103 = new Food() { CategoryID = 15, FoodName = "McDonald's, French Fries", Calories = 288, IsActive = true };
            Food newFood104 = new Food() { CategoryID = 15, FoodName = "McDonald's, Cheeseburger", Calories = 265, IsActive = true };
            Food newFood105 = new Food() { CategoryID = 15, FoodName = "Chipotle, Chicken", Calories = 166, IsActive = true };
            Food newFood106 = new Food() { CategoryID = 15, FoodName = "Chipotle, Fajita Vegetables", Calories = 28, IsActive = true };
            Food newFood107 = new Food() { CategoryID = 15, FoodName = "Chipotle, White Rice", Calories = 176, IsActive = true };
            Food newFood108 = new Food() { CategoryID = 15, FoodName = "Chipotle, Steak", Calories = 258, IsActive = true };
            Food newFood109 = new Food() { CategoryID = 15, FoodName = "Chipotle, Black Beans", Calories = 114, IsActive = true };
            Food newFood110 = new Food() { CategoryID = 15, FoodName = "Chick-fil-A, Chicken Nuggets", Calories = 232, IsActive = true };
            Food newFood111 = new Food() { CategoryID = 15, FoodName = "Chick-fil-A, Waffle Potato Fries", Calories = 279, IsActive = true };
            Food newFood112 = new Food() { CategoryID = 15, FoodName = "Chick-fil-A, Chicken Sandwich", Calories = 248, IsActive = true };
            Food newFood113 = new Food() { CategoryID = 15, FoodName = "Chick-fil-A Sauce", Calories = 495, IsActive = true };
            Food newFood114 = new Food() { CategoryID = 15, FoodName = "Chick-fil-A, Grilled Chicken Sandwich", Calories = 197, IsActive = true };
            Food newFood115 = new Food() { CategoryID = 15, FoodName = "Subway, 9-Grain Wheat Bread", Calories = 274, IsActive = true };
            Food newFood116 = new Food() { CategoryID = 15, FoodName = "Subway, Veggie Delite Sandwich, No Mayo", Calories = 165, IsActive = true };
            Food newFood117 = new Food() { CategoryID = 15, FoodName = "Subway, Turkey Breast Sandwich with Veggies, No Mayo", Calories = 138, IsActive = true };
            Food newFood118 = new Food() { CategoryID = 15, FoodName = "Panda Express, Orange Chicken", Calories = 313, IsActive = true };
            Food newFood119 = new Food() { CategoryID = 15, FoodName = "Domino's, Pepperoni Pizza, Hand Tossed", Calories = 241, IsActive = true };
            Food newFood120 = new Food() { CategoryID = 15, FoodName = "Domino's, Cheese Pizza, Hand Tossed", Calories = 232, IsActive = true };









            context.Foods.Add(newFood1);
            context.Foods.Add(newFood2);
            context.Foods.Add(newFood3);
            context.Foods.Add(newFood4);
            context.Foods.Add(newFood5);
            context.Foods.Add(newFood6);
            context.Foods.Add(newFood7);
            context.Foods.Add(newFood8);
            context.Foods.Add(newFood9);
            context.Foods.Add(newFood10);
            context.Foods.Add(newFood11);
            context.Foods.Add(newFood12);
            context.Foods.Add(newFood13);
            context.Foods.Add(newFood14);
            context.Foods.Add(newFood15);
            context.Foods.Add(newFood16);
            context.Foods.Add(newFood17);
            context.Foods.Add(newFood18);
            context.Foods.Add(newFood19);
            context.Foods.Add(newFood20);
            context.Foods.Add(newFood21);
            context.Foods.Add(newFood22);
            context.Foods.Add(newFood23);
            context.Foods.Add(newFood24);
            context.Foods.Add(newFood25);
            context.Foods.Add(newFood26);
            context.Foods.Add(newFood27);
            context.Foods.Add(newFood28);
            context.Foods.Add(newFood29);
            context.Foods.Add(newFood30);
            context.Foods.Add(newFood31);
            context.Foods.Add(newFood32);
            context.Foods.Add(newFood33);
            context.Foods.Add(newFood34);
            context.Foods.Add(newFood35);
            context.Foods.Add(newFood36);
            context.Foods.Add(newFood37);
            context.Foods.Add(newFood38);
            context.Foods.Add(newFood39);
            context.Foods.Add(newFood40);
            context.Foods.Add(newFood41);
            context.Foods.Add(newFood42);
            context.Foods.Add(newFood43);
            context.Foods.Add(newFood44);
            context.Foods.Add(newFood45);
            context.Foods.Add(newFood46);
            context.Foods.Add(newFood47);
            context.Foods.Add(newFood48);
            context.Foods.Add(newFood49);
            context.Foods.Add(newFood50);
            context.Foods.Add(newFood51);
            context.Foods.Add(newFood52);
            context.Foods.Add(newFood53);
            context.Foods.Add(newFood54);
            context.Foods.Add(newFood55);
            context.Foods.Add(newFood56);
            context.Foods.Add(newFood57);
            context.Foods.Add(newFood58);
            context.Foods.Add(newFood59);
            context.Foods.Add(newFood60);
            context.Foods.Add(newFood61);
            context.Foods.Add(newFood62);
            context.Foods.Add(newFood63);
            context.Foods.Add(newFood64);
            context.Foods.Add(newFood65);
            context.Foods.Add(newFood66);
            context.Foods.Add(newFood67);
            context.Foods.Add(newFood68);
            context.Foods.Add(newFood69);
            context.Foods.Add(newFood70);
            context.Foods.Add(newFood71);
            context.Foods.Add(newFood72);
            context.Foods.Add(newFood73);
            context.Foods.Add(newFood74);
            context.Foods.Add(newFood75);
            context.Foods.Add(newFood76);
            context.Foods.Add(newFood77);
            context.Foods.Add(newFood78);
            context.Foods.Add(newFood79);
            context.Foods.Add(newFood80);
            context.Foods.Add(newFood81);
            context.Foods.Add(newFood82);
            context.Foods.Add(newFood83);
            context.Foods.Add(newFood84);
            context.Foods.Add(newFood85);
            context.Foods.Add(newFood86);
            context.Foods.Add(newFood87);
            context.Foods.Add(newFood88);
            context.Foods.Add(newFood89);
            context.Foods.Add(newFood90);
            context.Foods.Add(newFood91);
            context.Foods.Add(newFood92);
            context.Foods.Add(newFood93);
            context.Foods.Add(newFood94);
            context.Foods.Add(newFood95);
            context.Foods.Add(newFood96);
            context.Foods.Add(newFood97);
            context.Foods.Add(newFood98);
            context.Foods.Add(newFood99);
            context.Foods.Add(newFood100);
            context.Foods.Add(newFood101);
            context.Foods.Add(newFood102);
            context.Foods.Add(newFood103);
            context.Foods.Add(newFood104);
            context.Foods.Add(newFood105);
            context.Foods.Add(newFood106);
            context.Foods.Add(newFood107);
            context.Foods.Add(newFood108);
            context.Foods.Add(newFood109);
            context.Foods.Add(newFood110);
            context.Foods.Add(newFood111);
            context.Foods.Add(newFood112);
            context.Foods.Add(newFood113);
            context.Foods.Add(newFood114);
            context.Foods.Add(newFood115);
            context.Foods.Add(newFood116);
            context.Foods.Add(newFood117);
            context.Foods.Add(newFood118);
            context.Foods.Add(newFood119);
            context.Foods.Add(newFood120);

            context.SaveChanges();
        }
    }
}
