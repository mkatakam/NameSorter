using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Models
{
    /// <summary>
    /// This model helps us to reference names as required
    /// </summary>
    public class PersonName
    {

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string? ThirdName { get; set; }
        public string? LastName { get; set; }
    }
}
