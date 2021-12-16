using ApiOefening.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiOefening.Model
{
    class Cocktail
    {
        public static string GenerateURLName(string name)
        {
            return string.Format(Constants.COCKTAIL_BY_NAME, name);
        }
        public static string GenerateURLById(string name)
        {
            return string.Format(Constants.COCKTAIL_BY_NAME, name);
        }
    }
}
