using NameSorter.Helpers;
using NameSorter.Interfaces;
using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NameSorter.Services
{
    /// <summary>
    /// This Class will help to show in the console, this class uses NameSpacingHelper abstract class to add spacing according to first, second, third and lastname
    /// </summary>
    public class ConsoleWriter : NameSpacingHelper, INameWriter
    {
        private readonly IEnumerable<PersonName> _personNames;

        public ConsoleWriter(IEnumerable<PersonName> personNames)
        {
            _personNames = personNames ?? throw new ArgumentException(nameof(personNames));
        }

        public void WriteOutPut()
        {
            List<string> nameList =  nameSpaceHelperClass(_personNames);
            nameList.ForEach(i => Console.Write("{0}\n", i));
        }
    }
}
