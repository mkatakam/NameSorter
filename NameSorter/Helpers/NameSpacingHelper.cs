using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Helpers
{
    public abstract class NameSpacingHelper
    {
        /// <summary>
        /// I created this astract helper class to avoid duplication of code for "ConsoleWriter" and "TextFileWriter"
        /// This class takes the list of sorted PersonNames and add them to the list with required spaces between first, second, third and last names.
        /// </summary>
        /// <param name="personNames"></param>
        /// <returns></returns>
        public List<string> nameSpaceHelperClass(IEnumerable<PersonName> personNames)
        {
            List<string> orderedList = new List<string>();
            foreach (var personName in personNames)
            {
                if (personName.SecondName == string.Empty)
                {
                    orderedList.Add(String.Join(' ', personName.FirstName, personName.LastName));
                }
                else if (personName.ThirdName == string.Empty)
                {
                    orderedList.Add(String.Join(' ', personName.FirstName, personName.SecondName, personName.LastName));
                }
                else
                {
                    orderedList.Add(String.Join(' ', personName.FirstName, personName.SecondName, personName.ThirdName, personName.LastName));
                }
            }
            return orderedList;
        }      
    }
}
