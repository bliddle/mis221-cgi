using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace mis221_cgi
{
    public class RecipeSearch
    {
        private string recipeSearch;
        private string numOfIngredients;
        private string dietType;
        private string healthLabel;
        private string cuisineType;
        private string mealType;
        private string dishType;
        private string caloriesRange;
        private string timeRange;
        private string excludedFoods;
        private string random;
        private string calcium;
        private string carbs;
        private string netCarbs;
        private string cholesterol;
        private string fattyAcids;
        private string totalFattyAcids;
        private string totalSaturated;
        private string totalLipidFat;
        private string totalTrans;
        private string iron;
        private string totalFiber;
        private string folicAcid;
        private string potassium;
        private string magnesium;
        private string socdium;
        private string niacin;
        private string phosphorus;
        private string protein;
        private string riboflavin;
        private string sugars;
        private string sugarsAdded;
        private string Thiamin;
        private string vitaminE;
        private string vitaminA;
        private string VitaminB12;
        private string VitaminB6;
        private string vitaminC;
        private string vitaminD;
        private string vitaminK;
        private string zinc;
        private string co2;
        private dynamic jsonResponse;


        public void SetRecipeSearch(string recipeSearch){
            this.recipeSearch = recipeSearch;
            if(recipeSearch != ""){
                this.recipeSearch = "q=" + recipeSearch;
            }
            else{
                this.recipeSearch = "";
            }
        }

        public string GetRecipeSearch(){
            return recipeSearch;
        }  
         public void SetNumOfIngredients(string numOfIngredients){
            this.numOfIngredients = numOfIngredients;
            if(numOfIngredients != ""){
                this.numOfIngredients = "&" + "ingr=" + numOfIngredients;
            }
            else{
                this.numOfIngredients = "";
            }
        }

        public string GetNumOfIngredients(){
            return numOfIngredients;
        }
        public void SetDietType(string dietType){

            this.dietType = dietType;

            this.dietType = dietType;
            if(dietType == "none"){
                this.dietType = "";
            }
        }

        public string GetDietType(){
            return dietType;
        }
        public void SetHealthLabel(string healthLabel){

            this.healthLabel = healthLabel;
            if(healthLabel == "none"){
                this.healthLabel = "";
            }

        }

        public string GetHealthLabel(){
            return healthLabel;
        }
        public void SetCuisineType(string cuisineType){
            this.cuisineType = cuisineType;
            if(cuisineType != ""){
                this.cuisineType = "&" + "cuisineType=" + cuisineType;
            }
            else{
                this.cuisineType = "";
            }
        }

        public string GetCuisineType(){
            return cuisineType;
        }
        public void SetMealType(string mealType){
            this.mealType = mealType;
            if(mealType != ""){
                this.mealType = "&" + "mealType=" + mealType;
            }
            else{
                this.mealType = "";
            }
        }

        public string GetMealType(){
            return mealType;
        }
        public void SetDishType(string dishType){
            this.dishType = dishType;
            if(dishType != ""){
                this.dishType = "&" + "dishType=" + dishType;
            }
            else{
                this.dishType = "";
            }
        }

        public string GetDishType(){
            return dishType;
        }
        public void SetCaloriesRange(string caloriesRange){
            this.caloriesRange = caloriesRange;
            if(caloriesRange != ""){
                this.caloriesRange = "&" + "calories=" + caloriesRange;
            }
            else{
                this.caloriesRange = "";
            }
        }

        public string GetCaloriesRange(){
            return caloriesRange;
        }
        public void SetTimeRange(string timeRange){
            this.timeRange = timeRange;
            if(timeRange != ""){
                this.timeRange = "&" + "time=" + timeRange;
            }
            else{
                this.timeRange = "";
            }
        }

        public string GetTimeRange(){
            return timeRange;
        }
        public void SetExcludedFoods(string excludedFoods){
            this.excludedFoods = excludedFoods;
            if(excludedFoods != ""){
                this.excludedFoods = "&" + "excluded=" + excludedFoods;
            }
            else{
                this.excludedFoods = "";
            }
        }

        public string GetExcludedFoods(){
            return excludedFoods;
        }
        public void SetRandom(string random){
            this.random = random;
        }

        public string GetRandom(){
            return random;
        }
        public void SetCalcium(string calcium){
            this.calcium = calcium;
        }

        public string GetCalcium(){
            return calcium;
        }
        public void SetCarbs(string carbs){
            this.carbs = carbs;
        }

        public string GetCarbs(){
            return carbs;
        }public void SetNetCarbs(string netCarbs){
            this.netCarbs = netCarbs;
        }

        public string GetNetCarbs(){
            return netCarbs;
        }
        public void SetCholesterol(string cholesterol){
            this.cholesterol = cholesterol;
        }

        public string GetCholeterol(){
            return cholesterol;
        }
       public void SetFattyAcids(string fattyAcids){
            this.fattyAcids = fattyAcids;
        }

        public string GetFattyAcids(){
            return fattyAcids;
        }

        public void SetTotalFattyAcids(string totalFattyAcids){
            this.totalFattyAcids = totalFattyAcids;
        }

        public string GetTotalFattyAcids(){
            return totalFattyAcids;
        }

        public void SetTotalSaturated(string totalSaturated){
            this.totalSaturated = totalSaturated;
        }

        public string GetTotalSaturated(){
            return totalSaturated;
        }

        public void SetTotalLipidFat(string totalLipidFat){
            this.totalLipidFat = totalLipidFat;
        }

        public string GetTotalLipidFat(){
            return totalLipidFat;
        }

        public void SetTotalTrans(string totalTrans){
            this.totalTrans = totalTrans;
        }

        public string GetTotalTrans(){
            return totalTrans;
        }

        public void SetIron(string iron){
            this.iron = iron;
        }

        public string GetIron(){
            return iron;
        }

        public void SetTotalFiber(string totalFiber){
            this.totalFiber = totalFiber;
        }

        public string GetTotalFiber(){
            return totalFiber;
        }

        public void SetFolicAcid(string folicAcid){
            this.folicAcid = folicAcid;
        }

        public string GetFolicAcid(){
            return folicAcid;
        }

        public void SetPotassium(string potassium){
            this.potassium = potassium;
        }

        public string GetPotassium(){
            return potassium;
        }

        public void SetMagnesium(string magnesium){
            this.magnesium = magnesium;
        }

        public string GetMagnesium(){
            return magnesium;
        }

        public void SetSodium(string sodium){
            this.socdium = sodium;
        }

        public string GetSodium(){
            return socdium;
        }

        public void SetNiacin(string niacin){
            this.niacin = niacin;
        }

        public string GetNiacin(){
            return niacin;
        }

        public void SetPhosphorus(string phosphorus){
            this.phosphorus = phosphorus;
        }

        public string GetPhosphorus(){
            return phosphorus;
        }

        public void SetProtein(string protein){
            this.protein = protein;
        }

        public string GetProtein(){
            return protein;
        }

        public void SetRiboflavin(string riboflavin){
            this.riboflavin = riboflavin;
        }

        public string GetRiboflavin(){
            return riboflavin;
        }

        public void SetSugars(string sugars){
            this.sugars = sugars;
        }

        public string GetSugars(){
            return sugars;
        }

        public void SetSugarsAdded(string sugarsAdded){
            this.sugarsAdded = sugarsAdded;
        }

        public string GetSugarsAdded(){
            return sugarsAdded;
        }

        public void SetThiamin(string thiamin){
            this.Thiamin = thiamin;
        }

        public string GetThiamin(){
            return Thiamin;
        }

        public void SetVitaminE(string vitaminE){
            this.vitaminE = vitaminE;
        }

        public string GetVitaminE(){
            return vitaminE;
        }

        public void SetVitaminA(string vitaminA){
            this.vitaminA = vitaminA;
        }

        public string GetVitaminA(){
            return vitaminA;
        }

        public void SetVitaminB12(string VitaminB12){
            this.VitaminB12 = VitaminB12;
        }

        public string GetVitaminB12(){
            return VitaminB12;
        }

        public void SetVitaminB6(string VitaminB6){
            this.VitaminB6 = VitaminB6;
        }

        public string GetVitaminB6(){
            return VitaminB6;
        }

        public void SetVitaminC(string vitaminC){
            this.vitaminC = vitaminC;
        }

        public string GetVitaminC(){
            return vitaminC;
        }

        public void SetVitaminD(string vitaminD){
            this.vitaminD = vitaminD;
        }

        public string GetVitaminD(){
            return vitaminD;
        }

        public void SetVitaminK(string vitaminK){
            this.vitaminK = vitaminK;
        }

        public string GetVitaminK(){
            return vitaminK;
        }

        public void SetZinc(string zinc){
            this.zinc = zinc;
        }

        public string GetZinc(){
            return zinc;
        }

        public void SetCO2(string co2){
            this.co2 = co2;
        }

        public string GetCO2(){
            return co2;
        }

        public async Task UserRecipeSearch(){
            RecipeSearch newRecipeSearch = new RecipeSearch();
            UserPreferenceFileHandler newUserPreference = new UserPreferenceFileHandler();

            //Query
            Console.Clear();
            System.Console.WriteLine("Please enter what recipe you would ike to search for:");
            newRecipeSearch.SetRecipeSearch(Console.ReadLine());

            //Ingredient Number
            Console.Clear();
            System.Console.WriteLine("Please enter the miniumum and maximum number of ingredients");
            newRecipeSearch.SetNumOfIngredients(Console.ReadLine());

            //Diet Type
            // Console.Clear();
            // System.Console.WriteLine("Please enter a diet type:\n\n1. None\n2. Balanced\n3. High-fiber\n4. Low-carb\n5. Low-fat\n6. Low-sodium");
            // newRecipeSearch.SetDietType(Console.ReadLine());
            newRecipeSearch.SetHealthLabel(newUserPreference.GetPreferredHealthType());
            System.Console.WriteLine(newRecipeSearch.GetHealthLabel());

            //Health Type
            // Console.Clear();
            // System.Console.WriteLine("Please enter a health type:\n\n1. Alcohol-cocktail\n2. Alcohol-free\n3. Celery-free\n4. Crustacean-free\n5. Dairy-free\n6. Egg-free\n7. Fish-free\n8. Fodmap-free\n9. Gluten-free\n10. Immuno-supportive\n11. Keto-friendly\n12. Kidney-friendly\n13. Kosher\n14. Low-fat-abs\n15. Low-potassium\n16. Low-sugar\n17. Lupine-free\n19. Mediterranean\n20. Mollusk-free\n21. Mustard-free\n22. No-oil-added\n23. Paleo\n24. Peanut-free\n25. Pescatarian\n26. Pork-free\n27. Red-meat-free\n28. Sesame-free\n29. Shellfish-free\n30. Soy-free\n31. Sugar-conscious\n32. Sulfite-free\n33. Tree-nut-free\n34. Vegan\n35. Vegetarian\n36. Wheat-free");
            // newRecipeSearch.SetHealthLabel(Console.ReadLine());
            newRecipeSearch.SetDietType(newUserPreference.GetPreferredDietType());
            System.Console.WriteLine(newRecipeSearch.GetHealthLabel());
            
            //Cuisine Type
            Console.Clear();
            System.Console.WriteLine("Please enter a cuisine type:\n\n1. American\n2. Aisan\n3. British\n4. Caribbean\n5. Central Europe\n6. Chinese\n7. Eastern Europe\n8. Frendh\n9. Indian\n10. Japanese\n11. Kosher\n12. Mediterranean\n13. Mexican\n14. Middle Eastern\n15. Nordic\n16. South American\n17. South East Aisan");
            newRecipeSearch.SetCuisineType(Console.ReadLine());

            //Meal Type
            Console.Clear();
            System.Console.WriteLine("Please enter a meal type:\n\n1. Breakfast\n2. Dinner\n3. Lunch\n4. Snack\n5. Teatime\n6. None");
            newRecipeSearch.SetMealType(Console.ReadLine());

            //Dish Type
            Console.Clear();
            System.Console.WriteLine("Please enter a dish type:\n\n1. Biscuits and cookies\n2. Bread\n3. Cereals\n4. Condiments and sauces\n5. Desserts\n6. Drinks\n7. Main course\n8. Pancake\n9. Preps\n10. Preserve\n11. Salad\n12. Sandwiches\n13. Side dish\n14. Soup\n15. Starter\n16. Sweets");
            newRecipeSearch.SetDishType(Console.ReadLine());

            //Calorie Range
            Console.Clear();
            System.Console.WriteLine("Please enter calorie range");
            newRecipeSearch.SetCaloriesRange(Console.ReadLine());
            
            //Time Range
            Console.Clear();
            System.Console.WriteLine("Please enter a preparation time range");
            newRecipeSearch.SetTimeRange(Console.ReadLine());
            
            //Excluded foods
            Console.Clear();
            System.Console.WriteLine("Please include any foods you want to exclude:");
            newRecipeSearch.SetExcludedFoods(Console.ReadLine());
            

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.edamam.com/api/recipes/v2?type=any&app_id=46cfeedb{newRecipeSearch.GetNumOfIngredients()}{newRecipeSearch.GetDietType()}{newRecipeSearch.GetHealthLabel()}{newRecipeSearch.GetCuisineType()}{newRecipeSearch.GetMealType()}{newRecipeSearch.GetDishType()}{newRecipeSearch.GetCaloriesRange()}{newRecipeSearch.GetTimeRange()}{newRecipeSearch.GetExcludedFoods()}&app_key=c7fb889a377694ad4a8a6516410d6713&{newRecipeSearch.GetRecipeSearch()}");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonData = await response.Content.ReadAsStringAsync();
            dynamic jsonResponse = JsonConvert.DeserializeObject(jsonData);


            if (jsonResponse != null && jsonResponse.hits != null && jsonResponse.hits.Count > 0)
            {
                Console.WriteLine("Recipes found:");
                foreach (var hit in jsonResponse.hits)
                {
                    string recipeName = hit.recipe?.label;
                    if (!string.IsNullOrEmpty(recipeName))
                    {
                        Console.Clear();
                        System.Console.WriteLine("Enter 'Y if you want to learn more about the recipe and 'N' if you want to skip to the next recipe. Enter -1 if you want to return to the menu.");
                        Console.WriteLine($"Recipe Name: {recipeName}");
                        string userLikeRecipe = Console.ReadLine().ToUpper();
                        if(userLikeRecipe == "Y"){
                            List<string> ingList = new List<string>();         
                            foreach (JToken token in hit.recipe?.ingredientLines){             
                                ingList.Add(token.Value<string>());
                            }
                            System.Console.WriteLine("Here is a list of the ingredients:\n\n");
                            foreach (string item in ingList){
                                System.Console.WriteLine(item);
                            }
                            System.Console.WriteLine("Do you want to know about this recipe's nutrition? (Y/N)");
                            userLikeRecipe = Console.ReadLine().ToUpper();
                            
                            if(userLikeRecipe == "Y"){
                                string calories = hit.recipe?.calories;
                                if (!string.IsNullOrEmpty(calories)){
                                    System.Console.WriteLine($"Calories: {calories}");
                                    Console.ReadLine();
                                }
                                // string calories = hit.recipe?.calories;
                                // if (!string.IsNullOrEmpty(calories)){
                                //     System.Console.WriteLine($"Calories: {calories}");
                                //     Console.ReadLine();
                                // }
                                // string calories = hit.recipe?.calories;
                                // if (!string.IsNullOrEmpty(calories)){
                                //     System.Console.WriteLine($"Calories: {calories}");
                                //     Console.ReadLine();
                                // }
                                
                            }
                            
                        }

                        if(userLikeRecipe == "-1"){
                            return;
                        }

                    }

                }
            }
            else
            {
                Console.WriteLine("No more recipes found :(");
            }

        }
    }
}