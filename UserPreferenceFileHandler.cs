using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis221_cgi
{
    public class UserPreferenceFileHandler
    {
        public string GetPreferredDietType(){
            //open file
            StreamReader inFile = new StreamReader("user-preferences.txt");

            //process file
            string line = inFile.ReadLine();

            string dietType = null;

            while(line != null){
                string[] temp = line.Split("#");

                int userIndex = int.Parse(temp[0]);
                dietType = temp[1];

                line = inFile.ReadLine();
            }
            //close file
            inFile.Close();
            return dietType;
        }
        public string GetPreferredHealthType(){
            //open file
            StreamReader inFile = new StreamReader("user-preferences.txt");

            //process file
            string line = inFile.ReadLine();

            string healthType = null;

            while(line != null){
                string[] temp = line.Split("#");

                int userIndex = int.Parse(temp[0]);
                healthType = temp[2];

                line = inFile.ReadLine();
            }
            //close file
            inFile.Close();
            return healthType;
        }
    }
}