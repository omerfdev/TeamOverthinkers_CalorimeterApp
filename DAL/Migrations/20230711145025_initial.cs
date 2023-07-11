using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category Details",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    IsAllergen = table.Column<bool>(type: "bit", nullable: false),
                    IsGlutenFree = table.Column<bool>(type: "bit", nullable: false),
                    HasLactose = table.Column<bool>(type: "bit", nullable: false),
                    IsVegaterian = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category Details", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Category Details_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CarbonHydrateValue = table.Column<decimal>(type: "decimal", nullable: false),
                    ProteinValue = table.Column<decimal>(type: "decimal", nullable: false),
                    FatValue = table.Column<decimal>(type: "decimal", nullable: false),
                    Calories = table.Column<decimal>(type: "decimal", nullable: false),
                    FoodImagePath = table.Column<string>(type: "nvarchar", nullable: true),
                    FoodDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User Details",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<decimal>(type: "decimal", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    IsAllergic = table.Column<bool>(type: "bit", nullable: false),
                    GlutenPreference = table.Column<bool>(type: "bit", nullable: false),
                    IsLactoseIntolerant = table.Column<bool>(type: "bit", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User Details", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User Details_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User Food Meals",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User Food Meals", x => new { x.UserID, x.FoodID, x.MealID });
                    table.ForeignKey(
                        name: "FK_User Food Meals_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User Food Meals_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User Food Meals_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryDescription", "CategoryName", "CreateDate", "ImagePath", "IsActive", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "...", "Beverages", null, "beverages", null, null },
                    { 2, "...", "Breakfast Foods", null, "breakfastfoods", null, null },
                    { 3, "...", "Dairy Products", null, "dairyproducts", null, null },
                    { 4, "...", "Desserts", null, "desserts", null, null },
                    { 5, "...", "Fast Foods", null, "fastfoods", null, null },
                    { 6, "...", "Grain Foods", null, "grainfoods", null, null },
                    { 7, "...", "Legume Dishes", null, "legumedishes", null, null },
                    { 8, "...", "Main Courses", null, "maincourses", null, null },
                    { 9, "...", "Meat Foods", null, "meatfoods", null, null },
                    { 10, "...", "Nuts", null, "nuts", null, null },
                    { 11, "...", "Pastry Foods", null, "pastryfoods", null, null },
                    { 12, "...", "Salads", null, "salads", null, null },
                    { 13, "...", "Sea Foods", null, "seafoods", null, null },
                    { 14, "...", "Soups", null, "soups", null, null },
                    { 15, "...", "Vegetable Foods", null, "vegetablefoods", null, null },
                    { 16, "...", "Vegetables&fruits", null, "vegetablesandfruits", null, null }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "ID", "CreateDate", "IsActive", "MealName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "Breakfast", null },
                    { 2, null, null, "Lunch", null },
                    { 3, null, null, "Dinner", null },
                    { 4, null, null, "Snack", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreateDate", "Email", "FirstName", "IsActive", "IsAdmin", "LastName", "Password", "UpdateDate" },
                values: new object[] { 1, null, "overthinkersapp@gmail.com", "admin", true, true, "admin", "60fe74406e7f353ed979f350f2fbb6a2e8690a5fa7d1b0c32983d1d8b3f95f67", null });

            migrationBuilder.InsertData(
                table: "Category Details",
                columns: new[] { "ID", "CategoryID", "CreateDate", "HasLactose", "IsActive", "IsAllergen", "IsGlutenFree", "IsVegaterian", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, null, false, null, false, false, true, null },
                    { 2, 2, null, true, null, true, false, true, null },
                    { 3, 3, null, true, null, true, false, true, null },
                    { 4, 4, null, true, null, false, false, true, null },
                    { 5, 5, null, false, null, false, true, false, null },
                    { 6, 6, null, false, null, true, true, true, null },
                    { 7, 7, null, false, null, false, false, true, null },
                    { 8, 8, null, false, null, false, false, false, null },
                    { 9, 9, null, false, null, false, false, false, null },
                    { 10, 10, null, false, null, true, false, true, null },
                    { 11, 11, null, true, null, false, true, true, null },
                    { 12, 12, null, false, null, false, false, true, null },
                    { 13, 13, null, false, null, true, false, false, null },
                    { 14, 14, null, false, null, false, true, true, null },
                    { 15, 15, null, false, null, false, false, true, null },
                    { 16, 16, null, false, null, false, false, true, null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "Calories", "CarbonHydrateValue", "CategoryID", "CreateDate", "FatValue", "FoodDescription", "FoodImagePath", "FoodName", "IsActive", "ProteinValue", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 37m, 2.7m, 1, null, 2m, "1 glass is 200 g", "..\\..\\..\\Image\\Images\\beverages\\ayran.jpg", "Ayran", null, 2m, null },
                    { 2, 39m, 3.7m, 1, null, 1.7m, "1 cup is 85 g", "..\\..\\..\\Image\\Images\\beverages\\cappucino.jpg", "Cappucino", null, 2.3m, null },
                    { 3, 61m, 10.9m, 1, null, 0m, "1 glass is 200 g", "..\\..\\..\\Image\\Images\\beverages\\cola.jpg", "Cola", null, 0m, null },
                    { 4, 95m, 24m, 1, null, 0m, "1 glass is 200 g", "..\\..\\..\\Image\\Images\\beverages\\soda.jpg", "Soda", null, 0m, null },
                    { 5, 158m, 0m, 2, null, 11.2m, "1 piece is 60 g", "..\\..\\..\\Image\\Images\\breakfastfoods\\boiledegg.jpg", "Boiled Egg", null, 12.1m, null },
                    { 6, 315m, 78.4m, 2, null, 0m, "1 teaspoon is 7 g", "..\\..\\..\\Image\\Images\\breakfastfoods\\honey.jpg", "Honey", null, 0.3m, null },
                    { 7, 207m, 2m, 2, null, 2m, "1 piece is 4 g", "..\\..\\..\\Image\\Images\\breakfastfoods\\olive.jpg", "Olive", null, 1.8m, null },
                    { 8, 184m, 2.3m, 2, null, 14.4m, "1 piece is 60 g", "..\\..\\..\\Image\\Images\\breakfastfoods\\omelette.jpg", "Omelette", null, 12.1m, null },
                    { 9, 215m, 81.1m, 3, null, 0.1m, "1 teaspoon is 7 g", "..\\..\\..\\Image\\Images\\dairyproducts\\butter.jpg", "Butter", null, 0.9m, null },
                    { 10, 404m, 1.4m, 3, null, 31.8m, "1 slice is 20 g", "..\\..\\..\\Image\\Images\\dairyproducts\\cheddarcheese.jpg", "Cheddar Cheese", null, 27m, null },
                    { 11, 289m, 0m, 3, null, 21.6m, "1 cube is 30 g", "..\\..\\..\\Image\\Images\\dairyproducts\\fetacheese.jpg", "Feta Cheese", null, 22.5m, null },
                    { 12, 63m, 7m, 3, null, 1.6m, "1 cup is 180 g", "..\\..\\..\\Image\\Images\\dairyproducts\\yogurt.jpg", "Yogurt", null, 5.3m, null },
                    { 13, 412m, 49.4m, 4, null, 21.5m, "1 slice is 40 g", "..\\..\\..\\Image\\Images\\desserts\\baklava.jpg", "Baklava", null, 7.7m, null },
                    { 14, 331m, 36.3m, 4, null, 19.1m, "1 slice is 125 g", "..\\..\\..\\Image\\Images\\desserts\\cheesecake.jpg", "Cheesecake", null, 4.8m, null },
                    { 15, 438m, 58.6m, 4, null, 17.8m, "1 piece is 85 g", "..\\..\\..\\Image\\Images\\desserts\\donuts.jpg", "Donuts", null, 10m, null },
                    { 16, 360m, 38.1m, 4, null, 18.7m, "1 piece is 95 g", "..\\..\\..\\Image\\Images\\desserts\\souffle.jpg", "Souffle", null, 7.3m, null },
                    { 17, 165m, 19.9m, 5, null, 6.1m, "1 piece is 190 g", "..\\..\\..\\Image\\Images\\fastfoods\\hamburger.jpg", "Hamburger", null, 7m, null },
                    { 18, 253m, 28m, 5, null, 11.9m, "1 piece is 175 g", "..\\..\\..\\Image\\Images\\fastfoods\\hotdog.jpg", "Hot Dog", null, 8.3m, null },
                    { 19, 94m, 2.3m, 5, null, 2.4m, "1 half loaf is 245 g", "..\\..\\..\\Image\\Images\\fastfoods\\kokorec.jpg", "Kokorec", null, 15m, null },
                    { 20, 186m, 30.5m, 5, null, 4.3m, "1 slice is 130 g", "..\\..\\..\\Image\\Images\\fastfoods\\pizza.jpg", "Pizza", null, 5.8m, null },
                    { 21, 114m, 18.2m, 6, null, 3.4m, "1 portion is 130 g", "..\\..\\..\\Image\\Images\\grainfoods\\bulgurpilaf.jpg", "Bulgur Pilaf", null, 2.8m, null },
                    { 22, 357m, 84.1m, 6, null, 0.4m, "1 case is 50 g", "..\\..\\..\\Image\\Images\\grainfoods\\cornflakes.jpg", "Corn Flakes", null, 7.5m, null },
                    { 23, 162m, 24.8m, 6, null, 5.8m, "1 portion is 170 g", "..\\..\\..\\Image\\Images\\grainfoods\\rice.jpg", "Rice", null, 2.1m, null },
                    { 24, 77m, 11.7m, 6, null, 1.8m, "1 portion is 130 g", "..\\..\\..\\Image\\Images\\grainfoods\\rolledoats.jpg", "Rolled Oats", null, 3.3m, null },
                    { 25, 27m, 3.3m, 7, null, 0.3m, "1 portion is 130 g", "..\\..\\..\\Image\\Images\\legumedishes\\greenbeans.jpg", "Green Beans", null, 2.6m, null },
                    { 26, 84m, 14.4m, 7, null, 0.4m, "1 portion is 180 g", "..\\..\\..\\Image\\Images\\legumedishes\\greenpea.jpg", "Green Pea", null, 6.3m, null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "Calories", "CarbonHydrateValue", "CategoryID", "CreateDate", "FatValue", "FoodDescription", "FoodImagePath", "FoodName", "IsActive", "ProteinValue", "UpdateDate" },
                values: new object[,]
                {
                    { 27, 281m, 29.4m, 7, null, 1.4m, "1 portion is 250 g", "..\\..\\..\\Image\\Images\\legumedishes\\haricotbean.jpg", "Haricot Bean", null, 21.8m, null },
                    { 28, 340m, 60.1m, 7, null, 1.1m, "1 portion is 230 g", "..\\..\\..\\Image\\Images\\legumedishes\\lentildish.jpg", "Lentil Dish", null, 24.7m, null },
                    { 29, 104m, 2.8m, 8, null, 8m, "1 portion is 416 g", "..\\..\\..\\Image\\Images\\maincourses\\alinazik.jpg", "Alinazik", null, 5.2m, null },
                    { 30, 152m, 3.5m, 8, null, 9.2m, "1 portion is 266 g", "..\\..\\..\\Resources\\Images\\maincourses\\beefstroganoff.jpg", "Beef Stroganoff", null, 13.4m, null },
                    { 31, 198m, 26.5m, 8, null, 10.2m, "1 portion is 195 g", "..\\..\\..\\Resources\\Images\\maincourses\\biryani.jpg", "Biryani", null, 2.3m, null },
                    { 32, 151m, 15.5m, 8, null, 5.4m, "1 portion is 500 g", "..\\..\\..\\Resources\\Images\\maincourses\\iskender.jpg", "İskender", null, 9.7m, null },
                    { 33, 183m, 5.6m, 9, null, 11.6m, "1 portion is 150 g", "..\\..\\..\\Resources\\Images\\meatfoods\\beef.jpg", "Beef", null, 13.4m, null },
                    { 34, 215m, 0m, 9, null, 15.1m, "1 portion is 170 g", "..\\..\\..\\Resources\\Images\\meatfoods\\chicken.jpg", "Chicken", null, 18.6m, null },
                    { 35, 345m, 0m, 9, null, 28.5m, "1 portion is 360 g", "..\\..\\..\\Resources\\Images\\meatfoods\\kavurma.jpg", "Kavurma", null, 20.6m, null },
                    { 36, 137m, 2.6m, 9, null, 7.6m, "1 portion is 237 g", "..\\..\\..\\Resources\\Images\\meatfoods\\kusbasi.jpg", "Kuşbaşı", null, 5.8m, null },
                    { 37, 600m, 19.8m, 10, null, 54.2m, "1 piece is 2 g", "..\\..\\..\\Resources\\Images\\nuts\\almond.jpg", "Almond", null, 18.6m, null },
                    { 38, 574m, 32.7m, 10, null, 46.4m, "1 piece is 4 g", "..\\..\\..\\Resources\\Images\\nuts\\cashew.jpg", "Cashew", null, 11.3m, null },
                    { 39, 634m, 16.8m, 10, null, 62.4m, "1 piece is 2 g", "..\\..\\..\\Resources\\Images\\nuts\\hazelnut.jpg", "Hazelnut", null, 12.6m, null },
                    { 40, 610m, 10m, 10, null, 50m, "1 handful is 10 g", "..\\..\\..\\Resources\\Images\\nuts\\pumpkinseeds.jpg", "Pumpkin Seeds", null, 30.1m, null },
                    { 41, 259m, 33.5m, 11, null, 9.14m, "1 portion is 150 g", "..\\..\\..\\Resources\\Images\\pastryfoods\\borek.jpg", "Börek", null, 10.1m, null },
                    { 42, 256m, 52.8m, 11, null, 0.9m, "1 piece is 25 g", "..\\..\\..\\Resources\\Images\\pastryfoods\\bread.jpg", "Bread", null, 8.1m, null },
                    { 43, 271m, 42m, 11, null, 7.4m, "1 piece is 60 g", "..\\..\\..\\Resources\\Images\\pastryfoods\\croissant.jpg", "Croissant", null, 8.2m, null },
                    { 44, 255m, 48.9m, 11, null, 5.2m, "1 piece is 100 g", "..\\..\\..\\Resources\\Images\\pastryfoods\\simit.jpg", "Simit", null, 2.3m, null },
                    { 45, 128m, 6.6m, 12, null, 5m, "1 portion is 365 g", "..\\..\\..\\Resources\\Images\\salads\\ceasarsalad.jpg", "Ceasar Salad", null, 23.8m, null },
                    { 46, 52m, 7.6m, 12, null, 1.7m, "1 portion is 220 g", "..\\..\\..\\Resources\\Images\\salads\\cobansalad.jpg", "Çoban Salad", null, 1.5m, null },
                    { 47, 188m, 2m, 12, null, 13.8m, "1 portion is 173 g", "..\\..\\..\\Resources\\Images\\salads\\cobbsalad.jpg", "Cobb Salad", null, 13.9m, null },
                    { 48, 73m, 5m, 12, null, 5m, "1 portion is 155 g", "..\\..\\..\\Resources\\Images\\salads\\gavurdagisalad.jpg", "Gavurdağı Salad", null, 1.9m, null },
                    { 49, 115m, 0m, 13, null, 5m, "1 portion is 200 g", "..\\..\\..\\Resources\\Images\\seafoods\\anchovy.jpg", "Anchovy", null, 17m, null },
                    { 50, 85m, 0m, 13, null, 0.5m, "1 portion is 100 g", "..\\..\\..\\Resources\\Images\\seafoods\\prawn.jpg", "Prawn", null, 20.1m, null },
                    { 51, 179m, 0m, 13, null, 10.4m, "1 portion is 150 g", "..\\..\\..\\Resources\\Images\\seafoods\\salmon.jpg", "Salmon", null, 19.9m, null },
                    { 52, 113m, 7m, 13, null, 6.7m, "1 portion is 170 g", "..\\..\\..\\Resources\\Images\\seafoods\\sushi.jpg", "Sushi", null, 7.3m, null },
                    { 53, 45m, 5.9m, 14, null, 1.2m, "1 ladle is 150 g", "..\\..\\..\\Resources\\Images\\soups\\ezogelinsoup.jpg", "Ezogelin Soup", null, 1.9m, null },
                    { 54, 49m, 4.4m, 14, null, 1.3m, "1 ladle is 150 g", "..\\..\\..\\Resources\\Images\\soups\\fishsoup.jpg", "Fish Soup", null, 4.5m, null },
                    { 55, 46m, 8.3m, 14, null, 0.2m, "1 ladle is 150 g", "..\\..\\..\\Resources\\Images\\soups\\lentilsoup.jpg", "Lentil Soup", null, 2.5m, null },
                    { 56, 32m, 4.4m, 14, null, 1.1m, "1 ladle is 150 g", "..\\..\\..\\Resources\\Images\\soups\\tomatosoup.jpg", "Tomato Soup", null, 0.9m, null },
                    { 57, 53m, 12m, 15, null, 0.3m, "1 portion is 100 g", "..\\..\\..\\Resources\\Images\\vegetablefoods\\artichoke.jpg", "Artichoke", null, 2.9m, null },
                    { 58, 83m, 83m, 15, null, 5m, "1 piece is 60 g", "..\\..\\..\\Resources\\Images\\vegetablefoods\\mucver.jpg", "Mücver", null, 3.7m, null },
                    { 59, 27m, 4.4m, 15, null, 0.7m, "1 portion is 480 g", "..\\..\\..\\Resources\\Images\\vegetablefoods\\ratatouille.jpg", "Ratatouille", null, 1.1m, null },
                    { 60, 76m, 5.7m, 15, null, 4.6m, "1 portion is 175 g", "..\\..\\..\\Resources\\Images\\vegetablefoods\\spinachmeal.jpg", "Spinach Meal", null, 2.6m, null },
                    { 61, 58m, 15m, 16, null, 0.6m, "1 piece is 90 g", "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\apple.jpg", "Apple", null, 0.2m, null },
                    { 62, 160m, 8.5m, 16, null, 14.7m, "1 piece is 140 g", "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\avocado.jpg", "Avocado", null, 2m, null },
                    { 63, 85m, 11.6m, 16, null, 0.2m, "1 piece is 170 g", "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\banana.jpg", "Banana", null, 1.1m, null },
                    { 64, 10m, 10m, 16, null, 0.2m, "1 piece is 40 g", "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\carrot.jpg", "Carrot", null, 0.1m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category Details_CategoryID",
                table: "Category Details",
                column: "CategoryID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_User Details_UserID",
                table: "User Details",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User Food Meals_FoodID",
                table: "User Food Meals",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_User Food Meals_MealID",
                table: "User Food Meals",
                column: "MealID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category Details");

            migrationBuilder.DropTable(
                name: "User Details");

            migrationBuilder.DropTable(
                name: "User Food Meals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
