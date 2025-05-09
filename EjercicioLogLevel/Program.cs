using ConsoleApp1;

string log = "[INFO]: File Deleted.";

Console.WriteLine(log.SubstringAfter(": "));
Console.WriteLine(log.SubstringBetween("[", "]"));
Console.WriteLine(log.Message());
Console.WriteLine(log.LogLevel());