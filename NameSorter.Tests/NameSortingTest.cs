using NameSorter.Models;
using NameSorter.Services;
using System.Linq;
using Xunit.Abstractions;

namespace NameSorter.Tests
{
    public class NameSortingTest 
    {

        private readonly ITestOutputHelper output;

        public NameSortingTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        /// <summary>
        /// Get all Unsorted Names and output in Test Detail Summary
        /// </summary>
        [Fact]
        public void GetUnsortedNames()
        {
            var unsortedNames = GetNamesFromFile();

            foreach(var unsortedName in unsortedNames)
            {
                output.WriteLine(unsortedName.FirstName + " " + unsortedName.SecondName + " " + unsortedName.ThirdName + " " + unsortedName.LastName);
            }                      
        }

        /// <summary>
        /// Get all unsorted Names and sort them and show it in Test Detail Summary
        /// </summary>
        [Fact]
        public void GetSortedNames()
        {
            var unsortedNames = GetNamesFromFile();
            var nameSortEngine = new NameSortingEngine();
            var sortedNames = nameSortEngine.SortNames(unsortedNames);
            foreach (var sortedName in sortedNames)
            {
                output.WriteLine(sortedName.FirstName + " " + sortedName.SecondName + " " + sortedName.ThirdName + " " + sortedName.LastName);
            }
        }


        private IEnumerable<PersonName> GetNamesFromFile()
        {
            var unorderedNamesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", @"unsorted-names-list.txt");
            var nameSortEngine = new NameSortingEngine();
            var unsortedNames = nameSortEngine.ReadUnsortedNames(unorderedNamesFilePath);

            return unsortedNames;
        }
    }
}