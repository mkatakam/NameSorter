
using NameSorter.Interfaces;
using NameSorter.Services;

var unorderedNamesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", @"unsorted-names-list.txt");
var sortedNamesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\", @"sorted-names-list.txt");

//Sort Process to Read Unsorted Names from the txt file and create a list of sorted names
var nameSortEngine = new NameSortingEngine();
var unsortedNames = nameSortEngine.ReadUnsortedNames(unorderedNamesFilePath);
var sortedNames = nameSortEngine.SortNames(unsortedNames);

//Write to Console
INameWriter writer = new ConsoleWriter(sortedNames);
writer.WriteOutPut();

//Write to text file
writer = new TextFileWriter(sortedNames, sortedNamesFilePath);
writer.WriteOutPut();
