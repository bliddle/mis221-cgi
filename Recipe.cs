using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace mis221_cgi
{
    public class Recipe{


        private string recipeName;
        private List <string> ingList;

        public void SetRecipeName(string recipeName){
            this. recipeName = recipeName;
        }

        public string GetRecipeName(){
            return recipeName;
        }

        public void SetIngredientList(List <string> ingList){
            this.ingList = ingList;
        }

        public List <string> GetIngredientList(){
            return ingList;
        }
    }


}