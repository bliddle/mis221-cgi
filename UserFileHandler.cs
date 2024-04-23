using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace mis221_cgi
{
    public class UserFileHandler
    {
        public void CreateUser(){
            System.Console.WriteLine("Please enter a username:\n");
            string username = Console.ReadLine();

            bool usernameExists = true;

            while (usernameExists)
            {
                StreamReader inFile = new StreamReader("user-logins.txt");
                string line = inFile.ReadLine();

                usernameExists = false;

                while (line != null)
                {
                    string[] temp = line.Split("#");
                    string fileUsername = temp[1];

                    if (username == fileUsername)
                    {
                        usernameExists = true; 
                        break; 
                    }

                    line = inFile.ReadLine();
                }

                inFile.Close();

                if (usernameExists)
                {
                    System.Console.WriteLine("Username already taken. Please enter a new one:\n");
                    username = Console.ReadLine();
                }
            }


            System.Console.WriteLine("Please enter a password:\n");
            string password = Console.ReadLine();

            int userID = CreateUserID();

            //open file
            StreamWriter outFile = File.AppendText("user-logins.txt");

            //process file
            outFile.WriteLine($"{userID}#{username}#{password}");

            //close file
            outFile.Close();

            User newUser = new User();
            newUser.SetCurrUser(userID);


            Console.Clear();
            string dietTypes = "";
            string healthTypes = "";
            Console.WriteLine($"Welcome! Let's get some of your diet preferences! Please enter your choice (1-6) or 'done' when you're finished. Please enter one at a time\n\n1. None\n2. Balanced\n3. High-fiber\n4. Low-carb\n5. Low-fat\n6. Low-sodium");

            
            while (true)
            {
                string userInput = Console.ReadLine().Trim().ToLower();
                
                if (userInput == "done" || userInput ==  "none")
                    break;
                
                if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5" || userInput == "6")
                {
                    string dietType = GetDietType(userInput);
                    
                    dietTypes += dietType;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6 or 'done' to finish.");
                }
            }


            System.Console.WriteLine("Great! Now let's get your health types. Please enter your choice (1-36) or enter 'done' whenever you're finished! Please enter one at a time.\n\n1. None\n2. Alcohol-cocktail\n3. Alcohol-free\n4. Celery-free\n5. Crustacean-free\n6. Dairy-free\n7. Egg-free\n8. Fish-free\n9. Fodmap-free\n10. Gluten-free\n11. Immuno-supportive\n12. Keto-friendly\n13. Kidney-friendly\n14. Kosher\n15. Low-fat-abs\n16. Low-potassium\n17. Low-sugar\n18. Lupine-free\n19. Mediterranean\n20. Mollusk-free\n21. Mustard-free\n22. No-oil-added\n23. Paleo\n24. Peanut-free\n25. Pescatarian\n26. Pork-free\n27. Red-meat-free\n28. Sesame-free\n29. Shellfish-free\n30. Soy-free\n31. Sugar-conscious\n32. Sulfite-free\n33. Tree-nut-free\n34. Vegan\n35. Vegetarian\n36. Wheat-free");

            while (true)
            {
                string userInput = Console.ReadLine().Trim().ToLower();
                
                if (userInput == "done" || userInput ==  "none")
                    break;
                
                if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5" || userInput == "6" || userInput == "7" || userInput == "8" || userInput == "9" || userInput == "10" || userInput == "11" || userInput == "12" || userInput == "13" || userInput == "14" || userInput == "15" || userInput == "16" || userInput == "17" || userInput == "18" || userInput == "19" || userInput == "20" || userInput == "21" || userInput == "22" || userInput == "23" || userInput == "24" || userInput == "25" || userInput == "262" || userInput == "27" || userInput == "28" || userInput == "29" || userInput == "30" || userInput == "31" || userInput == "32" || userInput == "33" || userInput == "34" || userInput == "35" || userInput == "36")
                {
                    string healthType = GetHealthType(userInput);
                    
                    healthTypes += healthType;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6 or 'done' to finish.");
                }
            }

            SaveToFile(dietTypes, healthTypes, userID);
        }
        
        public void SaveToFile(string dietTypes, string healthTypes, int userID){
            //open file
            StreamWriter preferenceOutFile = File.AppendText("user-preferences.txt");
            //process file
            string line = $"{userID}#{dietTypes}#{healthTypes}";
            preferenceOutFile.WriteLine(line);
            //close file
            preferenceOutFile.Close();
        }
        public int CreateUserID(){
            UserFileHandler newUserFileHandler = new UserFileHandler();
            int newUserID = newUserFileHandler.FindMaxIndex() + 1;
            return newUserID;
        }
        
        public string GetHealthType(string userInput){
            switch(userInput){

            case "1":
                return "";
            case "2":
                return "&health=alcohol-cocktail";
            case "3":
                return "&health=alcohol-free";
            case "4":
                return "&health=celery-free";
            case "5":
                return "&health=crustacean-free";
            case "6":
                return "&health=dairy-free";
            case "7":
                return "&health=egg-free";
            case "8":
                return "&health=fish-free";
            case "9":
                return "&health=fodmap-free";
            case "10":
                return "&health=gluten-free";
            case "11":
                return "&health=immuno-supportive";
            case "12":
                return "&health=keto-friendly";
             case "13":
                return "&health=kidney-friendly";
            case "14":
                return "&health=kosher";
            case "15":
                return "&health=low-fat-abs";
            case "16":
                return "&health=low-potassium";
            case "17":
                return "&health=low-sugar";
            case "18":
                return "&health=lupine-free";
            case "19":
                return "&health=Mediterranean";
            case "20":
                return "&health=mollusk-free";
            case "21":
                return "&health=mustard-free";
            case "22":
                return "&health=no-oil-added";
            case "23":
                return "&health=paleo";
            case "24":
                return "&health=peanut-free";
            case "25":
                return "&health=pescatarian";
            case "26":
                return "&health=pork-free";
            case "27":
                return "&health=red-meat-free";
            case "28":
                return "&health=sesame-free";
            case "29":
                return "&health=shellfish-free";
            case "30":
                return "&health=soy-free";  
            case "31":
                return "&health=sugar-conscious";
            case "32":
                return "&health=sulfite-free";
            case "33":
                return "&health=tree-nut-free";
            case "34":
                return "&health=vegan";
            case "35":
                return "&health=vegetarian";
            case "36":
                return "&health=wheat-free";                                             
            default:
                return "";
            }
        }
     
        public string GetDietType(string userInput){
            switch(userInput){

            case "1":
                return "";
            case "2":
                return "&diet=balanced";
            case "3":
                return "&diet=high-fiber";
            case "4":
                return "&dietlow-carb";
            case "5":
                return "&diet=low-fat";
            case "6":
                return "&diet=low-sodium";
            default:
                return "";
            }
        }
        public int FindMaxIndex(){
            //open file

            StreamReader inFile = new StreamReader("user-logins.txt");

            string line = inFile.ReadLine();
            int max = 0;

            while (line != null){

                string[] temp = line.Split("#");
                int index = int.Parse(temp[0]);

                if (index > max){
                    max = index;
                }

                line = inFile.ReadLine();
            }

            return max;
            
            inFile.Close();
        }

        public void UserLogin(){
            User newUser = new User();

            bool userInfo = false;

            while (!userInfo)
            {
                System.Console.WriteLine("Please enter a username:\n");
                string username = Console.ReadLine();

                System.Console.WriteLine("Please enter a password:\n");
                string password = Console.ReadLine();

                StreamReader inFile = new StreamReader("user-logins.txt");
                string line = inFile.ReadLine();

                userInfo = false;

                while (line != null)
                {
                    string[] temp = line.Split("#");
                    string fileUsername = temp[1];
                    string filePassword = temp[2];

                    if (username == fileUsername && password == filePassword)
                    {
                        userInfo = true;
                        newUser.SetCurrUser(int.Parse(temp[0]));
                        break;
                    }

                    line = inFile.ReadLine();
                }

                inFile.Close();

                if (!userInfo)
                {
                    System.Console.WriteLine("Username or password incorrect. Please try again or enter 1 to exit:\n");
                    string userInput = Console.ReadLine();
                    if (userInput == "1"){
                        return;
                    }
                }
            }
        }
    }
}