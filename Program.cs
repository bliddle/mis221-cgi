using System.Security.Cryptography.X509Certificates;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using mis221_cgi;

RecipeSearch newRecipeSearch = new RecipeSearch();
DisplayMenus displayMenus = new DisplayMenus();


//Login
displayMenus.LoginMenu();

//Dispaly Options
await displayMenus.MainMenu();