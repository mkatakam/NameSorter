using NameSorter.Interfaces;
using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
    public class NameSortingEngine : INameSortingEngine
    {
        /// <summary>
        /// Check if the filePath is null and throw an exception.
        /// "unsortedNames" variable to store all unformated names.
        /// "personNames" variable to store list of names as per the Model.
        /// foreach to loop through all the names in "unsortedNames" variable, 
        /// split those names by space and assign values to the list of "personeName"
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<PersonName> ReadUnsortedNames(string filePath)
        {
            if(filePath == null) throw new ArgumentNullException(nameof(filePath));

            var unsortedNames = File.ReadAllLines(filePath);
            var personNames = new List<PersonName>();
            foreach (var name in unsortedNames)
            {
                var fullName = new List<string>(name.Split(' ', StringSplitOptions.None));
                var personeName = new PersonName
                {
                    FirstName = fullName.First(),
                    SecondName = fullName.Count > 2 ? fullName[1] : string.Empty,
                    ThirdName = fullName.Count > 3 ? fullName[2] : string.Empty,
                    LastName = fullName.Last()
                };
                personNames.Add( personeName );
            }
            return personNames;
        }
        /// <summary>
        /// using a simple LINQ query to Order by LastName and then by, First, Second and ThirdName 
        /// </summary>
        /// <param name="personNames"></param>
        /// <returns></returns>
        public IEnumerable<PersonName> SortNames(IEnumerable<PersonName> personNames)
        {
          return personNames.OrderBy(n => n.LastName)
                .ThenBy(n => n.FirstName)
                .ThenBy(n => n.SecondName)
                .ThenBy(n => n.ThirdName);
        }
    }
}
