using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class FrenchData
    {
        string specialCharacters = "ÀàÂâÆæÇçÉéÈèÊêËëÎîÏïÔôŒœÙùÛûÜüŸÿ";
        string lowercaseCharacters = "abcdefghijklmnopqrstuvwxyz";
        string UppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string allCharacters;

        public FrenchData()
        {
            allCharacters = specialCharacters + lowercaseCharacters + UppercaseCharacters;
        }       

        public string getFrenchCharacterString()
        {
            return "ÀàÂâÆæÇçÉéÈèÊêËëÎîÏïÔôŒœÙùÛûÜüŸÿ";
        }

        public string getRandomFrenchString(int lenght)
        {
            StringBuilder temp = new StringBuilder();
            Random rand = new Random();
            int rand2 = 0;

            for (int i = 0; i < lenght; i++)
            {
                rand2 = rand.Next(1, lenght);
                temp.Append(allCharacters[rand2]);
            }

            return temp.ToString();
        }
    }
}
