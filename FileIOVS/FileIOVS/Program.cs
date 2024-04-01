/*
 ./  <-- current folder
 ../ <-- parent folder
 @"" <-- literal string (ignore escapes)
*/

// store the path to the data folder
string dataFolder = @"..\..\..\data\";

Console.ForegroundColor = ConsoleColor.Red;

// output the contents of a file
Console.WriteLine(File.ReadAllText(dataFolder + "hello.txt"));

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;

// storing multiple lines of text in an array
string[] fileLines = File.ReadAllLines(dataFolder + "multiline.txt");

Console.WriteLine($"There were {fileLines.Count()} lines of text in the file.");

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;

// give all file paths in the data folder
string[] filePaths = Directory.GetFiles(dataFolder);
foreach(string filePath in filePaths) Console.WriteLine(filePath);

Console.ForegroundColor = ConsoleColor.White;
