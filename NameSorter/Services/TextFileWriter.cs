using NameSorter.Helpers;
using NameSorter.Interfaces;
using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
    /// <summary>
    /// This Class will help write to the "sorted-names-list.txt file", this class uses NameSpacingHelper abstract class to add spacing according to first, second, third and lastname
    /// </summary>
    internal class TextFileWriter : NameSpacingHelper, INameWriter
    {
        private readonly IEnumerable<PersonName> _personNames;
        private readonly string _filePath;
        public TextFileWriter(IEnumerable<PersonName> personNames, string filePath)
        {
            _personNames = personNames ?? throw new ArgumentNullException(nameof(personNames));
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }
        public void WriteOutPut()
        {
            List<string> nameList = nameSpaceHelperClass(_personNames);
            File.WriteAllLines(_filePath,nameList);
        }
    }
}
