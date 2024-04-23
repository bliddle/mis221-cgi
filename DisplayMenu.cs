using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace mis221_cgi
{
    public class DisplayMenus
    {
        public void LoginMenu(){
            UserFileHandler userFileHandler= new UserFileHandler();

            System.Console.WriteLine("LOGIN\n\n1. Login\n2. Create new user\n3. Exit");
            string userInput = Console.ReadLine();

            while(userInput != "3"){
                switch(userInput){
                    case "1":
                        userFileHandler.UserLogin();
                        break;

                    case "2":
                        userFileHandler.CreateUser();
                        break;

                    default:
                        break;
                }

                return;
            }  
        }
        public async Task MainMenu(){
            RecipeSearch newRecipeSearch = new RecipeSearch();
            // System.Console.WriteLine("Welcome to Bailey Bytes!\n\n1. Recipe Search\n2. Search by ingredient\n3. Saved Recipes\n4. Exit");
            System.Console.WriteLine("Welcome to Bailey Bytes!\n\n1. Recipe Search\n2. Exit");
            string userInput = Console.ReadLine();

            while (userInput != "4"){
                switch (userInput){
                    case "1":
                        await newRecipeSearch.UserRecipeSearch();
                        break;

                    case "2":
                        //IngredientSearch();
                        break;

                    case "3":
                        //ViewSavedRecipes();
                        break;
                        
                    default:
                        break;
                }
                // System.Console.WriteLine("Welcome to Bailey Bytes!\n\n1. Recipe Search\n2. Search by ingredient\n3. Saved Recipes\n4. Exit");
                System.Console.WriteLine("Welcome to Bailey Bytes!\n\n1. Recipe Search\n2. Exit");
                userInput = Console.ReadLine();
            }
        }
    }
}