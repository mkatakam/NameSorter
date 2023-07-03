using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Interfaces
{
    public interface INameSortingEngine
    {
        /// <summary>
        /// Interface to get all Person Names from the filePath
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        IEnumerable<PersonName> ReadUnsortedNames(string filePath);
        /// <summary>
        /// Interface to sort all Person Names based on the logic provided
        /// </summary>
        /// <param name="personNames"></param>
        /// <returns></returns>
        IEnumerable<PersonName> SortNames(IEnumerable<PersonName> personNames);

    }
}
